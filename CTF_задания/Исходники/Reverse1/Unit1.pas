unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    lblHello: TLabel;
    procedure lblHelloClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

const flag = 'flag{easy_get_flag_from_binary_file}';

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.lblHelloClick(Sender: TObject);
var s : string;
begin
  s := 'flag{easy_get_flag_from_binary_file}';
end;

end.
