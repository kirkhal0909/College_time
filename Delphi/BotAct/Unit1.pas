unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, StdCtrls, Menus, Buttons, ShellApi, AppEvnts;

const WM_ICONTRAY = WM_User+1;

type
  TNewThread = class(TThread)
    private
      {}
    public
      procedure Execute; override;
      procedure DoAct(Var PanelN:integer);
      procedure LockPanels(Var Lock:Boolean);
    end;
  TForm1 = class(TForm)
    pnlKeybd: TPanel;
    ListActions: TComboBox;
    InpKey: TEdit;
    edtNum: TEdit;
    ListEvent: TComboBox;
    pnlMouse: TPanel;
    cbb1: TComboBox;
    edt2: TEdit;
    cbb2: TComboBox;
    InpInt: TEdit;
    InpXY: TEdit;
    btnAddPnl: TButton;
    Panel1: TPanel;
    ComboBox1: TComboBox;
    Edit1: TEdit;
    Edit2: TEdit;
    mm: TMainMenu;
    mniFile: TMenuItem;
    mniOpen: TMenuItem;
    mniSave: TMenuItem;
    mniSaveAs: TMenuItem;
    mniNew: TMenuItem;
    mniOptions: TMenuItem;
    Panel2: TPanel;
    ComboBox2: TComboBox;
    Edit3: TEdit;
    Edit4: TEdit;
    edt1: TEdit;
    btnRemove: TBitBtn;
    btn1: TBitBtn;
    btnDelT: TBitBtn;
    btn3: TBitBtn;
    ListMouseKeyses: TComboBox;
    aplctnvnts: TApplicationEvents;
    procedure mniOptionsClick(Sender: TObject);
    procedure mniAboutClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure addAct(ActPos: integer);
    procedure deleteAct(Num: integer);
    procedure btnAddPnlClick(Sender: TObject);
    procedure btnDelTClick(Sender: TObject);
    procedure ListActionsChange(Sender: TObject);
    procedure InpIntChange(Sender: TObject);
    procedure InpKeyKeyDown(Sender: TObject; var Key: Word;
      Shift: TShiftState);
    procedure InpKeyKeyPress(Sender: TObject; var Key: Char);
    procedure InpIntKeyPress(Sender: TObject; var Key: Char);
    procedure InpXYKeyDown(Sender: TObject; var Key: Word;
      Shift: TShiftState);
    procedure InpXYKeyUp(Sender: TObject; var Key: Word;
      Shift: TShiftState);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure mniOpenClick(Sender: TObject);
    procedure mniSaveClick(Sender: TObject);
    procedure mniNewClick(Sender: TObject);
    procedure mniSaveAsClick(Sender: TObject);
    procedure aplctnvntsMinimize(Sender: TObject);
  private
    { Private declarations }
  public
    TrayIconData : TNotifyIconData;
    procedure TrayMessage(var Msg: TMessage); message WM_ICONTRAY;
    function GetNumOfPanel(NameObj: string) : integer;
    procedure CheckTab(Var Msg: TWMKey); message CM_DIALOGKEY;
    procedure StartStop(Var Msg : TWMHotKey); message WM_Hotkey;
    procedure CreateDelBtn(var Sender: TBitBtn; PanelN : Integer);
    procedure CreateEdit(var Sender: TEdit; PanelN : Integer);
    procedure CreateComboBox(var Sender: TComboBox; PanelN : Integer);
    procedure CreateAddBtn(var Sender: TButton; PanelN : Integer);
    procedure Scrolling(Var Msg: TWMMouseWheel); message WM_MOUSEWHEEL;
    procedure ShiftActsFrom(Var Frm : integer);
    procedure ShiftActsBack(Var B : integer);

    procedure OpenScript(Var F : String);
    procedure SaveScript(Var F : String);
    function OpenDlg(Var DlgT : string) : Boolean;
    function CheckSave(Var Ext : byte) : Boolean;

    { Public declarations }
  end;

const Progrm = 'BotAct';
      FormWidth = 610;
      PanelHeight = 42;
      FormHeight = PanelHeight*9+10;
      PanelColor = clGrayText;
    fontSizeText = 14; heightObjs = 30;
    TopObj = (PanelHeight-heightObjs) div 2-1;
    sizeBtnDel = 30; leftBtnDel = 5;
    sizeBtnAdd = 32;
    spaceBetween = 10;
    widthNumOfAct = 60;// leftNumOfAct = 10;
    widthListActs = 120;// leftListActs = 10;
    widthListEvents = 90;
    //mouse
    widthListMouseKeys = 64;
    widthEdtInp = 60;
    //sleep
    WidthInpMlSec = 100;
    //Repeat
    WidthInpRepeat = 60;

  Objs = 1000;
  MaxEdits = 4;
  BtnDelName = 'Del';
  BtnDelAdd = 'Add';
  ComboEventsName = 'Event';
  EditInpKey = 'InpKey';
