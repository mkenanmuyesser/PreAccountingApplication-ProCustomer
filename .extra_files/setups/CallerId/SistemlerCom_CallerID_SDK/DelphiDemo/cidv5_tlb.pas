unit cidv5_tlb;

{$TYPEDADDRESS OFF} // Unit must be compiled without type-checked pointers. 
{$WARN SYMBOL_PLATFORM OFF}
{$WRITEABLECONST ON}

interface

uses Windows, ActiveX, Classes, Graphics, OleCtrls, OleServer, StdVCL, Variants;
  
const
  cidv5calleridMajorVersion = 1;
  cidv5calleridMinorVersion = 0;

  LIBID_cidv5callerid: TGUID = '{ABD767AA-AF41-4B9C-909B-160B2AF85190}';

  IID_ICIDv5: TGUID = '{0A16189E-10E9-4A76-8D2D-0A8F1AD4729A}';
  DIID_ICIDv5Events: TGUID = '{B6A36C9A-2DC9-4CEF-AF6E-D6DDD2F91CC4}';
  CLASS_CIDv5: TGUID = '{EEA18052-171F-4293-8598-AB6E1D7257B2}';

type
  TxActiveFormBorderStyle = TOleEnum;
const
  afbNone = $00000000;
  afbSingle = $00000001;
  afbSunken = $00000002;
  afbRaised = $00000003;

type
  TxPrintScale = TOleEnum;
const
  poNone = $00000000;
  poProportional = $00000001;
  poPrintToFit = $00000002;

type
  TxMouseButton = TOleEnum;
const
  mbLeft = $00000000;
  mbRight = $00000001;
  mbMiddle = $00000002;

type

  ICIDv5 = interface;
  ICIDv5Disp = dispinterface;
  ICIDv5Events = dispinterface;

  CIDv5 = ICIDv5;


  PPUserType1 = ^IFontDisp; {*}

