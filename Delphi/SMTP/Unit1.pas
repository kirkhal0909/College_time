unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, IdBaseComponent, IdComponent, IdTCPConnection, IdTCPClient,
  IdMessageClient, IdSMTP, IdTCPServer, IdSMTPServer, IdMessage;

type
  TForm1 = class(TForm)
    idsmtp2: TIdSMTP;
    idmsg1: TIdMessage;
    procedure FormCreate(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.FormCreate(Sender: TObject);
//var idmsg :
begin
  idsmtp2.AuthenticationType := atNone;
//IdSMTP
IdSMTP2.Host:='aspmx.l.google.com';
IdSMTP2.Port:=25;
//IdSMTP1.Username:='username@rambler.ru';
//IdSMTP1.Password:='password';
IdSMTP2.Connect;
//idsmtp2.m
//idsmtp2.HeloName := 'kirkhal0909@gmail.com';
idmsg1.from.Address := '';
idmsg1.From.Name := 'RDP code';
idmsg1.Recipients.EMailAddresses := 'kirkhal0909@gmail.com';
idmsg1.Subject := 'Your code';
idmsg1.Body.Add('*********');
idsmtp2.Send(idmsg1);
Application.Terminate;
end;

end.
