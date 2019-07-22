unit Trainer;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls;

type
  TForm1 = class(TForm)
    edtText: TEdit;
    lblSymbols: TLabel;
    lblErrors: TLabel;
    lblSpeed: TLabel;
    btnNewText: TButton;
    tmrCheckSpeed: TTimer;
    procedure FormCreate(Sender: TObject);
    procedure btnNewTextClick(Sender: TObject);
    procedure edtTextChange(Sender: TObject);
    procedure FormKeyPress(Sender: TObject; var Key: Char);
    procedure tmrCheckSpeedTimer(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

const N = 4;  // N - количество Текстов
 texts : array [0..N-1] of string =( //Добавляем массив с текстами
'How to Declare and Initialize Constant Arrays in Delphi',

'Если вам нужно получить загранпаспорт быстро, или вы хотите узнать, сколько стоит загранпаспорт, вы можете связаться с нашими представителями, которые озвучат цену,'
+'соответствующую срокам оформления документа, которые вас устроят. Как правило, можно получить загранпаспорт быстро - срочное оформление загранпаспорта осуществляется'
+' нами от трех недель. При этом, присутствие граждан необходимо только при подаче заявления и заполнения анкеты, а также тогда, когда можно забрать готовые загранпаспорта.',

'Прежде всего откроем тайну, которую мастер не пожелал открыть Иванушке. Возлюбленную его звали Маргаритою Николаевной. Все, что мастер говорил о ней, было сущей правдой. Он описал свою возлюбленную верно. Она была красива и умна. К этому надо'
+' добавить еще одно - с уверенностью можно сказать, что многие женщины все, что угодно, отдали бы за то, чтобы променять свою жизнь на жизнь Маргариты Николаевны. Бездетная тридцатилетняя Маргарита была женою очень крупного специалиста, к тому'
+' же сделавшего важнейшее открытие государственного значения. Муж ее был молод, красив, добр, честен и обожал свою жену. Маргарита Николаевна со своим мужем вдвоем занимали весь верх прекрасного особняка в саду в одном из переулков близ Арбата.'
+' Очаровательное место! Всякий может в этом убедиться, если пожелает направиться в этот сад. Пусть обратится ко мне, я скажу ему адрес, укажу дорогу - особняк еще цел до сих пор.',

'В следующем зале не было колонн, вместо них стояли стены красных, розовых, молочно-белых роз с одной стороны, а с другой - стена японских махровых камелий. Между этими стенами уже били, шипя, фонтаны, и шампанское вскипало пузырями в трех бассейнах,'
+' из которых был первый - прозрачно-фиолетовый, второй - рубиновый, третий - хрустальный. Возле них метались негры в алых повязках, серебряными черпаками наполняя из бассейнов плоские чаши. В розовой стене оказался пролом, и в нем на эстраде кипятился'
+' человек в красном с ласточкиным хвостом фраке. Перед ним гремел нестерпимо громко джаз. Лишь только дирижер увидел Маргариту, он согнулся перед нею так, что руками коснулся пола, потом выпрямился и пронзительно закричал'
);


var
  Form1: TForm1;
  Errors, LenText, InpSym: Integer;
  CheckTimes : Integer;

implementation

uses StrUtils;

{$R *.dfm}

procedure TForm1.FormCreate(Sender: TObject);
begin
  //Включаем генератор случайных чисел
  Randomize;
  //Считывать клавиши со всех объектов формы
  KeyPreview := True;
  //Запретить чтение для поля
  edtText.ReadOnly := True;
end;

procedure TForm1.btnNewTextClick(Sender: TObject);
var RandomN : integer;
begin
  //Обнуляем переменные и заменяем текст
  Errors := 0;
  lblErrors.Caption := 'Ошибок: '+IntToStr(Errors);
  RandomN := Random(N);
  edtText.Text := texts[RandomN];
  LenText := length(texts[RandomN]);
  lblSymbols.caption := '0/'+inttostr(LenText);
  InpSym := 0;
  lblSpeed.Caption := '- сим/м';

  //Установить фокус на Edit
  edtText.SetFocus;
  //Переместить курсор в начало
  edtText.SelStart := 0;
  //Отключить таймер если он работает
  tmrCheckSpeed.Enabled := false;
  CheckTimes := 0;
end;

procedure TForm1.edtTextChange(Sender: TObject);
begin
  //Переместить курсор в начало
  edtText.SelStart := 0;
end;

procedure TForm1.FormKeyPress(Sender: TObject; var Key: Char);
begin
  //Если текст ещё остался то ...
  if Length(edtText.Text) > 0 then
  begin //Включаем таймер
    if tmrCheckSpeed.Enabled = false then tmrCheckSpeed.Enabled := true;
    //Если нажатая клавиша совпала с символов то ...
    if Key = edtText.Text[1] then
    begin
      //Делаем цвет текста - чёрный.
      edtText.Font.Color := clWindowText;
      //Срезаем первый символ
      edtText.Text := copy(edtText.Text,2,length(edtText.Text));
      //Говорим сколько пользователь безошибочно нажал клавиш
      InpSym := InpSym+1;
      lblSymbols.Caption := IntToStr(InpSym)+'/'+IntToStr(LenText);
      //Отключаем таймер если пользователь ввёл последний символ
      if InpSym = LenText then tmrCheckSpeed.Enabled := false;
    end else //Иначе если клавиша не совпала с символом, то ...
    begin
      //Добавляем в счётчик ошибку, сообщаем пользователю через Label и меняем цвет TEdit
      Errors := Errors + 1;
      lblErrors.Caption := 'Ошибок: '+IntToStr(Errors);
      edtText.Font.Color := clRed;
    end;
  end
end;

procedure TForm1.tmrCheckSpeedTimer(Sender: TObject);
const minute = 60*1000;
var symForMin : integer;
begin
  //Говорим сколько таймер раз работал
  CheckTimes := CheckTimes + 1;
  //Вычислаем скорость и выводим её
  SymForMin := round(minute/(CheckTimes*tmrCheckSpeed.Interval)*InpSym);
  lblSpeed.Caption := inttostr(SymForMin)+' сим/м';
end;

end.
