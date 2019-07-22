unit Unit2;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm2 = class(TForm)
    mmoTask: TMemo;
    mmoAns: TMemo;
    btnBack: TButton;
    btnAns: TButton;
    btnExamples: TButton;
    lblStatus: TLabel;
    lblHint: TLabel;
    btnFrmOut: TButton;
    function cryptAns(ans: string) : string;
    procedure decryptAns;
    procedure SaveStats;
    procedure NextQuestion(task: Integer);
    procedure btnBackClick(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure btnExamplesClick(Sender: TObject);
    procedure btnAnsClick(Sender: TObject);
    procedure mmoAnsChange(Sender: TObject);
    procedure btnFrmOutClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form2: TForm2;
  Examples,TaskText,inputTask,answer: string;
  taskNum : integer;
  path : string;

implementation
uses unit1, Math;

{$R *.dfm}

procedure Tform2.SaveStats;
var f : TextFile;
    today : TDate;
    fileName : string;
    plusOk : boolean;
    stat,i: integer;
begin
    if lblStatus.Caption = 'Ok' then plusOk := true else plusOk := false;
    stat := 1+(taskNum-1)*2;
    if not plusOk then stat := stat+1;
    stats[stat] := stats[stat]+1;
    stats[50+stat] := stats[50+stat]+1;
    today := Now;
    fileName := DateToStr(today)+'.txt';
    AssignFile(f,fileName);
    Rewrite(f);
    for i := 1 to 7 do Writeln(f,inttostr(stats[i])); write(f,inttostr(stats[8]));
    CloseFile(f);

    fileName := 'stats.txt';
    AssignFile(f,fileName);
    Rewrite(f);
    for i := 51 to 57 do Writeln(f,inttostr(stats[i])); write(f,inttostr(stats[58]));
    CloseFile(f);

    Form1.UpdateStats;
end;

procedure TForm2.NextQuestion(task: Integer);
const exmpls = 3;
var r,i,j,k: integer;
    tmpInp,tmpAns : string;
    a,b,c: integer;
    arr1 : array[1..100] of integer;
    f : TextFile;
begin
  Form1.Hide; Form2.Show;
  taskNum := task;
  mmoAns.Font.Color := clWindowText;
  lblStatus.Visible := false;
  r := Random(100);
  Examples := ''; inputTask := ''; answer := ''; TaskText := ''; tmpInp := ''; tmpAns := '';
  btnExamples.Caption := 'Примеры';
  case taskNum of
    1:
    begin
        r := r mod 4;
        if r = 0 then
        begin
          //Examples,TaskText,input,answer: string;
          a := Random(15000)+1; b := Random(15000)+1;
          TaskText := 'Найдите сумму двух целых чисел '+inttostr(a)+' и '+inttostr(b);
          inputTask := inttostr(a)+' '+inttostr(b);
          answer := IntToStr(a+b);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
               a := Random(15000)+1; b := Random(15000)+1;
               tmpInp := inttostr(a)+' '+inttostr(b);
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+IntToStr(a+b);
            end;
          end;
        end else if r = 1 then
        begin
          //Examples,TaskText,input,answer: string;
          a := Random(180)+1; b := Random(180)+1;
          TaskText := 'Найдите произведение двух целых чисел '+inttostr(a)+' и '+inttostr(b);
          inputTask := inttostr(a)+' '+inttostr(b);
          answer := IntToStr(a*b);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
               a := Random(180)+1; b := Random(180)+1;
               tmpInp := inttostr(a)+' '+inttostr(b);
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+IntToStr(a*b);
            end;
          end;
        end else if r = 2 then
        begin
          //Examples,TaskText,input,answer: string;
          a := Random(180)+1;
          TaskText := 'Найдите квадрат числа '+inttostr(a);
          inputTask := inttostr(a);
          answer := IntToStr(a*a);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
               a := Random(180)+1;
               tmpInp := inttostr(a);
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+IntToStr(a*a);
            end;
          end;
        end else if r = 3 then
        begin
          //Examples,TaskText,input,answer: string;
          a := Random(180)+1;
          TaskText := 'Найдите корень числа '+inttostr(a*a);
          inputTask := inttostr(a*a);
          answer := IntToStr(a);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
               a := Random(180)+1;
               tmpInp := inttostr(a*a);
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+IntToStr(a);
            end;
          end;
        end
    end;
    
    2:
    begin
      r := r mod 5;
        if r = 0 then
        begin
          //Examples,TaskText,input,answer: string;
          a := Random(30000)+1; b := Random(30000)+1;
          TaskText := 'Дано два целых числа '+inttostr(a)+' и '+inttostr(b)+'. Найдите максимальное из них';
          inputTask := inttostr(a)+' '+inttostr(b);
          if b> a then a := b;
          answer := IntToStr(a);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
               a := Random(30000)+1; b := Random(30000)+1;
               tmpInp := inttostr(a)+' '+inttostr(b);
               if b> a then a := b;
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+IntToStr(a);
            end;
          end;
        end else if r = 1 then
        begin
          //Examples,TaskText,input,answer: string;
          a := Random(30000)+1; b := Random(30000)+1; c := Random(30000)+1;
          TaskText := 'Дано три целых числа '+inttostr(a)+'; '+inttostr(b)+' и '+inttostr(c)+'. Найдите максимальное из них';
          inputTask := inttostr(a)+' '+inttostr(b)+' '+inttostr(c);
          if b> a then a := b;
          if c>a then a := c;
          answer := IntToStr(a);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
               a := Random(30000)+1; b := Random(30000)+1; c := Random(30000)+1;
               tmpInp := inttostr(a)+' '+inttostr(b)+' '+inttostr(c);
               if b> a then a := b;
               if c>a then a := c;
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+IntToStr(a);
            end;
          end;
        end else if r = 2 then
        begin
          //Examples,TaskText,input,answer: string;
          a := Random(30000)+1; b := Random(30000)+1;
          TaskText := 'Дано два целых числа '+inttostr(a)+' и '+inttostr(b)+'. Найдите минимальное из них';
          inputTask := inttostr(a)+' '+inttostr(b);
          if b< a then a := b;
          answer := IntToStr(a);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
               a := Random(30000)+1; b := Random(30000)+1;
               tmpInp := inttostr(a)+' '+inttostr(b);
               if b< a then a := b;
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+IntToStr(a);
            end;
          end;
        end else if r = 3 then
        begin
          //Examples,TaskText,input,answer: string;
          a := Random(30000)+1; b := Random(30000)+1; c := Random(30000)+1;
          TaskText := 'Дано три целых числа '+inttostr(a)+'; '+inttostr(b)+' и '+inttostr(c)+'. Найдите минимальное из них';
          inputTask := inttostr(a)+' '+inttostr(b)+' '+inttostr(c);
          if b< a then a := b;
          if c<a then a := c;
          answer := IntToStr(a);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
               a := Random(30000)+1; b := Random(30000)+1; c := Random(30000)+1;
               tmpInp := inttostr(a)+' '+inttostr(b)+' '+inttostr(c);
               if b< a then a := b;
               if c<a then a := c;
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+IntToStr(a);
            end;
          end;
        end else if r = 4 then
        begin
          //Examples,TaskText,input,answer: string;
          a := Random(30000)+1;
          TaskText := 'Дано целое положительное число '+inttostr(a)+'. Если оно чётное, выведите 0, иначе 1';
          inputTask := inttostr(a);
          answer := IntToStr(a mod 2);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
               a := Random(30000)+1;
               tmpInp := inttostr(a);
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+IntToStr(a mod 2);
            end;
          end;
        end
    end;
    3:
    begin
      r := r mod 5;
        if r = 0 then
        begin
          //Examples,TaskText,input,answer: string;
          //a := Random(30000)+1; b := Random(30000)+1;
          TaskText := 'Дано двадцать целых числел';//. Найдите максимальное из них';
          b := 0;
          for i := 1 to 20 do
          begin
            a := Random(1500)+1;
            b := b+a;
            TaskText := TaskText + ' ' + IntToStr(a);
            inputTask := inputTask+IntToStr(a);
            if i <> 20 then inputTask := inputTask + ' ';
          end;
          TaskText := TaskText + '. Найдите их сумму';
          answer := IntToStr(b);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
                b := 0;
                tmpInp := ''; tmpAns := '';
                for j := 1 to 20 do
                begin
                  a := Random(1500)+1;
                  b := b+a;
                  tmpInp := tmpInp+IntToStr(a);
                  if j <> 20 then tmpInp := tmpInp + ' ';
                end;
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+IntToStr(b);
            end;
          end;
        end else if r = 1 then
        begin
          //Examples,TaskText,input,answer: string;
          //a := Random(30000)+1; b := Random(30000)+1;
          TaskText := 'Дано двадцать целых чисел';//. Найдите максимальное из них';
          b := 0;
          for i := 1 to 20 do
          begin
            a := Random(1500)+1;
            if i mod 2 = 0 then b := b+a;
            TaskText := TaskText + ' ' + IntToStr(a);
            inputTask := inputTask+IntToStr(a);
            if i <> 20 then inputTask := inputTask + ' ';
          end;
          TaskText := TaskText + '. Найдите сумму чисел, которые находятся на чётной позиции';
          answer := IntToStr(b);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
                b := 0;
                tmpInp := ''; tmpAns := '';
                for j := 1 to 20 do
                begin
                  a := Random(1500)+1;
                  if j mod 2 = 0 then b := b+a;
                  tmpInp := tmpInp+IntToStr(a);
                  if j <> 20 then tmpInp := tmpInp + ' ';
                end;
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+IntToStr(b);
            end;
          end;
        end else if r = 2 then
        begin
          //Examples,TaskText,input,answer: string;
          //a := Random(30000)+1; b := Random(30000)+1;
          TaskText := 'Дано тридцать целых чисел';//. Найдите максимальное из них';
          b := MaxInt;
          for i := 1 to 30 do
          begin
            a := Random(30000)+1;
            TaskText := TaskText + ' ' + IntToStr(a);
            inputTask := inputTask+IntToStr(a);
            if i <> 20 then inputTask := inputTask + ' ';
            if a>b then answer := answer + ' ' +IntToStr(a);
            b := a;
          end;
          answer := copy(answer,2,length(answer)-1);
          TaskText := TaskText + '. Выведите числа, которые больше предыдущего чсла';
          answer := IntToStr(b);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
                b := MaxInt;
                tmpInp := ''; tmpAns := '';
                for j := 1 to 30 do
                begin
                  a := Random(30000)+1;
                  tmpInp := tmpInp+IntToStr(a);
                  if j <> 20 then tmpInp := tmpInp + ' ';
                  if a>b then tmpAns := tmpAns + ' ' +IntToStr(a);
                  b := a;
                end;
                tmpAns := copy(tmpAns,2,length(tmpAns)-1);
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+tmpAns;
            end;
          end;
        end else if r = 3 then
        begin
          //Examples,TaskText,input,answer: string;
          //a := Random(30000)+1; b := Random(30000)+1;
          TaskText := 'Дано тридцать целых чисел';//. Найдите максимальное из них';
          b := -MaxInt;
          for i := 1 to 30 do
          begin
            a := Random(30000)+1;
            TaskText := TaskText + ' ' + IntToStr(a);
            inputTask := inputTask+IntToStr(a);
            if i <> 20 then inputTask := inputTask + ' ';
            if a<b then answer := answer + ' ' +IntToStr(a);
            b := a;
          end;
          answer := copy(answer,2,length(answer)-1);
          TaskText := TaskText + '. Выведите числа, которые меньше предыдущего чсла';
          answer := IntToStr(b);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
                b := -MaxInt;
                tmpInp := ''; tmpAns := '';
                for j := 1 to 30 do
                begin
                  a := Random(30000)+1;
                  tmpInp := tmpInp+IntToStr(a);
                  if j <> 20 then tmpInp := tmpInp + ' ';
                  if a<b then tmpAns := tmpAns + ' ' +IntToStr(a);
                  b := a;
                end;
                tmpAns := copy(tmpAns,2,length(tmpAns)-1);
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+tmpAns;
            end;
          end;
        end else if r = 4 then
        begin
          //Examples,TaskText,input,answer: string;
          //a := Random(30000)+1; b := Random(30000)+1;
          TaskText := 'Дано двадцать целых чисел';//. Найдите максимальное из них';
          b := 0;
          for i := 1 to 20 do
          begin
            a := Random(1500)+1;
            if i mod 2 = 1 then b := b+a;
            TaskText := TaskText + ' ' + IntToStr(a);
            inputTask := inputTask+IntToStr(a);
            if i <> 20 then inputTask := inputTask + ' ';
          end;
          TaskText := TaskText + '. Найдите сумму чисел, которые находятся на нечётной позиции';
          answer := IntToStr(b);
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
                b := 0;
                tmpInp := ''; tmpAns := '';
                for j := 1 to 20 do
                begin
                  a := Random(1500)+1;
                  if j mod 2 = 1 then b := b+a;
                  tmpInp := tmpInp+IntToStr(a);
                  if j <> 20 then tmpInp := tmpInp + ' ';
                end;
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+IntToStr(b);
            end;
          end;
        end
    end;
    4:
    begin
       r := r mod 4;
       if r = 0 then
        begin
          //Examples,TaskText,input,answer: string;
          //a := Random(30000)+1; b := Random(30000)+1;
          TaskText := 'Дано сорок целых чисел';//. Найдите максимальное из них';
          b := 0;
          for i := 1 to 40 do
          begin
            a := Random(1500)+1;
            TaskText := TaskText + ' ' + IntToStr(a);
            inputTask := inputTask+IntToStr(a);
            if i <> 20 then inputTask := inputTask + ' ';
            arr1[i] := a;
          end;
          for j := 1 to 40 do
          begin
            for k := 1 to 40-j do
            begin
              if arr1[k] > arr1[k+1] then
              begin
                a := arr1[k];
                arr1[k] := arr1[k+1];
                arr1[k+1] := a;
              end;
            end;
          end;
          for j := 1 to 40 do answer := answer+' '+inttostr(arr1[j]);
          answer := Copy(answer,2,length(answer)-1);
          TaskText := TaskText + '. Требуется отсортировать их по воозрастанию';
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
                b := 0;
                tmpInp := ''; tmpAns := '';
                for j := 1 to 40 do
                begin
                  a := Random(1500)+1;
                  tmpInp := tmpInp+IntToStr(a);
                  if j <> 20 then tmpInp := tmpInp + ' ';
                  arr1[j] := a;
                end;
                for j := 1 to 40 do
                begin
                  for k := 1 to 40-j do
                  begin
                    if arr1[k] > arr1[k+1] then
                    begin
                      a := arr1[k];
                      arr1[k] := arr1[k+1];
                      arr1[k+1] := a;
                    end;
                  end;
                end;
                for j := 1 to 40 do tmpAns := tmpAns+' '+inttostr(arr1[j]);
                tmpAns := Copy(tmpAns,2,length(tmpAns)-1);
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+tmpAns;
            end;
          end;
        end else       if r = 1 then
        begin
          //Examples,TaskText,input,answer: string;
          //a := Random(30000)+1; b := Random(30000)+1;
          TaskText := 'Дано сорок целых чисел';//. Найдите максимальное из них';
          b := 0;
          for i := 1 to 40 do
          begin
            a := Random(1500)+1;
            TaskText := TaskText + ' ' + IntToStr(a);
            inputTask := inputTask+IntToStr(a);
            if i <> 20 then inputTask := inputTask + ' ';
            arr1[i] := a;
          end;
          for j := 1 to 40 do
          begin
            for k := 1 to 40-j do
            begin
              if arr1[k] < arr1[k+1] then
              begin
                a := arr1[k];
                arr1[k] := arr1[k+1];
                arr1[k+1] := a;
              end;
            end;
          end;
          for j := 1 to 40 do answer := answer+' '+inttostr(arr1[j]);
          answer := Copy(answer,2,length(answer)-1);
          TaskText := TaskText + '. Требуется отсортировать их по убыванию';
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
                b := 0;
                tmpInp := ''; tmpAns := '';
                for j := 1 to 40 do
                begin
                  a := Random(1500)+1;
                  tmpInp := tmpInp+IntToStr(a);
                  if j <> 20 then tmpInp := tmpInp + ' ';
                  arr1[j] := a;
                end;
                for j := 1 to 40 do
                begin
                  for k := 1 to 40-j do
                  begin
                    if arr1[k] < arr1[k+1] then
                    begin
                      a := arr1[k];
                      arr1[k] := arr1[k+1];
                      arr1[k+1] := a;
                    end;
                  end;
                end;
                for j := 1 to 40 do tmpAns := tmpAns+' '+inttostr(arr1[j]);
                tmpAns := Copy(tmpAns,2,length(tmpAns)-1);
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+tmpAns;
            end;
          end;
        end else       if r = 2 then
        begin
          //Examples,TaskText,input,answer: string;
          //a := Random(30000)+1; b := Random(30000)+1;
          TaskText := 'Дано сорок целых чисел';//. Найдите максимальное из них';
          b := 0;
          for i := 1 to 40 do
          begin
            a := Random(1500)+1;
            TaskText := TaskText + ' ' + IntToStr(a);
            inputTask := inputTask+IntToStr(a);
            if i <> 20 then inputTask := inputTask + ' ';
            arr1[i] := a;
          end;
          for j := 1 to 40 do
          begin
            for k := 1 to 40-j do
            begin
              if arr1[k] < arr1[k+1] then
              begin
                a := arr1[k];
                arr1[k] := arr1[k+1];
                arr1[k+1] := a;
              end;
            end;
          end;
          for j := 1 to 3 do answer := answer+' '+inttostr(arr1[j]);
          answer := Copy(answer,2,length(answer)-1);
          TaskText := TaskText + '. Требуется найти три максимальных числа в порядке убывания';
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
                b := 0;
                tmpInp := ''; tmpAns := '';
                for j := 1 to 40 do
                begin
                  a := Random(1500)+1;
                  tmpInp := tmpInp+IntToStr(a);
                  if j <> 20 then tmpInp := tmpInp + ' ';
                  arr1[j] := a;
                end;
                for j := 1 to 40 do
                begin
                  for k := 1 to 40-j do
                  begin
                    if arr1[k] < arr1[k+1] then
                    begin
                      a := arr1[k];
                      arr1[k] := arr1[k+1];
                      arr1[k+1] := a;
                    end;
                  end;
                end;
                for j := 1 to 3 do tmpAns := tmpAns+' '+inttostr(arr1[j]);
                tmpAns := Copy(tmpAns,2,length(tmpAns)-1);
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+tmpAns;
            end;
          end;
        end else       if r = 3 then
        begin
          //Examples,TaskText,input,answer: string;
          //a := Random(30000)+1; b := Random(30000)+1;
          TaskText := 'Дано сорок целых чисел';//. Найдите максимальное из них';
          b := 0;
          for i := 1 to 40 do
          begin
            a := Random(1500)+1;
            TaskText := TaskText + ' ' + IntToStr(a);
            inputTask := inputTask+IntToStr(a);
            if i <> 20 then inputTask := inputTask + ' ';
            arr1[i] := a;
          end;
          for j := 1 to 40 do
          begin
            for k := 1 to 40-j do
            begin
              if arr1[k] < arr1[k+1] then
              begin
                a := arr1[k];
                arr1[k] := arr1[k+1];
                arr1[k+1] := a;
              end;
            end;
          end;
          for j := 38 to 40 do answer := answer+' '+inttostr(arr1[j]);
          answer := Copy(answer,2,length(answer)-1);
          TaskText := TaskText + '. Требуется найти три минимальных числа в порядке убывания';
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
                b := 0;
                tmpInp := ''; tmpAns := '';
                for j := 1 to 40 do
                begin
                  a := Random(1500)+1;
                  tmpInp := tmpInp+IntToStr(a);
                  if j <> 20 then tmpInp := tmpInp + ' ';
                  arr1[j] := a;
                end;
                for j := 1 to 40 do
                begin
                  for k := 1 to 40-j do
                  begin
                    if arr1[k] < arr1[k+1] then
                    begin
                      a := arr1[k];
                      arr1[k] := arr1[k+1];
                      arr1[k+1] := a;
                    end;
                  end;
                end;
                for j := 38 to 40 do tmpAns := tmpAns+' '+inttostr(arr1[j]);
                tmpAns := Copy(tmpAns,2,length(tmpAns)-1);
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+tmpAns;
            end;
          end;
        end  else       if r = 4 then
        begin
          //Examples,TaskText,input,answer: string;
          //a := Random(30000)+1; b := Random(30000)+1;
          TaskText := 'Дано сорок целых чисел';//. Найдите максимальное из них';
          b := 0;
          for i := 1 to 40 do
          begin
            a := Random(1500)+1;
            TaskText := TaskText + ' ' + IntToStr(a);
            inputTask := inputTask+IntToStr(a);
            if i <> 20 then inputTask := inputTask + ' ';
            arr1[i] := a;
          end;
          for j := 1 to 40 do
          begin
            for k := 1 to 40-j do
            begin
              if arr1[k] < arr1[k+1] then
              begin
                a := arr1[k];
                arr1[k] := arr1[k+1];
                arr1[k+1] := a;
              end;
            end;
          end;
          for j := 3 downto 1 do answer := answer+' '+inttostr(arr1[j]);
          answer := Copy(answer,2,length(answer)-1);
          TaskText := TaskText + '. Требуется найти три максимальных числа в порядке возрастания';
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
                b := 0;
                tmpInp := ''; tmpAns := '';
                for j := 1 to 40 do
                begin
                  a := Random(1500)+1;
                  tmpInp := tmpInp+IntToStr(a);
                  if j <> 20 then tmpInp := tmpInp + ' ';
                  arr1[j] := a;
                end;
                for j := 1 to 40 do
                begin
                  for k := 1 to 40-j do
                  begin
                    if arr1[k] < arr1[k+1] then
                    begin
                      a := arr1[k];
                      arr1[k] := arr1[k+1];
                      arr1[k+1] := a;
                    end;
                  end;
                end;
                for j := 3 downto 1 do tmpAns := tmpAns+' '+inttostr(arr1[j]);
                tmpAns := Copy(tmpAns,2,length(tmpAns)-1);
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+tmpAns;
            end;
          end;
        end else       if r = 5 then
        begin
          //Examples,TaskText,input,answer: string;
          //a := Random(30000)+1; b := Random(30000)+1;
          TaskText := 'Дано сорок целых чисел';//. Найдите максимальное из них';
          b := 0;
          for i := 1 to 40 do
          begin
            a := Random(1500)+1;
            TaskText := TaskText + ' ' + IntToStr(a);
            inputTask := inputTask+IntToStr(a);
            if i <> 20 then inputTask := inputTask + ' ';
            arr1[i] := a;
          end;
          for j := 1 to 40 do
          begin
            for k := 1 to 40-j do
            begin
              if arr1[k] < arr1[k+1] then
              begin
                a := arr1[k];
                arr1[k] := arr1[k+1];
                arr1[k+1] := a;
              end;
            end;
          end;
          for j := 40 downto 38 do answer := answer+' '+inttostr(arr1[j]);
          answer := Copy(answer,2,length(answer)-1);
          TaskText := TaskText + '. Требуется найти три минимальных числа в порядке возрастания';
          for i := 1 to exmpls do
          begin
            tmpInp := inputTask;
            while tmpInp = inputTask do
            begin
                b := 0;
                tmpInp := ''; tmpAns := '';
                for j := 1 to 40 do
                begin
                  a := Random(1500)+1;
                  tmpInp := tmpInp+IntToStr(a);
                  if j <> 20 then tmpInp := tmpInp + ' ';
                  arr1[j] := a;
                end;
                for j := 1 to 40 do
                begin
                  for k := 1 to 40-j do
                  begin
                    if arr1[k] < arr1[k+1] then
                    begin
                      a := arr1[k];
                      arr1[k] := arr1[k+1];
                      arr1[k+1] := a;
                    end;
                  end;
                end;
                for j := 40 downto 38 do tmpAns := tmpAns+' '+inttostr(arr1[j]);
                tmpAns := Copy(tmpAns,2,length(tmpAns)-1);
               if tmpInp <> inputTask then Examples := Examples+ #13#10 +'inp: '+tmpInp+#13#10+'out: '+tmpAns;
            end;
          end;
        end
    end;
    end;

  try
    AssignFile(f,'input.txt');
    Rewrite(f);
    Write(f,inputTask);
    CloseFile(f);

    AssignFile(f,'task.txt');
    Rewrite(f);
    Write(f,TaskText);
    CloseFile(f);

    AssignFile(f,'examples.txt');
    Rewrite(f);
    Write(f,Examples);
    CloseFile(f);

    AssignFile(f,'answer.txt');
    Rewrite(f);
    Write(f,cryptAns(answer));
    CloseFile(f);

    decryptAns;
    //ShowMessage(cryptAns(answer));
    //ShowMessage(IntToStr(taskNum)+' '+answer);
  except
  end;
  mmoTask.Text := TaskText;
end;

function TForm2.cryptAns(ans: string): string;
var tmp: string;
    i : Integer;
begin
  tmp := IntToStr(taskNum+ord(ans[1]))+#13#10;
  for i := 1 to Length(ans) do
  begin
    tmp := tmp+IntToStr(Ord(Ans[i]));
    if i <> Length(ans) then tmp := tmp+' ';
  end;
  Result := tmp;
end;

procedure TForm2.decryptAns;
var tmp,tmpsep: string;
    i : Integer;
    qst,ans : string;
    f : TextFile;
begin
  try
    AssignFile(f,'answer.txt');
    Reset(f);
    Readln(f,qst);
    Readln(f,ans);
    CloseFile(f);
  //Encrypt function
  //tmp := IntToStr(taskNum+ord(ans[1]))+#13#10;
  tmp := ''; tmpsep := '';
  for i := 1 to Length(ans) do
  begin
    if not (ans[i] in ['0'..'9']) then
    begin
        tmp := tmp+ chr(StrToInt(tmpsep));
      tmpsep := '';
      //ShowMessage(tmp);
    end else tmpsep := tmpsep + ans[i];
  end;
  if tmpsep <> '' then tmp := tmp+chr(StrToInt(tmpsep));
  answer := tmp;
  taskNum := StrToInt(chr(StrToInt(qst)-StrToInt(tmp[1])));
  except
  end;
end;

procedure TForm2.btnBackClick(Sender: TObject);
begin
  Form2.Hide; Form1.Show;
end;

procedure TForm2.FormClose(Sender: TObject; var Action: TCloseAction);
begin
  Form2.Hide; Form1.Show;
end;

procedure TForm2.btnExamplesClick(Sender: TObject);
begin
  if btnExamples.Caption = 'Примеры' then
  begin
    btnExamples.Caption := 'Задание';
    mmoTask.Text := Examples;
  end
  else begin
    btnExamples.Caption := 'Примеры';
    mmoTask.Text := TaskText;
  end;
end;

procedure TForm2.btnAnsClick(Sender: TObject);
begin
  if answer <> mmoAns.Text then
  begin
    mmoAns.Font.Color := clMaroon;
    lblStatus.Caption := 'Wrong';
    lblStatus.Font.Color := clMaroon;
    lblStatus.Left := 216;
  end else
  begin
    mmoAns.Font.Color := clGreen;
    lblStatus.Caption := 'Ok';
    lblStatus.Font.Color := clGreen;
    lblStatus.Left := 226;
    mmoAns.Text := '';
    NextQuestion(taskNum);
  end;
  SaveStats;
  lblStatus.Visible := true;
end;

procedure TForm2.mmoAnsChange(Sender: TObject);
begin
  mmoAns.Font.Color := clWindowText;
  lblStatus.Visible := false;
end;

procedure TForm2.btnFrmOutClick(Sender: TObject);
var f : TextFile;
    full,tmp: string;
begin
  try
    AssignFile(f,'output.txt');
    Reset(f); tmp := ''; full := '';
    while not Eof(f) do
    begin
      Readln(f,tmp);
      full := full+tmp;
      if not Eof(f) then full := full+#13#10;
    end;
    CloseFile(f);
    mmoAns.Text := full;
  except
  end;
end;

procedure TForm2.FormCreate(Sender: TObject);
begin
    Form2.Left := Screen.Width div 2 - Form2.Width div 2;
    Form2.Top := Screen.Height div 2 - Form2.Height div 2;
end;

end.
