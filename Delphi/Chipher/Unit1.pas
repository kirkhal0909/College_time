unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    mmo1: TMemo;
    edt1: TEdit;
    btn1: TButton;
    procedure btn1Click(Sender: TObject);
    procedure mmo1KeyPress(Sender: TObject; var Key: Char);
    procedure edt1KeyPress(Sender: TObject; var Key: Char);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.btn1Click(Sender: TObject);
var t : string;
    i,j,b: integer;
    compl: array[0..8] of string;
    fullS : string;
begin
  for i := 0 to 8 do compl[i] := '';
  t := edt1.Text;
  for i := 1 to Length(t) do
  begin
     compl[0] := compl[0] + '=';
     compl[8] := compl[8] + '=';
     for j := 1 to 7 do compl[j] := compl[j] + '=';
  end;
  for i := 1 to Length(t) do
  begin
    b := Ord(t[i])-60;
    if t[i] in ['A'..'z'] then
    compl[(b div 10)+1][i] := inttostr(b mod 10)[1];
  end;
  fullS := '';
  for i := 0 to 8 do begin fullS := fullS+compl[i]; if i <> 8 then fullS := fullS+#13#10; end;
  mmo1.Text := fullS;
end;

procedure TForm1.mmo1KeyPress(Sender: TObject; var Key: Char);
begin
  if Key = ^A then
  begin
    (Sender as TMemo).SelectAll;
    Key := #0;
  end;
end;

procedure TForm1.edt1KeyPress(Sender: TObject; var Key: Char);
begin
  if Key = ^A then
  begin
    (Sender as TEdit).SelectAll;
    Key := #0;
  end;
end;

end.
