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

const N = 4;  // N - ���������� �������
 texts : array [0..N-1] of string =( //��������� ������ � ��������
'How to Declare and Initialize Constant Arrays in Delphi',

'���� ��� ����� �������� ������������� ������, ��� �� ������ ������, ������� ����� �������������, �� ������ ��������� � ������ ���������������, ������� ������� ����,'
+'��������������� ������ ���������� ���������, ������� ��� �������. ��� �������, ����� �������� ������������� ������ - ������� ���������� �������������� ��������������'
+' ���� �� ���� ������. ��� ����, ����������� ������� ���������� ������ ��� ������ ��������� � ���������� ������, � ����� �����, ����� ����� ������� ������� ��������������.',

'������ ����� ������� �����, ������� ������ �� ������� ������� ��������. ������������ ��� ����� ���������� �����������. ���, ��� ������ ������� � ���, ���� ����� �������. �� ������ ���� ������������ �����. ��� ���� ������� � ����. � ����� ����'
+' �������� ��� ���� - � ������������ ����� �������, ��� ������ ������� ���, ��� ������, ������ �� �� ��, ����� ��������� ���� ����� �� ����� ��������� ����������. ��������� �������������� ��������� ���� ����� ����� �������� �����������, � ����'
+' �� ���������� ��������� �������� ���������������� ��������. ��� �� ��� �����, ������, ����, ������ � ������ ���� ����. ��������� ���������� �� ����� ����� ������ �������� ���� ���� ����������� �������� � ���� � ����� �� ��������� ���� ������.'
+' �������������� �����! ������ ����� � ���� ���������, ���� �������� ����������� � ���� ���. ����� ��������� �� ���, � ����� ��� �����, ����� ������ - ������� ��� ��� �� ��� ���.',

'� ��������� ���� �� ���� ������, ������ ��� ������ ����� �������, �������, �������-����� ��� � ����� �������, � � ������ - ����� �������� �������� �������. ����� ����� ������� ��� ����, ����, �������, � ���������� �������� �������� � ���� ���������,'
+' �� ������� ��� ������ - ���������-����������, ������ - ���������, ������ - �����������. ����� ��� �������� ����� � ���� ��������, ����������� ��������� �������� �� ��������� ������� ����. � ������� ����� �������� ������, � � ��� �� ������� ���������'
+' ������� � ������� � ����������� ������� �����. ����� ��� ������ ���������� ������ ����. ���� ������ ������� ������ ���������, �� �������� ����� ��� ���, ��� ������ �������� ����, ����� ���������� � ������������ ��������'
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
  //�������� ��������� ��������� �����
  Randomize;
  //��������� ������� �� ���� �������� �����
  KeyPreview := True;
  //��������� ������ ��� ����
  edtText.ReadOnly := True;
end;

procedure TForm1.btnNewTextClick(Sender: TObject);
var RandomN : integer;
begin
  //�������� ���������� � �������� �����
  Errors := 0;
  lblErrors.Caption := '������: '+IntToStr(Errors);
  RandomN := Random(N);
  edtText.Text := texts[RandomN];
  LenText := length(texts[RandomN]);
  lblSymbols.caption := '0/'+inttostr(LenText);
  InpSym := 0;
  lblSpeed.Caption := '- ���/�';

  //���������� ����� �� Edit
  edtText.SetFocus;
  //����������� ������ � ������
  edtText.SelStart := 0;
  //��������� ������ ���� �� ��������
  tmrCheckSpeed.Enabled := false;
  CheckTimes := 0;
end;

procedure TForm1.edtTextChange(Sender: TObject);
begin
  //����������� ������ � ������
  edtText.SelStart := 0;
end;

procedure TForm1.FormKeyPress(Sender: TObject; var Key: Char);
begin
  //���� ����� ��� ������� �� ...
  if Length(edtText.Text) > 0 then
  begin //�������� ������
    if tmrCheckSpeed.Enabled = false then tmrCheckSpeed.Enabled := true;
    //���� ������� ������� ������� � �������� �� ...
    if Key = edtText.Text[1] then
    begin
      //������ ���� ������ - ������.
      edtText.Font.Color := clWindowText;
      //������� ������ ������
      edtText.Text := copy(edtText.Text,2,length(edtText.Text));
      //������� ������� ������������ ����������� ����� ������
      InpSym := InpSym+1;
      lblSymbols.Caption := IntToStr(InpSym)+'/'+IntToStr(LenText);
      //��������� ������ ���� ������������ ��� ��������� ������
      if InpSym = LenText then tmrCheckSpeed.Enabled := false;
    end else //����� ���� ������� �� ������� � ��������, �� ...
    begin
      //��������� � ������� ������, �������� ������������ ����� Label � ������ ���� TEdit
      Errors := Errors + 1;
      lblErrors.Caption := '������: '+IntToStr(Errors);
      edtText.Font.Color := clRed;
    end;
  end
end;

procedure TForm1.tmrCheckSpeedTimer(Sender: TObject);
const minute = 60*1000;
var symForMin : integer;
begin
  //������� ������� ������ ��� �������
  CheckTimes := CheckTimes + 1;
  //��������� �������� � ������� �
  SymForMin := round(minute/(CheckTimes*tmrCheckSpeed.Interval)*InpSym);
  lblSpeed.Caption := inttostr(SymForMin)+' ���/�';
end;

end.
