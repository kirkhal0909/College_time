unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ShellAPI,Registry;

type
  TForm1 = class(TForm)
    btnSetup: TButton;
    lblInfo: TLabel;
    btnBack: TButton;
    edtPass: TEdit;
    lblStatus: TLabel;
    lblStatusInfo: TLabel;
    procedure btn1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure btnSetupClick(Sender: TObject);
    procedure btnBackClick(Sender: TObject);
    function Encrypt(s:string): string;
    function Decrypt(s:string): string;
    procedure Setuped(setup:Boolean);
    procedure ExtractRes(ResType, ResName, ResNewName : String);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

const programName = 'ParentControl';


var
  Form1: TForm1;
  programPath,filePass,paramBlock: string;
  Access: Boolean;
  CryptedPass : string;

implementation

uses PassEnter;

{$R *.dfm}
{$R exe.res}
{$R mn.res}

procedure TForm1.ExtractRes(ResType, ResName, ResNewName : String);
var
  Res : TResourceStream;
begin
  Res := TResourceStream.Create(Hinstance, Resname, Pchar(ResType));
  Res.SavetoFile(ResNewName);
  Res.Free;
end;

procedure Tform1.Setuped(setup:Boolean);
var reg:TRegistry;
begin
  btnBack.Enabled := setup;
  if setup then
  begin
    btnSetup.Caption := 'Изменить пароль';
    lblStatusInfo.Caption := 'Включена';
    lblStatusInfo.Font.Color := clGreen;

    if not FileExists(programPath+'\Locker.exe') then
      ExtractRes('EXEFILE', 'ARJ', programPath+'\Locker.exe');

    reg := TRegistry.Create(KEY_WRITE OR $0100);
    reg.RootKey := HKEY_LOCAL_MACHINE;
    reg.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon',True);
    //reg.WriteString('Shell',PChar('cmd.exe /c start "" "'+paramBlock+'""'));
    reg.WriteString('Userinit',PChar('"'+programPath+'\Locker.exe"'));
    reg.Free;
  end else
  begin
    btnSetup.Caption := 'Поставить пароль';
    lblStatusInfo.Caption := 'Отключена';
    lblStatusInfo.Font.Color := clMaroon;

    reg := TRegistry.Create(KEY_WRITE OR $0100);
    reg.RootKey := HKEY_LOCAL_MACHINE;
    reg.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon',True);
    reg.WriteString('Userinit',PChar(getEnvironmentVariable('WINDIR')+'\system32\userinit.exe,'));
    reg.Free;
  end;
end;

procedure TForm1.btn1Click(Sender: TObject);
//var reg:TRegistry;
var paramReg : string;
    cmdPath : string;
    reg:TRegistry;
begin
//  ShellExecute(Application.Handle,nil,'cmd','',nil,SW_SHOW);
  {cmdPath := GetEnvironmentVariable('WINDIR')+'\System32\cmd.exe';
  paramReg := '/k reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon" /v Shell /t REG_SZ /d test.exe /f';
  ShellExecute(Application.Handle,nil,PChar(cmdPath),PChar(paramReg),nil,SW_SHOW);}


  //reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon" /v Shell /t REG_SZ /d test.exe
  reg := TRegistry.Create(KEY_WRITE OR $0100);
  reg.RootKey := HKEY_LOCAL_MACHINE;
  reg.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon',True);
  reg.WriteString('Shell','VALUE');
  reg.Free;
end;

procedure TForm1.FormCreate(Sender: TObject);
var pass : string;
    PassF: TextFile;
