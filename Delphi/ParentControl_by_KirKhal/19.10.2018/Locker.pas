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
    tmrTaskkill: TTimer;
    procedure FormCreate(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure edtPassKeyPress(Sender: TObject; var Key: Char);
    procedure btnUnlockClick(Sender: TObject);
    procedure btnShutDownClick(Sender: TObject);
    procedure chkShowClick(Sender: TObject);
    procedure FormDeactivate(Sender: TObject);
    procedure tmrTaskkillTimer(Sender: TObject);
    procedure FormKeyDown(Sender: TObject; var Key: Word;
      Shift: TShiftState);
  private
    function Encrypt(s:string): string;
    procedure Unlock();
    function FindTask(ExeFileName: string): Boolean;
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

const programName = 'ParentControl';

var
  Form3: TForm3;
  Locked : Boolean = true;
  CryptedPass : string;
  programPath,filePass,paramBlock,regHidePath: string;
  TaskKiller : TMyThread;



implementation

{$R *.dfm}

procedure TMyThread.Execute;
var reg:TRegistry;
begin
  while Locked do
  begin
    Sleep(300);
    //if FindTask('taskmgr.exe') then
    ShellExecute(Application.Handle,nil,'taskkill.exe','/f /im taskmgr.exe /t',nil,SW_HIDE);
    Sleep(50);

    {reg := TRegistry.Create(KEY_READ OR $0100);
    reg.RootKey := HKEY_LOCAL_MACHINE;
    if reg.OpenKeyReadOnly('SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon') then
    begin
      if reg.ReadString('Shell') <> paramBlock then
      begin}
        reg := TRegistry.Create(KEY_WRITE OR $0100);
        //reg := TRegistry.Create(KEY_READ OR $0100);
        reg.RootKey := HKEY_LOCAL_MACHINE;
        //reg.OpenKeyReadOnly('\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon');
        reg.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon',True);
        //ShowMessage(reg.ReadString('Shell'));
        reg.WriteString('Shell',PChar('cmd.exe /c start "" "'+paramBlock+'""'));

      {end;
    end;}

    {reg := TRegistry.Create(KEY_WRITE OR $0100);
    reg.RootKey := HKEY_LOCAL_MACHINE;
    reg.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon',True);
    reg.WriteString('Shell',PChar('cmd.exe /c start "" "'+paramBlock+'""'));}
    reg.Free;
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

  reg := TRegistry.Create(KEY_WRITE OR $0100);
  reg.RootKey := HKEY_LOCAL_MACHINE;
  reg.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon',True);
  reg.WriteString('Shell','Explorer.exe');
  reg.Free;                                                 //cmd /c start explorer.exe
  //Sleep(1000);
  //ShellExecute(Application.Handle,nil,'explorer.exe',nil,nil,SW_SHOWNORMAL);
  //WinExec('Explorer.exe',SW_SHOWNORMAL);
  ShellExecute(Application.Handle,nil,Pchar(getEnvironmentVariable('WINDIR')+'\explorer.exe'),nil,nil,SW_SHOWNORMAL);
  Self.Hide;
  Sleep(100);
  //ShellExecute(Application.Handle,nil,'cmd.exe',PChar('/c start explorer.exe'),nil,SW_SHOWNORMAL);
  while(not FindTask('Explorer.exe')) do
  begin
    Sleep(100);
  end;
  Sleep(777);
  //Sleep(1000);
  //Sleep(100000);

  reg := TRegistry.Create(KEY_WRITE OR $0100);
  reg.RootKey := HKEY_LOCAL_MACHINE;
  reg.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon',True);
  //cmd.exe /c start "" "C:\Program Files (x86)\ParentControl\ParentControl.exe" -blockStart" "

  //-----------------------MAIN
  reg.WriteString('Shell',PChar('cmd.exe /c start "" "'+paramBlock+'""'));
  //---------------------------------------------------------------------//
  reg.Free;


  {reg := TRegistry.Create(KEY_WRITE OR $0100);
  reg.RootKey := HKEY_LOCAL_MACHINE;
  reg.OpenKey('SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System',True);
  reg.WriteString('','0');
  reg.Free;}

  {reg := TRegistry.Create(KEY_WRITE OR $0100);
  reg.RootKey := HKEY_LOCAL_MACHINE;
  reg.OpenKey('SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System',True);
  reg.WriteString('DisableTaskMgr','0');
  reg.Free; }

  Application.Terminate;
end;

procedure TForm3.FormCreate(Sender: TObject);
var PassF,regHide: TextFile;

    reg:TRegistry;
begin
  {reg := TRegistry.Create(KEY_WRITE OR $0100);
  reg.RootKey := HKEY_LOCAL_MACHINE;
  reg.OpenKey('SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System',True);
  reg.WriteString('','1');
  reg.Free;}

  {reg := TRegistry.Create(KEY_WRITE OR $0100);
  reg.RootKey := HKEY_LOCAL_MACHINE;
  reg.OpenKey('SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System',True);
  reg.WriteString('DisableTaskMgr','1');
  reg.Free;}

  //ShowMessage('test replace');

  {regHidePath := getEnvironmentVariable('WINDIR')+'\System32\regedit.exe';
  //CopyFile('NUL',PChar(regHidePath),true);
  ShellExecute(Application.Handle,nil,pchar(regHidePath),nil,nil,SW_SHOWNORMAL);
  if not FileExists(regHidePath) then ShowMessage(regHidePath);
  ShowMessage(regHidePath);
  AssignFile(regHide,regHidePath);}

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
  //filePass := programPath+'\pass';
  filePass := getEnvironmentVariable('WINDIR')+'\pass';
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

procedure TForm3.tmrTaskkillTimer(Sender: TObject);
var reg:TRegistry;
begin
  if Locked then
  begin
    if FindTask('taskmgr.exe') then
    ShellExecute(Application.Handle,nil,'taskkill.exe','/f /im taskmgr.exe /t',nil,SW_HIDE);
    Sleep(50);

    {reg := TRegistry.Create(KEY_READ OR $0100);
    reg.RootKey := HKEY_LOCAL_MACHINE;
    if reg.OpenKeyReadOnly('SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon') then
    begin
      if reg.ReadString('Shell') <> paramBlock then
      begin}
        //reg := TRegistry.Create(KEY_WRITE OR $0100);
        reg := TRegistry.Create(KEY_READ OR $0100);
        reg.RootKey := HKEY_LOCAL_MACHINE;
        reg.OpenKeyReadOnly('\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon');
        //reg.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon',True);
        ShowMessage(reg.ReadString('Shell'));
        //reg.WriteString('Shell',PChar('cmd.exe /c start "" "'+paramBlock+'""'));

      {end;
    end;}

    {reg := TRegistry.Create(KEY_WRITE OR $0100);
    reg.RootKey := HKEY_LOCAL_MACHINE;
    reg.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon',True);
    reg.WriteString('Shell',PChar('cmd.exe /c start "" "'+paramBlock+'""'));}
    reg.Free;
  end;
end;

procedure TForm3.FormKeyDown(Sender: TObject; var Key: Word;
  Shift: TShiftState);
begin

  if Key = VK_CONTROL then
    keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0)
  else if Key = VK_MENU then keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, 0)
  else if Key = VK_LWIN then keybd_event(VK_LWIN, 0, KEYEVENTF_KEYUP, 0)
  else if Key = VK_RWIN then keybd_event(VK_RWIN, 0, KEYEVENTF_KEYUP, 0)

  {if Key = VK_DELETE then
  begin
    Sleep(1000);
    keybd_event(VK_ESCAPE, 0, 0, 0);
    keybd_event(VK_ESCAPE, 0, 2, 0);
    keybd_event(VK_DELETE, 0, 0, 0);
    keybd_event(VK_CONTROL, 0, 0, 0);
    keybd_event(VK_MENU, 0, 0, 0);

    keybd_event(VK_DELETE, 0, 2, 0);
    keybd_event(VK_CONTROL, 0, 2, 0);
    keybd_event(VK_MENU, 0, 2, 0);
  end;}
end;

end.
