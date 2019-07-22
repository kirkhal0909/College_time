unit Unit2;

interface
uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ComObj;
procedure SortRoutes(XLSFile: string; Route: Integer);
procedure SortInDir(Path: string; Route: Integer);

implementation

procedure SortRoutes(XLSFile: string; Route: Integer);
const xlCellTypeLastCell = $0000000B;
var
  ExlApp, Sheet: OLEVariant;
  i, j, r, c,CountCol,CountRow,k:integer;
  ThereIs,HaveRoute: Boolean;
  cell: string;
begin
  //XLSFile := 'D:\ѕрактика\Test\2.xlsx';
  ExlApp := CreateOleObject('Excel.Application'); //создаем объект Excel
  ExlApp.Visible := false; //делаем окно Excel невидимым
  ExlApp.DisplayAlerts := false;  //Ќе запрашивать перезапись файла
  ExlApp.Workbooks.Open(XLSFile); //открываем файл XLSFile

  //создаем объект Sheet(страница) и указываем номер листа (1)
  //в книге, с которого будем осуществл€ть чтение
  Sheet := ExlApp.Workbooks[ExtractFileName(XLSFile)].WorkSheets[1];
  //Sheet.Cells.SpecialCells(xlCellTypeLastCell, EmptyParam).Activate; //активируем последнюю €чейку на листе
    r := Sheet.Cells.SpecialCells(11, EmptyParam).Row;//ExlApp.ActiveCell.Row; // ¬озвращает номер последней строки
    c := Sheet.Cells.SpecialCells(11, EmptyParam).Column;// ExlApp.ActiveCell.Column; // ¬озвращает номер последнего столбца
  //ShowMessage(IntToStr(r)+':'+IntToStr(c));
  //sheet.cells[j,i]


  i := 1; j := 1; CountCol := 1; CountRow := 0;
  while i <= r do
  begin
    try cell := Sheet.Cells[i,countCol]; except cell := ''; end;
    if CountRow = 0 then
    begin
     if Pos('є маршрута',LowerCase(sheet.cells[i,j])) <> 0 then
     begin CountCol := j; CountRow := i; i := i + 2; end else Inc(j);
    end
    else begin
         if cell = '' then
         begin ThereIs := False; for k := 2 to 9 do begin
            try cell := Sheet.Cells[i,k]; except cell := ''; end;
            if cell <> '' then ThereIs := True;
           end;
           if not(ThereIs) then CountRow := 0
           else ExlApp.Rows[i].delete;
         end else if cell <> IntToStr(Route) then begin ExlApp.Rows[i].delete; Dec(i); end
         else HaveRoute := True;
         inc(i);
    end;

    if j > c then begin j := 1; inc(i); end;
  end;


{  if Pos('є маршрута',LowerCase(sheet.cells[21,3])) <> 0 then ShowMessage('≈сть')
  else ShowMessage('Ќету');}
  //ExlApp.Rows[21].delete;
  Sheet.SaveAs(XLSFile);// —охран€ем изменени€

 ExlApp.Quit; //закрываем приложение Excel
 //очищаем выделенную пам€ть
 ExlApp := Unassigned;
 Sheet := Unassigned;
 if not (HaveRoute) then begin Sleep(100); DeleteFile(XLSFile); end;
end;

//–екурсивно ищем файлы в подпапках директории
procedure SortInDir(Path: string; Route: Integer);
var SR : TSearchRec;
  List,SubPath: string;
  op,cl : Integer;
  HaveExcel: Boolean;
begin
 // ѕолучаем список подпапок
 if DirectoryExists(Path) then
  if FindFirst(IncludeTrailingBackslash(Path)+ '*.*',faAnyFile, SR) = 0 then
   begin
    repeat
     if (SR.Attr = faDirectory) and (SR.Name[Length(SR.Name)] <> '.') then
       List := List + 'Х'+SR.Name+'Х';
    until FindNext(SR) <> 0;
   end
 else ShowMessage(Path+' - “акого пути нет');
 //ќткрываем папки на уровень ниже
 while Pos('Х',List) <> 0 do
 begin
  op := Pos('Х',List); List[op] := '~';
  cl := Pos('Х',List); List[cl] := '~';
  SubPath := Path + '\' + Copy(List,op+1,cl-op-1);
  //ShowMessage(Copy(List,op+1,cl-op-1));
  SortInDir(SubPath,Route);
 end;
 List := '';

 //»щем Excel файлы
 if FindFirst(IncludeTrailingBackslash(Path)+ '*.*',faAnyFile, SR) = 0 then
 begin
   repeat
     if (ExtractFileExt(SR.Name) = '.xlsx') or (ExtractFileExt(SR.Name) = '.xls') or (ExtractFileExt(SR.Name) = '.xml')
     then List := List + 'Х' + SR.Name + 'Х';
   until FindNext(SR) <> 0;
 end;
 //»змен€ем Excel файлы
 while Pos('Х',List) <> 0 do
 begin
  op := Pos('Х',List); List[op] := '~';
  cl := Pos('Х',List); List[cl] := '~';
  SubPath := Path+'\'+Copy(List,op+1,cl-op-1);
  //ShowMessage(SubPath);
  SortRoutes(SubPath,Route);
 end;

 List := '';

 //ѕроверить, есть ли хоть один Excel файл
 if FindFirst(IncludeTrailingBackslash(Path)+ '*.*',faAnyFile, SR) = 0 then
 begin
   repeat
     if (ExtractFileExt(SR.Name) = '.xlsx') or (ExtractFileExt(SR.Name) = '.xls') or (ExtractFileExt(SR.Name) = '.xml')
     then List := List + 'Х' + SR.Name + 'Х';
   until FindNext(SR) <> 0;
 end;
end;

end.
