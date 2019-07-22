object Form1: TForm1
  Left = 320
  Top = 142
  Width = 597
  Height = 299
  Caption = 'BotAct'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  KeyPreview = True
  Menu = mm
  OldCreateOrder = False
  OnClose = FormClose
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object pnlKeybd: TPanel
    Left = 0
    Top = 0
    Width = 581
    Height = 41
    Align = alTop
    BevelOuter = bvNone
    Caption = 'pnlKeybd'
    Color = clMoneyGreen
    TabOrder = 0
    object ListActions: TComboBox
      Left = 72
      Top = 4
      Width = 145
      Height = 31
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ItemHeight = 23
      ParentFont = False
      TabOrder = 0
      Text = 'Keyboard'
      OnChange = ListActionsChange
      Items.Strings = (
        'Keyboard'
        'Mouse'
        'Sleep'
        'Repeat')
    end
    object InpKey: TEdit
      Left = 352
      Top = 4
      Width = 57
      Height = 31
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 1
      Text = 'InpKey'
      OnKeyDown = InpKeyKeyDown
      OnKeyPress = InpKeyKeyPress
    end
    object edtNum: TEdit
      Left = 36
      Top = 4
      Width = 33
      Height = 31
      BevelOuter = bvNone
      BiDiMode = bdLeftToRight
      Enabled = False
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentBiDiMode = False
      ParentFont = False
      ReadOnly = True
      TabOrder = 2
      Text = '1'
    end
    object ListEvent: TComboBox
      Left = 224
      Top = 4
      Width = 121
      Height = 31
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ItemHeight = 23
      ItemIndex = 0
      ParentFont = False
      TabOrder = 3
      Text = 'Press'
      Items.Strings = (
        'Press'
        'Down'
        'Up')
    end
    object btnDelT: TBitBtn
      Left = 5
      Top = 8
      Width = 28
      Height = 25
      Caption = ' '
      TabOrder = 4
      OnClick = btnDelTClick
      Kind = bkCancel
    end
  end
  object pnlMouse: TPanel
    Left = 0
    Top = 82
    Width = 581
    Height = 41
    Align = alTop
    BevelOuter = bvNone
    Caption = 'pnl1'
    Color = clActiveCaption
    TabOrder = 1
    object cbb1: TComboBox
      Left = 72
      Top = 4
      Width = 145
      Height = 31
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ItemHeight = 23
      ItemIndex = 0
      ParentFont = False
      TabOrder = 0
      Text = 'Mouse'
      Items.Strings = (
        'Mouse')
    end
    object edt2: TEdit
      Left = 36
      Top = 4
      Width = 33
      Height = 31
      Enabled = False
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      ReadOnly = True
      TabOrder = 1
      Text = '3'
    end
    object cbb2: TComboBox
      Left = 224
      Top = 4
      Width = 121
      Height = 31
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ItemHeight = 23
      ItemIndex = 0
      ParentFont = False
      TabOrder = 2
      Text = 'Press'
      Items.Strings = (
        'Press'
        'Down'
        'Up')
    end
    object InpInt: TEdit
      Left = 456
      Top = 4
      Width = 57
      Height = 31
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 3
      Text = 'X'
      OnChange = InpIntChange
      OnKeyPress = InpIntKeyPress
    end
    object InpXY: TEdit
      Left = 520
      Top = 4
      Width = 57
      Height = 31
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 4
      Text = 'Y'
      OnKeyDown = InpXYKeyDown
      OnKeyUp = InpXYKeyUp
    end
    object btnRemove: TBitBtn
      Left = 5
      Top = 8
      Width = 28
      Height = 25
      Caption = ' '
      TabOrder = 5
      Kind = bkCancel
    end
    object ListMouseKeyses: TComboBox
      Left = 352
      Top = 2
      Width = 73
      Height = 31
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ItemHeight = 23
      ParentFont = False
      TabOrder = 6
      Text = 'Press'
      Items.Strings = (
        'Left'
        'Right'
        'Mid')
    end
  end
  object btnAddPnl: TButton
    Left = 320
    Top = 184
    Width = 41
    Height = 33
    Caption = '+'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 2
    TabStop = False
    Visible = False
    OnClick = btnAddPnlClick
  end
  object Panel1: TPanel
    Left = 0
    Top = 123
    Width = 581
    Height = 41
    Align = alTop
    BevelOuter = bvNone
    Caption = 'pnl1'
    Color = clMaroon
    TabOrder = 3
    object ComboBox1: TComboBox
      Left = 72
      Top = 4
      Width = 145
      Height = 31
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ItemHeight = 23
      ItemIndex = 0
      ParentFont = False
      TabOrder = 0
      Text = 'Sleep'
      Items.Strings = (
        'Sleep')
    end
    object Edit1: TEdit
      Left = 36
      Top = 4
      Width = 33
      Height = 31
      Enabled = False
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      ReadOnly = True
      TabOrder = 1
      Text = '4'
    end
    object Edit2: TEdit
      Left = 224
      Top = 4
      Width = 121
      Height = 31
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 2
      Text = 'msec'
    end
    object btn3: TBitBtn
      Left = 5
      Top = 8
      Width = 28
      Height = 25
      Caption = ' '
      TabOrder = 3
      Kind = bkCancel
    end
  end
  object Panel2: TPanel
    Left = 0
    Top = 41
    Width = 581
    Height = 41
    Align = alTop
    BevelOuter = bvNone
    Caption = 'pnl1'
    Color = clGrayText
    TabOrder = 4
    object ComboBox2: TComboBox
      Left = 72
      Top = 4
      Width = 145
      Height = 31
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ItemHeight = 23
      ItemIndex = 3
      ParentFont = False
      TabOrder = 0
      Text = 'Repeat'
      Items.Strings = (
        'Keyboard'
        'Mouse'
        'Sleep'
        'Repeat')
    end
    object Edit3: TEdit
      Left = 224
      Top = 4
      Width = 57
      Height = 31
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 1
      Text = 'From'
    end
    object Edit4: TEdit
      Left = 36
      Top = 4
      Width = 33
      Height = 31
      Enabled = False
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      ReadOnly = True
      TabOrder = 2
      Text = '2'
    end
    object edt1: TEdit
      Left = 288
      Top = 4
      Width = 57
      Height = 31
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
      TabOrder = 3
      Text = 'To'
    end
    object btn1: TBitBtn
      Left = 5
      Top = 8
      Width = 28
      Height = 25
      Caption = ' '
      TabOrder = 4
      Kind = bkCancel
    end
  end
  object mm: TMainMenu
    Left = 32
    Top = 144
    object mniFile: TMenuItem
      Caption = 'File'
      object mniNew: TMenuItem
        Caption = 'New'
        OnClick = mniNewClick
      end
      object mniOpen: TMenuItem
        Caption = 'Open'
        OnClick = mniOpenClick
      end
      object mniSave: TMenuItem
        Caption = 'Save'
        OnClick = mniSaveClick
      end
      object mniSaveAs: TMenuItem
        Caption = 'Save As...'
        OnClick = mniSaveAsClick
      end
    end
    object mniOptions: TMenuItem
      Caption = 'Options'
      OnClick = mniOptionsClick
    end
  end
  object aplctnvnts: TApplicationEvents
    OnMinimize = aplctnvntsMinimize
    Left = 104
    Top = 192
  end
end
