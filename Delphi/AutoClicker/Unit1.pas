unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Menus;

type
  TForm1 = class(TForm)
    sec: TLabel;
    secOption: TEdit;
    Check: TCheckBox;
    HotKey: TEdit;
    ComboBox1: TComboBox;
    HotKeysLbl: TLabel;
    mm1: TMainMenu;
    N11: TMenuItem;
    Status: TLabel;
    procedure WMHotKey(var Msg: TWMHotKey); message WM_HOTKEY;
    procedure FormCreate(Sender: TObject);
    procedure secOptionKeyPress(Sender: TObject; var Key: Char);
    procedure CheckClick(Sender: TObject);
    procedure HotKeyKeyPress(Sender: TObject; var Key: Char);
    procedure RegKey(Key:byte);
    procedure UnRegKey(Key:byte);
    procedure ComboBox1Change(Sender: TObject);
    procedure HotKeyKeyDown(Sender: TObject; var Key: Word;
      Shift: TShiftState);
    procedure N11Click(Sender: TObject);
    procedure secOptionChange(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

  TNewThread = class(TThread)
  private
    { Private declarations }
  protected
    procedure Execute; override;
  end;

var
  Form1: TForm1;
  NewThread : TNewThread;
  Exc : boolean = false;
  SleepSec : longint = 0;
  KeyID: byte;
  strt : boolean;

implementation

{$R *.dfm}

procedure TForm1.FormCreate(Sender: TObject);
begin
  SleepSec := strtoint(secOption.text);
  KeyID := 112;
  RegKey(KeyID);
end;

procedure TNewThread.Execute;
var MouseP : TPoint;
begin
  while strt do begin
    GetCursorPos(MouseP);
    mouse_event(MOUSEEVENTF_LEFTDOWN,MouseP.X,MouseP.Y,0,0);
    mouse_event(MOUSEEVENTF_LEFTUP,MouseP.X,MouseP.Y,0,0);
    sleep(SleepSec);
  end;
end;

procedure TForm1.secOptionKeyPress(Sender: TObject; var Key: Char);
begin
  if not (key in ['0'..'9',#8]) then key := #0;
end;

procedure TForm1.CheckClick(Sender: TObject);
begin
  if Check.Checked then begin sec.Enabled := True; secOption.Enabled := True; SleepSec := strtoint(secOption.text); end
  else begin sec.Enabled := False; secOption.Enabled := False; SleepSec := 0; end;
end;

procedure Tform1.UnRegKey(Key:byte);
begin
  UnregisterHotKey(Handle,Key); 
end;

procedure Tform1.RegKey(Key:byte);
var vk_mod : byte;
begin
  vk_mod := 0;
  case ComboBox1.ItemIndex of
    1: vk_mod := MOD_CONTROL;
    2: vk_mod := MOD_SHIFT;
    3: vk_mod := MOD_ALT;
    4: vk_mod := MOD_WIN;
  end;
  RegisterHotKey(handle,Key,vk_mod,Key);
end;

procedure TForm1.WMHotKey(var Msg: TWMHotKey);
begin
  try
  if NewThread.Terminated then strt := True else strt := false;
  except strt := True; end;
  if strt then
  begin
    NewThread:=TNewThread.Create(true);
    NewThread.FreeOnTerminate:=true;
    NewThread.Priority:=tpHighest;
    NewThread.Resume;
    Status.Caption := 'Сейчас кликает'; status.Font.Color := clGreen;
  end else begin Status.Caption := 'Сейчас не кликает'; status.Font.Color := clMaroon;
   try NewThread.Terminate; except end; end;
//  else showmessage(Application.Title+' завершил кликать');
 // else NewThread.Terminate;
end;

procedure TForm1.ComboBox1Change(Sender: TObject);
begin
  UnRegKey(KeyID);
  RegKey(KeyID);
end;

procedure TForm1.HotKeyKeyPress(Sender: TObject; var Key: Char);
begin
  if (ord(key)<>vk_ESCAPE) then HotKey.Text := Key;
  Key := #0;
end;

procedure TForm1.HotKeyKeyDown(Sender: TObject; var Key: Word;
  Shift: TShiftState);
const KeyF = 111;
begin
  UnRegKey(KeyID);
  KeyID := Key;
  if (Key = VK_ESCAPE) then HotKey.Text := 'Esc'
  else
  if (Key >= vk_F1) and (key <= VK_F12) then
  begin
    HotKey.Text := 'F'+inttostr(Key-KeyF);
  end;
  RegKey(KeyID);
end;

procedure TForm1.N11Click(Sender: TObject);
begin
  showmessage('От Кирилла');
end;

procedure TForm1.secOptionChange(Sender: TObject);
begin
  SleepSec := strtoint(secOption.Text);
end;

end.
 