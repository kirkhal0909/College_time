object Form1: TForm1
  Left = 265
  Top = 126
  BorderStyle = bsSingle
  Caption = #1055#1086#1080#1089#1082' max,min'
  ClientHeight = 341
  ClientWidth = 486
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Visible = True
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object lblInpElm: TLabel
    Left = 304
    Top = 18
    Width = 155
    Height = 23
    Caption = #1057#1083#1091#1095#1072#1081#1085#1099#1081' '#1085#1072#1073#1086#1088
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object lblInpElm2: TLabel
    Left = 317
    Top = 66
    Width = 127
    Height = 23
    Caption = #1057#1082#1086#1083#1100#1082#1086' '#1095#1080#1089#1077#1083
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object lblMinMax: TLabel
    Left = 168
    Top = 301
    Width = 79
    Height = 23
    Caption = 'min; max'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object lblInpElm3: TLabel
    Left = 312
    Top = 101
    Width = 90
    Height = 23
    Caption = #1076#1086#1073#1072#1074#1080#1090#1100'?'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object lblInpElm4: TLabel
    Left = 312
    Top = 138
    Width = 149
    Height = 23
    Caption = #1050#1072#1082#1086#1081' '#1076#1080#1072#1087#1072#1079#1086#1085'?'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object lblInpElm5: TLabel
    Left = 376
    Top = 173
    Width = 7
    Height = 23
    Caption = '-'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object mmoNumbers: TMemo
    Left = 8
    Top = 16
    Width = 273
    Height = 273
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 0
    OnChange = mmoNumbersChange
  end
  object EdtInpElm: TEdit
    Left = 408
    Top = 98
    Width = 41
    Height = 31
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    PopupMenu = pmEmpty
    TabOrder = 1
    Text = '70'
    OnKeyPress = EdtInpElmKeyPress
  end
  object btnAdd: TButton
    Left = 304
    Top = 215
    Width = 153
    Height = 33
    Caption = #1044#1086#1073#1072#1074#1080#1090#1100' '#1095#1080#1089#1083#1072
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 2
    OnClick = btnAddClick
  end
  object btnNew: TButton
    Left = 304
    Top = 255
    Width = 153
    Height = 33
    Caption = #1047#1072#1084#1077#1085#1080#1090#1100' '#1095#1080#1089#1083#1072
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 3
    OnClick = btnNewClick
  end
  object btnCalc: TButton
    Left = 8
    Top = 296
    Width = 153
    Height = 33
    Caption = #1053#1072#1081#1090#1080' min,max'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 4
    OnClick = btnCalcClick
  end
  object edtMin: TEdit
    Left = 312
    Top = 170
    Width = 57
    Height = 31
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    PopupMenu = pmEmpty
    TabOrder = 5
    Text = '-500'
    OnKeyPress = edtMinKeyPress
  end
  object edtMax: TEdit
    Left = 392
    Top = 170
    Width = 57
    Height = 31
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    PopupMenu = pmEmpty
    TabOrder = 6
    Text = '1000'
    OnKeyPress = edtMinKeyPress
  end
  object pmEmpty: TPopupMenu
    Left = 640
    Top = 48
  end
end
