unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls;

type
  TForm1 = class(TForm)
    tmr1: TTimer;
    lblTime: TLabel;
    procedure FormCreate(Sender: TObject);
    procedure tmr1Timer(Sender: TObject);
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
var
  today : TDateTime;
begin
  today := Now;
  lblTime.Caption := TimeToStr(today);
  //lblDate.Caption := DateToStr(today);
  Self.FormStyle := fsStayOnTop;
end;

procedure TForm1.tmr1Timer(Sender: TObject);
var
  today : TDateTime;
begin
  today := Now;
  lblTime.Caption := TimeToStr(today);
  //lblDate.Caption := DateToStr(today);
  Self.Caption := 'Часы - '+DateToStr(today);
  //ShowMessage('today has time = '+TimeToStr(today));
end;

end.
