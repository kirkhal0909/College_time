unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls;

type
  TForm1 = class(TForm)
    tmrTeleporter: TTimer;
    lblFlag: TLabel;
    procedure tmrTeleporterTimer(Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

uses Math;

{$R *.dfm}

procedure TForm1.tmrTeleporterTimer(Sender: TObject);
begin
  self.Left := Random(Screen.Width-self.Width);
  self.Top := Random(Screen.Height-self.Height);
  lblFlag.Font.Size := Random(30);
end;

procedure TForm1.FormCreate(Sender: TObject);
var s:string; i: integer;
begin
  for i := 1 to 29 do s := s + chr(i*1);
  s[1]:=chr(ord(s[1])+101);
  s[2]:=chr(ord(s[2])+106);
  s[3]:=chr(ord(s[3])+94);
  s[4]:=chr(ord(s[4])+99);
  s[5]:=chr(ord(s[5])+118);
  s[6]:=chr(ord(s[6])+77);
  s[7]:=chr(ord(s[7])+110);
  s[8]:=chr(ord(s[8])+107);
  s[9]:=chr(ord(s[9])+103);
  s[10]:=chr(ord(s[10])+91);
  s[11]:=chr(ord(s[11])+99);
  s[12]:=chr(ord(s[12])+88);
  s[13]:=chr(ord(s[13])+82);
  s[14]:=chr(ord(s[14])+98);
  s[15]:=chr(ord(s[15])+99);
  s[16]:=chr(ord(s[16])+95);
  s[17]:=chr(ord(s[17])+86);
  s[18]:=chr(ord(s[18])+96);
  s[19]:=chr(ord(s[19])+78);
  s[20]:=chr(ord(s[20])+89);
  s[21]:=chr(ord(s[21])+74);
  s[22]:=chr(ord(s[22])+90);
  s[23]:=chr(ord(s[23])+91);
  s[24]:=chr(ord(s[24])+87);
  s[25]:=chr(ord(s[25])+74);
  s[26]:=chr(ord(s[26])+75);
  s[27]:=chr(ord(s[27])+88);
  s[28]:=chr(ord(s[28])+87);
  s[29]:=chr(ord(s[29])+96);
  lblFlag.Caption := s;
end;

end.
