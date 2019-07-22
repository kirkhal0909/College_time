object Form1: TForm1
  Left = 198
  Top = 169
  Width = 614
  Height = 109
  Caption = 'Form1'
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
  object lblFlag: TLabel
    Left = 8
    Top = 8
    Width = 13
    Height = 48
    Caption = 'f'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -40
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object tmrTeleporter: TTimer
    Interval = 9
    OnTimer = tmrTeleporterTimer
    Left = 64
    Top = 72
  end
end
