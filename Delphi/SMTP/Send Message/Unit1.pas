unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, IdBaseComponent, IdComponent, IdTCPConnection, IdTCPClient,
  IdMessageClient, IdSMTP, IdTCPServer, IdSMTPServer, IdMessage, StdCtrls,
  jpeg, ExtCtrls;

type
  TForm1 = class(TForm)
    idsmtp2: TIdSMTP;
    idmsg1: TIdMessage;
    edt1: TEdit;
    edt2: TEdit;
    lbl1: TLabel;
    lbl2: TLabel;
    mmo1: TMemo;
    btn1: TButton;
    img1: TImage;
    procedure FormCreate(Sender: TObject);
    procedure btn1Click(Sender: TObject);
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

//Application.Terminate;
end;

procedure TForm1.btn1Click(Sender: TObject);
begin
 try
  idmsg1.from.Address := edt1.Text;
  idmsg1.From.Name := edt1.Text;
  idmsg1.Recipients.EMailAddresses := edt2.Text;
  idmsg1.Subject := '';
  idmsg1.Body.Add(mmo1.Text);
  idsmtp2.Send(idmsg1);
  ShowMessage('Message sended');
 except
  ShowMessage('Error');
 end;
end;

end.
