object Form1: TForm1
  Left = 364
  Top = 194
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = #1057#1080#1089#1090#1077#1084#1072' '#1087#1088#1086#1074#1077#1088#1082#1080
  ClientHeight = 173
  ClientWidth = 578
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
  object pnlTasks: TPanel
    Left = 0
    Top = 0
    Width = 193
    Height = 177
    TabOrder = 0
    object lbl: TLabel
      Left = 6
      Top = 8
      Width = 178
      Height = 23
      Caption = #1042#1099#1073#1077#1088#1080#1090#1077' '#1090#1080#1087' '#1079#1072#1076#1072#1095
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object btnMassive1: TButton
      Left = 37
      Top = 136
      Width = 106
      Height = 25
      Caption = #1052#1072#1089#1089#1080#1074#1099
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 0
      OnClick = btnMassive1Click
    end
    object btnbranch: TButton
      Left = 37
      Top = 72
      Width = 106
      Height = 25
      Caption = #1042#1077#1090#1074#1083#1077#1085#1080#1077
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 1
      OnClick = btnbranchClick
    end
    object btnCycle: TButton
      Left = 37
      Top = 104
      Width = 106
      Height = 25
      Caption = #1062#1080#1082#1083#1099
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 2
      OnClick = btnCycleClick
    end
    object btnLine: TButton
      Left = 37
      Top = 40
      Width = 106
      Height = 25
      Caption = #1051#1080#1085#1077#1081#1085#1099#1077
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 3
      OnClick = btnLineClick
    end
  end
  object pnlStats: TPanel
    Left = 192
    Top = -8
    Width = 193
    Height = 185
    TabOrder = 1
    object lblToday: TLabel
      Left = 54
      Top = 16
      Width = 71
      Height = 23
      Caption = #1057#1077#1075#1086#1076#1085#1103
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object lblLineToday: TLabel
      Left = 8
      Top = 48
      Width = 125
      Height = 23
      Caption = '0 OK; 0 Wrong'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object lblBranchToday: TLabel
      Left = 8
      Top = 80
      Width = 125
      Height = 23
      Caption = '0 OK; 0 Wrong'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object lblCycleToday: TLabel
      Left = 8
      Top = 112
      Width = 125
      Height = 23
      Caption = '0 OK; 0 Wrong'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object lblArray1Today: TLabel
      Left = 8
      Top = 144
      Width = 125
      Height = 23
      Caption = '0 OK; 0 Wrong'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
  end
  object pnlDays: TPanel
    Left = 384
    Top = -8
    Width = 193
    Height = 185
    TabOrder = 2
    object lblLineDays: TLabel
      Left = 6
      Top = 48
      Width = 125
      Height = 23
      Caption = '0 OK; 0 Wrong'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object lblBranchDays: TLabel
      Left = 8
      Top = 80
      Width = 125
      Height = 23
      Caption = '0 OK; 0 Wrong'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object lblCycleDays: TLabel
      Left = 8
      Top = 112
      Width = 125
      Height = 23
      Caption = '0 OK; 0 Wrong'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object lblArray1Days: TLabel
      Left = 8
      Top = 144
      Width = 125
      Height = 23
      Caption = '0 OK; 0 Wrong'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object lblDays: TLabel
      Left = 40
      Top = 16
      Width = 114
      Height = 23
      Caption = #1047#1072' '#1074#1089#1105' '#1074#1088#1077#1084#1103
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
  end
  object tmrEnd: TTimer
    Enabled = False
    Interval = 1
    OnTimer = tmrEndTimer
    Left = 360
    Top = 56
  end
  object mm1: TMainMenu
    Left = 336
    Top = 32
    object mniAbout: TMenuItem
      Caption = 'About'
      OnClick = mniAboutClick
    end
  end
end
