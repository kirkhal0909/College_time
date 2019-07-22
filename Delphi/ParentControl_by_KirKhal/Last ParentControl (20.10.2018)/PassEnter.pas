unit PassEnter;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm2 = class(TForm)
    btnSetup: TButton;
    edtPass: TEdit;
    chkShow: TCheckBox;
    lblInfo: TLabel;
    procedure FormCreate(Sender: TObject);
    procedure btnSetupClick(Sender: TObject);
    procedure chkShowClick(Sender: TObject);
    procedure edtPassKeyPress(Sender: TObject; var Key: Char);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form2: TForm2;

implementation

{$R *.dfm}

uses Unit1;

procedure TForm2.FormCreate(Sender: TObject);
begin
  self.Caption := 'Ввод старого пароля';
  self.Top := (Screen.Height-self.Height) div 2;
  self.Left := (Screen.Width-self.Width) div 2;
end;

procedure TForm2.btnSetupClick(Sender: TObject);
begin
  if CryptedPass = Form1.Encrypt(edtPass.Text) then
  begin
    Access := True;
    //ShowMessage(CryptedPass+'|'+Form1.Encrypt(edtPass.Text));
    edtPass.Text := '';
    Self.Close;
  end else ShowMessage('Неправильный пароль!');
end;

procedure TForm2.chkShowClick(Sender: TObject);
begin
  if (Sender as TCheckBox).Checked then
  begin
    edtPass.PasswordChar := #0;
  end else edtPass.PasswordChar := '*';
  //edtPass.SetFocus;
end;

procedure TForm2.edtPassKeyPress(Sender: TObject; var Key: Char);
begin
  if Key = #13 then btnSetup.Click();
end;

end.
