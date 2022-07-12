; -- Components.iss --
; Demonstrates a components-based installation.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

[Setup]
AppName=My Program
AppVerName=My Program version 1.5
DefaultDirName={pf}\My Program
DefaultGroupName=My Program
UninstallDisplayIcon={app}\MyProg.exe
OutputDir=.\


[Languages]
; Name: tr; MessagesFile: "compiler:turkish.isl"


[Types]

Name: "custom"; Description: "Özel kurulum"; Flags: iscustom
Name: "full"; Description: "Tam kurulum" ;


[Components]
Name: "Callerid"; Description: "Caller ID cihazý kurulumu "; Types: full custom; Flags: fixed
Name: "Program1"; Description: "Program1Kurulumu"; Types: full custom ;
Name: "Program2"; Description: "Program2Kurulumu"; Types: full custom  ;
Name: "readme"; Description: "Readme File"; Types: custom    ;

[Files]
Source: "CIDSetup.exe"; DestDir: "{app}" ;Components: Callerid; Permissions: admins-full; CopyMode: alwaysoverwrite; AfterInstall: kur0;
Source: "Program1Kur.exe"; DestDir: "{app}" ;Components: Program1; Permissions: admins-full; CopyMode: alwaysoverwrite; AfterInstall: kur1;
Source: "Program2Kur.exe"; DestDir: "{app}" ;Components: Program2; Permissions: admins-full; CopyMode: alwaysoverwrite; AfterInstall: kur2;
Source: "Readme.txt"; DestDir: "{app}"; Components: readme; Flags: isreadme



[code]
procedure kur0();
var
  ResultCode:integer;
begin
    Exec(ExpandConstant('{app}\CIDSetup.exe'), '', '', SW_SHOW,   ewWaitUntilTerminated, ResultCode);
//  Exec(ExpandConstant('{app}\CIDSetup.exe'), '/verysilent', '', SW_SHOW,   ewWaitUntilTerminated, ResultCode);
// gÝZLÝ kurmak isterseniz /verysilent parameteresi kullanýlýr.
    DeleteFile (ExpandConstant('{app}\CIDSetup.exe')) ;

end;

procedure kur1();
var
  ResultCode:integer;
begin
    Exec(ExpandConstant('{app}\Program1Kur.exe'), '', '', SW_SHOW,   ewWaitUntilTerminated, ResultCode);
    //DeleteFile (ExpandConstant('{app}\Program1Kur.exe')) ;

end;

procedure kur2();
var
  ResultCode:integer;
begin
    Exec(ExpandConstant('{app}\Program2Kur.exe'), '', '', SW_SHOW,   ewWaitUntilTerminated, ResultCode);
    //DeleteFile (ExpandConstant('{app}\Program2Kur.exe')) ;
end;


begin
end.




[Icons]

