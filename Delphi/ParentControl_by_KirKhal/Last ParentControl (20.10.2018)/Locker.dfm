object Form3: TForm3
  Left = 305
  Top = 192
  BorderStyle = bsNone
  Caption = 'Form3'
  ClientHeight = 324
  ClientWidth = 393
  Color = cl3DLight
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  FormStyle = fsStayOnTop
  KeyPreview = True
  OldCreateOrder = False
  OnClose = FormClose
  OnCreate = FormCreate
  OnKeyDown = FormKeyDown
  PixelsPerInch = 96
  TextHeight = 13
  object pnlLine: TPanel
    Left = 0
    Top = 0
    Width = 409
    Height = 324
    TabOrder = 0
    object pnlForm: TPanel
      Left = 8
      Top = 8
      Width = 377
      Height = 305
      Color = clScrollBar
      TabOrder = 0
      object lblPass: TLabel
        Left = 96
        Top = 40
        Width = 72
        Height = 23
        Caption = #1055#1072#1088#1086#1083#1100':'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -19
        Font.Name = 'Tahoma'
        Font.Style = []
        ParentFont = False
      end
      object lblInfo: TLabel
        Left = 104
        Top = 212
        Width = 185
        Height = 46
        Caption = #1041#1083#1086#1082#1080#1088#1072#1090#1086#1088' '#1079#1072#1075#1088#1091#1079#1082#1080#13#10'  '#1088#1072#1073#1086#1095#1077#1075#1086' '#1089#1090#1086#1083#1072
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowFrame
        Font.Height = -19
        Font.Name = 'Tahoma'
        Font.Style = []
        ParentFont = False
      end
      object edtPass: TEdit
        Left = 96
        Top = 64
        Width = 201
        Height = 31
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -19
        Font.Name = 'Tahoma'
        Font.Style = []
        ParentFont = False
        PasswordChar = '*'
        TabOrder = 1
        OnKeyPress = edtPassKeyPress
      end
      object chkShow: TCheckBox
        Left = 96
        Top = 96
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
      object btnUnlock: TButton
        Left = 96
        Top = 124
        Width = 201
        Height = 34
        Caption = #1056#1072#1079#1073#1083#1086#1082#1080#1088#1086#1074#1072#1090#1100
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -19
        Font.Name = 'Tahoma'
        Font.Style = []
        ParentFont = False
        TabOrder = 3
        OnClick = btnUnlockClick
      end
      object btnShutDown: TButton
        Left = 96
        Top = 164
        Width = 201
        Height = 34
        Caption = #1042#1099#1082#1083#1102#1095#1080#1090#1100' '#1082#1086#1084#1087#1100#1102#1090#1077#1088
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -16
        Font.Name = 'Tahoma'
        Font.Style = []
        ParentFont = False
        TabOrder = 0
        OnClick = btnShutDownClick
      end
    end
  end
  object tmrTaskkill: TTimer
    Enabled = False
    Interval = 20000
    OnTimer = tmrTaskkillTimer
    Left = 184
    Top = 40
  end
end
