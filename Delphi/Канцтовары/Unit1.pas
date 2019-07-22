unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, Grids, StdCtrls, ExtCtrls, Menus;

type
  TForm1 = class(TForm)
    strngCanctovarVnalichii: TStringGrid;
    lblNadpis: TLabel;
    pnlNetVNalichii: TPanel;
    strngCanctovarNetVnalichii: TStringGrid;
    pnlVnalichii: TPanel;
    menu: TMainMenu;
    N1: TMenuItem;
    N2: TMenuItem;
    N3: TMenuItem;
    N5: TMenuItem;
    procedure FormCreate(Sender: TObject);
    procedure strngCanctovarVnalichiiDrawCell(Sender: TObject; ACol,
      ARow: Integer; Rect: TRect; State: TGridDrawState);
    procedure FormResize(Sender: TObject);
    procedure strngCanctovarNetVnalichiiExit(Sender: TObject);
    procedure strngCanctovarNetVnalichiiMouseMove(Sender: TObject;
      Shift: TShiftState; X, Y: Integer);
    procedure strngCanctovarVnalichiiSelectCell(Sender: TObject; ACol,
      ARow: Integer; var CanSelect: Boolean);
    procedure strngCanctovarVnalichiiKeyPress(Sender: TObject;
      var Key: Char);
    procedure strngCanctovarVnalichiiMouseMove(Sender: TObject;
      Shift: TShiftState; X, Y: Integer);
    procedure strngCanctovarVnalichiiExit(Sender: TObject);
    procedure N3Click(Sender: TObject);
    procedure N2Click(Sender: TObject);
    procedure N4Click(Sender: TObject);
    procedure strngCanctovarVnalichiiMouseWheelDown(Sender: TObject;
      Shift: TShiftState; MousePos: TPoint; var Handled: Boolean);
    procedure strngCanctovarVnalichiiMouseWheelUp(Sender: TObject;
      Shift: TShiftState; MousePos: TPoint; var Handled: Boolean);
    procedure N5Click(Sender: TObject);
  private
    Col : integer;
    Row : integer;
    { Private declarations }
  public
    //procedure ExportToFile(path: string; Excl: Boolean);
    procedure ProchitatIdobavitTovari(vPapke: String);
    procedure ProveritPapky(ppapka: String);
    { Public declarations }
  end;

//��������� ������ ������
//�� ������
//�������� ������
//���� ������ �� 1 �����
//���������� ������
type tovar = record
        id: Integer;
        nazvanieTovara: string;
        cenaTovara: string;
        kolichestvoTovara: string;
      end;

var
  Form1: TForm1;
  //PostfixCena : String;

  //�������� ����������
  papka : string; //����� � ������� ��������� ���������� �� �������
  tovari: array[1..10000000] of tovar; //������ �������
  kolvoTovarov: Integer = 0;   //���������� �������
  PoslednijID: Integer = 0; //ID ���������� ������������ ������

  //tovariNeVnalichii: array[1..10000000] of tovar;
  //kolvoNeVnalichii: Integer = 0;
  //poslednijRyadVnalichii,poslednijStolbecVnalichii: integer;
  //poslednijRyadNeVnalichii,poslednijStolbecNeVnalichii: integer;

implementation

uses unit2,Unit3;

{$R *.dfm}

//������� ���������� ������� �� ������ � �������
procedure Tform1.ProchitatIdobavitTovari(vPapke: String);
var sr:TSearchRec;
  f: TextFile;
  tmpInt,codeInt: Integer;
  put : string;
  info : string;
  tovar : integer;
  sort1,sort2: integer;
