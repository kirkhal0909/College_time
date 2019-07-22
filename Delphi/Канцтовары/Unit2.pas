unit Unit2;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls;

type
  TForm2 = class(TForm)
    edtID: TEdit;
    lblID: TLabel;
    btnLoad: TButton;
    pnlID: TPanel;
    edtItem: TEdit;
    lblItem: TLabel;
    pnlEdit: TPanel;
    lblCena: TLabel;
    edtCena: TEdit;
    lblKolvo: TLabel;
    edtKolvo: TEdit;
    btnDelete: TButton;
    btnSave: TButton;
    btnNovij: TButton;
    procedure edtIDKeyPress(Sender: TObject; var Key: Char);
    procedure btnLoadClick(Sender: TObject);
    procedure btnDeleteClick(Sender: TObject);
    procedure btnSaveClick(Sender: TObject);
    procedure btnNovijClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure edtCenaKeyPress(Sender: TObject; var Key: Char);
    procedure edtItemChange(Sender: TObject);
  private
    procedure EnableEdit(Enbl:Boolean);
    { Private declarations }
  public
    procedure Update(updt: Boolean);
    { Public declarations }
  end;

var
  Form2: TForm2;
  StrokaVtablice: Integer;

implementation

uses unit1;

{$R *.dfm}

procedure Tform2.EnableEdit(Enbl:Boolean);
begin
  //�������������/���������� ����� �������
  edtCena.Enabled := Enbl;
  edtItem.Enabled := Enbl;
  edtKolvo.Enabled := Enbl;
  lblKolvo.Enabled := Enbl;
  lblItem.Enabled := Enbl;
  lblCena.Enabled := Enbl;
  btnDelete.Enabled := Enbl;
  btnSave.Enabled := Enbl;
  //��������������� ���������� ������ �������
  btnNovij.Enabled := not Enbl;
  lblID.Enabled := not Enbl;
  edtID.Enabled := not Enbl;
  btnLoad.Enabled := not Enbl;

  //����� ���������� �������
  if not Enbl then
  begin
    pnlID.BevelOuter := bvRaised;
    pnlEdit.BevelOuter := bvLowered;
  end else
  begin
    pnlEdit.BevelOuter := bvRaised;
    pnlID.BevelOuter := bvLowered;
  end;
end;

//������� ��� ���������� � ��������������/���������� ������
procedure Tform2.Update(updt: Boolean);
var Enbl: Boolean;
    put: string;
    svobodnijID: Integer;
begin
  Enbl := not updt;
  if not updt then
  begin
    Form1.ProveritPapky(papka); //��������� ������� �����,
    //���� ��������� ID
    svobodnijID := PoslednijID+1;
    put := papka+'\'+IntToStr(svobodnijID);
    //... �� ��������� �����
    while DirectoryExists(put) do
    begin
      svobodnijID := svobodnijID+1;
      put := papka+'\'+IntToStr(svobodnijID);
    end;
    PoslednijID := svobodnijID;
    //CreateDir(put);
    edtID.Text := IntToStr(PoslednijID);
    edtCena.Text := '0';
    edtKolvo.Text := '0';
    StrokaVtablice := kolvoTovarov+1;
  end;
  //��������� ���� �������
  EnableEdit(Enbl);
end;