begin
  Application.Title := 'Родительский контроль';
  programPath := GetEnvironmentVariable('PROGRAMFILES')+'\'+programName;
  paramBlock := programPath+'\'+programName+'.exe" -blockStart';
  filePass := programPath+'\pass';
  //filePass := getEnvironmentVariable('WINDIR')+'\pass';
  Setuped(FileExists(filePass));
  
  self.Top := (Screen.Height-self.Height) div 2;
  self.Left := (Screen.Width-self.Width) div 2;

  Access := True;
  if FileExists(filePass) then
  begin
    Access := False;
    AssignFile(PassF,filePass);
    Reset(PassF);
    Read(PassF,CryptedPass);
    CloseFile(PassF);
    //ShowMessage(CryptedPass);
    {pass := '-';
    while ((Encrypt(pass) <> CryptedPass) and (pass <>'')) do
    begin

      //Нужны звёзды

      pass := inputbox(Application.Title, 'Для изменения настроек необходимо ввести пароль', '');
      if pass = '' then Application.Terminate
      else if (Encrypt(pass) <> CryptedPass) then ShowMessage('Неправильный пароль!');
    end;}
  end;

  //ShowMessage(pass);
  //ShowMessage(GetEnvironmentVariable('WINDIR'));
  //ShowMessage(GetEnvironmentVariable('PROGRAMFILES'));
  //ShowMessage(programPath+'\'+programName+'.exe');
end;

function tform1.Encrypt(s:string): string;
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

function tform1.Decrypt(s:string): string;
var i,sym: integer;
  tmpS,tmpBlock: string;
begin
  tmpS := '';
  tmpBlock := '';
  sym := 0;
  for i := 1 to Length(s) do
  begin
    if (s[i] = ' ') then
    begin
      sym := sym+1;
      tmpS := tmpS + Char(StrToInt(tmpBlock)-sym*7);
      tmpBlock := '';
    end else
    begin
      tmpBlock := tmpBlock + s[i];
    end;
  end;
  sym := sym+1;
  tmpS := tmpS + Char(StrToInt(tmpBlock)-sym*7);
  Decrypt := tmpS;
end;

procedure TForm1.btnSetupClick(Sender: TObject);
var programExe : string;
    PassF : TextFile;
    pass : string;
    reg:TRegistry;    
begin
  //ShowMessage('post-modal');
  if Length(edtPass.Text) = 0 then begin ShowMessage('Блокировка не установлена!'+#13#10+'В поле необходимо ввести пароль'); end
  else
  begin
    if not Access then
      Form2.ShowModal();
    if Access then
    begin
      programExe := programPath+'\'+programName+'.exe';
      if (not (DirectoryExists(programPath))) then
        MkDir(programPath);
      if (Application.ExeName <> programExe) then
      begin
        DeleteFile(programExe);
        CopyFile(PChar(Application.ExeName),PChar(programExe),False);
      end;

      pass := Encrypt(edtPass.Text);
         AssignFile(PassF,filePass);
         Rewrite(PassF);
         Write(PassF,pass);
         CloseFile(PassF);
      CryptedPass := pass;
      ShowMessage('Блокировка установлена'+#13#10+
                  'Теперь при каждом запуске системы программа будет запрашивать пароль.'+#13#10+#13#10+
                  'Чтобы отключить блокировку, необходимо нажать - Сбросить пароль.'+#13#10+
                  'Копия программы находится по пути - '+programPath);
      Setuped(True);
      Access := false;
    end;
  end;
end;

procedure TForm1.btnBackClick(Sender: TObject);
var reg:TRegistry;
begin
  if not Access then
    Form2.ShowModal();
  if Access then
  begin
    DeleteFile(filePass);
    {reg := TRegistry.Create(KEY_WRITE OR $0100);
    reg.RootKey := HKEY_LOCAL_MACHINE;
    reg.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon',True);
    reg.WriteString('Shell','Explorer.exe');
    reg.Free;}
    Setuped(false);
    ShowMessage('Пароль сброшен и блокировка отключена!');
  end else ShowMessage('Блокировка не отключена|Пароль не сброшен!'+#13#10+'Чтобы отключить блокировку, необходимо ввести старый пароль');
end;

end.
