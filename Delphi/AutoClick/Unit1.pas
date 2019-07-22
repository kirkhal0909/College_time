unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls;

type
  TForm1 = class(TForm)
    tmr1: TTimer;
    edt1: TEdit;
    lbl1: TLabel;
    Button1: TButton;
    lbl2: TLabel;
    edt2: TEdit;
    procedure FormKeyDown(Sender: TObject; var Key: Word;
      Shift: TShiftState);
    procedure chk1KeyDown(Sender: TObject; var Key: Word;
      Shift: TShiftState);
    procedure tmr1Timer(Sender: TObject);
    procedure FormHide(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.FormKeyDown(Sender: TObject; var Key: Word;
  Shift: TShiftState);
begin
 edt2.Text := inttostr(key);
// keybd_event();
end;

procedure TForm1.chk1KeyDown(Sender: TObject; var Key: Word;
  Shift: TShiftState);
begin
 //showmessage(inttostr(key));
end;

procedure TForm1.tmr1Timer(Sender: TObject);
begin
 keybd_event(strtoint(edt1.text),0,0,0);
 keybd_event(strtoint(edt1.text),0,2,0);
end;

procedure TForm1.FormHide(Sender: TObject);
begin
 tmr1.Enabled := true;
end;

procedure TForm1.FormShow(Sender: TObject);
begin
 tmr1.Enabled := false;
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
 tmr1.Enabled := not tmr1.Enabled;
end;

end.
