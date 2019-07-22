unit Unit2;

interface
uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ComObj;
procedure SortRoutes(XLSFile: string; Route: Integer);
procedure SortInDir(Path: string; Route: Integer);
procedure RemoveEmptyDirs(Path : String);

implementation

procedure RemoveEmptyDirs(Path : String);
var SR : TSearchRec;
  List,SubPath: string;
  op,cl : Integer;
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
  RemoveEmptyDirs(SubPath);
  try RemoveDir(Path) except end;
 end;

end;

procedure SortRoutes(XLSFile: string; Route: Integer);
var
  ExlApp, Sheet: OLEVariant;
  CountCol,k:integer;
  i,j,r,c,CountRow : LongInt;
  ThereIs,HaveRoute,ByTime: Boolean;
  cell: string;
  f: TextFile;
begin
  try ExlApp := CreateOleObject('Excel.Application'); //������� ������ Excel
  ExlApp.Visible := false; //������ ���� Excel ���������
  ExlApp.DisplayAlerts := false;  //�� ����������� ���������� �����
  ExlApp.Workbooks.Open(XLSFile); //��������� ���� XLSFile
  //������� ������ Sheet(��������) � ��������� ����� ����� (1)
  //� �����, � �������� ����� ������������ ������
  Sheet := ExlApp.Workbooks[ExtractFileName(XLSFile)].WorkSheets[1];
  //Sheet.Cells.SpecialCells(xlCellTypeLastCell, EmptyParam).Activate; //���������� ��������� ������ �� �����
    r := Sheet.Cells.SpecialCells(11, EmptyParam).Row;//ExlApp.ActiveCell.Row; // ���������� ����� ��������� ������
    c := Sheet.Cells.SpecialCells(11, EmptyParam).Column;// ExlApp.ActiveCell.Column; // ���������� ����� ���������� �������

  //���� ������� "� ��������"
  i := 1; j := 1; CountCol := 0; CountRow := 0;
  while (i <= r) and (CountCol = 0) do
  begin
    if Pos('� ��������',LowerCase(sheet.cells[i,j])) <> 0 then
    begin CountCol := j; CountRow := i;
     try cell := Sheet.Cells[i+1,j-1]; except cell := ''; end;
     if (Pos(',',cell) <> 0) or (Pos('-',cell) <> 0) or (Pos(':',cell) <> 0) then Inc(i) else i := i + 2;
    end else Inc(j);
    if j > c then begin j := 1; Inc(i); end;
  end;
  //���� ������� � ����� ������ ����, �� ���� ������ �� �������
  if CountCol = 0 then begin
    i := 1; j := 0;
    while (i <= r) and (CountCol = 0) do
    begin //showmessage('test '+inttostr(i));
      inc(j);
      try cell := Sheet.Cells[i,j]; except cell := ''; end;
          //if (i = 20) and (j = 2) then ShowMessage(cell);
      k := Pos(':',cell); if k = 0 then k := Pos('-',cell); if k = 0 then k := Pos(',',cell);
      if k > 1 then if (cell[k-1] in ['0'..'9']) and (cell[k+1] in ['0'..'9']) then
      begin
        try cell := Sheet.Cells[i,j+1]; except cell := ''; end;
        if cell <> '' then try k := StrToInt(cell); CountRow := i; CountCol := j+1; except end;
      end;
      if j > c then begin j := 1; inc(i); end;
    end;
  end;

  while i <= r do
  begin
    try cell := Sheet.Cells[i,countCol]; except cell := ''; end;
    if CountRow = 0 then
    begin
     if Pos('� ��������',LowerCase(sheet.cells[i,CountCol])) <> 0 then
     begin CountRow := i; i := i + 1; end
    end
    else begin
         if cell = '' then  // ���������, ���� �� �� 2 �� 9 �������, ���� �����-�� ������
         begin ThereIs := False; for k := 2 to 9 do begin
            try cell := Sheet.Cells[i,k]; except cell := ''; end;
            if cell <> '' then ThereIs := True;
           end;
           if not(ThereIs) then
           begin
            CountRow := 0; j := CountCol; CountCol := 0;
            while (i <= r) and (CountCol = 0) do
              begin
                inc(j);
                if j > 1 then try cell := Sheet.Cells[i,j]; except cell := ''; end else cell := '';
                k := Pos(':',cell); if k = 0 then k := Pos('-',cell); if k = 0 then k := Pos(',',cell);
                if k > 1 then if (cell[k-1] in ['0'..'9']) and (cell[k+1] in ['0'..'9']) then
                begin
                   try cell := Sheet.Cells[i,j+1]; except cell := ''; end;
                  if cell <> '' then try k := StrToInt(cell); CountRow := i; CountCol := j+1; Dec(i); except end;
                end;
                if j > c then begin j := 1; inc(i); end;
              end;
            end else ExlApp.Rows[i].delete;  //���� ����, �� �������
           end else
           begin if cell <> IntToStr(Route) then begin ExlApp.Rows[i].delete; Dec(i); end
           else HaveRoute := True; end;
         end;
    Inc(i); //showmessage(cell);
  end;


{  if Pos('� ��������',LowerCase(sheet.cells[21,3])) <> 0 then ShowMessage('����')
  else ShowMessage('����');}
  //ExlApp.Rows[21].delete;
  Sheet.SaveAs(XLSFile);// ��������� ���������

 ExlApp.Quit; //��������� ���������� Excel
 //������� ���������� ������
 ExlApp := Unassigned;
 Sheet := Unassigned;
 if not (HaveRoute) then begin Sleep(50); DeleteFile(XLSFile); end;
 except Assign(f,'LogErrors.txt'); Try Append(f); except Rewrite(f); Close(f); Append(f); end; Writeln(f,XLSFile+#13#10); Close(f); end;
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
     then begin List := List + '�' + ExtractFileName(SR.Name) + '�'; {ShowMessage(list);} end;
   until FindNext(SR) <> 0;
 end;
 //�������� Excel �����
   //showmessage(list);
 while Pos('�',List) <> 0 do
 begin
  op := Pos('�',List); List[op] := '~';
  cl := Pos('�',List); List[cl] := '~';
  SubPath := Path+'\'+Copy(List,op+1,cl-op-1);
  //ShowMessage(SubPath);
  SortRoutes(SubPath,Route);
 end;

 //������� ����� ���� � ��� ������ ���
 try RemoveDir(Path) except end;

end;

end.
