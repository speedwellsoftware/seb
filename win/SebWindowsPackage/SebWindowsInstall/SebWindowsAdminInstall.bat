

@echo off

echo.
echo.
echo Safe Exam Browser administrative installation
echo =============================================
echo.
echo The whole installation procedure comprises three phases:
echo.
ehco.
echo 1st phase (configuration):
echo --------------------------
echo The teacher configures SEB by modifiying
echo the "MsgHook.ini" and "SebStarter.ini" files using a text editor.
echo.
echo If third-party applications shall be permitted,
echo the teacher can additionally edit the "SebStarter.bat" file.
echo This batch file enhances the PATH variable by the paths to the
echo third-party applications, such that SEB can find the executables
echo of these applications when they are called during an exam.
echo.
echo.
echo 2nd phase (administrative installation):
echo ----------------------------------------
echo The teacher executes the "SebWindowsAdminInstall.bat" script
echo when logged in as an administrator (not as a standard user!)
echo.
echo This script runs the MSI installer with the option /a
echo and the installation file SebWindowsInstall.msi.
echo.
echo It creates a source image named "SebWindowsAdminImage",
echo containing a copy of the SebWindowsInstall.msi file,
echo and a "Common Application Data Folder".
echo.
echo Afterwards, the script copies the (previously modified)
echo configuration files MsgHook.ini and SebStarter.ini
echo to the "Common Application Data Folder".
echo.
echo [And if desired, the script copies also the batch file
echo SebStarter.bat to the Program Files directory,
echo where SEB has been installed.]
echo.
echo The source image can then serve as a network share,
echo so a workgroup with access to the network share
echo can install SEB from this remote source image.
echo.
echo Rather than offering the source image to the students,
echo the teacher can also pack the source image as a zip file,
echo e.g. "SebWindowsInstall.zip",
echo and distribute the zip file to the students.
echo.
echo.
echo 3rd phase (actual installation):
echo --------------------------------
echo In order to install SEB, a student must
echo.
echo - connect to the network share, enter the source image
echo "SebWindowsAdminImage" and double-click the
echo "SebWindowsInstall.msi" file
echo or
echo - unzip the "SebWindowsInstall.zip" file
echo in an arbitrary folder (e.g. "C:\tmp") on his machine
echo and then double-click the "SebWindowsInstall.msi" file.
echo.



echo.
echo.
echo Display the ProgramData and ProgramFiles directories
echo ----------------------------------------------------

echo ProgramData       = %ProgramData%
echo ProgramFiles      = %ProgramFiles%
echo ProgramFiles(x86) = %ProgramFiles(x86)%
echo CommonAppDataFolder=%CommonAppDataFolder%



echo.
echo.
echo Assign the directory containing this batch file
echo -----------------------------------------------

set CurrentDir=%CD%
set BatchDir=%~dp0
set BatchFile=%0

echo CurrentDir = %CurrentDir%
echo BatchDir   = %BatchDir%
echo BatchFile  = %BatchFile%



echo.
echo.
echo Assign the SEB installation and configuration directories
echo ---------------------------------------------------------

set Manufacturer=ETH Zuerich
set Product=SEB Windows
set Version=1.7
set Component=SebWindowsClient
set Build=Release

set CommonAppDataFolder=Common Application Data Folder
set SebAdminImage=SebWindowsAdminImage



set SebConfigDir=%ProgramData%\%Manufacturer%\%Product% %Version%

set SebInstallDir=%ProgramFiles%\%Manufacturer%\%Product% %Version%
set SebClientDir=%ProgramFiles%\%Manufacturer%\%Product% %Version%\%Component%
set SebReleaseDir=%ProgramFiles%\%Manufacturer%\%Product% %Version%\%Component%\%Build%

set SebInstallDir(x86)=%ProgramFiles(x86)%\%Manufacturer%\%Product% %Version%
set SebClientDir(x86)=%ProgramFiles(x86)%\%Manufacturer%\%Product% %Version%\%Component%
set SebReleaseDir(x86)=%ProgramFiles(x86)%\%Manufacturer%\%Product% %Version%\%Component%\%Build%

set SebAdminImageDir=%BatchDir%%SebAdminImage%
set SebAdminConfigDir=%BatchDir%%SebAdminImage%\%CommonAppDataFolder%



set InstallMsi=SebWindowsInstall.msi
set SebStarterBat=SebStarter.bat
set SebStarterIni=SebStarter.ini
set MsgHookIni=MsgHook.ini

set InstallMsiFile=%BatchDir%%InstallMsi%
set SebStarterBatFile=%BatchDir%%SebStarterBat%
set SebStarterIniFile=%BatchDir%%SebStarterIni%
set MsgHookIniFile=%BatchDir%%MsgHookIni%



echo Manufacturer = %Manufacturer%
echo Product      = %Product%
echo Version      = %Version%
echo Component    = %Component%
echo Build        = %Build%
echo.
echo SebConfigDir       = %SebConfigDir%
echo.
echo SebInstallDir      = %SebInstallDir%
echo SebClientDir       = %SebClientDir%
echo SebReleaseDir      = %SebReleaseDir%
echo.
echo SebInstallDir(x86) = %SebInstallDir(x86)%
echo SebClientDir(x86)  = %SebClientDir(x86)%
echo SebReleaseDir(x86) = %SebReleaseDir(x86)%
echo.
echo InstallMsi         = %InstallMsi%
echo SebStarterBat      = %SebStarterBat%
echo SebStarterIni      = %SebStarterIni%
echo MsgHookIni         = %MsgHookIni%
echo.
echo InstallMsiFile     = %InstallMsiFile%
echo SebStarterBatFile  = %SebStarterBatFile%
echo SebStarterIniFile  = %SebStarterIniFile%
echo MsgHookIniFile     = %MsgHookIniFile%
echo.
echo CommonAppDataFolder = %CommonAppDataFolder%
echo SebAdminImage       = %SebAdminImage%
echo SebAdminImageDir    = %SebAdminImageDir%
echo SebAdminConfigDir   = %SebAdminConfigDir%



@REM echo Expand the PATH environment variable by the batch directory
@REM echo -----------------------------------------------------------

path %path%;%BatchDir%



echo.
echo.
echo Run the Administrative Install
echo ------------------------------

@echo on
msiexec /a "%InstallMsiFile%" TARGETDIR=%SebAdminImageDir%
@echo off



echo.
echo.
echo Copy the configured .ini files to the SEB configuration directory
echo Copy the configured .bat file  to the SEB  installation directory
echo -----------------------------------------------------------------

@echo on

copy    "%MsgHookIniFile%" "%SebAdminConfigDir%"
copy "%SebStarterIniFile%" "%SebAdminConfigDir%"

@REM copy "%SebStarterBatFile%" "%SebReleaseDir%"
@REM copy "%SebStarterBatFile%" "%SebReleaseDir(x86)%"

@echo off



echo.
pause
@echo on


