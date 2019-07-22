object Form1: TForm1
  Left = 388
  Top = 135
  Width = 1044
  Height = 540
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
  object idsmtp2: TIdSMTP
    MaxLineAction = maException
    Port = 25
    AuthenticationType = atNone
    Left = 336
    Top = 80
  end
  object idmsg1: TIdMessage
    AttachmentEncoding = 'MIME'
    BccList = <>
    CCList = <>
    DeleteTempFiles = False
    Encoding = meMIME
    Recipients = <>
    ReplyTo = <>
    Left = 440
    Top = 120
  end
end
