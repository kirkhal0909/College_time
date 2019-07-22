unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls, Menus;

type
  TForm1 = class(TForm)
    mmoNumbers: TMemo;
    EdtInpElm: TEdit;
    btnAdd: TButton;
    btnNew: TButton;
    pmEmpty: TPopupMenu;
    lblInpElm: TLabel;
    lblInpElm2: TLabel;
    btnCalc: TButton;
    lblMinMax: TLabel;
    lblInpElm3: TLabel;
    lblInpElm4: TLabel;
    edtMin: TEdit;
    edtMax: TEdit;
    lblInpElm5: TLabel;
    procedure EdtInpElmKeyPress(Sender: TObject; var Key: Char);
    procedure FormCreate(Sender: TObject);
    procedure btnAddClick(Sender: TObject);
    procedure AddRand(New: Boolean);
    procedure btnCalcClick(Sender: TObject);
    procedure btnNewClick(Sender: TObject);
    procedure SaveToFile();
    procedure btn1Click(Sender: TObject);
    procedure mmoNumbersChange(Sender: TObject);
    procedure edtMinKeyPress(Sender: TObject; var Key: Char);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

uses StrUtils;
const maxDigits = 3;
      txtFile = '����������';
      formHeight = 380;
      formWidth = 502;

var saved : Boolean;
    exe : string;
    pathToFile : string;
    min,max : integer;

{$R *.dfm}
{$AppType CONSOLE}

