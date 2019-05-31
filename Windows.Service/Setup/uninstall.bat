@setlocal enableextensions
@setlocal enabledelayedexpansion
@echo off

set parent=%~dp0
set parent=%parent:\Setup=!!%

echo Uninstalling Service...
echo ###################################################
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\installutil.exe /u "%parent%\Windows.Service.exe"
echo ###################################################
pause