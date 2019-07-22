object Form1: TForm1
  Left = 302
  Top = 305
  Width = 478
  Height = 175
  Caption = #1050#1083#1072#1074#1080#1072#1090#1091#1088#1085#1099#1081' '#1090#1088#1077#1085#1072#1078#1105#1088
  Color = clAppWorkSpace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  OnKeyPress = FormKeyPress
  PixelsPerInch = 96
  TextHeight = 13
  object lblSymbols: TLabel
    Left = 328
    Top = 48
    Width = 30
    Height = 33
    Caption = '-/-'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -27
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object lblErrors: TLabel
    Left = 8
    Top = 48
    Width = 126
    Height = 33
    Caption = #1054#1096#1080#1073#1086#1082': -'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clMaroon
    Font.Height = -27
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object lblSpeed: TLabel
    Left = 8
    Top = 84
    Width = 89
    Height = 33
    Caption = '- '#1089#1080#1084'/'#1084
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -27
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object edtText: TEdit
    Left = 4
    Top = 4
    Width = 453
    Height = 41
    Color = cl3DLight
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -27
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    ReadOnly = True
    TabOrder = 0
    OnChange = edtTextChange
  end
  object btnNewText: TButton
    Left = 224
    Top = 84
    Width = 193
    Height = 41
    Caption = #1053#1086#1074#1072#1103' '#1087#1086#1087#1099#1090#1082#1072
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -27
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 1
    TabStop = False
    OnClick = btnNewTextClick
  end
  object tmrCheckSpeed: TTimer
    Enabled = False
    Interval = 300
    OnTimer = tmrCheckSpeedTimer
    Left = 168
    Top = 8
  end
end
