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

//Структура данных товара
//ИД товара
//Название товара
//цена товара за 1 штуку
//количество товара
type tovar = record
        id: Integer;
        nazvanieTovara: string;
        cenaTovara: string;
        kolichestvoTovara: string;
      end;

var
  Form1: TForm1;
  //PostfixCena : String;

  //Основные переменные
  papka : string; //Папка в которой находится информация об товарах
  tovari: array[1..10000000] of tovar; //Массив товаров
  kolvoTovarov: Integer = 0;   //Количетсво товаров
  PoslednijID: Integer = 0; //ID последнего загруженного товара

  //tovariNeVnalichii: array[1..10000000] of tovar;
  //kolvoNeVnalichii: Integer = 0;
  //poslednijRyadVnalichii,poslednijStolbecVnalichii: integer;
  //poslednijRyadNeVnalichii,poslednijStolbecNeVnalichii: integer;

implementation

uses unit2,Unit3;

{$R *.dfm}

//Функция Добавление товаров из файлов в таблицу
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
  //Проверка главной папки
  ProveritPapky(vPapke);
  //Просматриваем файлы и подпапки в главной папке
  if FindFirst(ExtractFilePath(vPapke+'\')+'*',faDirectory,sr)=0 then
  repeat
  //Продолжаем работу только если путь будет являться папкой
  if sr.Attr=16 then if SR.Name<>'..' then if SR.Name<>'.'
  then begin
    //ShowMessage(SR.Name);

    //Пробуем перевести название папки из строки в числовую переменную tmpInt
    //так как названия папки является ID товара
    val(SR.Name, tmpInt, codeInt);

    //Если код = 0, то название папки является число и мы продолжаем
    if codeInt = 0 then
    begin
      //Прописываем в переменной путь главная_папка\ID_товара\
      put := vPapke+'\'+SR.Name+'\';
      //Если там есть файл item(в котором название товара), то продолжаем работу
      if FileExists(put+'item') then
      begin
        //Говорим что у нас появился новый товар
        kolvoTovarov := kolvoTovarov+1;
        //Товар.id = id
        tovari[kolvoTovarov].id := tmpInt;
        //Открываем и читаем файл item
        AssignFile(f,put+'item');
        Reset(f);
        Readln(f,info);
        //ShowMessage(info);
        CloseFile(f);
        //Заносим название товара из файла
        tovari[kolvoTovarov].nazvanieTovara := info;
        //Если есть файл с ценной, то открываем и заносим цену в переменную
        //    Товар.цена_товара
        //Иначе создаём такой файл и говорим что цена 0, так как она неизвестна
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
        //Если есть файл с количеством товара, то открываем и заносим значение в переменную
        //    Товар.количество_товара
        //Иначе создаём такой файл и говорим что товара 0 штук, так как неизвестно количество
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
  //Проверяем подпапки, пока в главной папки не будут проверены все файлы и подпапки
  until Findnext(sr)<>0;
  FindClose(sr);

  //Добавляем такое количество строк в таблицу, сколько товаров программа нашла
  strngCanctovarVnalichii.RowCount := kolvoTovarov+1;

  //Делаем сортировку товаров по их ID
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

  PoslednijID :=tovari[kolvoTovarov].id;  //Добавляем ID последнего товара, для дальнейшего обновления списка товаров

  //Добавляем найденные товары из файлов в таблицу
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

//Функция проверки главной папки
procedure TForm1.ProveritPapky(ppapka: String);
begin
    //Если её нет, то создаём
    if not DirectoryExists(ppapka) then
    begin
      CreateDir(ppapka)
    end;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  //Выравниваем форму по центру экрана
  if self.Width > Screen.Width then begin
    self.Left := 0;  self.Width := Screen.Width;
  end else self.Left := (Screen.Width-self.Width) div 2;
  if self.Height > Screen.Height then begin
    self.Top := 0;  self.Height := Screen.Height;
  end else Self.Top := (Screen.Height-self.Height) div 2;

  //strngCanctovarVnalichii.RowCount := 10;
  Application.Title := 'Канцтовары';  //Меняем название приложения


  papka := 'Товары';  //Задаём папку с товарами
  ProchitatIdobavitTovari(papka);  //Читаем товары из файлов в папке
  //PostfixCena := 'р.';
  //Задаём надписи в первой строке в таблице
  strngCanctovarVnalichii.Cells[0,0] := 'ID_Товара';
  strngCanctovarVnalichii.Cells[1,0] := 'Товар';
  strngCanctovarVnalichii.Cells[2,0] := 'Цена за шт.';
  strngCanctovarVnalichii.Cells[3,0] := 'Количество';
  strngCanctovarVnalichii.Cells[4,0] := 'Цена*кол-во';

  //Меняем ширину второго столбца
  strngCanctovarVnalichii.ColWidths[1] := 250;

  //strngCanctovarVnalichii.de

{  strngCanctovarVnalichii.Cells[0,1] := '1';
  strngCanctovarVnalichii.Cells[1,1] := 'Набор синих ручек 10 шт.';

  strngCanctovarNetVnalichii.Cells[0,0] := 'ID_Товара';
  strngCanctovarNetVnalichii.Cells[1,0] := 'Товар';
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
  //Запрещаем делать длину формы больше 705
  if self.Width > 705 then self.Width := 705;
  //Делаем гибкую таблицу, меняя её высоту при изменении размера формы
  strngCanctovarVnalichii.Height := Self.Height-strngCanctovarVnalichii.Top*2-58;//-40;
  //strngCanctovarNetVnalichii.Height := Self.Height-strngCanctovarVnalichii.Top*2-83;//-65;//120;
end;

//Функция убирает синее выделение столбца
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

//Кнопка редактировать товар
procedure TForm1.N3Click(Sender: TObject);
begin
  Form2.Update(true);
  //Меняем позицию второй формы и отображаем её
  Form2.Left := Self.Left+Self.Width div 2-form2.Width div 2;
  Form2.Top := Self.Top+Self.Height div 2-form2.Height div 2;
  Form2.Show();
end;

//Кнопка добавить товар
procedure TForm1.N2Click(Sender: TObject);
begin
  Form2.Update(false);
  //Меняем позицию второй формы и отображаем её
  Form2.Left := Self.Left+Self.Width div 2-form2.Width div 2;
  Form2.Top := Self.Top+Self.Height div 2-form2.Height div 2;
  Form2.Show();
end;

procedure TForm1.N4Click(Sender: TObject);
begin
  //ExportToFile('test.csv',true);
end;

//Прокрутка таблицы при помощи колеса мыши вниз
procedure TForm1.strngCanctovarVnalichiiMouseWheelDown(Sender: TObject;
  Shift: TShiftState; MousePos: TPoint; var Handled: Boolean);
begin
  Handled := true;
  with (Sender as TStringGrid) do
    if TopRow <= (Sender as TStringGrid).RowCount-2 then
      TopRow := TopRow + 1;
end;

//Прокрутка таблицы при помощи колеса мыши в верх
procedure TForm1.strngCanctovarVnalichiiMouseWheelUp(Sender: TObject;
  Shift: TShiftState; MousePos: TPoint; var Handled: Boolean);
begin
  Handled := true;
  with (Sender as TStringGrid) do
    if TopRow > 1 then
      TopRow := TopRow - 1;
end;

//Кнопка заказ
procedure TForm1.N5Click(Sender: TObject);
begin
  //Меняем позицию третей формы и отображаем её
  Form3.Left := Self.Left+Self.Width div 2-form3.Width div 4;
  Form3.Top := Self.Top+Self.Height div 2-form3.Height div 2;
  Form3.Show;
end;

end.
