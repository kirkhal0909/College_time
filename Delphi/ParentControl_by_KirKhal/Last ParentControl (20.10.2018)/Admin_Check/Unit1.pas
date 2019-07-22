unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, WinSvc,ShellAPI;

type
  TForm1 = class(TForm)
    procedure FormCreate(Sender: TObject);
    function IsAdmin: Boolean;
  private
    { Private declarations }
  public
    { Public declarations }
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
  Form1: TForm1;
  programPath,filePass,paramBlock: string;

implementation

uses Locker;

{$R *.dfm}

function TForm1.IsAdmin: Boolean;
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

procedure TForm1.FormCreate(Sender: TObject);
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
  end
  else begin
    //self.Hide;
    Form3.Show;
  end;
end;

end.
