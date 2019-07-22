unit Unit2;

interface
uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ComObj;
procedure SortRoutes(Path: string; route: Integer);

implementation
procedure SortRoutes(Path: string; route: Integer);
var XL, WB, Sheet : Variant;
  Rows,Cols : LongInt;
  count,i,j: integer;
begin
  XL := CreateOleObject('Excel.Application');
  XL.DisplayAlerts := false;   //Убираем подвтерждение перезаписи файла
  WB := XL.Workbooks.Add(Path);   //Открываем файл
  Sheet := WB.activeSheet;

  //Число используемых строк и столбцов
  Rows := XL.ActiveSheet.UsedRange.Rows.Count;
  Cols := XL.ActiveSheet.UsedRange.Columns.Count;

  while (i <= Rows) do
  begin

    if j > Cols then Inc(i);
  end;

  //Sheet.Cells[5,5] := 'TEST';
  //XL.Rows[4].Delete;

  Sheet.SaveAs(Path);

  XL.Quit;
  ShowMessage(IntToStr(Rows)+':'+IntToStr(Cols));
end;

end.
 