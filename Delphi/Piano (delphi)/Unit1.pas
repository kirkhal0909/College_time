unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls, MPlayer;

type
  TForm1 = class(TForm)
    mp1: TMediaPlayer;
    pnl1: TPanel;
    btnB24: TButton;
    btnB22: TButton;
    btnB20: TButton;
    btnB18: TButton;
    btnB17: TButton;
    btnB15: TButton;
    btnB13: TButton;
    btnB12: TButton;
    btnB10: TButton;
    btnB8: TButton;
    btnB6: TButton;
    btnB5: TButton;
    btnB3: TButton;
    btnB1: TButton;
    btnB2: TButton;
    btnB4: TButton;
    btnB7: TButton;
    btnB9: TButton;
    btnB11: TButton;
    btnB14: TButton;
    btnB16: TButton;
    btnB19: TButton;
    btnB21: TButton;
    btnB23: TButton;
    btn1: TButton;
    btn2: TButton;
    lbl1: TLabel;
    edt1: TEdit;
    btn3: TButton;
    btn4: TButton;
    tmr1: TTimer;
    procedure FormCreate(Sender: TObject);
    procedure FormKeyPress(Sender: TObject; var Key: Char);
    procedure btnB1Click(Sender: TObject);
    procedure btn1Click(Sender: TObject);
    procedure btn2Click(Sender: TObject);
    procedure edt1KeyPress(Sender: TObject; var Key: Char);
    procedure edt1Change(Sender: TObject);
    procedure btn4Click(Sender: TObject);
    procedure btn3Click(Sender: TObject);
    procedure edt1Click(Sender: TObject);
    procedure edt1Exit(Sender: TObject);
    procedure pnl1Click(Sender: TObject);
    procedure tmr1Timer(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;
const path = 'C:\Windows\Media\notes';
var
  Form1: TForm1;
  Octave : Integer = 3;

implementation

{$R *.dfm}

procedure TForm1.FormCreate(Sender: TObject);
begin

 mp1.FileName := path + '\notes1.mid';
 mp1.Open;
 lbl1.Caption := IntToStr(octave);
end;

procedure TForm1.FormKeyPress(Sender: TObject; var Key: Char);
begin
 if Key in ['q','Q'] then begin
  btnB1click(btnB3);
  btnB3.SetFocus;
 end else if Key in ['a','A'] then begin
  btnB1click(btnB4);
  btnB4.SetFocus;
 end else if Key in ['z','Z'] then begin
  btnB1click(btnB5);
  btnB5.SetFocus;
 end else if Key in ['x','X'] then begin
  btnB1click(btnB6);
  btnB6.SetFocus;
 end else if Key in ['d','D'] then begin
  btnB1click(btnB7);
  btnB7.SetFocus;
 end else if Key in ['c','C'] then begin
  btnB1click(btnB8);
  btnB8.SetFocus;
 end else if Key in ['f','F'] then begin
  btnB1click(btnB9);
  btnB9.SetFocus;
 end else if Key in ['v','V'] then begin
  btnB1click(btnB10);
  btnB10.SetFocus;
 end else if Key in ['g','G'] then begin
  btnB1click(btnB11);
  btnB11.SetFocus;
 end else if Key in ['b','B'] then begin
  btnB1click(btnB12);
  btnB12.SetFocus;
 end else if Key in ['n','N'] then begin
  btnB1click(btnB13);
  btnB13.SetFocus;
 end else if Key in ['j','J'] then begin
  btnB1click(btnB14);
  btnB14.SetFocus;
 end else if Key in ['m','M'] then begin
  btnB1click(btnB15);
  btnB15.SetFocus;
 end else if Key in ['k','K'] then begin
  btnB1click(btnB16);
  btnB16.SetFocus;
 end else if Key in [','] then begin
  btnB1click(btnB17);
  btnB17.SetFocus;
 end else if Key in ['.'] then begin
  btnB1click(btnB18);
  btnB18.SetFocus;
 end else if Key in [';'] then begin
  btnB1click(btnB19);
  btnB19.SetFocus;
 end else if Key in ['/'] then begin
  btnB1click(btnB20);
  btnB20.SetFocus;
 end else if Key in [#39] then begin
  btnB1click(btnB21);
  btnB21.SetFocus;
 end else if Key in ['1'] then begin
  btnB1click(btnB22);
  btnB22.SetFocus;
 end else if Key in ['5'] then begin
  btnB1click(btnB23);
  btnB23.SetFocus;
 end else if Key in ['3'] then begin
  btnB1click(btnB24);
  btnB24.SetFocus;
 end else if Key in ['[','{'] then begin
  btn1click(btn1);
  btn1.SetFocus;
 end else if Key in [']','}'] then begin
  btn2click(btn2);
  btn2.SetFocus;
 end else if Key in ['-','_'] then begin
  btn3click(btn3);
  btn3.SetFocus;
 end else if Key in ['=','+'] then begin
  btn4click(btn4);
  btn4.SetFocus;
 end;
end;

procedure TForm1.btnB1Click(Sender: TObject);
var note,i : Integer;
begin
 Val(Copy((Sender as TButton).name,5,2),note,i);
 mp1.StartPos := ((Octave - 1)*12 + note-1) * 16;
 mp1.EndPos := mp1.StartPos + 16;
 mp1.Play;
 if StrToInt(edt1.Text) > 1 then
 begin
  tmr1.Enabled := False;
  tmr1.Enabled := True;
 end;
end;

procedure TForm1.btn1Click(Sender: TObject);
begin
 if Octave > 1 then begin
   Octave := Octave - 1;
   lbl1.Caption := IntToStr(octave);
 end;
end;

procedure TForm1.btn2Click(Sender: TObject);
begin
 if Octave < 6 then begin
   Octave := Octave + 1;
   lbl1.Caption := IntToStr(octave);
 end;
end;

procedure TForm1.edt1KeyPress(Sender: TObject; var Key: Char);
begin
 if not (key in ['0'..'9',#8]) then key := #0;
end;

procedure TForm1.edt1Change(Sender: TObject);
var a : Integer;
begin
 if edt1.Text <> '' then begin a := StrToInt(edt1.Text);
  if a > 128 then begin
   a := 128;
   edt1.text := IntToStr(a);
  end else
   if a < 1 then begin
    a := 1;
    edt1.text := IntToStr(a);
   end else begin mp1.Close;
    mp1.FileName := path + '\notes' + IntToStr(a) + '.mid'; mp1.open end;
 end;
end;

procedure TForm1.btn4Click(Sender: TObject);
begin
 edt1.Text := IntToStr(StrToInt(edt1.Text) + 1);
end;

procedure TForm1.btn3Click(Sender: TObject);
begin
 edt1.Text := IntToStr(StrToInt(edt1.Text) - 1);
end;

procedure TForm1.edt1Click(Sender: TObject);
begin
 KeyPreview := False;
end;

procedure TForm1.edt1Exit(Sender: TObject);
begin
 KeyPreview := True;
end;

procedure TForm1.pnl1Click(Sender: TObject);
begin
 KeyPreview := True;
end;

procedure TForm1.tmr1Timer(Sender: TObject);
begin
 mp1.StartPos := 83*16;
 mp1.EndPos := 83*16;
 mp1.Play;
 tmr1.Enabled := False;
end;

end.
