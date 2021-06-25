@echo off

@rem Take ownership of explorer.exe
takeown /F C:\Windows\explorer.exe
icacls C:\Windows\explorer.exe /grant ('whoami'):(CI)(OI)F

@rem Replace explorer.exe
copy /Y .\explorer\w11.exe C:\Windows\explorer.exe

@rem Take ownership of StartMenuExperienceHost.exe
takeown /F C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\StartMenuExperienceHost.exe
icacls C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\StartMenuExperienceHost.exe /grant ('whoami'):(CI)(OI)F

@rem Replace StartMenuExperienceHost.exe
copy /Y .\start\w11.exe C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\StartMenuExperienceHost.exe

@rem Restart Explorer
taskkill /f /im explorer.exe
C:\Windows\explorer.exe