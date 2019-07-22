unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    chkbTechM: TCheckBox;
    chkNar: TCheckBox;
    chkSal: TCheckBox;
    chkVoskHol: TCheckBox;
    chkSilikon: TCheckBox;
    chkPolirol: TCheckBox;
    chkTehMPena: TCheckBox;
    chkCond: TCheckBox;
    chkVoskGor: TCheckBox;
    lblPrice: TLabel;
    rb5: TRadioButton;
    rb15: TRadioButton;
    rb20: TRadioButton;
    rb30: TRadioButton;
    rb0: TRadioButton;
    lblKassa: TLabel;
    lblMojshik: TLabel;
    procedure chkbTechMClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

//Задаём константы цен  
const PriceTehM = 120;
      PriceNarujka = 250;
      PriceSalon = 200;
      PriceVoskHolodnij = 50;
      PriceSilikon = 100;
      PricePolirol = 100;
      PriceTehMPena = 200;
      PriceKondKoji = 100;
      PriceVoskGoryachij = 150;


var
  Form1: TForm1;
  Price : Integer;

implementation

{$R *.dfm}

procedure TForm1.chkbTechMClick(Sender: TObject);
begin
  {with (Sender as TCheckBox) do
  begin
     if Name = chkbTechM.Name then
     begin
        chkNar.Checked := False;
        chkTehMPena.Checked := False;
     end else if Name = chkNar.Name then
     begin
       chkbTechM.Checked := False;
       chkTehMPena.Checked := False;
     end else if Name = chkTehMPena.Name then
     begin
       chkbTechM.Checked := False;
       chkNar.Checked := False;
     end;
  end; }

  //Обнуляем переменную цены
  Price := 0;
  //Вычисляем цену
  if (chkbTechM.Checked) then Price := Price + PriceTehM;
  if (chkNar.Checked) then Price := Price + PriceNarujka;
  if (chkSal.Checked) then Price := Price + PriceSalon;
  if (chkVoskHol.Checked) then Price := Price + PriceVoskHolodnij;
  if (chkSilikon.Checked) then Price := Price + PriceSilikon;
  if (chkPolirol.Checked) then Price := Price + PricePolirol;
  if (chkTehMPena.Checked) then Price := Price + PriceTehMPena;
  if (chkCond.Checked) then Price := Price + PriceKondKoji;
  if (chkVoskGor.Checked) then Price := Price + PriceVoskGoryachij;
  //Вычисляем скидку
  if (rb5.Checked) then Price := Trunc(Price*0.95)
  else if (rb15.Checked) then Price := Trunc(Price*0.85)
  else if (rb20.Checked) then Price := Trunc(Price*0.80)
  else if (rb30.Checked) then Price := Trunc(Price*0.70);
  //Выводим цену и зарплату
  lblPrice.Caption := 'Цена: ' + IntToStr(Price)+'р';
  lblKassa.Caption := 'Касса: ' + IntToStr(Trunc(Price*0.70))+'р';
  lblMojshik.Caption := 'Мойщик: ' + IntToStr(Trunc(Price*0.30))+'р';
end;

end.
