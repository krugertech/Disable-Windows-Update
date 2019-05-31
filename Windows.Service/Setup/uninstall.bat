@echo off
echo Uninstalling Windows Service...
echo ###################################################
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\installutil.exe /u "..\Windows.Service.exe"
echo ###################################################
pause