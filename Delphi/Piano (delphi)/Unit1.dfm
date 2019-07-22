object Form1: TForm1
  Left = 161
  Top = 149
  BorderStyle = bsSingle
  Caption = 'Piano'
  ClientHeight = 299
  ClientWidth = 689
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  KeyPreview = True
  OldCreateOrder = False
  OnCreate = FormCreate
  OnKeyPress = FormKeyPress
  PixelsPerInch = 96
  TextHeight = 13
  object mp1: TMediaPlayer
    Left = 72
    Top = 64
    Width = 253
    Height = 30
    TabOrder = 0
  end
  object pnl1: TPanel
    Left = 0
    Top = 0
    Width = 689
    Height = 299
    Align = alClient
    Color = clGreen
    TabOrder = 1
    OnClick = pnl1Click
    object lbl1: TLabel
      Left = 336
      Top = 264
      Width = 11
      Height = 24
      Caption = '0'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -20
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object btnB24: TButton
      Left = 632
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 0
      OnClick = btnB1Click
    end
    object btnB22: TButton
      Left = 584
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 1
      OnClick = btnB1Click
    end
    object btnB20: TButton
      Left = 536
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 2
      OnClick = btnB1Click
    end
    object btnB18: TButton
      Left = 488
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 3
      OnClick = btnB1Click
    end
    object btnB17: TButton
      Left = 440
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 4
      OnClick = btnB1Click
    end
    object btnB15: TButton
      Left = 392
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 5
      OnClick = btnB1Click
    end
    object btnB13: TButton
      Left = 344
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 6
      OnClick = btnB1Click
    end
    object btnB12: TButton
      Left = 296
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 7
      OnClick = btnB1Click
    end
    object btnB10: TButton
      Left = 248
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 8
      OnClick = btnB1Click
    end
    object btnB8: TButton
      Left = 200
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 9
      OnClick = btnB1Click
    end
    object btnB6: TButton
      Left = 152
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 10
      OnClick = btnB1Click
    end
    object btnB5: TButton
      Left = 104
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 11
      OnClick = btnB1Click
    end
    object btnB3: TButton
      Left = 56
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 12
      OnClick = btnB1Click
    end
    object btnB1: TButton
      Left = 8
      Top = 8
      Width = 49
      Height = 249
      TabOrder = 13
      OnClick = btnB1Click
    end
    object btnB2: TButton
      Left = 40
      Top = 8
      Width = 28
      Height = 145
      TabOrder = 14
      OnClick = btnB1Click
    end
    object btnB4: TButton
      Left = 88
      Top = 8
      Width = 28
      Height = 145
      TabOrder = 15
      OnClick = btnB1Click
    end
    object btnB7: TButton
      Left = 184
      Top = 8
      Width = 28
      Height = 145
      TabOrder = 16
      OnClick = btnB1Click
    end
    object btnB9: TButton
      Left = 232
      Top = 8
      Width = 28
      Height = 145
      TabOrder = 17
      OnClick = btnB1Click
    end
    object btnB11: TButton
      Left = 280
      Top = 8
      Width = 28
      Height = 145
      TabOrder = 18
      OnClick = btnB1Click
    end
    object btnB14: TButton
      Left = 376
      Top = 8
      Width = 28
      Height = 145
      TabOrder = 19
      OnClick = btnB1Click
    end
    object btnB16: TButton
      Left = 424
      Top = 8
      Width = 28
      Height = 145
      TabOrder = 20
      OnClick = btnB1Click
    end
    object btnB19: TButton
      Left = 520
      Top = 8
      Width = 28
      Height = 145
      TabOrder = 21
      OnClick = btnB1Click
    end
    object btnB21: TButton
      Left = 568
      Top = 8
      Width = 28
      Height = 145
      TabOrder = 22
      OnClick = btnB1Click
    end
    object btnB23: TButton
      Left = 616
      Top = 8
      Width = 28
      Height = 145
      TabOrder = 23
      OnClick = btnB1Click
    end
    object btn1: TButton
      Left = 300
      Top = 262
      Width = 25
      Height = 30
      Caption = '<'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -20
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 24
      OnClick = btn1Click
    end
    object btn2: TButton
      Left = 360
      Top = 262
      Width = 25
      Height = 30
      Caption = '>'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -20
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 25
      OnClick = btn2Click
    end
    object edt1: TEdit
      Left = 64
      Top = 262
      Width = 41
      Height = 27
      Hint = '1-128'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      ParentShowHint = False
      ShowHint = True
      TabOrder = 26
      Text = '1'
      OnChange = edt1Change
      OnClick = edt1Click
      OnExit = edt1Exit
      OnKeyPress = edt1KeyPress
    end
    object btn3: TButton
      Left = 36
      Top = 263
      Width = 25
      Height = 30
      Caption = '<'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -20
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 27
      OnClick = btn3Click
    end
    object btn4: TButton
      Left = 112
      Top = 263
      Width = 25
      Height = 30
      Caption = '>'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -20
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 28
      OnClick = btn4Click
    end
  end
  object tmr1: TTimer
    Enabled = False
    Interval = 2000
    OnTimer = tmr1Timer
    Left = 200
    Top = 264
  end
end
