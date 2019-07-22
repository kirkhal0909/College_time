unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, Unit2, StdCtrls,ComObj, ShellAPI;

type
  TForm1 = class(TForm)
    btn2: TButton;
    edt1: TEdit;
    Label1: TLabel;
    lbl1: TLabel;
    num1: TEdit;
    num2: TEdit;
    num: TLabel;
    Pr: TLabel;
    lbl2: TLabel;
    rpt: TEdit;
    procedure btn2Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure btn1Click(Sender: TObject);
    procedure btn3Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

{procedure TForm1.btn1Click(Sender: TObject);
begin
 SortRoutes('D:\Практика\Файлы для теста\2.xlsx',41);
end; }

procedure TForm1.btn2Click(Sender: TObject);
var CF:TSHFileOpStruct;
 i,j,n1,n2,Routes: Integer;
begin
 Form1.Hide;
 btn2.Enabled := false;
 edt1.Enabled := False;
 num1.Enabled := false;
 num2.Enabled := false;
 if num2.Text = '' then num2.Text := num1.Text;
 n1 := StrToInt(num1.Text); n2 := StrToInt(num2.Text);
 Routes := n2-n1+1;

 Pr.Visible := True;
 CreateDir(ExtractFilePath(Application.ExeName) + edt1.Text + ' (Sorted)');
 for i := n1 to n2 do
 begin
   Pr.Caption := 'Обрабатывается маршрут: ' + inttostr(i);
   CF.Wnd := 0;
   CF.pFrom := PChar(ExtractFilePath(Application.ExeName) + edt1.Text + '\*.*');
   CreateDir(ExtractFilePath(Application.ExeName) + edt1.Text + ' (Sorted)\'+ intToStr(i));
   CF.pTo := PChar(ExtractFilePath(Application.ExeName) + edt1.Text + ' (Sorted)\'+ intToStr(i));
   CF.wFunc := FO_COPY;
   CF.fFlags := FOF_ALLOWUNDO+FOF_NOCONFIRMATION;
   SHFileOperation(CF);

   for j := 1 to StrToInt(rpt.text) do
   SortInDir(ExtractFilePath(Application.ExeName) + edt1.Text + ' (Sorted)\'+ intToStr(i),i);
//   SortInDir(ExtractFilePath(Application.ExeName) + edt1.Text + ' (Sorted)\'+ intToStr(i),i);
 end;
// SortInDir('D:\Практика\Файлы для теста',70);
 //SortInDir('D:\Практика\Excl\70',70);
 RemoveEmptyDirs(ExtractFilePath(Application.ExeName) + edt1.Text + ' (Sorted)\'+ intToStr(i));
 ShowMessage('Завершено');
 Pr.Visible := False;
 btn2.Enabled := True;
 edt1.Enabled := True;
 num1.Enabled := True;
 num2.Enabled := True;
 Application.Terminate;
end;

procedure TForm1.FormCreate(Sender: TObject);
var f : TextFile;
begin
// AssignFile(f,'LogErrors.txt'); Rewrite(f); CloseFile(f);
end;

procedure TForm1.btn1Click(Sender: TObject);
begin
 SortRoutes('D:\Практика\Файлы для теста\222.xlsx',70);
 ShowMessage('Всё');
end;

procedure TForm1.btn3Click(Sender: TObject);
begin
 SortRoutes('D:\Практика\Файлы для теста\105.xlsx',105);
 ShowMessage('Всё');
end;

end.
