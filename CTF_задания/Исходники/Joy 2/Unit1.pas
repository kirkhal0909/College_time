unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    btnHello: TButton;
    procedure FormCreate(Sender: TObject);
    procedure btnHelloClick(Sender: TObject);
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
begin
  Application.Title := 'Click me :)';
end;

procedure TForm1.btnHelloClick(Sender: TObject);
var s: string;
    i: Integer;
begin
  s := '';  //flag{I_am_hided_Click_me}
  for i := 1 to 25 do
    s := s + chr(i*3);
  s[1]:=chr(ord(s[1])+99);
  s[2]:=chr(ord(s[2])+102);
  s[3]:=chr(ord(s[3])+88);
  s[4]:=chr(ord(s[4])+91);
  s[5]:=chr(ord(s[5])+108);
  s[6]:=chr(ord(s[6])+55);
  s[7]:=chr(ord(s[7])+74);
  s[8]:=chr(ord(s[8])+73);
  s[9]:=chr(ord(s[9])+82);
  s[10]:=chr(ord(s[10])+65);
  s[11]:=chr(ord(s[11])+71);
  s[12]:=chr(ord(s[12])+69);
  s[13]:=chr(ord(s[13])+61);
  s[14]:=chr(ord(s[14])+59);
  s[15]:=chr(ord(s[15])+55);
  s[16]:=chr(ord(s[16])+47);
  s[17]:=chr(ord(s[17])+16);
  s[18]:=chr(ord(s[18])+54);
  s[19]:=chr(ord(s[19])+48);
  s[20]:=chr(ord(s[20])+39);
  s[21]:=chr(ord(s[21])+44);
  s[22]:=chr(ord(s[22])+29);
  s[23]:=chr(ord(s[23])+40);
  s[24]:=chr(ord(s[24])+29);
  s[25]:=chr(ord(s[25])+50);
  Self.Caption := s;
  ShowMessage(s);
end;

end.
