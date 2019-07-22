unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    btnRunner: TButton;
    procedure btnRunnerMouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure btnRunnerClick(Sender: TObject);
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

procedure TForm1.btnRunnerMouseMove(Sender: TObject; Shift: TShiftState; X,
  Y: Integer);
begin
  self.Left := Random(Screen.Width-Self.Width);
  self.Top := Random(Screen.Height-Self.Height);
end;

procedure TForm1.btnRunnerClick(Sender: TObject);
var s : string;
  i : integer;
begin
  s := '';  //flag{You_can_not_click_But_You_can_press}
  for i := 1 to 41 do
    s := s + chr(i);
  s[1]:=chr(ord(s[1])+101);
  s[2]:=chr(ord(s[2])+106);
  s[3]:=chr(ord(s[3])+94);
  s[4]:=chr(ord(s[4])+99);
  s[5]:=chr(ord(s[5])+118);
  s[6]:=chr(ord(s[6])+83);
  s[7]:=chr(ord(s[7])+104);
  s[8]:=chr(ord(s[8])+109);
  s[9]:=chr(ord(s[9])+86);
  s[10]:=chr(ord(s[10])+89);
  s[11]:=chr(ord(s[11])+86);
  s[12]:=chr(ord(s[12])+98);
  s[13]:=chr(ord(s[13])+82);
  s[14]:=chr(ord(s[14])+96);
  s[15]:=chr(ord(s[15])+96);
  s[16]:=chr(ord(s[16])+100);
  s[17]:=chr(ord(s[17])+78);
  s[18]:=chr(ord(s[18])+81);
  s[19]:=chr(ord(s[19])+89);
  s[20]:=chr(ord(s[20])+85);
  s[21]:=chr(ord(s[21])+78);
  s[22]:=chr(ord(s[22])+85);
  s[23]:=chr(ord(s[23])+72);
  s[24]:=chr(ord(s[24])+42);
  s[25]:=chr(ord(s[25])+92);
  s[26]:=chr(ord(s[26])+90);
  s[27]:=chr(ord(s[27])+68);
  s[28]:=chr(ord(s[28])+61);
  s[29]:=chr(ord(s[29])+82);
  s[30]:=chr(ord(s[30])+87);
  s[31]:=chr(ord(s[31])+64);
  s[32]:=chr(ord(s[32])+67);
  s[33]:=chr(ord(s[33])+64);
  s[34]:=chr(ord(s[34])+76);
  s[35]:=chr(ord(s[35])+60);
  s[36]:=chr(ord(s[36])+76);
  s[37]:=chr(ord(s[37])+77);
  s[38]:=chr(ord(s[38])+63);
  s[39]:=chr(ord(s[39])+76);
  s[40]:=chr(ord(s[40])+75);
  s[41]:=chr(ord(s[41])+84);
  Self.Caption := s;
  ShowMessage(s);
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  Application.Title := 'Teleporter';
end;

end.
