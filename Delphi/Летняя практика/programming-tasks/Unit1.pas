unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls,Unit2, Menus;

type
  TForm1 = class(TForm)
    btnLine: TButton;
    lbl: TLabel;
    btnbranch: TButton;
    btnCycle: TButton;
    btnMassive1: TButton;
    pnlTasks: TPanel;
    pnlStats: TPanel;
    lblToday: TLabel;
    lblLineToday: TLabel;
    lblBranchToday: TLabel;
    lblCycleToday: TLabel;
    lblArray1Today: TLabel;
    pnlDays: TPanel;
    lblLineDays: TLabel;
    lblBranchDays: TLabel;
    lblCycleDays: TLabel;
    lblArray1Days: TLabel;
    lblDays: TLabel;
    tmrEnd: TTimer;
    mm1: TMainMenu;
    mniAbout: TMenuItem;
    procedure ExamplesToConsole;
    procedure TaskToConsole;
    procedure StatsToConsole;
    procedure ReadStats;
    procedure UpdateStats;
    procedure btnLineClick(Sender: TObject);
    procedure btnbranchClick(Sender: TObject);
    procedure btnCycleClick(Sender: TObject);
    procedure btnMassive1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure tmrEndTimer(Sender: TObject);
    procedure mniAboutClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

  //const tasks : array[1..4] of string = ('��������','���������','�����','�������');  
var
  Form1: TForm1;
  stats: array[1..100] of Integer;
  newTask : Boolean = False;
  GetAns : Boolean = False;
  frstPrm : string;
  exe : string;

implementation

{$R *.dfm}
{$APPTYPE CONSOLE}

procedure TForm1.UpdateStats;
begin
      lblLineToday.Caption := inttostr(stats[1])+' OK; '+inttostr(stats[2])+' Wrong';
      lblBranchToday.Caption := inttostr(stats[3])+' OK; '+inttostr(stats[4])+' Wrong';
      lblCycleToday.Caption := inttostr(stats[5])+' OK; '+inttostr(stats[6])+' Wrong';
      lblArray1Today.Caption := inttostr(stats[7])+' OK; '+inttostr(stats[8])+' Wrong';

      lblLineDays.Caption := inttostr(stats[51])+' OK; '+inttostr(stats[52])+' Wrong';
      lblBranchDays.Caption := inttostr(stats[53])+' OK; '+inttostr(stats[54])+' Wrong';
      lblCycleDays.Caption := inttostr(stats[55])+' OK; '+inttostr(stats[56])+' Wrong';
      lblArray1Days.Caption := inttostr(stats[57])+' OK; '+inttostr(stats[58])+' Wrong';
end;

procedure Tform1.ReadStats;
var f : TextFile;
    today : TDate;
    fileName : string;
    tmpOK,tmpWrong: string;
    i : integer;
begin
  for i := 1 to 100 do stats[i] := 0;
  today := Now;
  fileName := DateToStr(today)+'.txt';
  AssignFile(f,fileName);
  if FileExists(fileName) then
  begin
    i := 1;
    Reset(f);
    try
      Readln(f,tmpOK); stats[i] := StrToInt(tmpOK); i := i + 1;
      Readln(f,tmpWrong); stats[i] := StrToInt(tmpWrong); i := i + 1;
      Readln(f,tmpOK); stats[i] := StrToInt(tmpOK); i := i + 1;
      Readln(f,tmpWrong); stats[i] := StrToInt(tmpWrong); i := i + 1;
      Readln(f,tmpOK); stats[i] := StrToInt(tmpOK); i := i + 1;
      Readln(f,tmpWrong); stats[i] := StrToInt(tmpWrong); i := i + 1;
      Readln(f,tmpOK); stats[i] := StrToInt(tmpOK); i := i + 1;
      Readln(f,tmpWrong); stats[i] := StrToInt(tmpWrong); i := i + 1;
    except
    end;
  end else begin Rewrite(f); for i := 1 to 7 do Writeln(f,'0'); write(f,'0'); end;
  CloseFile(f);

  fileName := 'stats.txt';
  AssignFile(f,fileName);
  if FileExists(fileName) then
  begin
    i := 51;
    Reset(f);
    try
      Readln(f,tmpOK); stats[i] := StrToInt(tmpOK); i := i + 1;
      Readln(f,tmpWrong); stats[i] := StrToInt(tmpWrong); i := i + 1;
      Readln(f,tmpOK); stats[i] := StrToInt(tmpOK); i := i + 1;
      Readln(f,tmpWrong); stats[i] := StrToInt(tmpWrong); i := i + 1;
      Readln(f,tmpOK); stats[i] := StrToInt(tmpOK); i := i + 1;
      Readln(f,tmpWrong); stats[i] := StrToInt(tmpWrong); i := i + 1;
      Readln(f,tmpOK); stats[i] := StrToInt(tmpOK); i := i + 1;
      Readln(f,tmpWrong); stats[i] := StrToInt(tmpWrong); i := i + 1;
    except
    end;
  end else begin Rewrite(f); for i := 1 to 7 do Writeln(f,'0'); write(f,'0'); end;
  CloseFile(f);
  
  UpdateStats;
end;

procedure TForm1.btnLineClick(Sender: TObject);
begin
  Form2.NextQuestion(1);
end;

procedure TForm1.btnbranchClick(Sender: TObject);
begin
  Form2.NextQuestion(2);
end;

