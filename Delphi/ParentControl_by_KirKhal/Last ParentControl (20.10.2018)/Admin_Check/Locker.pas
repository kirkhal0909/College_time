unit Locker;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Registry,ShellAPI,TlHelp32, ExtCtrls;

type
  TForm3 = class(TForm)
    lblInfo: TLabel;
    edtPass: TEdit;
    lblPass: TLabel;
    btnUnlock: TButton;
    btnShutDown: TButton;
    chkShow: TCheckBox;
    pnlForm: TPanel;
    pnlLine: TPanel;
    procedure FormCreate(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure edtPassKeyPress(Sender: TObject; var Key: Char);
    procedure btnUnlockClick(Sender: TObject);
    procedure btnShutDownClick(Sender: TObject);
    procedure chkShowClick(Sender: TObject);
    procedure FormDeactivate(Sender: TObject);
    procedure FormKeyDown(Sender: TObject; var Key: Word;
      Shift: TShiftState);
  private
    function Encrypt(s:string): string;
    procedure Unlock();
    function FindTask(ExeFileName: string): Boolean;
    function IsAdmin: Boolean;
    { Private declarations }
  public
    { Public declarations }
  end;

  TMyThread = class(TThread)
    private
    { Private declarations }
  protected
    procedure Execute; override;
  end;

Const
 programName = 'ParentControl';
 SECURITY_NT_AUTHORITY: TSIDIdentifierAuthority = (Value: (0, 0, 0, 0, 0, 5));
 SECURITY_BUILTIN_DOMAIN_RID = $00000020;
 DOMAIN_ALIAS_RID_ADMINS     = $00000220;
 DOMAIN_ALIAS_RID_USERS      = $00000221;
 DOMAIN_ALIAS_RID_GUESTS     = $00000222;
 DOMAIN_ALIAS_RID_POWER_USERS= $00000223;

var
  Form3: TForm3;
  Locked : Boolean = true;
  CryptedPass : string;
  programPath,filePass,paramBlock,regHidePath: string;
  TaskKiller : TMyThread;



implementation

{$R *.dfm}

function TForm3.IsAdmin: Boolean;
var
  hAccessToken: THandle;
  ptgGroups: PTokenGroups;
  dwInfoBufferSize: DWORD;
  psidAdministrators: PSID;
  x: Integer;
  bSuccess: BOOL;
begin
  Result := False;
  bSuccess := OpenThreadToken(GetCurrentThread, TOKEN_QUERY, True,
    hAccessToken);
  if not bSuccess then
  begin
    if GetLastError = ERROR_NO_TOKEN then
    bSuccess := OpenProcessToken(GetCurrentProcess, TOKEN_QUERY,
                                  hAccessToken);
  end; 
  if bSuccess then 
  begin
    GetMem(ptgGroups, 1024); 
    bSuccess := GetTokenInformation(hAccessToken, TokenGroups, 
                                    ptgGroups, 1024, dwInfoBufferSize);
    CloseHandle(hAccessToken);
    if bSuccess then 
    begin
      AllocateAndInitializeSid(SECURITY_NT_AUTHORITY, 2,
        SECURITY_BUILTIN_DOMAIN_RID, DOMAIN_ALIAS_RID_ADMINS,
        0, 0, 0, 0, 0, 0, psidAdministrators);
      {$R-} 
      for x := 0 to ptgGroups.GroupCount - 1 do
        if EqualSid(psidAdministrators, ptgGroups.Groups[x].Sid) then 
        begin
          Result := True; 
          Break;
        end;
      {$R+}
      FreeSid(psidAdministrators); 
    end;
    FreeMem(ptgGroups); 
  end;
end;

procedure TMyThread.Execute;
var reg:TRegistry;
begin
  while Locked do
  begin
    Sleep(300);
    //if FindTask('taskmgr.exe') then
    ShellExecute(Application.Handle,nil,'taskkill.exe','/f /im taskmgr.exe /t',nil,SW_HIDE);
    Sleep(50);
  end;
end;

function Tform3.FindTask(ExeFileName: string): Boolean;
 var
  ContinueLoop: BOOL;
  FSnapshotHandle: THandle;
  FProcessEntry32: TProcessEntry32;
begin
  result := false;
  FSnapshotHandle := CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);
  FProcessEntry32.dwSize := Sizeof(FProcessEntry32);
  ContinueLoop := Process32First(FSnapshotHandle, FProcessEntry32);
  while integer(ContinueLoop) <> 0 do
   begin
    if ((UpperCase(ExtractFileName(FProcessEntry32.szExeFile)) = UpperCase(ExeFileName))
     or (UpperCase(FProcessEntry32.szExeFile) = UpperCase(ExeFileName)))
      then Result := true;
    ContinueLoop := Process32Next(FSnapshotHandle, FProcessEntry32);
   end;
  CloseHandle(FSnapshotHandle);
