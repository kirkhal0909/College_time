object Form1: TForm1
  Left = 203
  Top = 308
  BorderStyle = bsDialog
  Caption = #1059#1089#1090#1072#1085#1086#1074#1082#1072' '#1073#1083#1086#1082#1080#1088#1086#1074#1082#1080
  ClientHeight = 183
  ClientWidth = 421
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object lblInfo: TLabel
    Left = 8
    Top = 8
    Width = 399
    Height = 115
    Caption = 
      #1055#1088#1086#1075#1088#1072#1084#1084#1072' '#1086#1089#1090#1072#1085#1072#1074#1083#1080#1074#1072#1077#1090' '#1079#1072#1075#1088#1091#1079#1082#1091' '#1088#1072#1073#1086#1095#1077#1075#1086#13#10#1089#1090#1086#1083#1072' '#1087#1086#1089#1083#1077' '#1074#1093#1086#1076#1072' '#1074' '#1083 +
      #1102#1073#1086#1075#1086' '#1087#1086#1083#1100#1079#1086#1074#1072#1090#1077#1083#1103'. '#1048#13#10#1076#1083#1103' '#1087#1088#1086#1076#1086#1083#1078#1077#1085#1080#1103' '#1088#1072#1073#1086#1090#1099' '#1090#1088#1077#1073#1091#1077#1090' '#1079#1072#1076#1072#1085#1085#1086#1075#1086#13 +
      #10#1088#1086#1076#1080#1090#1077#1083#1077#1084' '#1087#1072#1088#1086#1083#1103#13#10
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowFrame
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object lblStatus: TLabel
    Left = 8
    Top = 152
    Width = 293
    Height = 23
    Caption = #1057#1090#1072#1090#1091#1089' '#1072#1074#1090#1086#1079#1072#1075#1088#1091#1079#1082#1080' '#1073#1083#1086#1082#1080#1088#1086#1074#1082#1080':'
    Color = clBtnFace
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentColor = False
    ParentFont = False
  end
  object lblStatusInfo: TLabel
    Left = 304
    Top = 152
    Width = 94
    Height = 23
    Caption = #1086#1090#1082#1083#1102#1095#1077#1085#1072
    Color = clBtnFace
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clMaroon
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentColor = False
    ParentFont = False
  end
  object btnSetup: TButton
    Left = 8
    Top = 112
    Width = 201
    Height = 33
    Caption = #1055#1086#1089#1090#1072#1074#1080#1090#1100' '#1087#1072#1088#1086#1083#1100
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -23
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 1
    OnClick = btnSetupClick
  end
  object btnBack: TButton
    Left = 216
    Top = 112
    Width = 193
    Height = 33
    Caption = #1057#1073#1088#1086#1089#1080#1090#1100' '#1087#1072#1088#1086#1083#1100
    Enabled = False
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clMaroon
    Font.Height = -23
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 2
    OnClick = btnBackClick
  end
  object edtPass: TEdit
    Left = 176
    Top = 80
    Width = 233
    Height = 24
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 0
  end
end
