unit Unit3;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, Grids, ExtCtrls, StdCtrls;

type
  TForm3 = class(TForm)
    pnlZakaz: TPanel;
    strngCanctovariZakaz: TStringGrid;
    edtID: TEdit;
    lblID: TLabel;
    lblNadpis: TLabel;
    edtKolvo: TEdit;
    lblKolvo: TLabel;
    btnAdd: TButton;
    lblNadpis2: TLabel;
    lblID2: TLabel;
    edtID2: TEdit;
    btnDelete: TButton;
    pnlAdd: TPanel;
    pnlDel: TPanel;
    lblSum: TLabel;
    btnZakaz: TButton;
    procedure FormCreate(Sender: TObject);
    procedure strngCanctovariZakazExit(Sender: TObject);
    procedure strngCanctovariZakazMouseMove(Sender: TObject;
      Shift: TShiftState; X, Y: Integer);
    procedure strngCanctovariZakazMouseWheelDown(Sender: TObject;
      Shift: TShiftState; MousePos: TPoint; var Handled: Boolean);
    procedure strngCanctovariZakazMouseWheelUp(Sender: TObject;
      Shift: TShiftState; MousePos: TPoint; var Handled: Boolean);
    procedure pnlZakazResize(Sender: TObject);
    procedure edtIDKeyPress(Sender: TObject; var Key: Char);
    procedure btnAddClick(Sender: TObject);
    procedure btnDeleteClick(Sender: TObject);
    procedure btnZakazClick(Sender: TObject);
  private
    { Private declarations }
  public
    procedure NajtiSummu();
    { Public declarations }
  end;

var
  Form3: TForm3;

implementation

uses Unit1;

{$R *.dfm}

procedure TForm3.NajtiSummu();
var summa : Real;
    stroka : integer;
begin
  summa := 0;
  //Вычисляем сумму проходя по столбцам в таблице
  for stroka := 1 to strngCanctovariZakaz.RowCount do
  begin
    if Length(strngCanctovariZakaz.Cells[4,stroka])>0 then
    summa := summa + StrToFloat(strngCanctovariZakaz.Cells[4,stroka]);
  end;
  //Выводим сумму в label
  lblSum.Caption := 'Сумма: '+FloatToStr(summa);
  //Выводим сумму в подсказку при наведении мыши
  lblSum.Hint := FloatToStr(summa);
  //
end;

procedure TForm3.FormCreate(Sender: TObject);
begin

  //Делаем форму заказа поверх основной формы
  self.FormStyle := fsStayOnTop;

  //Задаём надписи в первой строке в таблице
  strngCanctovariZakaz.Cells[0,0] := 'ID_Товара';
  strngCanctovariZakaz.Cells[1,0] := 'Товар';
  strngCanctovariZakaz.Cells[2,0] := 'Цена за шт.';
  strngCanctovariZakaz.Cells[3,0] := 'Количество';
  strngCanctovariZakaz.Cells[4,0] := 'Цена*кол-во';

  //Меняем ширину второго столбца
  strngCanctovariZakaz.ColWidths[1] := 250;
end;

//Функция убирает синее выделение столбца
procedure TForm3.strngCanctovariZakazExit(Sender: TObject);
var
  hGridRect: TGridRect;
begin
  hGridRect.Top := -1;
  hGridRect.Left := 0;
  hGridRect.Right := 0;
  hGridRect.Bottom := -1;
  (Sender as TStringgrid).Selection := hGridRect;
end;