// *********************************************************************//
// Interface: ICIDv5
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {0A16189E-10E9-4A76-8D2D-0A8F1AD4729A}
// *********************************************************************//
  ICIDv5 = interface(IDispatch)
    ['{0A16189E-10E9-4A76-8D2D-0A8F1AD4729A}']
    function Get_Visible: WordBool; safecall;
    procedure Set_Visible(Value: WordBool); safecall;
    function Get_AutoScroll: WordBool; safecall;
    procedure Set_AutoScroll(Value: WordBool); safecall;
    function Get_AutoSize: WordBool; safecall;
    procedure Set_AutoSize(Value: WordBool); safecall;
    function Get_AxBorderStyle: TxActiveFormBorderStyle; safecall;
    procedure Set_AxBorderStyle(Value: TxActiveFormBorderStyle); safecall;
    function Get_Caption: WideString; safecall;
    procedure Set_Caption(const Value: WideString); safecall;
    function Get_Color: OLE_COLOR; safecall;
    procedure Set_Color(Value: OLE_COLOR); safecall;
    function Get_Font: IFontDisp; safecall;
    procedure Set_Font(const Value: IFontDisp); safecall;
    procedure _Set_Font(var Value: IFontDisp); safecall;
    function Get_KeyPreview: WordBool; safecall;
    procedure Set_KeyPreview(Value: WordBool); safecall;
    function Get_PixelsPerInch: Integer; safecall;
    procedure Set_PixelsPerInch(Value: Integer); safecall;
    function Get_PrintScale: TxPrintScale; safecall;
    procedure Set_PrintScale(Value: TxPrintScale); safecall;
    function Get_Scaled: WordBool; safecall;
    procedure Set_Scaled(Value: WordBool); safecall;
    function Get_Active: WordBool; safecall;
    function Get_DropTarget: WordBool; safecall;
    procedure Set_DropTarget(Value: WordBool); safecall;
    function Get_HelpFile: WideString; safecall;
    procedure Set_HelpFile(const Value: WideString); safecall;
    function Get_ScreenSnap: WordBool; safecall;
    procedure Set_ScreenSnap(Value: WordBool); safecall;
    function Get_SnapBuffer: Integer; safecall;
    procedure Set_SnapBuffer(Value: Integer); safecall;
    function Get_DoubleBuffered: WordBool; safecall;
    procedure Set_DoubleBuffered(Value: WordBool); safecall;
    function Get_AlignDisabled: WordBool; safecall;
    function Get_VisibleDockClientCount: Integer; safecall;
    function Get_Enabled: WordBool; safecall;
    procedure Set_Enabled(Value: WordBool); safecall;
    procedure AboutBox; safecall;
    procedure Start; safecall;
    function Get_About: WideString; safecall;
    procedure Set_About(const Value: WideString); safecall;
    function Command(const Command: WideString): WideString; safecall;
    property Visible: WordBool read Get_Visible write Set_Visible;
    property AutoScroll: WordBool read Get_AutoScroll write Set_AutoScroll;
    property AutoSize: WordBool read Get_AutoSize write Set_AutoSize;
    property AxBorderStyle: TxActiveFormBorderStyle read Get_AxBorderStyle write Set_AxBorderStyle;
    property Caption: WideString read Get_Caption write Set_Caption;
    property Color: OLE_COLOR read Get_Color write Set_Color;
    property Font: IFontDisp read Get_Font write Set_Font;
    property KeyPreview: WordBool read Get_KeyPreview write Set_KeyPreview;
    property PixelsPerInch: Integer read Get_PixelsPerInch write Set_PixelsPerInch;
    property PrintScale: TxPrintScale read Get_PrintScale write Set_PrintScale;
    property Scaled: WordBool read Get_Scaled write Set_Scaled;
    property Active: WordBool read Get_Active;
    property DropTarget: WordBool read Get_DropTarget write Set_DropTarget;
    property HelpFile: WideString read Get_HelpFile write Set_HelpFile;
    property ScreenSnap: WordBool read Get_ScreenSnap write Set_ScreenSnap;
    property SnapBuffer: Integer read Get_SnapBuffer write Set_SnapBuffer;
    property DoubleBuffered: WordBool read Get_DoubleBuffered write Set_DoubleBuffered;
    property AlignDisabled: WordBool read Get_AlignDisabled;
    property VisibleDockClientCount: Integer read Get_VisibleDockClientCount;
    property Enabled: WordBool read Get_Enabled write Set_Enabled;
    property About: WideString read Get_About write Set_About;
  end;

// *********************************************************************//
// DispIntf:  ICIDv5Disp
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {0A16189E-10E9-4A76-8D2D-0A8F1AD4729A}
// *********************************************************************//
  ICIDv5Disp = dispinterface
    ['{0A16189E-10E9-4A76-8D2D-0A8F1AD4729A}']
    property Visible: WordBool dispid 201;
    property AutoScroll: WordBool dispid 202;
    property AutoSize: WordBool dispid 203;
    property AxBorderStyle: TxActiveFormBorderStyle dispid 204;
    property Caption: WideString dispid -518;
    property Color: OLE_COLOR dispid -501;
    property Font: IFontDisp dispid -512;
    property KeyPreview: WordBool dispid 205;
    property PixelsPerInch: Integer dispid 206;
    property PrintScale: TxPrintScale dispid 207;
    property Scaled: WordBool dispid 208;
    property Active: WordBool readonly dispid 209;
    property DropTarget: WordBool dispid 210;
    property HelpFile: WideString dispid 211;
    property ScreenSnap: WordBool dispid 212;
    property SnapBuffer: Integer dispid 213;
    property DoubleBuffered: WordBool dispid 214;
    property AlignDisabled: WordBool readonly dispid 215;
    property VisibleDockClientCount: Integer readonly dispid 216;
    property Enabled: WordBool dispid -514;
    procedure AboutBox; dispid -552;
    procedure Start; dispid 217;
    property About: WideString dispid 218;
    function Command(const Command: WideString): WideString; dispid 220;
  end;

