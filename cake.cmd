@echo off

SET DIR=%~dp0%

@PowerShell -ExecutionPolicy unrestricted -Command "[System.Threading.Thread]::CurrentThread.CurrentCulture = ''; [System.Threading.Thread]::CurrentThread.CurrentUICulture = '';& '%DIR%build.ps1' %*"
goto :end

:end
pause