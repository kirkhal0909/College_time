unit Mouse;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm2 = class(TForm)
    procedure FormCreate(Sender: TObject);
    procedure FormKeyUp(Sender: TObject; var Key: Word;
      Shift: TShiftState);
    procedure FormMouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure FormKeyDown(Sender: TObject; var Key: Word;
      Shift: TShiftState);
    procedure FormActivate(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form2: TForm2;
  ClickM : boolean;
  MouseB : TMouseButton;
  ActM : integer;

implementation

uses Unit1;

{$R *.dfm}


procedure TForm2.FormCreate(Sender: TObject);
begin
  AlphaBlend := true; AlphaBlendValue := 50;
  Self.Width := Screen.Width; Self.Height := screen.Height;
  self.Left := 0; self.Top := 0;
end;

procedure TForm2.FormKeyUp(Sender: TObject; var Key: Word;
  Shift: TShiftState);
begin
  self.Hide; Application.MainForm.Show
end;

procedure TForm2.FormMouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
  ClickM := true;
   MouseB := Button;
end;

procedure TForm2.FormKeyDown(Sender: TObject; var Key: Word;
  Shift: TShiftState);
var p : TPoint;
begin
  if Key = VK_CONTROL then
  begin
    GetCursorPos(p);
    edit[2][ActM].Text := inttostr(p.X);
    edit[4][ActM].Text := inttostr(p.Y);
    if ClickM then
      case MouseB of
        mbLeft: ListMouseKeys[ActM].ItemIndex := 0;
        mbRight: ListMouseKeys[ActM].ItemIndex := 1;
        mbMiddle: ListMouseKeys[ActM].ItemIndex := 2;
      end;
//    (Sender as TEdit).SelStart := length((Sender as TEdit).Text);
  end
end;

procedure TForm2.FormActivate(Sender: TObject);
begin
  Self.Width := Screen.Width; Self.Height := screen.Height;
  self.Left := 0; self.Top := 0;
end;

end.