begin
  kolvoTovarov := 0;
  strngCanctovarVnalichii.RowCount := 2;
  strngCanctovarVnalichii.Rows[1].Clear;
  //�������� ������� �����
  ProveritPapky(vPapke);
  //������������� ����� � �������� � ������� �����
  if FindFirst(ExtractFilePath(vPapke+'\')+'*',faDirectory,sr)=0 then
  repeat
  //���������� ������ ������ ���� ���� ����� �������� ������
  if sr.Attr=16 then if SR.Name<>'..' then if SR.Name<>'.'
  then begin
    //ShowMessage(SR.Name);

    //������� ��������� �������� ����� �� ������ � �������� ���������� tmpInt
    //��� ��� �������� ����� �������� ID ������
    val(SR.Name, tmpInt, codeInt);

    //���� ��� = 0, �� �������� ����� �������� ����� � �� ����������
    if codeInt = 0 then
    begin
      //����������� � ���������� ���� �������_�����\ID_������\
      put := vPapke+'\'+SR.Name+'\';
      //���� ��� ���� ���� item(� ������� �������� ������), �� ���������� ������
      if FileExists(put+'item') then
      begin
        //������� ��� � ��� �������� ����� �����
        kolvoTovarov := kolvoTovarov+1;
        //�����.id = id
        tovari[kolvoTovarov].id := tmpInt;
        //��������� � ������ ���� item
        AssignFile(f,put+'item');
        Reset(f);
        Readln(f,info);
        //ShowMessage(info);
        CloseFile(f);
        //������� �������� ������ �� �����
        tovari[kolvoTovarov].nazvanieTovara := info;
        //���� ���� ���� � ������, �� ��������� � ������� ���� � ����������
        //    �����.����_������
        //����� ������ ����� ���� � ������� ��� ���� 0, ��� ��� ��� ����������
        if FileExists(put+'price') then
        begin
          AssignFile(f,put+'price');
          Reset(f);
          Readln(f,info);
          CloseFile(f);
          tovari[kolvoTovarov].cenaTovara := info;
        end else begin
          tovari[kolvoTovarov].cenaTovara := '0';
          AssignFile(f,put+'price');
          Rewrite(f);
          Write(f,'0');
          CloseFile(f);
        end;
        //���� ���� ���� � ����������� ������, �� ��������� � ������� �������� � ����������
        //    �����.����������_������
        //����� ������ ����� ���� � ������� ��� ������ 0 ����, ��� ��� ���������� ����������
        if FileExists(put+'amount') then
        begin
          AssignFile(f,put+'amount');
          Reset(f);
          Readln(f,info);
          CloseFile(f);
          tovari[kolvoTovarov].kolichestvoTovara := info;
        end else begin
          tovari[kolvoTovarov].kolichestvoTovara := '0';
          AssignFile(f,put+'amount');
          Rewrite(f);
          Write(f,'0');
          CloseFile(f);
        end;
      end;
    end;
  end;
  //��������� ��������, ���� � ������� ����� �� ����� ��������� ��� ����� � ��������
  until Findnext(sr)<>0;
  FindClose(sr);

  //��������� ����� ���������� ����� � �������, ������� ������� ��������� �����
  strngCanctovarVnalichii.RowCount := kolvoTovarov+1;

  //������ ���������� ������� �� �� ID
  for sort1 := kolvoTovarov downto 2 do
    for sort2 := 1 to sort1-1 do
    begin
      if tovari[sort2].id > tovari[sort1].id then
      begin
        tmpInt := tovari[sort2].id;
        tovari[sort2].id := tovari[sort1].id;
        tovari[sort1].id := tmpInt;

        info := tovari[sort2].nazvanieTovara;
        tovari[sort2].nazvanieTovara := tovari[sort1].nazvanieTovara;
        tovari[sort1].nazvanieTovara := info;

        info := tovari[sort2].cenaTovara;
        tovari[sort2].cenaTovara := tovari[sort1].cenaTovara;
        tovari[sort1].cenaTovara := info;

        info := tovari[sort2].kolichestvoTovara;
        tovari[sort2].kolichestvoTovara := tovari[sort1].kolichestvoTovara;
        tovari[sort1].kolichestvoTovara := info;
      end;
    end;

  PoslednijID :=tovari[kolvoTovarov].id;  //��������� ID ���������� ������, ��� ����������� ���������� ������ �������

  //��������� ��������� ������ �� ������ � �������
  for tovar := 1 to kolvoTovarov do
  begin
     strngCanctovarVnalichii.Cells[0,tovar] := IntToStr(tovari[tovar].id);
     strngCanctovarVnalichii.Cells[1,tovar] := tovari[tovar].nazvanieTovara;
     strngCanctovarVnalichii.Cells[2,tovar] := tovari[tovar].cenaTovara;
     strngCanctovarVnalichii.Cells[3,tovar] := tovari[tovar].kolichestvoTovara;
     strngCanctovarVnalichii.Cells[4,tovar] := FloatToStr(StrToFloat(strngCanctovarVnalichii.Cells[2,tovar])*StrToInt(strngCanctovarVnalichii.Cells[3,tovar]));
  end;
end;

{procedure Tform1.ExportToFile(path: string; Excl: Boolean);
var f : TextFile;
  Stroka,Stolbec : integer;
begin
    AssignFile(f,path);
    Rewrite(f);
    for Stroka := 0 to strngCanctovarVnalichii.RowCount-1 do
    begin
      for Stolbec := 0 to strngCanctovarVnalichii.ColCount-1 do
      begin
        if Stolbec <> strngCanctovarVnalichii.ColCount-1 then Write(f,strngCanctovarVnalichii.cells[Stolbec,Stroka]+';')
        else Write(f,strngCanctovarVnalichii.cells[Stolbec,Stroka])
      end;
      if Stroka <> strngCanctovarVnalichii.RowCount-1 then writeln(f);
    end;
    CloseFile(f);
end; }

//������� �������� ������� �����
procedure TForm1.ProveritPapky(ppapka: String);
begin
    //���� � ���, �� ������
    if not DirectoryExists(ppapka) then
    begin
      CreateDir(ppapka)
    end;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  //����������� ����� �� ������ ������
  if self.Width > Screen.Width then begin
    self.Left := 0;  self.Width := Screen.Width;
  end else self.Left := (Screen.Width-self.Width) div 2;
  if self.Height > Screen.Height then begin
    self.Top := 0;  self.Height := Screen.Height;
  end else Self.Top := (Screen.Height-self.Height) div 2;

  //strngCanctovarVnalichii.RowCount := 10;
  Application.Title := '����������';  //������ �������� ����������


  papka := '������';  //����� ����� � ��������
  ProchitatIdobavitTovari(papka);  //������ ������ �� ������ � �����
  //PostfixCena := '�.';
  //����� ������� � ������ ������ � �������
  strngCanctovarVnalichii.Cells[0,0] := 'ID_������';
  strngCanctovarVnalichii.Cells[1,0] := '�����';
  strngCanctovarVnalichii.Cells[2,0] := '���� �� ��.';
  strngCanctovarVnalichii.Cells[3,0] := '����������';
  strngCanctovarVnalichii.Cells[4,0] := '����*���-��';

  //������ ������ ������� �������
  strngCanctovarVnalichii.ColWidths[1] := 250;

  //strngCanctovarVnalichii.de

{  strngCanctovarVnalichii.Cells[0,1] := '1';
  strngCanctovarVnalichii.Cells[1,1] := '����� ����� ����� 10 ��.';

  strngCanctovarNetVnalichii.Cells[0,0] := 'ID_������';
  strngCanctovarNetVnalichii.Cells[1,0] := '�����';
  strngCanctovarNetVnalichii.ColWidths[1] := 150;}

{  poslednijRyadNeVnalichii := 0;
  poslednijStolbecNeVnalichii := 0;
  poslednijRyadVnalichii := 0;
  poslednijStolbecVnalichii := 0; }
end;

procedure TForm1.strngCanctovarVnalichiiDrawCell(Sender: TObject; ACol,
  ARow: Integer; Rect: TRect; State: TGridDrawState);
begin
{ with Sender as TStringGrid, Canvas do
 begin
    if (state = [gdSelected]) then
    begin
      fillrect(rect);
      SetTextAlign(Handle, TA_LEFT);
      TextOut(Rect.left+2, Rect.Top+2, Cells[aCol, aRow]);
    end;
    if (ARow = 0) or (ACol = 0) then
    begin
      fillrect(rect);
      SetTextAlign(Handle, TA_CENTER);
      TextOut(round((Rect.right+Rect.left)/2), Rect.Top+2, Cells[aCol, aRow]);
    end else begin
      fillrect(rect);
      SetTextAlign(Handle, TA_LEFT);
      TextOut(Rect.left+2, Rect.Top+2, Cells[aCol, aRow]);
    end;
  end; }
end;

procedure TForm1.FormResize(Sender: TObject);
begin
  //��������� ������ ����� ����� ������ 705
  if self.Width > 705 then self.Width := 705;
  //������ ������ �������, ����� � ������ ��� ��������� ������� �����
  strngCanctovarVnalichii.Height := Self.Height-strngCanctovarVnalichii.Top*2-58;//-40;
  //strngCanctovarNetVnalichii.Height := Self.Height-strngCanctovarVnalichii.Top*2-83;//-65;//120;
end;

//������� ������� ����� ��������� �������
procedure TForm1.strngCanctovarNetVnalichiiExit(Sender: TObject);
var
  hGridRect: TGridRect;
begin
  //poslednijRyadNeVnalichii := (Sender as TStringGrid).Row;
  //poslednijStolbecNeVnalichii := (Sender as TStringGrid).Col;
  //poslednijRyad :=
  hGridRect.Top := -1;
  hGridRect.Left := 0;
  hGridRect.Right := 0;
  hGridRect.Bottom := -1;
  (Sender as TStringgrid).Selection := hGridRect;
end;

procedure TForm1.strngCanctovarNetVnalichiiMouseMove(Sender: TObject;
  Shift: TShiftState; X, Y: Integer);
var
  r : integer;
  c : integer;
  hGridRect: TGridRect;
begin
  //(Sender as TStringGrid).Canvas.Brush.Color:=clRed;

  {if poslednijRyadNeVnalichii <> -1 then
  begin
      hGridRect.Top := 0;
     hGridRect.Left := 1;
     hGridRect.Right := 1;
     hGridRect.Bottom := 0;
    (Sender as TStringgrid).Selection := hGridRect;
    with (Sender as TStringGrid) do
    begin
      Row :=poslednijRyadNeVnalichii;
      Col := poslednijStolbecNeVnalichii;
    end;
    poslednijRyadNeVnalichii := -1;
  end;}
  //(Sender as TStringGrid).SetFocus();
  try begin
    (Sender as TStringGrid).MouseToCell(x,y,c,r);
    //ShowMessage(IntToStr(c)+':'+IntToStr(r));
    if (c<>-1) then
    with (Sender as TStringGrid) do begin
     {if (c>0) and (r>0) then
     begin
      (Sender as TStringGrid).Row := r;
      (Sender as TStringGrid).Col := c;
     end;}
     Hint:=(Sender as TStringGrid).Cells[c,r];
    end;
    Application.ActivateHint(Mouse.CursorPos);
  end except begin end;
  end;
end;

procedure TForm1.strngCanctovarVnalichiiSelectCell(Sender: TObject; ACol,
  ARow: Integer; var CanSelect: Boolean);
begin
  {if (ACol>=4) then
    (Sender as TStringGrid).Options := (Sender as TStringGrid).Options-[goEditing]
  else
    (Sender as TStringGrid).Options := (Sender as TStringGrid).Options+[goEditing];}
end;

procedure TForm1.strngCanctovarVnalichiiKeyPress(Sender: TObject;
  var Key: Char);
begin
  Key := #0;
end;

procedure TForm1.strngCanctovarVnalichiiMouseMove(Sender: TObject;
  Shift: TShiftState; X, Y: Integer);
var
  r : integer;
  c : integer;
  hGridRect: TGridRect;
begin
    //(Sender as TStringGrid).SetFocus();
    try begin
      (Sender as TStringGrid).MouseToCell(x,y,c,r);
      //ShowMessage(IntToStr(c)+':'+IntToStr(r));
      if (c<>-1) then
      with (Sender as TStringGrid) do begin
       {if (c>0) and (r>0) then
       begin
        (Sender as TStringGrid).Row := r;
        (Sender as TStringGrid).Col := c;
       end;}
       Hint:=(Sender as TStringGrid).Cells[c,r];
      end;
      Application.ActivateHint(Mouse.CursorPos);
    end except begin end;
    end;
end;

procedure TForm1.strngCanctovarVnalichiiExit(Sender: TObject);
var
  hGridRect: TGridRect;
begin
  //poslednijRyadNeVnalichii := (Sender as TStringGrid).Row;
  //poslednijStolbecNeVnalichii := (Sender as TStringGrid).Col;
  //poslednijRyad :=
  hGridRect.Top := -1;
  hGridRect.Left := 0;
  hGridRect.Right := 0;
  hGridRect.Bottom := -1;
  (Sender as TStringgrid).Selection := hGridRect;
end;

//������ ������������� �����
procedure TForm1.N3Click(Sender: TObject);
begin
  Form2.Update(true);
  //������ ������� ������ ����� � ���������� �
  Form2.Left := Self.Left+Self.Width div 2-form2.Width div 2;
  Form2.Top := Self.Top+Self.Height div 2-form2.Height div 2;
  Form2.Show();
end;

//������ �������� �����
procedure TForm1.N2Click(Sender: TObject);
begin
  Form2.Update(false);
  //������ ������� ������ ����� � ���������� �
  Form2.Left := Self.Left+Self.Width div 2-form2.Width div 2;
  Form2.Top := Self.Top+Self.Height div 2-form2.Height div 2;
  Form2.Show();
end;

procedure TForm1.N4Click(Sender: TObject);
begin
  //ExportToFile('test.csv',true);
end;

//��������� ������� ��� ������ ������ ���� ����
procedure TForm1.strngCanctovarVnalichiiMouseWheelDown(Sender: TObject;
  Shift: TShiftState; MousePos: TPoint; var Handled: Boolean);
begin
  Handled := true;
  with (Sender as TStringGrid) do
    if TopRow <= (Sender as TStringGrid).RowCount-2 then
      TopRow := TopRow + 1;
end;

//��������� ������� ��� ������ ������ ���� � ����
procedure TForm1.strngCanctovarVnalichiiMouseWheelUp(Sender: TObject;
  Shift: TShiftState; MousePos: TPoint; var Handled: Boolean);
begin
  Handled := true;
  with (Sender as TStringGrid) do
    if TopRow > 1 then
      TopRow := TopRow - 1;
end;

//������ �����
procedure TForm1.N5Click(Sender: TObject);
begin
  //������ ������� ������ ����� � ���������� �
  Form3.Left := Self.Left+Self.Width div 2-form3.Width div 4;
  Form3.Top := Self.Top+Self.Height div 2-form3.Height div 2;
  Form3.Show;
end;

end.
