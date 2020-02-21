@echo off
color 1a
title BSI Corporation - Setup DetectDeviceCMDV4 Srv
mode con lines=25 cols=62
set Folder_Root=%~dp0%
set Folder_Root=%Folder_Root:~,-1%
cd /d "%Folder_Root%"

:CheckFile
if not exist "TransactionStatisticalScheduler.exe" goto Notfoundfileexe
if not exist "C:\Windows\Microsoft.NET\Framework\v2.0.50727\InstallUtil.exe" goto NotfoundNetfrm 

:CopySource
if not exist C:\protopas\BSI mkdir C:\protopas\BSI
if not exist C:\protopas\BSI\TransactionStatisticalScheduler mkdir C:\protopas\BSI\TransactionStatisticalScheduler
set pApp=c:\protopas\BSI\TransactionStatisticalScheduler
copy /y "TransactionStatisticalScheduler.exe" "%pApp%\TransactionStatisticalScheduler.exe"
:InstallSvr
C:\Windows\Microsoft.NET\Framework\v2.0.50727\InstallUtil.exe %pApp%\TransactionStatisticalScheduler.exe | find "The Commit phase completed successfully"
if not %errorlevel% == 0 goto InstallSvrFail
sc config "Transaction Statistical Scheduler" start= auto |find "ChangeServiceConfig SUCCESS"
if not %errorlevel% == 0 goto ChangeStartupTypeFail
net start DetectDeviceCMDV4 |find "service was started successfully"
if not %errorlevel% == 0 goto StartSrvFail
goto Finish
:InstallSvrFail
cls
echo The installation failed, and the rollback has been performed
goto Contact
:Notfoundreg
cls
echo Not found DetectDeviceCMDV4.reg
goto Contact
:Notfoundfileexe
cls
echo Not found DetectDeviceCMDV4.exe
goto Contact
:ChangStartupTypeFail
cls
echo ChangeServiceConfig Fail
goto Contact
:StartSrvFail
cls
echo Service was started fail
goto Contact
:NotfoundNetfrm
cls
echo Not found Framework.
echo Pls, setup from BSI_USB\APPLICATIONS\15-Windows\dotnetfx35.exe
goto Contact
:Finish
echo ============================
echo Setup successful
echo Enter to exit.
Pause>nul
exit
:Contact
echo Contact PhuocNM, 0908879769
echo Enter to exit.
Pause>nul
exit