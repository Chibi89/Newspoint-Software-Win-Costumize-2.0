@echo off

call :isAdmin
if %errorlevel% == 0 (
	regsvr32 "%~dp0ExplorerBlurMica.dll"
) else (
	echo ���Թ���Ա�������!
	echo Please run as Administrator
)

pause >nul
exit /b

:isAdmin
fsutil dirty query %systemdrive% >nul
exit /b