//Выводи надписи таблицы в подсказку
procedure TForm3.strngCanctovariZakazMouseMove(Sender: TObject;
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

//Прокрутка таблицы при помощи колеса мыши вниз
procedure TForm3.strngCanctovariZakazMouseWheelDown(Sender: TObject;
  Shift: TShiftState; MousePos: TPoint; var Handled: Boolean);
begin
  Handled := true;
  with (Sender as TStringGrid) do
    if TopRow <= (Sender as TStringGrid).RowCount-2 then
      TopRow := TopRow + 1;
end;

//Прокрутка таблицы при помощи колеса мыши в верх
procedure TForm3.strngCanctovariZakazMouseWheelUp(Sender: TObject;
  Shift: TShiftState; MousePos: TPoint; var Handled: Boolean);
begin
  Handled := true;
  with (Sender as TStringGrid) do
    if TopRow > 1 then
      TopRow := TopRow - 1;
end;

procedure TForm3.pnlZakazResize(Sender: TObject);
begin
  //Запрещаем делать длину формы больше 905
  if self.Width > 905 then self.Width := 905;
  //Делаем гибкую таблицу, меняя её высоту при изменении размера формы
  strngCanctovariZakaz.Height := Self.Height-strngCanctovariZakaz.Top*2-40;
end;

procedure TForm3.edtIDKeyPress(Sender: TObject; var Key: Char);
begin
  //Разрешить ввод только чисел
  if (not (Key in ['0'..'9'])) and (not (Key = #8)) then Key := #0;
end;

//Кнопка добавить/изменить
procedure TForm3.btnAddClick(Sender: TObject);
var stroka,stroka2: integer;
begin
  //Если пользователь не ввёл ID или количество, то вывести сообщение
  if Length(edtID.Text) < 1 then begin ShowMessage('Введите ID товара!'); Exit; end;
  if (Length(edtKolvo.Text) < 1) or (edtKolvo.Text = '0') then
    begin ShowMessage('Введите количество товара!'); Exit; end;

  //Иначе ищем товар в главной таблице
  for stroka := 1 to Form1.strngCanctovarVnalichii.RowCount do
  begin
    if edtID.Text = Form1.strngCanctovarVnalichii.cells[0,stroka] then
    begin
      //Если товар найден в главной таблице, но количество меньше заданного,
      // то вывести сообщение и закончить функцию
      if StrToInt(Form1.strngCanctovarVnalichii.cells[3,stroka]) < StrToInt(edtKolvo.Text)
      then begin
        ShowMessage('Не удалось добавить товар в заказ!'
          +#13#10+'В наличии количество товара - '+Form1.strngCanctovarVnalichii.cells[3,stroka]);
        Exit;
      end;
      //Перед добавляем в таблицу заказа товара, проверяем, не было его раньше
      //  Если он уже в таблице заказов, то обновляем таблицу
      for stroka2 := 1 to strngCanctovariZakaz.RowCount do begin
        if strngCanctovariZakaz.Cells[0,stroka2] = edtID.Text then
        begin
          strngCanctovariZakaz.Cells[3,stroka2] := edtKolvo.Text;
          strngCanctovariZakaz.Cells[4,strngCanctovariZakaz.RowCount-1] := FloatToStr(StrToFloat(strngCanctovariZakaz.Cells[2,strngCanctovariZakaz.RowCount-1])*strtoint(strngCanctovariZakaz.Cells[3,strngCanctovariZakaz.RowCount-1]));
          NajtiSummu();
          Exit;          
        end;
      end;
      //Иначе если такого товара в заказе нет, то мы добавляем строку и инфу о товаре
      if Length(strngCanctovariZakaz.Cells[0,strngCanctovariZakaz.RowCount-1]) > 0 then
        strngCanctovariZakaz.RowCount := strngCanctovariZakaz.RowCount + 1;
      strngCanctovariZakaz.Cells[1,strngCanctovariZakaz.RowCount-1] := Form1.strngCanctovarVnalichii.cells[1,stroka];
      strngCanctovariZakaz.Cells[2,strngCanctovariZakaz.RowCount-1] := Form1.strngCanctovarVnalichii.cells[2,stroka];

      strngCanctovariZakaz.Cells[0,strngCanctovariZakaz.RowCount-1] := edtID.Text;
      strngCanctovariZakaz.Cells[3,strngCanctovariZakaz.RowCount-1] := edtKolvo.Text;
      strngCanctovariZakaz.Cells[4,strngCanctovariZakaz.RowCount-1] := FloatToStr(StrToFloat(strngCanctovariZakaz.Cells[2,strngCanctovariZakaz.RowCount-1])*strtoint(strngCanctovariZakaz.Cells[3,strngCanctovariZakaz.RowCount-1]));
      NajtiSummu();
      Exit;
    end;
  end;
  //Если пользователь ввёл несуществующий ID, то он получит сообщение
  ShowMessage('Товар с ID('+edtID.Text+') не найден!');
end;

//Кнопка удалить
procedure TForm3.btnDeleteClick(Sender: TObject);
var Stroka,stroka2: integer;
begin
  //Если пользователь не ввёл ID, то вывести сообщение
  if Length(edtID2.Text) < 1 then begin ShowMessage('Введите ID товара!'); Exit; end;
  //Иначе ищем ID в таблице
  for Stroka := 1 to strngCanctovariZakaz.RowCount do
  begin
    if edtID2.Text = strngCanctovariZakaz.Cells[0,Stroka]
    then begin
        //Если нашли, то смещаем записи таблицы на одну строку
       for stroka2 := Stroka to strngCanctovariZakaz.RowCount-1 do
       begin
          strngCanctovariZakaz.Rows[stroka2] := strngCanctovariZakaz.Rows[stroka2+1];
       end;
       //Убираем одну строку
       if strngCanctovariZakaz.RowCount > 2 then
         strngCanctovariZakaz.RowCount := strngCanctovariZakaz.RowCount - 1;
       //Вычисляем сумму
       NajtiSummu();
       Exit;
    end;
  end;
  //Если пользователь ввёл несуществующий ID, то выводим сообщение
  ShowMessage('ID('+edtID2.Text+') не найден!');
end;

//Кнопка сделать заказ
procedure TForm3.btnZakazClick(Sender: TObject);
var papkaZ,put,put2,kolvo: string;
    f: TextFile;
    stroka,stolbec,i: integer;
begin
  //Если в таблице заказа нет товаров, то выводится сообщение
  if Length(strngCanctovariZakaz.Cells[0,1])<1 then
  begin
    ShowMessage('Чтобы сделать заказ, необходимо добавить хотя бы один товар!');
    Exit;
  end;

  //Создаём папку заказы
  papkaZ := 'Заказы';
  if not DirectoryExists(papkaZ) then
    CreateDir(papkaZ);
  //Делаем путь к файлу Заказы/Дата_Время.txt
  put := papkaZ +'\'+DateTimeToStr(Now())+'.txt';
  //Меняем символы в строке с : на _
  for i := 1 to Length(put) do
    if put[i] = ':' then put[i] := '_';
  put2 := put;
  //Открываем файл для чтения
  AssignFile(f,put);
  Rewrite(f);
  Writeln(f,DateTimeToStr(Now())); //Записываем время
  Writeln(f,lblSum.Caption); //Записываем сумму
  Writeln(f); //Делаем новую строку
  //Проходим по таблице и записываем каждую клетку
  for stroka := 0 to strngCanctovariZakaz.RowCount-1 do
  begin
    for stolbec := 0 to strngCanctovariZakaz.ColCount-1 do
    begin
      if stolbec <> strngCanctovariZakaz.ColCount-1 then
        write(f,strngCanctovariZakaz.Cells[stolbec,stroka]+';')
      else write(f,strngCanctovariZakaz.Cells[stolbec,stroka])
    end;
    if stroka <> strngCanctovariZakaz.RowCount-1 then
      Writeln(f)
  end;
  CloseFile(f); //Закрываем файл

  //Вычитаем количество товара минус кол-во товара которое было в заказе
  for stroka := 1 to strngCanctovariZakaz.RowCount-1 do
  begin
    put := papka+'\'+strngCanctovariZakaz.Cells[0,stroka]+'\';
    AssignFile(f,put+'amount');
    Reset(f);
    Read(f,kolvo);
    CloseFile(f);
    Rewrite(f);
    Write(f,inttostr(StrToInt(kolvo)-StrToInt(strngCanctovariZakaz.Cells[3,stroka])));
    CloseFile(f);
  end;

  //Обновляем таблицу
  Form1.ProchitatIdobavitTovari(papka);
  //Сообщаем пользователю куда сохранён заказ
  ShowMessage('Заказ сохранён в файле ...\'+put2);

  //Очищаем таблицу заказа
  strngCanctovariZakaz.RowCount := 2;
  strngCanctovariZakaz.Rows[1].Clear;
end;

end.