// *********************************************************************//
// DispIntf:  ICIDv5Events
// Flags:     (4096) Dispatchable
// GUID:      {B6A36C9A-2DC9-4CEF-AF6E-D6DDD2F91CC4}
// *********************************************************************//
  ICIDv5Events = dispinterface
    ['{B6A36C9A-2DC9-4CEF-AF6E-D6DDD2F91CC4}']
    procedure OnActivate; dispid 201;
    procedure OnClick; dispid 202;
    procedure OnCreate; dispid 203;
    procedure OnDblClick; dispid 204;
    procedure OnDestroy; dispid 205;
    procedure OnDeactivate; dispid 206;
    procedure OnKeyPress(var Key: Smallint); dispid 207;
    procedure OnPaint; dispid 208;
    procedure OnCallerID(const DeviceID: WideString; const Line: WideString; 
                         const PhoneNumber: WideString; const DateTime: WideString; 
                         const OtherText: WideString); dispid 209;
    procedure OnSignalA(const Level1: WideString; const Level2: WideString; 
                        const Level3: WideString; const Level4: WideString; 
                        const Level5: WideString; const Level6: WideString; 
                        const Level7: WideString; const Level8: WideString); dispid 210;
  end;


// *********************************************************************//
// OLE Control Proxy class declaration
// Control Name     : TCIDv5
// Help String      : CIDv5 Control
// Default Interface: ICIDv5
// Def. Intf. DISP? : No
// Event   Interface: ICIDv5Events
// TypeFlags        : (34) CanCreate Control
// *********************************************************************//
  TCIDv5OnKeyPress = procedure(ASender: TObject; var Key: Smallint) of object;
  TCIDv5OnCallerID = procedure(ASender: TObject; const DeviceID: WideString; 
                                                 const Line: WideString; 
                                                 const PhoneNumber: WideString; 
                                                 const DateTime: WideString; 
                                                 const OtherText: WideString) of object;
  TCIDv5OnSignalA = procedure(ASender: TObject; const Level1: WideString; const Level2: WideString; 
                                                const Level3: WideString; const Level4: WideString; 
                                                const Level5: WideString; const Level6: WideString; 
                                                const Level7: WideString; const Level8: WideString) of object;

  TCIDv5 = class(TOleControl)
  private
    FOnActivate: TNotifyEvent;
    FOnClick: TNotifyEvent;
    FOnCreate: TNotifyEvent;
    FOnDblClick: TNotifyEvent;
    FOnDestroy: TNotifyEvent;
    FOnDeactivate: TNotifyEvent;
    FOnKeyPress: TCIDv5OnKeyPress;
    FOnPaint: TNotifyEvent;
    FOnCallerID: TCIDv5OnCallerID;
    FOnSignalA: TCIDv5OnSignalA;
    FIntf: ICIDv5;
    function  GetControlInterface: ICIDv5;
  protected
    procedure CreateControl;
    procedure InitControlData; override;
  public
    procedure AboutBox;
    procedure Start;
    function Command(const Command: WideString): WideString;
    property  ControlInterface: ICIDv5 read GetControlInterface;
    property  DefaultInterface: ICIDv5 read GetControlInterface;
    property Visible: WordBool index 201 read GetWordBoolProp write SetWordBoolProp;
    property Active: WordBool index 209 read GetWordBoolProp;
    property DropTarget: WordBool index 210 read GetWordBoolProp write SetWordBoolProp;
    property HelpFile: WideString index 211 read GetWideStringProp write SetWideStringProp;
    property ScreenSnap: WordBool index 212 read GetWordBoolProp write SetWordBoolProp;
    property SnapBuffer: Integer index 213 read GetIntegerProp write SetIntegerProp;
    property DoubleBuffered: WordBool index 214 read GetWordBoolProp write SetWordBoolProp;
    property AlignDisabled: WordBool index 215 read GetWordBoolProp;
    property VisibleDockClientCount: Integer index 216 read GetIntegerProp;
    property Enabled: WordBool index -514 read GetWordBoolProp write SetWordBoolProp;
  published
    property Anchors;
    property  ParentColor;
    property  ParentFont;
    property  Align;
    property  DragCursor;
    property  DragMode;
    property  ParentShowHint;
    property  PopupMenu;
    property  ShowHint;
    property  TabOrder;
    property  OnDragDrop;
    property  OnDragOver;
    property  OnEndDrag;
    property  OnEnter;
    property  OnExit;
    property  OnStartDrag;
    property AutoScroll: WordBool index 202 read GetWordBoolProp write SetWordBoolProp stored False;
    property AutoSize: WordBool index 203 read GetWordBoolProp write SetWordBoolProp stored False;
    property AxBorderStyle: TOleEnum index 204 read GetTOleEnumProp write SetTOleEnumProp stored False;
    property Caption: WideString index -518 read GetWideStringProp write SetWideStringProp stored False;
    property Color: TColor index -501 read GetTColorProp write SetTColorProp stored False;
    property Font: TFont index -512 read GetTFontProp write SetTFontProp stored False;
    property KeyPreview: WordBool index 205 read GetWordBoolProp write SetWordBoolProp stored False;
    property PixelsPerInch: Integer index 206 read GetIntegerProp write SetIntegerProp stored False;
    property PrintScale: TOleEnum index 207 read GetTOleEnumProp write SetTOleEnumProp stored False;
    property Scaled: WordBool index 208 read GetWordBoolProp write SetWordBoolProp stored False;
    property About: WideString index 218 read GetWideStringProp write SetWideStringProp stored False;
    property OnActivate: TNotifyEvent read FOnActivate write FOnActivate;
    property OnClick: TNotifyEvent read FOnClick write FOnClick;
    property OnCreate: TNotifyEvent read FOnCreate write FOnCreate;
    property OnDblClick: TNotifyEvent read FOnDblClick write FOnDblClick;
    property OnDestroy: TNotifyEvent read FOnDestroy write FOnDestroy;
    property OnDeactivate: TNotifyEvent read FOnDeactivate write FOnDeactivate;
    property OnKeyPress: TCIDv5OnKeyPress read FOnKeyPress write FOnKeyPress;
    property OnPaint: TNotifyEvent read FOnPaint write FOnPaint;
    property OnCallerID: TCIDv5OnCallerID read FOnCallerID write FOnCallerID;
    property OnSignalA: TCIDv5OnSignalA read FOnSignalA write FOnSignalA;
  end;

