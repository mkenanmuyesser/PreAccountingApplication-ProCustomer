unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, OleCtrls, cidv5_tlb, StdCtrls, ExtCtrls, ComCtrls;

type
  TForm1 = class(TForm)
    Memo1: TMemo;
    StatusBar1: TStatusBar;
    Timer1: TTimer;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label15: TLabel;
    ProgressBar1: TProgressBar;
    ProgressBar2: TProgressBar;
    ProgressBar3: TProgressBar;
    ProgressBar4: TProgressBar;

    procedure CID_olay(ASender: TObject; const DeviceID, Line,
      PhoneNumber, DateTime, OtherText: WideString);

    procedure CIDSignal(ASender: TObject; const Level1, Level2, Level3,
      Level4, Level5, Level6, Level7, Level8: WideString);

    procedure Timer1Timer(Sender: TObject);
    procedure Memo1Change(Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  CIDnesne: TCIDv5;

implementation

{$R *.dfm}

procedure TForm1.CID_olay(ASender: TObject; const DeviceID, Line,
  PhoneNumber, DateTime, OtherText: WideString);
begin
  memo1.Lines.Add(timetostr(now) + ' : ' + ' Hat' + Line + ' Arayan: ' +
    PhoneNumber);
end;

procedure TForm1.CIDSignal(ASender: TObject; const Level1, Level2,
  Level3, Level4, Level5, Level6, Level7, Level8: WideString);
begin
  ProgressBar1.Position := strtoint(Level1);
  ProgressBar2.Position := strtoint(Level2);
  ProgressBar3.Position := strtoint(Level3);
  ProgressBar4.Position := strtoint(Level4);

  Label1.Caption := Level1;
  Label2.Caption := Level2;
  Label3.Caption := Level3;
  Label4.Caption := Level4;
end;

procedure TForm1.Timer1Timer(Sender: TObject);
var
  model, serialnum: string;
begin
  if not assigned(CIDnesne) then
    exit;

  model := cidnesne.Command('devicemodel');
  serialnum := cidnesne.Command('serial');
  if model = '' then
    statusbar1.SimpleText := '  Cihaz baðlantýsý bekleniyor...'
  else
    statusbar1.SimpleText := model + '  cihaz baðlý.  Cihaz seri no : ' +
      serialnum;

end;

procedure TForm1.Memo1Change(Sender: TObject);
begin
  if memo1.Lines.Count > 5 then
    memo1.Lines.Delete(0);
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  {  Caller ID nesnesi oluþsun, CallerID_Olayý atansýn. Cihaz iþlemleri baþlasýn
  }
  memo1.Clear;
  try
    CIDnesne := TCIDv5.Create(self);
    CIDnesne.Hide;
    CIDnesne.OnCallerID := CID_olay;
    CIDnesne.OnSignalA := CIDSignal;
    CIDnesne.Start; // cihaz iþlermleri baþlasýn
    if assigned(CIDnesne) then
    begin
      memo1.Text := 'CIDnesne oluþturuldu. Hazýr.';
    end;
  except
      memo1.Text :=  'CIDnesne oluþturulamadý';
      memo1.Lines.Add('Cihaz kurulumu yapýlmamýþ olabilir.');
  end;

  // Nesneyi baþlattýktan sonra Cihaz baðlantýsý saðlanýrsa OnCallerID olayý otomatik tetiklenir
  // .Start ile baþlatýlmýþ nesneyi, tekrar baþlatmanýn her hangi bir faydasý veya zararý olmaz.


end;

end.

