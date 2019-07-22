unit Options;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, StdCtrls, Menus;

type
  TFormOptions = class(TForm)
    imgEng: TImage;
    imgRus: TImage;
    HotMod: TComboBox;
    edtHotKey: TEdit;
    unsetFocus: TEdit;
    lblFiSl: TLabel;
    edtAutoSleep: TEdit;
    lblHotKeys: TLabel;
    pmNil: TPopupMenu;
    lblLang: TLabel;
    procedure FormCreate(Sender: TObject);
    procedure imgRusClick(Sender: TObject);
    procedure edtHotKeyKeyDown(Sender: TObject; var Key: Word;
      Shift: TShiftState);
    procedure HotModChange(Sender: TObject);
    procedure FormClick(Sender: TObject);
    procedure edtAutoSleepKeyPress(Sender: TObject; var Key: Char);
    procedure edtAutoSleepChange(Sender: TObject);
    procedure edtHotKeyChange(Sender: TObject);
    procedure edtHotKeyKeyPress(Sender: TObject; var Key: Char);
  private
    { Private declarations }
  public
    procedure ChangeLanguage;
    procedure RegHotKey(var key : word; modK : integer);
    procedure ReadOptions;
    procedure WriteOptions;
    { Public declarations }
  end;

var
  FormOptions: TFormOptions;

implementation
uses Unit1;

{$R *.dfm}

const FolderOptions = 'BotAct';
var KeyHot : word = VK_F1; modKey : integer = MOD_CONTROL;
    FileOptions : string = 'Options.bao';
    lclapp,pathF: string;

const lblsEng : array[1..3] of string = ('   Auto sleep','     Hot keys','Language:');
      lblsRus : array[1..3] of string = ('јвто задержка','√ор€чии клавиши','    язык:');

procedure TFormOptions.ChangeLanguage;
var i,j: integer;
    ind : byte;
begin
  case Language of
    //Eng
    0 : begin
       Self.Caption := mniOptionsEng[0];
       Self.lblFiSl.Caption := lblsEng[1];
       Self.lblHotKeys.Caption := lblsEng[2];
       Self.lblLang.Caption := lblsEng[3];
       imgRus.Visible := false;
       imgEng.Visible := true;
       with Form1 do
       begin
         mniFile.Caption := mniFileEng[0];
         mniNew.Caption := mniFileEng[1];
         mniOpen.Caption := mniFileEng[2];
         mniSave.Caption := mniFileEng[3];
         mniSaveAs.Caption := mniFileEng[4];
         mniOptions.Caption := mniOptionsEng[0];
         //mniAbout.Caption := mniAboutEng[0];
       end;
    end;
    //Rus
    1 : begin
       Self.Caption := mniOptionsRus[0];
       Self.lblFiSl.Caption := lblsRus[1];
       Self.lblHotKeys.Caption := lblsRus[2];
       Self.lblLang.Caption := lblsRus[3];
       imgEng.Visible := false;
       imgRus.Visible := true;

       with Form1 do
       begin
         mniFile.Caption := mniFileRus[0];
         mniNew.Caption := mniFileRus[1];
         mniOpen.Caption := mniFileRus[2];
         mniSave.Caption := mniFileRus[3];
         mniSaveAs.Caption := mniFileRus[4];

         mniOptions.Caption := mniOptionsRus[0];
