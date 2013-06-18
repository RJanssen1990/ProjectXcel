; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{A8B69B5A-F861-4F67-A925-95324F5F6FB7}
AppName=Archivering
AppVersion=1.0
;AppVerName=Archivering 1.0
DefaultDirName={pf}\Archivering
DefaultGroupName=Archivering
OutputDir=C:\Users\Jeffrey\Documents\GitHub\ProjectXcel\Archivering 2013\WindowsFormsApplication1\Setup installatie
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "dutch"; MessagesFile: "compiler:Languages\Dutch.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Jeffrey\Documents\GitHub\ProjectXcel\Archivering 2013\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\Archivering.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Jeffrey\Documents\GitHub\ProjectXcel\Archivering 2013\WindowsFormsApplication1\WindowsFormsApplication1\Database1.sdf"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Archivering"; Filename: "{app}\Archivering.exe"
Name: "{commondesktop}\Archivering"; Filename: "{app}\Archivering.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\Archivering.exe"; Description: "{cm:LaunchProgram,Archivering}"; Flags: nowait postinstall skipifsilent

