object Form1: TForm1
  Left = 233
  Top = 572
  BorderStyle = bsSingle
  Caption = #1040#1074#1090#1086#1050#1083#1080#1082#1077#1088
  ClientHeight = 233
  ClientWidth = 236
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  Menu = mm1
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object sec: TLabel
    Left = 24
    Top = 120
    Width = 163
    Height = 33
    Caption = #1052#1080#1083#1083#1080#1089#1077#1082#1091#1085#1076
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -27
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object HotKeysLbl: TLabel
    Left = 8
    Top = 0
    Width = 218
    Height = 33
    Caption = #1043#1086#1088#1103#1095#1080#1080' '#1082#1083#1072#1074#1080#1096#1080
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -27
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Status: TLabel
    Left = 5
    Top = 192
    Width = 228
    Height = 33
    Caption = #1057#1077#1081#1095#1072#1089' '#1085#1077' '#1082#1083#1080#1082#1072#1077#1090
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clMaroon
    Font.Height = -27
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object secOption: TEdit
    Left = 24
    Top = 152
    Width = 169
    Height = 41
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -27
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 0
    Text = '100'
    OnChange = secOptionChange
    OnKeyPress = secOptionKeyPress
  end
  object Check: TCheckBox
    Left = 8
    Top = 88
    Width = 153
    Height = 33
    Caption = #1047#1072#1076#1077#1088#1078#1082#1072
    Checked = True
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -27
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    State = cbChecked
    TabOrder = 1
    OnClick = CheckClick
  end
  object HotKey: TEdit
    Left = 32
    Top = 40
    Width = 49
    Height = 41
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -27
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 2
    Text = 'F1'
    OnKeyDown = HotKeyKeyDown
    OnKeyPress = HotKeyKeyPress
  end
  object ComboBox1: TComboBox
    Left = 96
    Top = 40
    Width = 113
    Height = 41
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -27
    Font.Name = 'Tahoma'
    Font.Style = []
    ItemHeight = 33
    ItemIndex = 1
    ParentFont = False
    TabOrder = 3
    Text = 'Ctrl'
    OnChange = ComboBox1Change
    Items.Strings = (
      #1053#1080#1095#1077#1075#1086
      'Ctrl'
      'Shift'
      'Alt'
      'Win')
  end
  object mm1: TMainMenu
    Left = 216
    Top = 128
    object N11: TMenuItem
      Caption = 'About'
      OnClick = N11Click
    end
  end
end