procedure TForm1.btnCycleClick(Sender: TObject);
begin
  Form2.NextQuestion(3);
end;

procedure TForm1.btnMassive1Click(Sender: TObject);
begin
  Form2.NextQuestion(4);
end;

procedure TForm1.StatsToConsole;
begin
   Writeln(' ���������� �� �������:'+#13#10+'  �������� '+lblLineToday.Caption
              +#13#10+'  ��������� '+lblBranchToday.Caption
              +#13#10+'  ����� '+lblCycleToday.Caption
              +#13#10+'  ������� '+lblArray1Today.Caption+#13#10
              +' ���������� �� �� �����:'+#13#10+'  �������� '+lblLineDays.Caption
              +#13#10+'  ��������� '+lblBranchDays.Caption
              +#13#10+'  ����� '+lblCycleDays.Caption
              +#13#10+'  ������� '+lblArray1Days.Caption);
end;

procedure TForm1.TaskToConsole;
var f : TextFile;
    full,tmp : string;
begin
  AssignFile(f,'task.txt');
  Reset(f);
  tmp := ''; full := ''; while not Eof(f) do begin Readln(f,tmp); full := full+tmp+#13#10; end;
  CloseFile(f);
  full := ' '+full;
  Writeln(full);
end;

procedure TForm1.ExamplesToConsole;
var f : TextFile;
    full,tmp : string;
begin
  AssignFile(f,'examples.txt');
  Reset(f);
  tmp := ''; full := ''; while not Eof(f) do begin Readln(f,tmp); full := full+tmp+#13#10; end;
  CloseFile(f);
  full := ' '+full;
  Writeln(full);
end;

procedure TForm1.FormCreate(Sender: TObject);
var
    prm : string;
    f : TextFile; tmp,full: string;
begin
  randomize;
  ReadStats;
  SetConsoleCP(1251);
  SetConsoleOutputCP(1251);
  exe := ExtractFileName(Application.ExeName);
  if ParamCount = 0 then
  begin
    Writeln('����� ���������� � ������� ��������. ��������� �������� � ����������� ������.');
    Writeln('����� ����������������� � ���������� ����� �������, ��������:');
    Writeln('     '+exe+' help');
    FreeConsole;
    Form1.Left := Screen.Width div 2 - Form1.Width div 2;
    Form1.Top := Screen.Height div 2 - Form1.Height div 2;
  end
  else begin
    prm := LowerCase(ParamStr(1));
    frstPrm := prm;
    if prm[1] in ['/','\','-'] then prm := Copy(prm,2,length(prm)-1);
    if prm = 'stats' then StatsToConsole
    else if prm = 'help' then begin
       Writeln('  '+exe+' '+'stats - ������� ����������');
       Writeln('  '+exe+' '+'output - ��������� �������� ������ ������');
       Writeln('  '+exe+' '+'1 - �������� ������ "��������"');
       Writeln('  '+exe+' '+'2 - �������� ������ "���������"');
       Writeln('  '+exe+' '+'3 - �������� ������ "�����"');
       Writeln('  '+exe+' '+'4 - �������� ������ "�������"');
       Writeln('  '+exe+' '+'task - �������� ����� ������');
       Writeln('  '+exe+' '+'test - �������� ����� ������');
    end else if prm = 'task' then TaskToConsole
    else if prm = 'test' then ExamplesToConsole
    else if (prm[1] in ['1'..'4']) and (Length(prm)=1) then begin
      
      //AssignFile(f,'task.txt');
      //Reset(f);
      //tmp := ''; full := ''; while not Eof(f) do begin Readln(f,tmp); full := full+tmp+#13#10; end;
      Writeln('  ������� ����� ���������� � ����� task.txt');
      newTask := true;
      tmrEnd.Enabled := True;
      Exit;
    end else if prm = 'output' then begin
      if FileExists('output.txt') then
      begin
         GetAns := True;
          tmrEnd.Enabled := True;
          Exit;
      end else begin
        Writeln(' ���� output.txt �� ������');
      end;
    end;
    Application.Terminate;
  end;
end;

procedure TForm1.tmrEndTimer(Sender: TObject);
begin
  if newTask then
  begin
    Form2.NextQuestion(StrToInt(frstPrm));
    Writeln('  '+TaskText);
    Writeln('  ����� ��������, ��������� �������� ������ � output.txt � �������� - '+exe+' output');
  end else if GetAns then
  begin
    Form2.decryptAns;
    Form2.btnFrmOutClick(nil);
    Form2.btnAnsClick(nil);
    if Form2.lblStatus.Caption = 'Ok' then
    begin
      Writeln('  �� ������ ������:)');
      StatsToConsole;
      Writeln(' ����� ������ ��������������� � task.txt');
    end else begin
      Writeln('  ������ ������ �����������!');
      StatsToConsole;
      Writeln(' �� ������ ����� ����������� � ������ � �������� - '+exe+' output');
      TaskToConsole;
      //Writeln(' ������� ��������� � ����� task.txt');
    end;
  end;
  Application.Terminate;
end;

procedure TForm1.mniAboutClick(Sender: TObject);
begin
  ShowMessage('����������� ������ � ����������� �����������, ������ ��� ����������� ������������� �� ���������'+#13#10'� ������� ����������� ��� ������ ������������(�����������) ����������.'+#13#10
  +#13#10+'   ��� ����������: 2018'+#13#10+'   �����������: ������ �������');
end;

end.
