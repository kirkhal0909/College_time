unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, Unit2, StdCtrls,ComObj, Grids;

type
  TForm1 = class(TForm)
    btn1: TButton;
    edt1: TEdit;
    strngrd1: TStringGrid;
    procedure btn1Click(Sender: TObject);
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
var XL, WB, Sheet : Variant;
  Rows,Cols : Integer;
  count,i,j: integer;
begin
  XL := CreateOleObject('Excel.Application');
  //XL.Workbooks.Open('D:\Практика\Excl\2.xlsx');
  XL.DisplayAlerts := false;
  WB := XL.Workbooks.Add('D:\Практика\Excl\2.xlsx');
  Sheet := WB.activeSheet;

  edt1.Text := Sheet.Cells[1,1];
  if Pos('№ маршрута',LowerCase(Sheet.cells[13,3])) <> 0 then ShowMessage('Маршрут')
  else ShowMessage('Маршрута нету');
  ShowMessage(LowerCase(Sheet.cells[15,3]));

{  Sheet.Cells[5,5] := 'TEST';
  XL.Rows[4].Delete;}
  Sheet.SaveAs('D:\Практика\Excl\2.xlsx');

  Rows := XL.ActiveSheet.UsedRange.Rows.Count;
  Cols := XL.ActiveSheet.UsedRange.Columns.Count;
  for i := 1 to 130 do
   for j := 1 to Cols do
    strngrd1.Cells[i,j] := Sheet.cells[i,j];

  XL.Quit;
  ShowMessage(IntToStr(Rows)+':'+IntToStr(Cols));


 //Xls_Open('C:\Users\Кирилл\Desktop\Книга1');

end;

end.
