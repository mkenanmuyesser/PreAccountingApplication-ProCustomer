VERSION 5.00
Object = "{ABD767AA-AF41-4B9C-909B-160B2AF85190}#1.0#0"; "cidv5callerid.dll"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3030
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   2310
   LinkTopic       =   "Form1"
   ScaleHeight     =   3030
   ScaleWidth      =   2310
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox Text1 
      Height          =   1335
      Left            =   120
      TabIndex        =   1
      Text            =   "Text1"
      Top             =   240
      Width           =   1935
   End
   Begin cidv5callerid.CIDv5 CIDv51 
      Height          =   390
      Left            =   480
      TabIndex        =   0
      Top             =   2160
      Width           =   390
      Object.Visible         =   -1  'True
      AutoScroll      =   0   'False
      AutoSize        =   -1  'True
      AxBorderStyle   =   1
      Caption         =   "CIDv5"
      Color           =   -16777201
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   162
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      KeyPreview      =   0   'False
      PixelsPerInch   =   96
      PrintScale      =   1
      Scaled          =   -1  'True
      DropTarget      =   0   'False
      HelpFile        =   ""
      ScreenSnap      =   0   'False
      SnapBuffer      =   10
      DoubleBuffered  =   0   'False
      Enabled         =   -1  'True
      About           =   "Caller ID v5 - Sistemler.com  © Her hakký saklýdýr 2005-2009"
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Form_Load()
    CIDv51.Visible = False
    CIDv51.Start
End Sub


Private Sub CIDv51_OnCallerID(ByVal DeviceID As String, ByVal Line As String, ByVal PhoneNumber As String, ByVal DateTime As String, ByVal OtherText As String)
   Text1.Text = PhoneNumber
End Sub


