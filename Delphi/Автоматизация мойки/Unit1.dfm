object Form1: TForm1
  Left = 320
  Top = 204
  Width = 510
  Height = 388
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object lblPrice: TLabel
    Left = 32
    Top = 312
    Width = 85
    Height = 25
    Caption = #1062#1077#1085#1072': 0'#1088
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object lblKassa: TLabel
    Left = 336
    Top = 160
    Width = 92
    Height = 25
    Caption = #1050#1072#1089#1089#1072': 0'#1088
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object lblMojshik: TLabel
    Left = 336
    Top = 192
    Width = 115
    Height = 25
    Caption = #1052#1086#1081#1097#1080#1082': 0'#1088
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object chkbTechM: TCheckBox
    Left = 24
    Top = 16
    Width = 177
    Height = 25
    Caption = #1058#1077#1093'. '#1084#1086#1081#1082#1072' 120'#1088
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 0
    OnClick = chkbTechMClick
  end
  object chkNar: TCheckBox
    Left = 24
    Top = 48
    Width = 169
    Height = 25
    Caption = #1053#1072#1088#1091#1078#1082#1072' 250'#1088
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 1
    OnClick = chkbTechMClick
  end
  object chkSal: TCheckBox
    Left = 24
    Top = 80
    Width = 137
    Height = 25
    Caption = #1057#1072#1083#1086#1085' 200'#1088
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 2
    OnClick = chkbTechMClick
  end
  object chkVoskHol: TCheckBox
    Left = 24
    Top = 112
    Width = 225
    Height = 25
    Caption = #1042#1086#1089#1082' '#1093#1086#1083#1086#1076#1085#1099#1081' 50'#1088
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 3
    OnClick = chkbTechMClick
  end
  object chkSilikon: TCheckBox
    Left = 24
    Top = 144
    Width = 225
    Height = 25
    Caption = #1057#1080#1083#1080#1082#1086#1085' 100'#1088
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 4
    OnClick = chkbTechMClick
  end
  object chkPolirol: TCheckBox
    Left = 24
    Top = 176
    Width = 225
    Height = 25
    Caption = #1055#1086#1083#1080#1088#1086#1083#1100' 100'#1088
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 5
    OnClick = chkbTechMClick
  end
  object chkTehMPena: TCheckBox
    Left = 24
    Top = 208
    Width = 265
    Height = 25
    Caption = #1058#1077#1093'. '#1084#1086#1081#1082#1072' + '#1087#1077#1085#1072' 200'#1088' '
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 6
    OnClick = chkbTechMClick
  end
  object chkCond: TCheckBox
    Left = 24
    Top = 240
    Width = 265
    Height = 25
    Caption = #1050#1086#1085#1076'. '#1082#1086#1078#1080' 100'#1088' '
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 7
    OnClick = chkbTechMClick
  end
  object chkVoskGor: TCheckBox
    Left = 24
    Top = 272
    Width = 265
    Height = 25
    Caption = #1042#1086#1089#1082' '#1075#1086#1088#1103#1095#1080#1081' 150'#1088
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 8
    OnClick = chkbTechMClick
  end
  object rb5: TRadioButton
    Left = 328
    Top = 48
    Width = 129
    Height = 25
    Caption = #1057#1082#1080#1076#1082#1072' 5%'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 9
    OnClick = chkbTechMClick
  end
  object rb15: TRadioButton
    Left = 328
    Top = 72
    Width = 145
    Height = 25
    Caption = #1057#1082#1080#1076#1082#1072' 15%'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 10
    OnClick = chkbTechMClick
  end
  object rb20: TRadioButton
    Left = 328
    Top = 96
    Width = 145
    Height = 25
    Caption = #1057#1082#1080#1076#1082#1072' 20%'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 11
    OnClick = chkbTechMClick
  end
  object rb30: TRadioButton
    Left = 328
    Top = 120
    Width = 145
    Height = 25
    Caption = #1057#1082#1080#1076#1082#1072' 30%'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 12
    OnClick = chkbTechMClick
  end
  object rb0: TRadioButton
    Left = 328
    Top = 24
    Width = 129
    Height = 25
    Caption = #1057#1082#1080#1076#1082#1072' 0%'
    Checked = True
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 13
    TabStop = True
    OnClick = chkbTechMClick
  end
end