end;

procedure TForm3.Unlock();
var reg : TRegistry;
begin
  Locked := False;
  ShellExecute(Application.Handle,nil,Pchar(getEnvironmentVariable('WINDIR')+'\explorer.exe'),nil,nil,SW_SHOWNORMAL);
  //self.Close;
  //ShellExecute(Application.Handle,nil,'taskkill.exe','/f /im Locker.exe /t',nil,SW_HIDE);
  Application.Terminate;
  //ShellExecute(Application.Handle,nil,'taskkill.exe','/f /im locked.exe /t',nil,SW_HIDE);
end;

procedure TForm3.FormCreate(Sender: TObject);
var PassF,regHide: TextFile;

    reg:TRegistry;
begin
  if IsAdmin() then
  begin
    //ShowMessage('Admin rights');
    programPath := GetEnvironmentVariable('PROGRAMFILES')+'\'+programName;
    paramBlock := programPath+'\'+programName+'.exe" -blockStart';
    ShellExecute(Handle,nil,PChar(programPath+'\'+programName+'.exe'),'-blockStart',nil,SW_SHOWNORMAL);
    Self.Left := -2000;
    Self.Width := 0; self.Height := 0;
    Self.BorderStyle := bsNone;
  end else
  begin
    pnlLine.Width := Screen.Width;
    Self.Width := Screen.Width;
    Self.Height := Screen.Height;
    self.Top := (Screen.Height-self.Height) div 2;
    self.Left := (Screen.Width-self.Width) div 2;

    pnlForm.Left := (pnlLine.Width - pnlForm.Width)div 2;
    pnlForm.Top := (pnlLine.Height - pnlForm.Height)div 2;
    pnlLine.Top := (Self.Height - pnlLine.Height)div 2;
    pnlLine.Left := (Self.Width - pnlLine.Width)div 2;

    programPath := GetEnvironmentVariable('PROGRAMFILES')+'\'+programName;
    paramBlock := programPath+'\'+programName+'.exe" -blockStart';
    filePass := programPath+'\pass';
    //filePass := getEnvironmentVariable('WINDIR')+'\pass';
    if FileExists(filePass) then
    begin
      AssignFile(PassF,filePass);
      Reset(PassF);
      Read(PassF,CryptedPass);
      CloseFile(PassF);
    end else
    begin
      ShowMessage('Пароль повреждён! Доступ разблокирован!'+#13#10+
                  'Необходимо установить новый пароль');
      Unlock;
    end;

    TaskKiller := TMyThread.Create(False);
  end;
end;

procedure TForm3.FormClose(Sender: TObject; var Action: TCloseAction);
begin
  if Locked then Abort;
end;

function tform3.Encrypt(s:string): string;
var i : integer;
  tmpS : string;
begin
  tmpS := '';
  for i := 1 to Length(s) do
  begin
    tmpS := tmpS + IntToStr(Ord(s[i])+i*7);
    if i <> Length(s) then tmpS := tmpS+' ';
  end;
  Encrypt := tmpS;
end;

procedure TForm3.edtPassKeyPress(Sender: TObject; var Key: Char);
begin
  if Key = #13 then btnUnlock.Click();
end;

procedure TForm3.btnUnlockClick(Sender: TObject);
begin
  if CryptedPass = Encrypt(edtPass.Text) then
    Unlock
  else ShowMessage('Неправильный пароль!');
end;

procedure TForm3.btnShutDownClick(Sender: TObject);
begin
  WinExec('shutdown /s /t 0',SW_HIDE);
end;

procedure TForm3.chkShowClick(Sender: TObject);
begin
  if (Sender as TCheckBox).Checked then edtPass.PasswordChar := #0
  else edtPass.PasswordChar := '*';
end;

procedure TForm3.FormDeactivate(Sender: TObject);
begin
  ShowMessage('Exit');
end;

procedure TForm3.FormKeyDown(Sender: TObject; var Key: Word;
  Shift: TShiftState);
begin

  if Key = VK_CONTROL then
    keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0)
  else if Key = VK_MENU then keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, 0)
  else if Key = VK_LWIN then keybd_event(VK_LWIN, 0, KEYEVENTF_KEYUP, 0)
  else if Key = VK_RWIN then keybd_event(VK_RWIN, 0, KEYEVENTF_KEYUP, 0)
end;

end.