//��������� � ���� ������������ ������ ����� � BackSpace
procedure TForm2.edtIDKeyPress(Sender: TObject; var Key: Char);
begin
  if (not (Key in ['0'..'9'])) and (not (Key = #8)) then Key := #0;
end;

//������ ������������� �����
procedure TForm2.btnLoadClick(Sender: TObject);
var tovar:integer;
  id:integer;
begin
  //���� ������������ �� ��� ID �� ������� ���������
  if Length(edtID.Text)<1 then begin ShowMessage('������� ID ������!'); Exit; end;
  //��������� ID ������� ��� ������������
  id := StrToInt(edtID.Text);
  for tovar := 1 to kolvoTovarov do
  begin
    //���� ��� ������ ����� �� ����� ����� � ������� �������
    if id = StrToInt(Form1.strngCanctovarVnalichii.Cells[0,tovar]) then
    begin
      //�� ������� �������� �� �������, � ���� ��� ��������������
      edtItem.Text := Form1.strngCanctovarVnalichii.Cells[1,tovar];//tovari[tovar].nazvanieTovara;
      edtCena.Text := Form1.strngCanctovarVnalichii.Cells[2,tovar];//tovari[tovar].cenaTovara;
      edtKolvo.Text := Form1.strngCanctovarVnalichii.Cells[3,tovar];//tovari[tovar].kolichestvoTovara;
      //������ ���������� �������
      EnableEdit(true);
      StrokaVtablice := tovar;
      //��������� �������
      Exit;
    end;
  end;
  //���� ������� �� �����������, ������ ID ������� ��� ������������ - �� ����������
  //��������� �� ���� ������������
  ShowMessage('����� � ����� ID �� ������!');
end;

//������ �������
procedure TForm2.btnDeleteClick(Sender: TObject);
var put:string;
  buttonSelected : Integer;
  stroka : integer;
begin
  put := papka+'\'+edtID.Text;
  if not DirectoryExists(put) then
  begin
    PoslednijID := form1.strngCanctovarVnalichii.RowCount-1;
  end else begin
    //���� ����� ��� �������� � � ������ ������ �������������
    //  �� ���������� ������������, ����� �� �� ����� �������
    buttonSelected := MessageDlg('�� ����� ������ ������� ��� ���������� � ������ ID-'+edtID.Text,mtWarning, mbOKCancel, 0);
    if buttonSelected = mrOK then
    begin

      //ShowMessage('All delete');
      //������� ����� �� �����
      try DeleteFile(put+'\item'); except end;
      try DeleteFile(put+'\price'); except end;
      try DeleteFile(put+'\amount'); except end;
      try RemoveDir(put); except end;
      //������� ����� �� ������� ������� � ������� ������
      for stroka := StrokaVtablice to form1.strngCanctovarVnalichii.RowCount-1 do
      begin
        form1.strngCanctovarVnalichii.Rows[stroka] := form1.strngCanctovarVnalichii.Rows[stroka+1];
      end;
      if StrokaVtablice <= form1.strngCanctovarVnalichii.RowCount-1 then
      begin
        form1.strngCanctovarVnalichii.RowCount := form1.strngCanctovarVnalichii.RowCount-1;
        kolvoTovarov := kolvoTovarov-1;
      end;
      //Form1.strngCanctovarVnalichii.Rows[StrokaVtablice]
      //self.Close;
    end;
  end;
  //������ ���������� ������
  EnableEdit(false);
end;

//������ ���������
procedure TForm2.btnSaveClick(Sender: TObject);
var put: string;
    f:TextFile;
begin
  //���� ������������ �� ����� ���� � ����������
  //  �� ��� ����������� ������
  if Length(edtCena.Text) < 1 then edtCena.Text := '0';
  if Length(edtKolvo.Text) < 1 then edtKolvo.Text := '0';
  //������� ���� ����� ������, ���� ������������ ��� ����� ����� � ������
  //  �������� 000032
  edtCena.Text := FloatToStr(Round(strToFloat(edtCena.Text)*100)/100);
  edtKolvo.Text := IntToStr(strToInt(edtKolvo.Text));
  //���� ������������ �� ����� �������� ������, �� ������� ���������
  if Length(edtItem.Text) < 1 then
    ShowMessage('������� �������� ������')
  else
  begin
    put := papka+'\'+edtID.Text;
    //����� ��������� ���� �� ������� ����� � ���� ���, ������
    Form1.ProveritPapky(papka);
    
    if not DirectoryExists(put) then
    begin
      CreateDir(put);
      kolvoTovarov := kolvoTovarov+1;
      StrokaVtablice := kolvoTovarov;
      form1.strngCanctovarVnalichii.RowCount := form1.strngCanctovarVnalichii.RowCount+1;
      form1.strngCanctovarVnalichii.Cells[0,StrokaVtablice] := edtID.Text;
      form1.strngCanctovarVnalichii.Cells[1,StrokaVtablice] := edtItem.Text;
      form1.strngCanctovarVnalichii.Cells[2,StrokaVtablice] := edtCena.Text;
      form1.strngCanctovarVnalichii.Cells[3,StrokaVtablice] := edtKolvo.Text;
      form1.strngCanctovarVnalichii.Cells[4,StrokaVtablice] := floatToStr(strtofloat(edtCena.Text)*strtoint(edtKolvo.Text));
    end else
    begin
      form1.strngCanctovarVnalichii.Cells[1,StrokaVtablice] := edtItem.Text;
      form1.strngCanctovarVnalichii.Cells[2,StrokaVtablice] := edtCena.Text;
      form1.strngCanctovarVnalichii.Cells[3,StrokaVtablice] := edtKolvo.Text;
      form1.strngCanctovarVnalichii.Cells[4,StrokaVtablice] := floatToStr(strtofloat(edtCena.Text)*strtoint(edtKolvo.Text));
    end;
    put := put+'\';
    AssignFile(f,put+'item');
    Rewrite(f);
    write(f,edtItem.text);
    CloseFile(f);

    AssignFile(f,put+'price');
    Rewrite(f);
    if Length(edtCena.Text) = 0 then edtCena.text := '0';
    write(f,edtCena.text);
    CloseFile(f);

    AssignFile(f,put+'amount');
    Rewrite(f);
    if Length(edtKolvo.text) = 0 then edtKolvo.text := '0';
    write(f,edtKolvo.text);
    CloseFile(f);

    EnableEdit(false);
  end;
end;

//������ ����� �����
procedure TForm2.btnNovijClick(Sender: TObject);
begin
  Update(false);
end;

procedure TForm2.FormCreate(Sender: TObject);
begin
  //����� ����� ������ �������
  self.FormStyle := fsStayOnTop;
end;

//��������� ���� ����
procedure TForm2.edtCenaKeyPress(Sender: TObject; var Key: Char);
begin
  //������� �� '.' ���� ','
  if Key = '.' then Key := ',';
  //������ ����� ������ �����, BackSpace, �������, �����
  if (not (Key in ['0'..'9'])) and (not (Key = #8)) and (not (Key = ',')) then Key := #0;
  //IntToStr(Pos(',',(sender as TEdit).Text));
  //���� ������� ������� � ����
  if (Pos(',',(sender as TEdit).Text)>0) then
  begin
    //�� ���� ������������ ����� �������� ��� ����, ��� �� ����������
    if (Key = ',') then Key := #0
    //���� �� ����� �� �����, �� ����� ������� �� ����� ��������� ������ ��� �����
    else if (Length((Sender as TEdit).Text)-Pos(',',(sender as TEdit).Text)>1) and (not (Key = #8)) then Key := #0;
  end;

end;

procedure TForm2.edtItemChange(Sender: TObject);
begin
  //������� ���������(����� ������� ��� ������������) ��� ����� ����� ��� ��������� �� ���
  (Sender as TEdit).Hint := (Sender as TEdit).Text
end;

end.
