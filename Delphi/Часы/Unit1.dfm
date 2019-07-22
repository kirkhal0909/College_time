object Form1: TForm1
  Left = 1210
  Top = 485
  Width = 285
  Height = 122
  Caption = #1063#1072#1089#1099' - 15.04.2018'
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
  object lblTime: TLabel
    Left = 8
    Top = 0
    Width = 248
    Height = 76
    Caption = '24:24:24'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -63
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object tmr1: TTimer
    Interval = 500
    OnTimer = tmr1Timer
    Left = 160
    Top = 64
  end
end
