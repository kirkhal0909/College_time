object Form1: TForm1
  Left = 249
  Top = 152
  Width = 705
  Height = 552
  Caption = #1050#1072#1085#1094#1090#1086#1074#1072#1088#1099
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  Menu = menu
  OldCreateOrder = False
  OnCreate = FormCreate
  OnResize = FormResize
  DesignSize = (
    689
    493)
  PixelsPerInch = 96
  TextHeight = 13
  object pnlNetVNalichii: TPanel
    Left = 696
    Top = 0
    Width = 305
    Height = 493
    Anchors = [akLeft, akTop, akBottom]
    Color = cl3DLight
    TabOrder = 0
    Visible = False
    object lblNadpis: TLabel
      Left = 94
      Top = 8
      Width = 107
      Height = 19
      Caption = #1053#1077#1090' '#1074' '#1085#1072#1083#1080#1095#1080#1080
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object strngCanctovarNetVnalichii: TStringGrid
      Left = 16
      Top = 33
      Width = 275
      Height = 184
      ColCount = 2
      DefaultColWidth = 100
      RowCount = 2
      FixedRows = 0
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      ParentShowHint = False
      ShowHint = True
      TabOrder = 0
      OnDrawCell = strngCanctovarVnalichiiDrawCell
      OnExit = strngCanctovarNetVnalichiiExit
      OnMouseMove = strngCanctovarNetVnalichiiMouseMove
      RowHeights = (
        24
        24)
    end
  end
  object pnlVnalichii: TPanel
    Left = 0
    Top = 0
    Width = 689
    Height = 493
    Anchors = [akLeft, akTop, akBottom]
    TabOrder = 1
    object strngCanctovarVnalichii: TStringGrid
      Left = 8
      Top = 8
      Width = 675
      Height = 209
      DefaultColWidth = 100
      RowCount = 2
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      ParentShowHint = False
      ShowHint = True
      TabOrder = 0
      OnDrawCell = strngCanctovarVnalichiiDrawCell
      OnExit = strngCanctovarVnalichiiExit
      OnKeyPress = strngCanctovarVnalichiiKeyPress
      OnMouseMove = strngCanctovarVnalichiiMouseMove
      OnMouseWheelDown = strngCanctovarVnalichiiMouseWheelDown
      OnMouseWheelUp = strngCanctovarVnalichiiMouseWheelUp
      OnSelectCell = strngCanctovarVnalichiiSelectCell
      RowHeights = (
        24
        24)
    end
  end
  object menu: TMainMenu
    Left = 208
    Top = 264
    object N1: TMenuItem
      Caption = #1058#1086#1074#1072#1088
      object N2: TMenuItem
        Caption = #1044#1086#1073#1072#1074#1080#1090#1100
        OnClick = N2Click
      end
      object N3: TMenuItem
        Caption = #1048#1079#1084#1077#1085#1080#1090#1100
        OnClick = N3Click
      end
    end
    object N5: TMenuItem
      Caption = #1047#1072#1082#1072#1079
      OnClick = N5Click
    end
  end
end