//         mniAbout.Caption := mniAboutRus[0];
       end;
     end;
  end;
  for i := 1 to CountActs do
  begin
    Ind := ListActs[i].ItemIndex;
    for j := 0 to NumOfActs-1 do
    case Language of
      0: begin
        ListActs[i].Hint := ListActsHintEng;
        ListActs[i].Items[j] := ListActsEng[j+1];
      end;
      1: begin
        ListActs[i].Hint := ListActsHintRus;
        ListActs[i].Items[j] := ListActsRus[j+1];
      end;
    end;
    ListActs[i].ItemIndex := Ind;

    case Ind of
      1: begin
        case Language of
          0: begin
            Edit[2][i].Hint := CoordsHintEng;
            Edit[4][i].Hint := CoordsHintEng;
          end;
          1: begin
            Edit[2][i].Hint := CoordsHintRus;
            Edit[4][i].Hint := CoordsHintRus;
          end;
        end;
      end;
      2: begin
        case Language of
          0: begin
            Edit[3][i].Hint := SleepHintEng;
          end;
          1: begin
            Edit[3][i].Hint := SleepHintRus;
          end;
        end;
      end;
      3: begin
        case Language of
          0: begin
            Edit[2][i].Hint := RepeatFromHintEng;
            Edit[3][i].Hint := RepeatToHintEng;
            Edit[4][i].Hint := RepeatCycHintEng;
          end;
          1: begin
            Edit[2][i].Hint := RepeatFromHintRus;
            Edit[3][i].Hint := RepeatToHintRus;
            Edit[4][i].Hint := RepeatCycHintRus;
          end;
        end;
      end;
    end;

    if ListEvents[i] <> nil then
    begin
      Ind := ListEvents[i].ItemIndex;
      for j := 0 to NumOfEvents-1 do
      case Language of
        0: begin
          ListEvents[i].Hint := ListEventHintEng;
          ListEvents[i].Items[j] := ListEventsEng[j+1];
        end;
        1: begin
          ListEvents[i].Hint := ListEventHintRus;
          ListEvents[i].Items[j] := ListEventsRus[j+1];
        end;
      end;
      ListEvents[i].ItemIndex := Ind;
    end;

    if ListMouseKeys[i] <> nil then
    begin
      Ind := ListMouseKeys[i].ItemIndex;
      for j := 0 to NumOfEvents-1 do
      case Language of
        0: begin
          ListMouseKeys[i].Hint := ListMouseKeysHintEng;
          ListMouseKeys[i].Items[j] := ListMouseKeysEng[j+1];
        end;
        1: begin
          ListMouseKeys[i].Hint := ListMouseKeysHintRus;
          ListMouseKeys[i].Items[j] := ListMouseKeysRus[j+1];
        end;
      end;
      ListMouseKeys[i].ItemIndex := Ind;
    end;
  end;
end;

procedure TFormOptions.ReadOptions;
var F : TextFile;
  info : string;
begin
  try
    Reset(F,pathF);
    Readln(F,info);
    CloseFile(F);
    Language := strtoint(copy(info,1,pos(';',info)-1)); info := copy(info,pos(';',info)+1,length(info));
    ChangeLanguage;
    edtAutoSleep.Text := copy(info,1,pos(';',info)-1); info := copy(info,pos(';',info)+1,length(info));
    autoSleep := StrToInt(edtAutoSleep.Text);
    modKey := strtoint(copy(info,1,pos(';',info)-1)); info := copy(info,pos(';',info)+1,length(info));

   if modKey = 0 then HotMod.ItemIndex := modKey
   else if modKey = MOD_ALT then HotMod.ItemIndex := 1
   else if modKey = MOD_CONTROL then HotMod.ItemIndex := 2
   else if modKey = MOD_SHIFT then HotMod.ItemIndex := 3
   else if modKey = MOD_WIN then HotMod.ItemIndex := 4;

    KeyHot := StrToInt(info);
    edtHotKeyKeyDown(edtHotKey,KeyHot,KeysToShiftState(0));
    RegHotKey(KeyHot,modKey);
    //showmessage(info);
  except end;
end;

procedure TformOptions.WriteOptions;
var F : TextFile;
  info : string;
begin
  info := '';
  try info := IntToStr(Language)+';'; except info := info + '0;' end;
  try info := info+IntToStr(autoSleep)+';'; except info := info + '0;' end;
  try info := info+IntToStr(modKey)+';'; except info := info + '0;' end;
  try info := info+IntToStr(KeyHot); except info := info + '0' end;
  Rewrite(F,pathF);
  Writeln(F,info);
  CloseFile(F);
end;

procedure TFormOptions.FormCreate(Sender: TObject);
begin
  //Path to options in appData/local
  lclapp := GetEnvironmentVariable('LocalAppData')+'\'+FolderOptions;
  pathF := lclapp+'\'+FileOptions;
  if not(DirectoryExists(lclapp)) then
    if not (CreateDir(lclapp)) then begin lclapp := ''; lclapp := FolderOptions; CreateDir(lclapp); end;
  //Create or read options
  pathF := lclapp+'\'+FileOptions;
  if not (FileExists(PathF)) then WriteOptions
  else ReadOptions;
  ChangeLanguage;
