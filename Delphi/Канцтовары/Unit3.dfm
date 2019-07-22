object Form3: TForm3
  Left = 595
  Top = 172
  Width = 905
  Height = 552
  Caption = #1047#1072#1082#1072#1079
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  DesignSize = (
    889
    513)
  PixelsPerInch = 96
  TextHeight = 13
  object lblSum: TLabel
    Left = 14
    Top = 320
    Width = 57
    Height = 19
    Caption = #1057#1091#1084#1084#1072': '
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -16
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    ParentShowHint = False
    ShowHint = True
  end
  object pnlZakaz: TPanel
    Left = 200
    Top = -1
    Width = 689
    Height = 515
    Anchors = [akLeft, akTop, akBottom]
    TabOrder = 0
    OnResize = pnlZakazResize
    object strngCanctovariZakaz: TStringGrid
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
      OnExit = strngCanctovariZakazExit
      OnMouseMove = strngCanctovariZakazMouseMove
      OnMouseWheelDown = strngCanctovariZakazMouseWheelDown
      OnMouseWheelUp = strngCanctovariZakazMouseWheelUp
      RowHeights = (
        24
        24)
    end
  end
  object pnlAdd: TPanel
    Left = 8
    Top = 184
    Width = 193
    Height = 129
    Color = cl3DLight
    TabOrder = 1
    object lblNadpis: TLabel
      Left = 30
      Top = 8
      Width = 126
      Height = 19
      Caption = #1044#1086#1073#1072#1074#1080#1090#1100' '#1074' '#1079#1072#1082#1072#1079
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object lblKolvo: TLabel
      Left = 22
      Top = 67
      Width = 86
      Height = 19
      Caption = #1050#1086#1083#1080#1095#1077#1089#1090#1074#1086
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object lblID: TLabel
      Left = 22
      Top = 35
      Width = 17
      Height = 19
      Caption = 'ID'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object edtKolvo: TEdit
      Left = 112
      Top = 64
      Width = 57
      Height = 27
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 0
      OnKeyPress = edtIDKeyPress
    end
    object btnAdd: TButton
      Left = 16
      Top = 96
      Width = 153
      Height = 25
      Caption = #1044#1086#1073#1072#1074#1080#1090#1100'/'#1080#1079#1084#1077#1085#1080#1090#1100
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 1
      OnClick = btnAddClick
    end
    object edtID: TEdit
      Left = 40
      Top = 32
      Width = 129
      Height = 27
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 2
      OnKeyPress = edtIDKeyPress
    end
  end
  object pnlDel: TPanel
    Left = 8
    Top = 8
    Width = 193
    Height = 97
    Color = cl3DLight
    TabOrder = 2
    object lblNadpis2: TLabel
      Left = 30
      Top = 8
      Width = 132
      Height = 19
      Caption = #1059#1076#1072#1083#1080#1090#1100' '#1080#1079' '#1079#1072#1082#1072#1079#1072
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object lblID2: TLabel
      Left = 22
      Top = 35
      Width = 17
      Height = 19
      Caption = 'ID'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object edtID2: TEdit
      Left = 40
      Top = 32
      Width = 129
      Height = 27
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 0
      OnKeyPress = edtIDKeyPress
    end
    object btnDelete: TButton
      Left = 16
      Top = 64
      Width = 153
      Height = 25
      Caption = #1059#1076#1072#1083#1080#1090#1100
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 1
      OnClick = btnDeleteClick
    end
  end
  object btnZakaz: TButton
    Left = 8
    Top = 400
    Width = 193
    Height = 41
    Caption = #1057#1076#1077#1083#1072#1090#1100' '#1079#1072#1082#1072#1079
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 3
    OnClick = btnZakazClick
  end
end