//Lists for localization
const NumOfActs = 4;
      ListActsHintEng = 'Enter action from list';
      ListActsHintRus = 'Выберите действие из списка';
      ListActsEng : array[1..NumOfActs] of string = ('Keyboard','Mouse','Sleep','Repeat');
      ListActsRus : array[1..NumOfActs] of string = ('Клавиатура','Мышь','Задержка','Повторение');
      NumOfEvents = 3;
      ListEventHintEng = {'Enter event from list:'
                 +#13#10+}'Down - just press on button'
                 +#13#10+'Up - unpress button after Down event'
                 +#13#10+'Press - do Down and after Up event';
      ListEventHintRus = {'Выберите событие из списка'
                 +#13#10+}'Down - просто нажать на кнопку'
                 +#13#10+'Up - отжать кнопку после Down события'
                 +#13#10+'Нажать - выполнить Down и потом Up событие';
      ListEventsEng : array[1..NumOfEvents] of string = ('Press','Down','Up');
      ListEventsRus : array[1..NumOfEvents] of string = ('Нажать','Down','Up');
      NumOfMouseKeys = 3;
      ListMouseKeysHintEng = 'LMB - left mouse button'
                     +#13#10+'RMB - right mouse button'
                     +#13#10+'MMB - middle mouse button';
      ListMouseKeysHintRus = 'ЛКМ - левая кнопка мыши'
                     +#13#10+'ПКМ - правая кнопка мыши'
                     +#13#10+'СКМ - средняя кнопка мыши';
      ListMouseKeysEng : array[1..NumOfMouseKeys] of string = ('LMB','RMB','MMB');
      ListMouseKeysRus : array[1..NumOfMouseKeys] of string = ('ЛКМ','ПКМ','СКМ');
      CoordsHintEng = 'Click on edit box and then You can press Ctrl for'
              +#13#10+'choosed needed position and can press needed mouse button.';
      CoordsHintRus = 'Кликните по полю и нажав на Ctrl, Вы можете выбрать'
              +#13#10+'нужные координаты и так же Вы можете нажать на нужную клавишу мыши';
      //'Нажмите Ctrl, выберите нужную позицию и нажмите на нужную кнопку мыши.';

      SleepHintEng = 'Write needed time of sleep in milliseconds';
      SleepHintRus = 'Введите нужное время задержки в миллисекундах.';

      RepeatFromHintEng = 'Write number of action, from which You need repeat.';
      RepeatFromHintRus = 'Введите номер действия, с которого Вам нужно повторять.';
      RepeatToHintEng = 'Write number of action, to which You need repeat.';
      RepeatToHintRus = 'Введите номер действия, до которого Вам нужно повторять.';
      RepeatCycHintEng = 'Write number of repeats.'
                 +#13#10+'0 - endless cycle'
                 +#13#10+'1..N - number of repeats';
      RepeatCycHintRus = 'Введите число повторений.'
                 +#13#10+'0 - бесконечный цикл'
                 +#13#10+'1..N - число повторов';

      //Main Menu
      mniFileEng : array[0..4] of string = ('File','New','Open','Save','Save as...');
      mniFileRus : array[0..4] of string = ('Файл','Создать','Открыть','Сохранить','Сохранить как...');
      openFileEng : string = 'File not found';
      openFileRus : string = 'Файл не найден';
      mniOptionsEng : array[0..0] of string = ('Options');
      mniOptionsRus : array[0..0] of string = ('Настройки');
      mniAboutEng : array[0..0] of string = ('About');
      mniAboutRus : array[0..0] of string = ('Об');

      dlgSaveReplaceEng : string = 'The file exists! You want rewrite this file?';
      dlgSaveReplaceRus : string = 'Такой файл уже есть! Вы хотите его перезаписать?';
      dlgSaveEng : string = 'You have not save your changes. Save?';
      dlgSaveRus : string = 'Вы не сохранили свои изменения. Сохранить?';
//      dlgSaveRus : string = 'Вы хотите сохранить Ваши изменения в файл?';

var
  Form1: TForm1;
  //Objects for actions
  CountActs : integer = 0;
  HidenActs : integer = 0;
  Panel : array[1..Objs] of TPanel;
  OverGround : TPanel;
  BtnDel : array[1..Objs] of TBitBtn;
  BtnAdd : array[1..Objs] of TButton;
  //NumAct : array[1..Objs] of TEdit;
  ListActs : array[1..Objs] of TComboBox;
  ListEvents : array[1..Objs] of TComboBox;
  ListMouseKeys : array[1..Objs] of TComboBox;
  Edit : array[1..MaxEdits,1..Objs] of TEdit;
  Language : integer = 0;
  autoSleep : integer = 1000;


implementation
uses Options,Mouse{, Math};

const extension = '.bas';

var //LasTX : integer = -1; LastY : integer = -1;
    status : bool = false;
    thread : TNewThread;
    Saved : Boolean = true;
    FileActs : string = '';
    FormCap : string;

{$R fileinfo.RES}
{$R *.dfm}

procedure TNewThread.LockPanels(Var Lock : Boolean);
var i,j: integer;
begin
  Lock := not Lock;
  //Lock\unlock all panels
  for i := 1 to CountActs do
  begin
    Panel[i].Enabled := Lock;
    for j := 2 to MaxEdits do
      if Edit[j][i] <> nil then Edit[j][i].Enabled := Lock;
    if ListActs[i] <> nil then ListActs[i].Enabled := Lock;
    if ListEvents[i] <> nil then ListEvents[i].Enabled := Lock;
    if ListMouseKeys[i] <> nil then ListMouseKeys[i].Enabled := Lock;
  end;
end;

procedure TNewThread.DoAct(Var PanelN:integer);
  var tempS :String;
    tempInt : integer;
    tempMouse : array[1..4] of integer;
    P : TPoint;
    slp : integer;
    RptBeg,RptEnd,Rpts: integer;
    j : integer;
begin
  //Check panels and do acts
  if PanelN<=CountActs then
  case ListActs[PanelN].ItemIndex of
        //Keyboard
      0: begin
          tempInt := strtoint(Edit[3][PanelN].text);
          case ListEvents[PanelN].ItemIndex of
            //Press key
            0: begin
                 keybd_event(tempInt,0,0,0);
                 keybd_event(tempInt,0,2,0);
               end;
            //Down
            1: keybd_event(tempInt,0,0,0);
            //Up
            2: keybd_event(tempInt,0,2,0);
          end;
      end;
        //Mouse
      1: begin
            //Get event
          case ListMouseKeys[PanelN].ItemIndex of
            0: begin tempMouse[1] := MOUSEEVENTF_ABSOLUTE or  MOUSEEVENTF_LEFTDOWN;
             tempMouse[2] := MOUSEEVENTF_ABSOLUTE or  MOUSEEVENTF_LEFTUP; end;
            1: begin tempMouse[1] := MOUSEEVENTF_ABSOLUTE or  MOUSEEVENTF_RIGHTDOWN;
            tempMouse[2] := MOUSEEVENTF_ABSOLUTE or  MOUSEEVENTF_RIGHTUP; end;
            2: begin tempMouse[1] := MOUSEEVENTF_ABSOLUTE or  MOUSEEVENTF_MIDDLEDOWN;
            tempMouse[2] := MOUSEEVENTF_ABSOLUTE or  MOUSEEVENTF_MIDDLEUP; end;
          end;
          //X
          try tempMouse[3] := StrToInt(Edit[2][PanelN].Text); except tempMouse[3] := 0; end;
          if tempMouse[3] > screen.Width then tempMouse[3] := screen.Width;
          //Y
          try tempMouse[4] := StrToInt(Edit[4][PanelN].Text); except tempMouse[4] := 0; end;
          if tempMouse[4] > screen.Height then tempMouse[4] := screen.Height;

          //Move mouse to X Y
          GetCursorPos(p);
          //if (LastX <> p.X) or (LastY <> p.Y) then
          while ((p.X <> tempMouse[3]) or (p.Y <> tempMouse[4])) do
          begin
            GetCursorPos(p);
            p.X := Round((tempMouse[3]-p.X) / 2);
            p.Y := Round((tempMouse[4]-p.Y) / 2);
            mouse_event(MOUSEEVENTF_MOVE,p.X,p.Y,0,0);
            if (P.X = 0) and (P.Y = 0) then break;
          end;
{          if (p.X = -1) and (p.Y = -1) then begin GetCursorPos(p); LasTX := p.X; LastY := p.Y; end
          else begin LastX := -1; LastY := -1; end;}
          case ListEvents[PanelN].ItemIndex of
            //Press
            0: begin
                 mouse_event(tempMouse[1],0,0,0,0);
                 mouse_event(tempMouse[2],0,0,0,0);
               end;
            //Down
            1: mouse_event(tempMouse[1],0,0,0,0);
            //Up
            2: mouse_event(tempMouse[2],0,0,0,0);
          end;
       end;
        //Sleep
      2: begin tempS := Edit[3][PanelN].Text;
          try
            slp := StrToInt(tempS);
{            while slp >= slpCheck do
            begin
              //dec(slp,slpCheck);
              slp := slp - slpCheck;
              if status then sleep(slpCheck)
              else break;
            end;}
            sleep(slp);
          except end; end;
        //Repeat
      3: begin
          try
            RptBeg := strtoint(Edit[2][PanelN].Text);
            RptEnd := strtoint(Edit[3][PanelN].Text);
            Rpts := strtoint(Edit[4][PanelN].Text);
            if Rpts = 0 then Rpts := -1;
          except
            Rpts := 0; RptBeg := 1; RptEnd := 0;
          end;
          try
          while (Rpts <> 0) and (status = true) do
          begin
            for j := RptBeg to RptEnd do
              if j <> PanelN then begin if (j <> RptBeg) then Sleep(autoSleep); DoAct(j); end;
            //endless cycle if Rpts < 0 (You can stop, use hot keys)
            if (Rpts > 0) then dec(Rpts);
          end;
          except
          end;
       end;
  end
  else status := false;
end;

procedure TNewThread.Execute;
var i : integer;
    Lock : Boolean;
begin
  //First delay
//  sleep(firstSleep);
  //Lock panels
  Lock := true; Self.LockPanels(Lock);
  //Hide main menu
  Form1.Menu := nil;
  //Get started/stoped
  for i := 1 to CountActs do
  begin
    //Rename caption of main form on active act
    Application.MainForm.Caption := FormCap + ' - ' + inttostr(i);
    Panel[i].Color := clGreen;
    if status then begin Sleep(autoSleep); Panel[i].Color := clMaroon; Self.DoAct(i) end else break;
    Panel[i].Color := PanelColor;
  end;
  status := false;
  //Unlock Panels and return caption
  Lock := false; Self.LockPanels(Lock);
  //Unhide main menu
  Form1.Menu := Form1.mm;
  //Rename caption of main form by default
  Application.MainForm.Caption :=FormCap;
end;

//Start|Stop
procedure Tform1.StartStop(Var Msg : TWMHotKey);
var Lock : boolean;
  i : integer;
begin
  status := not status;
  if status then
  begin
    //New thread(Do acts)
    thread:=TNewThread.Create(true);
    thread.FreeOnTerminate:=true;
    thread.Priority:=tpHighest;
    thread.Resume;
  end
  else begin
    //Stop thread
    thread.Terminate;
    for i := 1 to CountActs do
    begin
       Lock := false; thread.LockPanels(Lock);
       Panel[i].Color := PanelColor;
    end;
    Form1.Menu := Form1.mm;
    Application.MainForm.Caption := FormCap;
  end;
end;

//Scrolling on panels
procedure Tform1.Scrolling(Var Msg: TWMMouseWheel);
var UpWheel : boolean;
    ScroolPosChange : integer;
begin
  UpWheel := false;
  ScroolPosChange := PanelHeight;
  //Up wheel
  if Msg.WheelDelta > 0 then UpWheel := true;
  if not UpWheel then ScroolPosChange := - ScroolPosChange;
  Self.VertScrollBar.Position := Self.VertScrollBar.Position - ScroolPosChange;

  //Msg.Result := -1;
end;

procedure Tform1.CreateDelBtn(var Sender: TBitBtn; PanelN : Integer);
begin
  Sender := TBitBtn.Create(self); Sender.Parent := Panel[PanelN];
  Sender.Kind := bkCancel; Sender.Height := sizeBtnDel; Sender.Width := sizeBtnDel;
  Sender.Left := leftBtnDel; Sender.Top := (PanelHeight-sizeBtnDel) div 2+1;
  Sender.Name := BtnDelName + inttostr(PanelN); Sender.Caption := '';
  Sender.Cancel := false; Sender.OnClick := btnDelT.OnClick;
  Sender.TabStop := false;
end;

procedure Tform1.CreateEdit(var Sender: TEdit; PanelN : Integer);
var pp : TPopupMenu;
begin
  Sender := TEdit.Create(self); Sender.Parent := Panel[PanelN];
  Sender.Height := heightObjs; Sender.Top := TopObj;
  Sender.Font.Size := fontSizeText; Sender.TabStop := False;
  //Remove default PopupMenu
  pp := TPopupMenu.Create(Self);
  Sender.PopupMenu := pp;
  Sender.ShowHint := true;
end;

procedure Tform1.CreateComboBox(var Sender: TComboBox; PanelN : Integer);
begin
  Sender := TComboBox.Create(Self); Sender.Parent := Panel[PanelN];
  Sender.Height := heightObjs; Sender.Top := TopObj;
  Sender.Font.Size := fontSizeText; Sender.TabStop := False;
  Sender.Style := csDropDownList;
  Sender.ShowHint := true;
end;

procedure Tform1.CreateAddBtn(var Sender: TButton; PanelN : Integer);
begin
  Sender := TButton.Create(Self); Sender.Parent := Panel[PanelN];
  Sender.Height := sizeBtnAdd; Sender.Top := (PanelHeight-sizeBtnAdd) div 2+1;
  Sender.Width := sizeBtnAdd;
  Sender.Name := BtnDelAdd + inttostr(PanelN); Sender.Caption := '+';
  Sender.Font.Size := fontSizeText; Sender.TabStop := False;
  Sender.Left := ListActs[PanelN].Width + ListActs[PanelN].Left + spaceBetween;
  Sender.OnClick := btnAddPnl.OnClick;
end;

//Press Tab in TEdit
procedure TForm1.CheckTab(Var Msg: TWMKEY);
begin
  try
  if (ActiveControl is TEdit) and (Msg.Charcode = VK_TAB) then
  begin
    if ListActs[GetNumOfPanel((ActiveControl As TEdit).Name)].ItemIndex = 0 then
    begin
      Edit[3][GetNumOfPanel((ActiveControl As TEdit).Name)].Text := inttostr(VK_TAB);
      Edit[2][GetNumOfPanel((ActiveControl As TEdit).Name)].Text := 'Tab';
    end;
  end;
  inherited;
  except
  end;
end;

function Tform1.GetNumOfPanel(NameObj: string) : integer;
var IntS : string;
  i : integer;
begin
  IntS := '';
  //Get num of panel by last integer in names of objects
  //Example ObjName12, with Num = 12
  for i := length(NameObj) downto 1 do
  begin
    if NameObj[i] in ['0'..'9'] then IntS := NameObj[i]+IntS
    else break;
  end;
  Result := StrToInt(IntS);
end;

procedure Tform1.addAct(ActPos: integer);
var Act : integer;
  i : integer;
begin
  //Say that we have N acts
  inc(CountActs);
  Act := CountActs;

  if HidenActs > 0 then
  begin
    dec(HidenActs);
  end
  else begin
    //Create new Panel
    Panel[Act] := TPanel.Create(Panel[act]);
    //Hide Panel before initialize
    Panel[Act].Visible := false;
    Panel[Act].Parent := Self;
    Panel[Act].Color := PanelColor;
    //Say where will be locate our panel
    if ((ActPos > 0) and (ActPos < Act)) then Panel[Act].Top := Panel[ActPos].Top+1;
    Panel[Act].Align := alTop;
    //Add delete button
    CreateDelBtn(BtnDel[Act],Act);
   //Add numOfAct
   CreateEdit(Edit[1][Act],Act);
    Edit[1][Act].Width := widthNumOfAct;
    Edit[1][Act].Left := BtnDel[Act].Left+BtnDel[Act].Width + spaceBetween;
    Edit[1][Act].Enabled := false; Edit[1][Act].Text := inttostr(Act);
    //Add List of Acts
    CreateComboBox(ListActs[Act],Act);
    ListActs[Act].Width := widthListActs;
    ListActs[Act].Left := edit[1][Act].Left+edit[1][Act].Width + spaceBetween;
    ListActs[Act].OnChange := ListActions.OnChange;
    ListActs[Act].Name := ComboEventsName + inttostr(Act);
    for i := 1 to NumOfActs do
    case Language of
      0:begin ListActs[Act].Items.Add(ListActsEng[i]); end;
      1:begin ListActs[Act].Items.Add(ListActsRus[i]); end;
    end;
    CreateAddBtn(BtnAdd[Act],Act);
  end;
  //Hide old objects
  ListActionsChange(ListActs[Act]);
  //Show after initialize
  panel[Act].Visible := true;
end;

procedure Tform1.ShiftActsFrom(Var Frm : integer);
var i,j: integer;
begin
  for i := CountActs-1 downto Frm do
  begin
    ListActs[i+1].ItemIndex := ListActs[i].ItemIndex;
    //if ListActs[i].ItemIndex = -1 then ListActionsChange(ListActs[i]);
    if (ListActs[i+1].ItemIndex <> -1) then
    begin
      ListActionsChange(ListActs[i+1]);
      If (ListEvents[i] <> nil) and (ListEvents[i+1] <> nil) then begin
         ListEvents[i+1].ItemIndex := ListEvents[i].ItemIndex;
      end;
      try If (ListMouseKeys[i] <> nil) then ListMouseKeys[i+1].ItemIndex := ListMouseKeys[i].ItemIndex; except end;
      for j := 2 to MaxEdits do
        if (Edit[j][i] <> nil) and (Edit[j][i+1] <> nil) then Edit[j][i+1].Text := Edit[j][i].Text;
      ListActs[i].ItemIndex := -1; ListActionsChange(ListActs[i]);
    end;
  end;
  //for i := CountActs-1 downto Frm do ListActionsChange(ListActs[i]);
  //ListActs[Frm].ItemIndex := -1;
  //ListActionsChange(ListActs[Frm]); ListActionsChange(ListActs[CountActs-1]);

end;

procedure Tform1.deleteAct(Num: integer);
var i : integer;
begin
  //Hide Panel with our act
  dec(CountActs);
  for i := Num to CountActs do
  begin
    ListActs[i].ItemIndex := ListActs[i+1].ItemIndex;
  end;
  Panel[CountActs+1].visible := false;
  inc(HidenActs);
end;

procedure TForm1.mniOptionsClick(Sender: TObject);
begin
  //Open options
  FormOptions.Show;
end;

procedure TForm1.mniAboutClick(Sender: TObject);
begin
  showmessage('In developing');
end;

procedure TForm1.aplctnvntsMinimize(Sender: TObject);
begin
{  FormStyle := fsNormal;
  self.Visible := false;}
end;

procedure Tform1.TrayMessage(var Msg: TMessage);
begin
{  if Msg.LParam = WM_LBUTTONDOWN then
  begin
    //Application.MainForm.Show;
//    Application.MainForm.Visible := true;
    //Self.FormStyle := fsStayOnTop;
//    Self.ShowModal;
//    Self.Activate;
//    Application.MainForm.SetFocus;
    with Application.MainForm do
//    if WindowState = wsMinimized then
    begin
      //ShowMessage('');
      Visible := True;
      FormStyle := fsStayOnTop;
      WindowState := wsNormal;
    end;
   // Application.MainForm.ActiveControl := Application.MainForm;
  end; }
end;

procedure TForm1.FormCreate(Sender: TObject);
var ParamFile : string;
begin
//  Application.HintColor := 255255;
  Application.HintHidePause := 999999;
  //ShowMessage(ParamStr(1));
  FormCap := Progrm;
  ParamFile := ParamStr(1);
{with TrayIconData do
  begin
    cbSize := SizeOf(TrayIconData);
    Wnd := Handle;
    uID := 0;
    uFlags := NIF_MESSAGE + NIF_ICON + NIF_TIP;
    uCallbackMessage := WM_ICONTRAY;
    hIcon := Application.Icon.Handle;
    szTip := Progrm;
    //StrPCopy(szTip, Application.Title);
  end;
  Shell_NotifyIcon(NIM_ADD, @TrayIconData); }

  Application.Title := FormCap;
  Self.Caption := FormCap;
  //Register Hot Key Ctrl+F1
  RegisterHotKey(Handle,1,MOD_CONTROL,VK_F1);

  //Set size of form
  Self.Width := FormWidth; Self.Height := FormHeight;
  Self.Left := Screen.Width div 2 - FormWidth div 2;
  Self.Top := Screen.Height div 2 - FormHeight div 2;
  Self.Constraints.MaxWidth := FormWidth;
  Self.Constraints.MinWidth := FormWidth;
  //Remove the patterns
  Panel1.Destroy; Panel2.Destroy;
//  pnl2.Destroy;
  //Hide main templates for use the events
  pnlKeybd.Hide; pnlMouse.Hide;
  //Add first act
  addAct(0);
  
  //Language := 1;
  //Localization
  case Language of
    1: begin
       mniFile.Caption := mniFileRus[0];
       mniNew.Caption := mniFileRus[1];
       mniOpen.Caption := mniFileRus[2];
       mniSave.Caption := mniFileRus[3];
       mniSaveAs.Caption := mniFileRus[4];

       mniOptions.Caption := mniOptionsRus[0];
//       mniAbout.Caption := mniAboutRus[0];
    end;
  end;
  if FileExists(ParamStr(1)) then OpenScript(ParamFile);
  Saved := true;
end;

procedure TForm1.btnAddPnlClick(Sender: TObject);
var Frm : integer;
begin
  Saved := false;
  Frm := GetNumOfPanel((Sender As TButton).Name)+1;
  if HidenActs > 0 then ListActs[CountActs+1].ItemIndex := -1;
  addAct(CountActs);
  if Frm <> CountActs then ShiftActsFrom(Frm);
  //Scrolling to last act
//  VertScrollBar.Position := (Frm-1)*PanelHeight;
  //VertScrollBar.Position := (Frm+1)*PanelHeight;
end;

procedure Tform1.ShiftActsBack(Var B : integer);
var i,j: integer;
begin
  for i := B to CountActs-1 do
  begin
    ListActs[i].ItemIndex := ListActs[i+1].ItemIndex;
    //if ListActs[i].ItemIndex = -1 then ListActionsChange(ListActs[i]);
      ListActionsChange(ListActs[i]);
       If (ListEvents[i] <> nil) and (ListEvents[i+1] <> nil) then begin
         ListEvents[i].ItemIndex := ListEvents[i+1].ItemIndex;
      end;
      try If (ListMouseKeys[i+1] <> nil) then ListMouseKeys[i].ItemIndex := ListMouseKeys[i+1].ItemIndex; except end;
      for j := 2 to MaxEdits do
        if (Edit[j][i] <> nil) and (Edit[j][i+1] <> nil) then Edit[j][i].Text := Edit[j][i+1].Text;
  end;
  //ListActs[Frm].ItemIndex := -1;
  //ListActionsChange(ListActs[Frm]); ListActionsChange(ListActs[CountActs-1]);
end;

procedure TForm1.btnDelTClick(Sender: TObject);
var PanelN : integer;
begin
  Saved := false;
  PanelN := GetNumOfPanel((Sender as TBitBtn).Name);

  //delete Panel
  if (CountActs <> 1) then
  begin
    ShiftActsBack(PanelN);
    deleteAct(CountActs);
  end;
end;

//Change panel
procedure TForm1.ListActionsChange(Sender: TObject);
var ActNum : integer;
    Event : integer;
    i,j : integer;
const DynObj = 2;
begin
  Saved := false;
  ActNum := GetNumOfPanel((Sender as TComboBox).Name);
  Event := (Sender as TComboBox).ItemIndex;
  //Hide dynamic objects
  if ListEvents[ActNum] <> nil then ListEvents[ActNum].Visible := false;
  if ListMouseKeys[ActNum] <> nil then ListMouseKeys[ActNum].Visible := false;
  for i := DynObj to MaxEdits do
    if Edit[i][ActNum] <> nil then
    begin
      Edit[i][ActNum].Visible := false;
      Edit[i][ActNum].Hint := '';
    end;
  case Event of
      //keyboard and mouse
      -1:
      begin
        If ListEvents[ActNum] <> nil then ListEvents[ActNum].Visible := false;
        If (ListMouseKeys[ActNum] <> nil) then ListMouseKeys[ActNum].Visible := false;
        for j := 2 to MaxEdits do
          if Edit[j][ActNum] <> nil then Edit[j][ActNum].Visible := false;
        BtnAdd[ActNum].Left := ListActs[ActNum].Left + ListActs[ActNum].Width + spaceBetween;
      end;
    0,1:
    begin
      if ListEvents[ActNum] = nil then
      begin
        CreateComboBox(ListEvents[ActNum],ActNum);
        for i := 1 to NumOfEvents do
        case Language of
          0: begin
            ListEvents[ActNum].Hint := ListEventHintEng;
            ListEvents[ActNum].Items.Add(ListEventsEng[i]);
          end;
          1: begin
           ListEvents[ActNum].Hint := ListEventHintRus;
           ListEvents[ActNum].Items.Add(ListEventsRus[i]);
          end;
        end;
        ListEvents[ActNum].Left := ListActs[ActNum].Left+ ListActs[ActNum].Width + spaceBetween;
        listEvents[ActNum].Width := widthListEvents;
        ListEvents[ActNum].ItemIndex := 0;
      end else begin ListEvents[ActNum].Visible := True; ListEvents[ActNum].ItemIndex := 0; end;
      if Event = 1 then
        if ListMouseKeys[ActNum] = nil then
        begin
          CreateComboBox(ListMouseKeys[ActNum],ActNum);
          for i := 1 to NumOfMouseKeys do
          case Language of
            0: begin
             ListMouseKeys[ActNum].Hint := ListMouseKeysHintEng;
             ListMouseKeys[ActNum].Items.Add(ListMouseKeysEng[i]);
           end;
            1: begin
              ListMouseKeys[ActNum].Hint := ListMouseKeysHintRus;
              ListMouseKeys[ActNum].Items.Add(ListMouseKeysRus[i]);
            end;
          end;
          ListMouseKeys[ActNum].Left := ListEvents[ActNum].Left+ ListEvents[ActNum].Width + spaceBetween;
          ListMouseKeys[ActNum].ItemIndex := 0;
          ListMouseKeys[ActNum].Width := widthListMouseKeys;
        end else ListMouseKeys[ActNum].Visible := True;
      if Edit[2][ActNum] = nil then
      begin
        //Key
        CreateEdit(Edit[2][ActNum],ActNum);
        Edit[2][ActNum].Width := widthEdtInp;
        Edit[2][ActNum].Name := EditInpKey+inttostr(ActNum);
        Edit[2][ActNum].Text := 'Key';
      end else Edit[2][ActNum].Visible := True;
      Edit[2][ActNum].SetFocus;
      if Edit[4][ActNum] = nil then
      begin
        CreateEdit(Edit[4][ActNum],ActNum);
        Edit[4][ActNum].Width := widthEdtInp;
        Edit[4][ActNum].Text := 'Y';
        Edit[4][ActNum].OnKeyPress := InpInt.OnKeyPress;
      end else Edit[4][ActNum].Visible := True;
        if Event = 0 then
          begin
            Edit[2][ActNum].OnKeyPress := nil;
            Edit[2][ActNum].Left := ListEvents[ActNum].Left + ListEvents[ActNum].Width + spaceBetween;
            Edit[2][ActNum].Text := 'Key';
            Edit[2][ActNum].OnChange := InpKey.OnChange;
            Edit[2][ActNum].OnKeyDown := InpKey.OnKeyDown;
            Edit[2][ActNum].OnKeyPress := InpKey.OnKeyPress;
            Edit[4][ActNum].Visible := false;
          end
        else if Event = 1 then begin
          //X
         Edit[2][ActNum].OnKeyDown := InpXY.OnKeyDown;
         Edit[2][ActNum].OnKeyPress := nil;
         Edit[2][ActNum].OnChange := nil;
         Edit[2][ActNum].Left := ListMouseKeys[ActNum].Left + ListMouseKeys[ActNum].Width + spaceBetween;
         Edit[2][ActNum].Text := 'X';
         Edit[4][ActNum].Name := 'CoordsX'+inttostr(ActNum);
         Edit[2][ActNum].OnKeyPress := InpInt.OnKeyPress;
          //Y
         Edit[4][ActNum].OnKeyDown := InpXY.OnKeyDown;
         Edit[4][ActNum].OnKeyUp := InpXY.OnKeyUp;
         Edit[4][ActNum].Left := Edit[2][ActNum].Left + Edit[2][ActNum].Width + spaceBetween;
         Edit[4][ActNum].Text := 'Y';
         Edit[4][ActNum].Name := 'CoordsY'+inttostr(ActNum);

        end;
      if Edit[3][ActNum] = nil then
      begin
        //Code key
        CreateEdit(Edit[3][ActNum],ActNum);
        Edit[3][ActNum].Visible := false;
        Edit[3][ActNum].Text := '0';
      end else Edit[3][ActNum].Text := '0';
      if Event = 0 then BtnAdd[ActNum].Left := Edit[2][ActNum].Left + Edit[2][ActNum].Width + spaceBetween;
      if Event = 1 then BtnAdd[ActNum].Left := Edit[4][ActNum].Left + Edit[4][ActNum].Width + spaceBetween;

      if Event = 1 then
        case Language of
          0: begin
            Edit[2][ActNum].Hint := CoordsHintEng;
            Edit[4][ActNum].Hint := CoordsHintEng;
          end;
          1: begin
            Edit[2][ActNum].Hint := CoordsHintRus;
            Edit[4][ActNum].Hint := CoordsHintRus;
          end;
        end;
    end;
      //Sleep
    2: begin
      if Edit[3][ActNum] = nil then CreateEdit(Edit[3][ActNum],ActNum); //MlSec
      Edit[3][ActNum].Text := 'mlSec';
      Edit[3][ActNum].Width := WidthInpMlSec;
      Edit[3][ActNum].Left := ListActs[ActNum].Left + ListActs[ActNum].Width + spaceBetween;
      Edit[3][ActNum].Visible := True;
      Edit[3][ActNum].OnKeyPress := InpInt.OnKeyPress;
      Edit[3][ActNum].SetFocus;
      BtnAdd[ActNum].Left := Edit[3][ActNum].Left + Edit[3][ActNum].Width + spaceBetween;
        case Language of
          0: begin
            Edit[3][ActNum].Hint := SleepHintEng;
          end;
          1: begin
            Edit[3][ActNum].Hint := SleepHintRus;
          end;
        end;
      end;
      //Repeat
    3: begin
      if Edit[2][ActNum] = nil then begin CreateEdit(Edit[2][ActNum],ActNum);
                    Edit[2][ActNum].Name := EditInpKey+inttostr(ActNum); end;
      if Edit[3][ActNum] = nil then CreateEdit(Edit[3][ActNum],ActNum);
      if Edit[4][ActNum] = nil then begin CreateEdit(Edit[4][ActNum],ActNum);
                    Edit[4][ActNum].Name := 'CoordsY'+inttostr(ActNum); end;
      Edit[2][ActNum].Text := 'From';
      Edit[3][ActNum].Text := 'To';
      Edit[4][ActNum].Text := 'Repeats';
         Edit[2][ActNum].OnKeyDown := nil;
         Edit[2][ActNum].OnChange := nil;
      Edit[2][ActNum].OnKeyPress := InpInt.OnKeyPress;
      Edit[3][ActNum].OnKeyPress := InpInt.OnKeyPress;
      Edit[4][ActNum].OnKeyPress := InpInt.OnKeyPress;
      Edit[4][ActNum].OnKeyDown := nil;
      Edit[2][ActNum].Visible := True;
      Edit[3][ActNum].Visible := True;
      Edit[4][ActNum].Visible := True;
      Edit[2][ActNum].SetFocus;
      Edit[2][ActNum].Width := WidthInpRepeat;
      Edit[3][ActNum].Width := WidthInpRepeat;
      Edit[4][ActNum].Width := WidthInpRepeat;
      Edit[2][ActNum].Left := ListActs[ActNum].Width + ListActs[ActNum].Left + spaceBetween;
      Edit[3][ActNum].Left := Edit[2][ActNum].Width + Edit[2][ActNum].Left + spaceBetween;
      Edit[4][ActNum].Left := Edit[3][ActNum].Width + Edit[3][ActNum].Left + spaceBetween;

        case Language of
          0: begin
            Edit[2][ActNum].Hint := RepeatFromHintEng;
            Edit[3][ActNum].Hint := RepeatToHintEng;
            Edit[4][ActNum].Hint := RepeatCycHintEng;
          end;
          1: begin
            Edit[2][ActNum].Hint := RepeatFromHintRus;
            Edit[3][ActNum].Hint := RepeatToHintRus;
            Edit[4][ActNum].Hint := RepeatCycHintRus;
          end;
        end;

      BtnAdd[ActNum].Left := Edit[4][ActNum].Left + Edit[4][ActNum].Width + spaceBetween;
{      Edit[2][ActNum]
      Edit[3][ActNum]
      Edit[4][ActNum]}
    end;
     end;
end;

procedure TForm1.InpIntChange(Sender: TObject);
begin
end;

//Keyboard enter key
procedure TForm1.InpKeyKeyDown(Sender: TObject; var Key: Word;
  Shift: TShiftState);          
begin
  Edit[3][GetNumOfPanel((Sender As TEdit).Name)].Text := inttostr(Key);
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
    else (sender as TEdit).text := '';//chr(key);
  end;
  //showmessage(inttostr(key));

end;

procedure TForm1.InpKeyKeyPress(Sender: TObject; var Key: Char);
begin
  //Disable sound on enter and on escape!!!
  if (Key = #13) or (Key = #27) then Key := #0;

end;

procedure TForm1.InpIntKeyPress(Sender: TObject; var Key: Char);
begin
  if not (key in ['0'..'9',#8]) then key := #0
  else if not (Length((Sender as TEdit).Text) = 0) and not ((Sender as TEdit).Text[1] in ['0'..'9']) then
    begin (Sender as TEdit).Text := key; (Sender as TEdit).SelStart := length((Sender as TEdit).Text); key := #0;  end;
end;

procedure TForm1.InpXYKeyDown(Sender: TObject; var Key: Word;
  Shift: TShiftState);
var PanelN : integer;
    KeyC : char;
begin
  KeyC := chr(Key);
  InpIntKeyPress(Sender,KeyC);
  PanelN := GetNumOfPanel((Sender as TEdit).Name);
  if Key = VK_CONTROL then
  begin
    ClickM := false;
    ActM := GetNumOfPanel((Sender as TEdit).Name);
    if not (Form2.Showing) then Form2.Show;
  end else if Key = VK_ESCAPE then Panel[PanelN].SetFocus;

//  if Key = VK_CONTROL then Edit[2][PanelN].Text := p.X;
end;

procedure TForm1.InpXYKeyUp(Sender: TObject; var Key: Word;
  Shift: TShiftState);
var PanelN : integer;
begin
  PanelN := GetNumOfPanel((Sender As TEdit).Name);
  case MouseB of
    mbLeft: ListMouseKeys[PanelN].ItemIndex := 0;
    mbRight: ListMouseKeys[PanelN].ItemIndex := 1;
    mbMiddle: ListMouseKeys[PanelN].ItemIndex := 2;
  end;
  //if GetAsyncKeyState(VK_LBUTTON) < 0 then showmessage('Left');
end;

function Tform1.CheckSave(Var Ext : byte) :Boolean;
var Dlg : Integer;
    MsgDlg : string;
    OpnDlg : string;
begin
  Result := false;
  case Language of
    0 : MsgDlg := dlgSaveEng;
    1 : MsgDlg := dlgSaveRus;
  end;
    if Ext > 0 then Dlg := MessageDlg(MsgDlg,mtCustom,[mbYes,mbNo,mbCancel], 0)
    else Dlg := MessageDlg(MsgDlg,mtCustom,[mbYes,mbNo], 0);
  //Dlg := MessageBox(Handle, PAnsiChar(MsgDlg),nil, MB_YESNOCANCEL+MB_ICONQUESTION+MB_DEFBUTTON2);
  case Dlg of
    7 : Result := True;//no
    6 : begin
        Result := True;
        if FileActs = '' then
        begin
          OpnDlg := 'save';
          if not OpenDlg(OpnDlg) then abort;
        end else SaveScript(FileActs);
      end; //yes
    2 : abort; //Cancel
  end;
end;

procedure Tform1.SaveScript(Var F : String);
const Spliter = ';';
var Fle : TextFile;
    tempS : String;
    i : integer;
    dlg : string;
begin
  try
  dlg := 'save';
  if (FileActs <> '') and (not (FileExists(FileActs))) then begin FileActs := ''; OpenDlg(dlg); end
  else
  begin
  if FileActs = '' then FileActs := F;
  AssignFile(Fle,F);
  Rewrite(Fle);
  for i := 1 to CountActs do
  begin
    tempS := '';
    tempS := inttostr(ListActs[i].ItemIndex);
    case ListActs[i].ItemIndex of
      //Keyboard
      0: begin
         tempS := tempS + Spliter + inttostr(ListEvents[i].ItemIndex);
         tempS := tempS + Spliter + Edit[3][i].Text;
      end;
      //Mouse
      1: begin
         tempS := tempS + Spliter + inttostr(ListEvents[i].ItemIndex);
         tempS := tempS + Spliter + inttostr(ListMouseKeys[i].ItemIndex);
         tempS := tempS + Spliter + Edit[2][i].Text;
         tempS := tempS + Spliter + Edit[4][i].Text;
      end;
      //Sleep
      2: begin
         tempS := tempS + Spliter + Edit[3][i].Text;
      end;
      //Repeat
      3: begin
         tempS := tempS + Spliter + Edit[2][i].Text;
         tempS := tempS + Spliter + Edit[3][i].Text;
         tempS := tempS + Spliter + Edit[4][i].Text;
      end;
    end;
    if i <> CountActs then tempS := tempS + #13#10;
    Write(Fle,tempS);
  end;
  CloseFile(Fle);
  end
  except OpenDlg(dlg); end;
    FormCap := Progrm + '('+F+')';
  Application.MainForm.Caption := FormCap;
end;

procedure tform1.OpenScript(Var F : String);
const Spliter = ';';
      MaxObjs = 5;
var Fle : TextFile;
    tempS,tempInt : string;
    acts: integer;
    ObjsActs : array[1..Objs,1..MaxObjs] of integer;
    i,j: integer;  tempW : Word;
begin
  AssignFile(Fle,F);
  Reset(Fle);
  acts := 0; ObjsActs[1][1] := 0;
  //Read file and get info
  while not Eof(Fle) do
  begin
    inc(acts); j := 1; tempInt := '';
    Readln(Fle,tempS);
    for i := 1 to length(tempS) do
    begin
      if tempS[i] in ['0'..'9'] then tempInt := tempInt + tempS[i];
      if (tempS[i] = Spliter) or (i = Length(tempS)) then
      begin
        try if TempInt = '' then TempInt := '0';
          ObjsActs[acts][j] := strtoint(tempInt); except end;
        inc(j); if j > MaxObjs then break;
        TempInt := '';
      end
      //ShowMessage(tempInt);
    end;
  end;
  //Create panels
  for i := CountActs to acts-1 do addAct(i);
  for i := 1 to CountActs do
  begin
    ListActs[i].ItemIndex := ObjsActs[i][1]; ListActionsChange(ListActs[i]);
    //try
    case ListActs[i].ItemIndex of
      //Keyboard
      0: begin
         ListEvents[i].ItemIndex := ObjsActs[i][2];
         Edit[3][i].Text := inttostr(ObjsActs[i][3]);
         tempW := ObjsActs[i][3];
         InpKeyKeyDown(Edit[2][i],tempW,KeysToShiftState(0));
         if Edit[2][i].Text = '' then Edit[2][i].Text := chr(tempW); 
      end;
      //Mouse
      1: begin
         ListEvents[i].ItemIndex := ObjsActs[i][2];
         ListMouseKeys[i].ItemIndex := ObjsActs[i][3];
         Edit[2][i].Text := inttostr(ObjsActs[i][4]);
         Edit[4][i].Text := inttostr(ObjsActs[i][5]);
      end;
      //Sleep
      2: begin
         Edit[3][i].Text := inttostr(ObjsActs[i][2]);
      end;
      //Repeat
      3: begin
         Edit[2][i].Text := inttostr(ObjsActs[i][2]);
         Edit[3][i].Text := inttostr(ObjsActs[i][3]);
         Edit[4][i].Text := inttostr(ObjsActs[i][4]);
      end;
    end;
    //except end;
  end;
  //while CountActs <> 0 do deleteAct(CountActs);

  CloseFile(Fle);
  FormCap := Progrm + '('+F+')';
  Application.MainForm.Caption := FormCap;
  Saved := True;
end;

function Tform1.OpenDlg(Var DlgT : string): Boolean;
var dlgSave : TSaveDialog;
  dlgOpen : TOpenDialog; dlg : integer; MsgDlg : string;
  FileName : string;
  msgErr : string;
  st : Boolean;
begin
  st := false;
  //Result of success of executing
  Result := true;
  if DlgT = 'save' then
  begin
     dlgSave := TSaveDialog.Create(Self);
     case Language of
       0 : dlgSave.Title := mniFileEng[3];
       1 : dlgSave.Title := mniFileRus[3];
     end;
     dlgSave.Filter := 'BotActScript(*'+extension+')|*'+extension;
     while not st do
      if dlgSave.Execute then
      begin
        FileName := dlgSave.FileName;
        st := true;
        if pos(extension,FileName) = 0 then FileName := FileName + extension;
        if Not FileExists(FileName) then SaveScript(FileName)
        else begin
          case Language of
            0 : MsgDlg := dlgSaveReplaceEng;
            1 : MsgDlg := dlgSaveReplaceRus;
          end;
          Dlg := MessageDlg(MsgDlg,mtCustom,[mbYes,mbNo], 0);
       //Dlg := MessageBox(Handle, PAnsiChar(MsgDlg),nil, MB_YESNOCANCEL+MB_ICONQUESTION+MB_DEFBUTTON2);
          case Dlg of
          7 : st := false; // Result := True;//no
          6 : st := true; //yes
        end;
        end;
        if st then SaveScript(FileName);
      end else begin st := true; Result := false; end;
  end
  else if DlgT = 'open' then
  begin
    dlgOpen := TOpenDialog.Create(Self);
    case Language of
      0: dlgOpen.Title := mniFileEng[2];
      1: dlgOpen.Title := mniFileRus[2];
    end;
    dlgOpen.Filter := 'BotActScript(*'+extension+')|*'+extension+'|All files (*.*)|*.*';
    while not st do
      if dlgOpen.Execute then
      begin
        FileName := dlgOpen.FileName;
        if FileExists(FileName) then
        begin
           OpenScript(FileName);
           st := true;
        end
        else begin
           case Language of
             0 : MsgErr := openFileEng;
             1 : MsgErr := openFileRus;
           end;
           MsgErr := FileName+' - '+msgErr;
           ShowMessage(MsgErr);
        end;
      end else begin st := true; Result := false; end;
  end;
end;

procedure TForm1.FormClose(Sender: TObject; var Action: TCloseAction);
var ext : byte;
begin
  ext := 1;
  if not Saved then CheckSave(ext);
//  Shell_NotifyIcon(NIM_DELETE, @TrayIconData);
end;

procedure TForm1.mniOpenClick(Sender: TObject);
var dlg : string;
    ext : byte;
begin
  ext := 0;
  dlg := 'open';
  if saved then OpenDlg(dlg)
  else if CheckSave(ext) then OpenDlg(dlg);
end;

procedure TForm1.mniSaveClick(Sender: TObject);
var dlg : string;
begin
  dlg := 'save';
  if FileActs = '' then OpenDlg(dlg) else SaveScript(FileActs);
end;

procedure TForm1.mniNewClick(Sender: TObject);
var i : integer;
    ext : byte;
begin
  ext := 0;
  if not Saved then CheckSave(ext); {then}
//  begin
    FormCap := Progrm;
    Application.MainForm.Caption := FormCap;
    for i := CountActs downto 2 do deleteAct(i);
    ListActs[1].ItemIndex := -1; ListActionsChange(ListActs[1]);
    Saved := True;
    FileActs := '';
//  end;
end;

procedure TForm1.mniSaveAsClick(Sender: TObject);
var dlg : string;
begin
  dlg := 'save';
  OpenDlg(dlg);
end;

end.