end;

procedure TFormOptions.imgRusClick(Sender: TObject);
begin
   inc(Language);
   if Language > 1 then Language := 0;
   WriteOptions;
   ChangeLanguage;
end;

procedure TformOptions.RegHotKey(var key : word; modK : integer);
const Main_ID = 1;
begin
  UnregisterHotKey(Application.MainForm.Handle,Main_ID);
  if modKey = 22 then RegisterHotKey(Application.MainForm.Handle,Main_ID,MOD_SHIFT,key)
  else if modKey = 33 then RegisterHotKey(Application.MainForm.Handle,Main_ID,MOD_WIN,key)
  else RegisterHotKey(Application.MainForm.Handle,Main_ID,modk,key);
  //showmessage(inttostr(modkey));
end;

procedure TFormOptions.edtHotKeyKeyDown(Sender: TObject; var Key: Word;
  Shift: TShiftState);
begin
  case Key of
    8: (sender as TEdit).text := 'Bks';
    13: (sender as TEdit).text := 'Entr';
    16: (sender as TEdit).text := 'Shf';
    17: (sender as TEdit).text :=  'Ctrl';
    18: (sender as TEdit).text := 'Alt';
    20: (sender as TEdit).text := 'Cps';
    145: (sender as TEdit).text := 'ScrL';
    45: (sender as TEdit).text := 'Ins';
    46: (sender as TEdit).text := 'DDel';
    33: (sender as TEdit).text := 'PgUp';
    34: (sender as TEdit).text := 'PgDn';
    144: (sender as TEdit).text := 'NumL';
    37: (sender as TEdit).text := 'Left';
    38: (sender as TEdit).text := 'Up';
    39: (sender as TEdit).text := 'Rght';
    40: (sender as TEdit).text := 'Down';
    91: begin
       (sender as TEdit).text := 'Win';
       sleep(250);
       keybd_event(VK_LWIN,0,0,0); keybd_event(VK_LWIN,0,2,0);
     end;
 //   192: (sender as TEdit).text := '`';
    27: (sender as TEdit).text := 'Esc';
    35: (sender as TEdit).text := 'End';
    36: (sender as TEdit).text := 'Home';
{    219: (sender as TEdit).text := '[';
    220: (sender as TEdit).text := '\';
    221: (sender as TEdit).text := ']';
    186: (sender as TEdit).text := ';';
    188: (sender as TEdit).text := ',';
    190: (sender as TEdit).text := '.';
    191: (sender as TEdit).text := '/';
    222: (sender as TEdit).text := '''';}
    112..123: (sender as TEdit).text := 'F'+inttostr(Key-111);
    else (sender as TEdit).text := chr(key);//chr(key);
  end;
  KeyHot := Key;
  RegHotKey(KeyHot,modKey);
  WriteOptions;
end;

procedure TFormOptions.HotModChange(Sender: TObject);
begin
  case HotMod.ItemIndex of
    0 : modKey := 0;
    1: modKey := MOD_ALT;
    2: modKey := MOD_CONTROL;
    3: modKey := MOD_SHIFT;
    4: modKey := MOD_WIN;         
  end;
  WriteOptions;
  RegHotKey(KeyHot,modKey);
end;

procedure TFormOptions.FormClick(Sender: TObject);
begin
  unsetFocus.SetFocus;
end;

procedure TFormOptions.edtAutoSleepKeyPress(Sender: TObject;
  var Key: Char);
begin
  if not (key in ['0'..'9',#8]) then key := #0;
end;

procedure TFormOptions.edtAutoSleepChange(Sender: TObject);
begin
  try autoSleep := StrToInt((Sender as TEdit).Text); Except autoSleep := 0; end;
  //ShowMessage(IntToStr(autoSleep));
  WriteOptions;
end;

procedure TFormOptions.edtHotKeyChange(Sender: TObject);
begin
  WriteOptions;
end;

procedure TFormOptions.edtHotKeyKeyPress(Sender: TObject; var Key: Char);
begin
  Key := #0;
end;

end.
