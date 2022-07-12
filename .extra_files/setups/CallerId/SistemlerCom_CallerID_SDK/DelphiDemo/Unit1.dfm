object Form1: TForm1
  Left = 416
  Top = 273
  Width = 531
  Height = 384
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 482
    Top = 187
    Width = 25
    Height = 13
    AutoSize = False
    Caption = '-'
  end
  object Label2: TLabel
    Left = 482
    Top = 211
    Width = 25
    Height = 13
    AutoSize = False
    Caption = '-'
  end
  object Label3: TLabel
    Left = 482
    Top = 235
    Width = 25
    Height = 13
    AutoSize = False
    Caption = '-'
  end
  object Label4: TLabel
    Left = 482
    Top = 259
    Width = 25
    Height = 13
    AutoSize = False
    Caption = '-'
  end
  object Label6: TLabel
    Left = 15
    Top = 185
    Width = 56
    Height = 16
    Caption = 'Telefon 1'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Label7: TLabel
    Left = 15
    Top = 209
    Width = 56
    Height = 16
    Caption = 'Telefon 2'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Label8: TLabel
    Left = 15
    Top = 233
    Width = 56
    Height = 16
    Caption = 'Telefon 3'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Label15: TLabel
    Left = 15
    Top = 257
    Width = 56
    Height = 16
    Caption = 'Telefon 4'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Memo1: TMemo
    Left = 16
    Top = 24
    Width = 393
    Height = 137
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -15
    Font.Name = 'Verdana'
    Font.Style = []
    Lines.Strings = (
      'Memo1')
    ParentFont = False
    TabOrder = 0
    OnChange = Memo1Change
  end
  object StatusBar1: TStatusBar
    Left = 0
    Top = 324
    Width = 515
    Height = 24
    Panels = <>
    SimplePanel = True
    SimpleText = '  Cihaz ba'#287'lant'#305's'#305' bekleniyor...'
  end
  object ProgressBar1: TProgressBar
    Left = 84
    Top = 185
    Width = 376
    Height = 17
    Max = 64
    Smooth = True
    TabOrder = 2
  end
  object ProgressBar2: TProgressBar
    Left = 84
    Top = 209
    Width = 376
    Height = 17
    Max = 64
    Smooth = True
    TabOrder = 3
  end
  object ProgressBar3: TProgressBar
    Left = 84
    Top = 233
    Width = 376
    Height = 17
    Max = 64
    Smooth = True
    TabOrder = 4
  end
  object ProgressBar4: TProgressBar
    Left = 84
    Top = 257
    Width = 376
    Height = 17
    Max = 64
    Smooth = True
    TabOrder = 5
  end
  object Timer1: TTimer
    OnTimer = Timer1Timer
    Left = 64
    Top = 56
  end
end