procedure TForm1.EdtInpElmKeyPress(Sender: TObject; var Key: Char);
begin
  if not (key in ['0'..'9',#8]) then key := #0
  else if (Key <> #8) and (Length(EdtInpElm.Text)>=maxDigits) then key := #0;
end;

procedure TForm1.AddRand(New: Boolean);
var i : Integer;
    numbers : integer;
    tmpValue : string;
    tmp: integer;
begin
  try min := StrToInt(edtMin.text);
  except min := -1000; end;
  try max := StrToInt(edtMax.text);
  except max := 1000; end;
  if min > max then
  begin
     tmp := min;
     min := max;
     max := tmp;
  end;
  if New then mmoNumbers.Clear;
  tmpValue := EdtInpElm.Text;
  if length(tmpValue) > 0 then
    try
    begin
      numbers := StrToInt(tmpValue);
      for i := 1 to numbers do
      begin
        mmoNumbers.Text := mmoNumbers.Text + ' ' + intToStr(Random(max-min+1)+min);
      end;
    end;
    if mmoNumbers.Text[1] = ' ' then begin mmoNumbers.Text := Copy(mmoNumbers.Text,2,length(mmoNumbers.Text)-1); end;
    except begin mmoNumbers.Clear; ShowMessage('� ���� ������� ����� ������ �����') end;
  end else ShowMessage('������� � ���� �����');
end;

function GetConsoleWindow: HWND; stdcall; external kernel32;

procedure TForm1.FormCreate(Sender: TObject);
var tmpParam,nextParam,fl: string;
    i: integer;
    next : integer;
begin
  SetConsoleCP(1251);
  SetConsoleOutputCP(1251);
  Randomize;
  exe := ExtractFileName(Application.ExeName);
  fl := txtFile + '.txt';
  pathToFile := GetCurrentDir+'\'+fl;
  //Form1.Hide;
  //ShowMessage(ParamStr(20000));
  //readln;
  if ParamCount = 0 then
  begin
    try
    Writeln('  �� ��������� ����������� ������ ��� ������ min � max � ����������� ������.'+#13#10
           +'  ����� ����������������� � ������� ����� �������, �������� ���� ����������'+#13#10
           +'  � �������� � ������� - '+exe+' /help');
    except
    end;
    FreeConsole;
    form1.left := Screen.Width div 2 - form1.Width div 2;
    Form1.Top := Screen.Height div 2 - form1.Height div 2;
  end
  else
  begin
    Form1.left := -1000;
    Form1.Width := 0;
    tmpParam := LowerCase(paramStr(1));
    nextParam := LowerCase(paramStr(2));
    if (tmpParam = '/help') or (tmpParam = '-help') or (tmpParam = 'h')
      or (tmpParam = 'help') or (tmpParam = '/h') or (tmpParam = '-h') then
      begin
         Writeln('  ����������� ������ ������ ��� ������ 3-�� ������������'+#13#10
                +'  � 3-�� ����������� ����� �� ��������� ��������� �����.'+#13#10
                +'               -------�����-------'+#13#10
                +'  /random n a b - ����� min � max � ��������� ������ �� n-����� � ��������� [a;b]'+#13#10
                +'  /numbers n1 n2 n3 n4 ... - ����� min � max � �������� ������'+#13#10
                +'               ------�������------'+#13#10
                +'  '+exe+' - ��������� ����������� ������ � ����������� ������'+#13#10
                +'  '+exe+' /random 30 -7 134 - ����� min � max � ��������� ������ �� 30 ����� � ��������� [-7;134]'+#13#10
                +'  '+exe+' /random 22 - ����� min � max � ��������� ������ �� 22 ����� � ��������� [-1000;1000]'+#13#10
                +'  '+exe+' /numbers 8 3 0 -14 12 15 - ����� min � max � �������� ������'+#13#10
                +'  '+exe+' /random 18 /numbers 3 2 1 - ��������� ��������� ����� �� 18 ����� � �������� ���� �����. ����� 3 max � 3 min � ���� ������');
      end
    else if (tmpParam = '/random') or (tmpParam = '-random') or (tmpParam = 'random')
        or (tmpParam = '/r') or (tmpParam = '-r') or (tmpParam = 'r') then
            try begin
               if StrToInt(nextParam) < 1 then Writeln('  ����� ������ �������� ���� �� �� ������ �����')
               else begin
                   EdtInpElm.Text := IntToStr(Abs(StrToInt(nextParam)));
                   edtMin.Text := ParamStr(3);
                   edtMax.Text := ParamStr(4);

                   next := 0;
                   tmpParam := ParamStr(3);
                   if (tmpParam = '/numbers') or (tmpParam = '-numbers') or (tmpParam = 'numbers')
                        or (tmpParam = '/n') or (tmpParam = '-n') or (tmpParam = 'n') then next := 3;
                   tmpParam := ParamStr(4);
                   if (tmpParam = '/numbers') or (tmpParam = '-numbers') or (tmpParam = 'numbers')
                        or (tmpParam = '/n') or (tmpParam = '-n') or (tmpParam = 'n') then next := 4;
                   tmpParam := ParamStr(5);
                   if (tmpParam = '/numbers') or (tmpParam = '-numbers') or (tmpParam = 'numbers')
                        or (tmpParam = '/n') or (tmpParam = '-n') or (tmpParam = 'n') then next := 5;
                   if next >2 then
                   begin
                       try
                          if ParamStr(next+1) = '' then begin Writeln('  �� �� ����� ����� ����� ����� /numbers !!!'); Application.Terminate; Exit; end;
                          mmoNumbers.Clear;
                          for i := next+1 to ParamCount do
                          begin
                            IntToStr(strToInt(ParamStr(i)));
                            mmoNumbers.Text := mmoNumbers.Text+' '+ ParamStr(i);
                          end;
                          btnAddClick(btnAdd);
                          btnCalcClick(btnCalc);
                          Writeln(mmoNumbers.Text);
                          Writeln('  '+lblMinMax.Caption);
                          Writeln('  ��������� ������� �� ���������� ���� - '+pathToFile);
                       except
                          Writeln('  ���������� ��������� �������, ��� ��� "'+paramStr(i)+'" �� �������� ������!!!');
                       end;
                   end
                   else
                   begin
                     btnNewClick(btnNew);
                     btnCalcClick(btnCalc);
                     Writeln('  ��������� ����� �� ��������� ['+inttostr(min)+';'+inttostr(max)+']:');
                     Writeln(mmoNumbers.Text);
                     Writeln('  '+lblMinMax.Caption);
                     Writeln('  ��������� ������� �� ���������� ���� - '+pathToFile);
                   //Writeln('-------------------------------------');
                   //Writeln('��������� ������� ');
                   end;
                end;
            end
            except
               if nextParam = '' then Writeln('  �� �� ����� ����� ������ ����� /random !!!')
               else Writeln('  ���������� ��������� �������, ��� ��� "'+nextParam+'" �� �������� ������!!!');
            end
    else if (tmpParam = '/numbers') or (tmpParam = '-numbers') or (tmpParam = 'numbers')
        or (tmpParam = '/n') or (tmpParam = '-n') or (tmpParam = 'n') then
        begin
          try
            if ParamStr(2) = '' then begin Writeln('  �� �� ����� ����� ����� ����� /numbers !!!'); Application.Terminate; Exit; end;
            mmoNumbers.Clear;
            for i := 2 to ParamCount do
            begin
              IntToStr(strToInt(ParamStr(i)));
              mmoNumbers.Text := mmoNumbers.Text+' '+ ParamStr(i);
            end;
            btnCalcClick(btnCalc);
            Writeln('  '+lblMinMax.Caption);
            Writeln('  ��������� ������� �� ���������� ���� - '+pathToFile);
          except
            tmpParam := ParamStr(i);
            if (tmpParam = '/random') or (tmpParam = '-random') or (tmpParam = 'random')
                or (tmpParam = '/r') or (tmpParam = '-r') or (tmpParam = 'r') then
                  try
                  begin
                    nextParam := ParamStr(i+1);
                     if StrToInt(nextParam) < 1 then Writeln('  ����� ������ �������� ���� �� �� ������ �����')
                     else begin
                         EdtInpElm.Text := IntToStr(Abs(StrToInt(nextParam)));
                         edtMin.Text := ParamStr(i+2);
                         edtMax.Text := ParamStr(i+3);

                         btnAddClick(btnAdd);
                         btnCalcClick(btnCalc);
                         Writeln(mmoNumbers.Text);
                         Writeln('  '+lblMinMax.Caption);
                         Writeln('  ��������� ������� �� ���������� ���� - '+pathToFile);
                     end;
                   end;
                   except
                     if nextParam = '' then Writeln('  �� �� ����� ����� ������ ����� /random !!!')
                     else Writeln('  ���������� ��������� �������, ��� ��� "'+nextParam+'" �� �������� ������!!!');
                   end else Writeln('  ���������� ��������� �������, ��� ��� "'+paramStr(i)+'" �� �������� ������!!!');
          end;
        end
    else Writeln('  ����� �������� ������, ������� - '+exe+' /help');
    Application.Terminate;
  end;
  //Application.Terminate;
  //Application.ShowMainForm:=false;
  saved := true;
end;

procedure TForm1.btnAddClick(Sender: TObject);
begin
  AddRand(false);
end;

procedure TForm1.btnCalcClick(Sender: TObject);
const elms = 3;
var min,max: array [1..elms] of integer;
    bg,i,j,k,k2: Integer;
    tmpInt,tmp: integer;
    mainStr,msg: string;
    next,chmax,chmin: Boolean;
    numIsMinus : boolean;
begin
  bg := MaxInt;
  for i := 1 to elms do begin min[i] := bg; max[i] := -bg end;
  mainStr := mmoNumbers.Text;
  tmpInt := 0; numisMinus := false;
  next := false;
  for i := 1 to Length(mainStr) do
  begin
    if not (mainStr[i] in ['0'..'9']) then
    begin
      if mainStr[i] = '-' then numIsMinus := true;
      if next then begin
        //showmessage(inttostr(tmpInt));
        chmax := true; chmin := True;
        if numIsMinus then
        begin
          tmpInt := -tmpInt;
          numIsMinus := false;
        end;
        for j := 1 to elms do
        begin
          if (tmpInt <= min[j]) and (chmin) then
          begin
              for k := elms downto j+1 do min[k] := Min[k-1];
              //ShowMessage(IntToStr(k));
              min[j] := tmpInt;
              //tmpInt := tmp;
              chmin := False;
          end;
          if (tmpInt >= max[j]) and (chmax) then
          begin
              for k := elms downto j+1 do max[k] := Max[k-1];
              max[j] := tmpInt;
              chmax := False;
          end;

        end;
        {for k := 1 to elms do
          For k2 := elms downto k+1 do
               begin
                 if min[k2]<min[k2-1] then
                 begin
                   tmpInt := Min[k2];
                   min[k2] := Min[k2-1];
                   min[k2-1] := tmpInt;
                 end;
               end;}
               //for k := elms downto 1 do ShowMessage(inttostr(min[k]));
               //ShowMessage('next');
        tmpInt := 0;
        next := false;
      end;
    end
    else begin tmpInt := tmpInt*10+StrToInt(mainStr[i]); next := true; end;
   end;
        if numIsMinus then
        begin
          tmpInt := -tmpInt;
          numIsMinus := false;
        end;
        if next then begin
        chmax := true; chmin := True;
        for j := 1 to elms do
        begin
          if (tmpInt <= min[j]) and (chmin) then
          begin
              for k := elms downto j+1 do min[k] := Min[k-1];
              //ShowMessage(IntToStr(k));
              min[j] := tmpInt;
              //tmpInt := tmp;
              chmin := False;
          end;
          if (tmpInt >= max[j]) and (chmax) then
          begin
              for k := elms downto j+1 do max[k] := Max[k-1];
              max[j] := tmpInt;
              chmax := False;
          end;
        end;
        end;
  //for i := 1 to elms do ShowMessage(IntToStr(Min[i])+' '+IntToStr(Max[i]));
  if min[1] = bg then begin ShowMessage('������� ����� �����'); Exit; end;
  msg := 'min ';
  for i := 1 to elms do if min[i] <> bg then msg := msg+inttostr(Min[i])+',' else Break;
  msg[Length(msg)] := ';'; msg := msg+' max ';
  for i := elms downto 1 do if max[i] <> -bg then msg := msg+inttostr(Max[i])+',';
  msg[Length(msg)] := #0;
  lblMinMax.Caption := msg;
  if (min[1] <> bg) and (not(saved)) then begin SaveToFile; end;
end;

procedure Tform1.SaveToFile();
const sep = '***************************************';
      sep2 = '---';
var f : TextFile;
    fName: string;
    today : TDateTime;
begin
    //sep := '---------------------------------------';
    fName := txtFile+'.txt';
    AssignFile(f,fName);
    today := Now;
    if FileExists(fName) then Append(f) else Rewrite(f);
    writeln(f,''); writeln(f,'');
    Writeln(f,sep);
    Writeln(f,mmoNumbers.Text);
    Writeln(f,sep2);
    Writeln(f,lblMinMax.Caption);
    Writeln(f,sep2);
    Writeln(f,DateToStr(today)+' '+TimeToStr(today));


    CloseFile(f);
    saved := true;
end;

procedure TForm1.btnNewClick(Sender: TObject);
begin
  AddRand(true);
end;

procedure TForm1.btn1Click(Sender: TObject);
begin
SaveToFile;
end;

procedure TForm1.mmoNumbersChange(Sender: TObject);
begin
  saved := false;
end;

procedure TForm1.edtMinKeyPress(Sender: TObject; var Key: Char);
begin
  if (Length((Sender as TEdit).Text) > 0) and (Key = '-') then key := #0;
  if not (key in ['0'..'9',#8,'-']) then Key := #0;
end;

end.
