unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    btnSorry: TButton;
    btnGetFlag: TButton;
    procedure btnSorryClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure btnGetFlagClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btnSorryClick(Sender: TObject);
begin
  ShowMessage('Флаг выдаётся по нажатию на вторую кнопку!');
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  Application.Title := 'Where the second button?';
end;

procedure TForm1.btnGetFlagClick(Sender: TObject);
var s:string; i: integer;
begin
  for i := 1 to 72 do s := s + chr(i*1);
  s[1]:=chr(ord(s[1])+101);
  s[2]:=chr(ord(s[2])+106);
  s[3]:=chr(ord(s[3])+94);
  s[4]:=chr(ord(s[4])+99);
  s[5]:=chr(ord(s[5])+118);
  s[6]:=chr(ord(s[6])+67);
  s[7]:=chr(ord(s[7])+95);
  s[8]:=chr(ord(s[8])+87);
  s[9]:=chr(ord(s[9])+107);
  s[10]:=chr(ord(s[10])+94);
  s[11]:=chr(ord(s[11])+90);
  s[12]:=chr(ord(s[12])+83);
  s[13]:=chr(ord(s[13])+85);
  s[14]:=chr(ord(s[14])+103);
  s[15]:=chr(ord(s[15])+101);
  s[16]:=chr(ord(s[16])+100);
  s[17]:=chr(ord(s[17])+94);
  s[18]:=chr(ord(s[18])+92);
  s[19]:=chr(ord(s[19])+76);
  s[20]:=chr(ord(s[20])+85);
  s[21]:=chr(ord(s[21])+94);
  s[22]:=chr(ord(s[22])+73);
  s[23]:=chr(ord(s[23])+81);
  s[24]:=chr(ord(s[24])+81);
  s[25]:=chr(ord(s[25])+75);
  s[26]:=chr(ord(s[26])+74);
  s[27]:=chr(ord(s[27])+74);
  s[28]:=chr(ord(s[28])+82);
  s[29]:=chr(ord(s[29])+66);
  s[30]:=chr(ord(s[30])+75);
  s[31]:=chr(ord(s[31])+85);
  s[32]:=chr(ord(s[32])+63);
  s[33]:=chr(ord(s[33])+67);
  s[34]:=chr(ord(s[34])+77);
  s[35]:=chr(ord(s[35])+66);
  s[36]:=chr(ord(s[36])+79);
  s[37]:=chr(ord(s[37])+58);
  s[38]:=chr(ord(s[38])+72);
  s[39]:=chr(ord(s[39])+72);
  s[40]:=chr(ord(s[40])+76);
  s[41]:=chr(ord(s[41])+54);
  s[42]:=chr(ord(s[42])+67);
  s[43]:=chr(ord(s[43])+58);
  s[44]:=chr(ord(s[44])+53);
  s[45]:=chr(ord(s[45])+65);
  s[46]:=chr(ord(s[46])+49);
  s[47]:=chr(ord(s[47])+69);
  s[48]:=chr(ord(s[48])+56);
  s[49]:=chr(ord(s[49])+48);
  s[50]:=chr(ord(s[50])+66);
  s[51]:=chr(ord(s[51])+44);
  s[52]:=chr(ord(s[52])+69);
  s[53]:=chr(ord(s[53])+58);
  s[54]:=chr(ord(s[54])+63);
  s[55]:=chr(ord(s[55])+40);
  s[56]:=chr(ord(s[56])+43);
  s[57]:=chr(ord(s[57])+40);
  s[58]:=chr(ord(s[58])+52);
  s[59]:=chr(ord(s[59])+36);
  s[60]:=chr(ord(s[60])+50);
  s[61]:=chr(ord(s[61])+50);
  s[62]:=chr(ord(s[62])+54);
  s[63]:=chr(ord(s[63])+32);
  s[64]:=chr(ord(s[64])+48);
  s[65]:=chr(ord(s[65])+49);
  s[66]:=chr(ord(s[66])+35);
  s[67]:=chr(ord(s[67])+48);
  s[68]:=chr(ord(s[68])+47);
  s[69]:=chr(ord(s[69])+26);
  s[70]:=chr(ord(s[70])+35);
  s[71]:=chr(ord(s[71])+45);
  s[72]:=chr(ord(s[72])+53);
  Self.Caption := s;
  ShowMessage(s);
end;

end.
