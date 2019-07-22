object Form2: TForm2
  Left = 459
  Top = 319
  BorderStyle = bsDialog
  Caption = 'Form2'
  ClientHeight = 104
  ClientWidth = 243
  Color = clScrollBar
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
    Width = 141
    Height = 23
    Caption = #1057#1090#1072#1088#1099#1081' '#1087#1072#1088#1086#1083#1100':'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object btnSetup: TButton
    Left = 186
    Top = 75
    Width = 49
    Height = 25
    Caption = #1042#1074#1086#1076
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 1
    OnClick = btnSetupClick
  end
  object edtPass: TEdit
    Left = 4
    Top = 40
    Width = 233
    Height = 31
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    PasswordChar = '*'
    TabOrder = 0
    OnKeyPress = edtPassKeyPress
  end
  object chkShow: TCheckBox
    Left = 8
    Top = 72
    Width = 177
    Height = 25
    TabStop = False
    Caption = #1055#1086#1082#1072#1079#1072#1090#1100' '#1087#1072#1088#1086#1083#1100
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 2
    OnClick = chkShowClick
  end
end
