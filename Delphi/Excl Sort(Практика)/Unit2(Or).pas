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
  //XLSFile := 'D:\��������\Test\2.xlsx';
  ExlApp := CreateOleObject('Excel.Application'); //������� ������ Excel
  ExlApp.Visible := false; //������ ���� Excel ���������
  ExlApp.DisplayAlerts := false;  //�� ����������� ���������� �����
  ExlApp.Workbooks.Open(XLSFile); //��������� ���� XLSFile

  //������� ������ Sheet(��������) � ��������� ����� ����� (1)
  //� �����, � �������� ����� ������������ ������
  Sheet := ExlApp.Workbooks[ExtractFileName(XLSFile)].WorkSheets[1];
  //Sheet.Cells.SpecialCells(xlCellTypeLastCell, EmptyParam).Activate; //���������� ��������� ������ �� �����
    r := Sheet.Cells.SpecialCells(11, EmptyParam).Row;//ExlApp.ActiveCell.Row; // ���������� ����� ��������� ������
    c := Sheet.Cells.SpecialCells(11, EmptyParam).Column;// ExlApp.ActiveCell.Column; // ���������� ����� ���������� �������
  //ShowMessage(IntToStr(r)+':'+IntToStr(c));
  //sheet.cells[j,i]


  i := 1; j := 1; CountCol := 1; CountRow := 0;
  while i <= r do
  begin
    try cell := Sheet.Cells[i,countCol]; except cell := ''; end;
    if CountRow = 0 then
    begin
     if Pos('� ��������',LowerCase(sheet.cells[i,j])) <> 0 then
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


{  if Pos('� ��������',LowerCase(sheet.cells[21,3])) <> 0 then ShowMessage('����')
  else ShowMessage('����');}
  //ExlApp.Rows[21].delete;
  Sheet.SaveAs(XLSFile);// ��������� ���������

 ExlApp.Quit; //��������� ���������� Excel
 //������� ���������� ������
 ExlApp := Unassigned;
 Sheet := Unassigned;
 if not (HaveRoute) then begin Sleep(100); DeleteFile(XLSFile); end;
end;

//���������� ���� ����� � ��������� ����������
procedure SortInDir(Path: string; Route: Integer);
var SR : TSearchRec;
  List,SubPath: string;
  op,cl : Integer;
  HaveExcel: Boolean;
begin
 // �������� ������ ��������
 if DirectoryExists(Path) then
  if FindFirst(IncludeTrailingBackslash(Path)+ '*.*',faAnyFile, SR) = 0 then
   begin
    repeat
     if (SR.Attr = faDirectory) and (SR.Name[Length(SR.Name)] <> '.') then
       List := List + '�'+SR.Name+'�';
    until FindNext(SR) <> 0;
   end
 else ShowMessage(Path+' - ������ ���� ���');
 //��������� ����� �� ������� ����
 while Pos('�',List) <> 0 do
 begin
  op := Pos('�',List); List[op] := '~';
  cl := Pos('�',List); List[cl] := '~';
  SubPath := Path + '\' + Copy(List,op+1,cl-op-1);
  //ShowMessage(Copy(List,op+1,cl-op-1));
  SortInDir(SubPath,Route);
 end;
 List := '';

 //���� Excel �����
 if FindFirst(IncludeTrailingBackslash(Path)+ '*.*',faAnyFile, SR) = 0 then
 begin
   repeat
     if (ExtractFileExt(SR.Name) = '.xlsx') or (ExtractFileExt(SR.Name) = '.xls') or (ExtractFileExt(SR.Name) = '.xml')
     then List := List + '�' + SR.Name + '�';
   until FindNext(SR) <> 0;
 end;
 //�������� Excel �����
 while Pos('�',List) <> 0 do
 begin
  op := Pos('�',List); List[op] := '~';
  cl := Pos('�',List); List[cl] := '~';
  SubPath := Path+'\'+Copy(List,op+1,cl-op-1);
  //ShowMessage(SubPath);
  SortRoutes(SubPath,Route);
 end;

 List := '';

 //���������, ���� �� ���� ���� Excel ����
 if FindFirst(IncludeTrailingBackslash(Path)+ '*.*',faAnyFile, SR) = 0 then
 begin
   repeat
     if (ExtractFileExt(SR.Name) = '.xlsx') or (ExtractFileExt(SR.Name) = '.xls') or (ExtractFileExt(SR.Name) = '.xml')
     then List := List + '�' + SR.Name + '�';
   until FindNext(SR) <> 0;
 end;
end;

end.