procedure Register;

resourcestring
  dtlServerPage = 'ActiveX';

  dtlOcxPage = 'ActiveX';

implementation

uses ComObj;

procedure TCIDv5.InitControlData;
const
  CEventDispIDs: array [0..9] of DWORD = (
    $000000C9, $000000CA, $000000CB, $000000CC, $000000CD, $000000CE,
    $000000CF, $000000D0, $000000D1, $000000D2);
  CTFontIDs: array [0..0] of DWORD = (
    $FFFFFE00);
  CControlData: TControlData2 = (
    ClassID: '{EEA18052-171F-4293-8598-AB6E1D7257B2}';
    EventIID: '{B6A36C9A-2DC9-4CEF-AF6E-D6DDD2F91CC4}';
    EventCount: 10;
    EventDispIDs: @CEventDispIDs;
    LicenseKey: nil (*HR:$00000000*);
    Flags: $0000001D;
    Version: 401;
    FontCount: 1;
    FontIDs: @CTFontIDs);
begin
  ControlData := @CControlData;
  TControlData2(CControlData).FirstEventOfs := Cardinal(@@FOnActivate) - Cardinal(Self);
end;

procedure TCIDv5.CreateControl;

  procedure DoCreate;
  begin
    FIntf := IUnknown(OleObject) as ICIDv5;
  end;

begin
  if FIntf = nil then DoCreate;
end;

function TCIDv5.GetControlInterface: ICIDv5;
begin
  CreateControl;
  Result := FIntf;
end;

procedure TCIDv5.AboutBox;
begin
  DefaultInterface.AboutBox;
end;

procedure TCIDv5.Start;
begin
  DefaultInterface.Start;
end;

function TCIDv5.Command(const Command: WideString): WideString;
begin
  Result := DefaultInterface.Command(Command);
end;

procedure Register;
begin
  RegisterComponents(dtlOcxPage, [TCIDv5]);
end;

end.
