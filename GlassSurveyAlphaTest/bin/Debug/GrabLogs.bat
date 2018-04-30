@echo off
Title 5 Ghz Band Select
echo PLEASE MAKE SURE GLASS IS CONNECTED AND THE SCREEN IS ON!!!
echo PLEASE MAKE SURE GLASS IS CONNECTED AND THE SCREEN IS ON!!!
echo PLEASE MAKE SURE GLASS IS CONNECTED AND THE SCREEN IS ON!!!
echo PLEASE MAKE SURE GLASS IS CONNECTED AND THE SCREEN IS ON!!!
echo PLEASE MAKE SURE GLASS IS CONNECTED AND THE SCREEN IS ON!!!
echo.
echo.
echo.
echo.
for /f "tokens=2 delims==" %%a in ('wmic OS Get localdatetime /value') do set "dt=%%a"
set "YY=%dt:~2,2%" & set "YYYY=%dt:~0,4%" & set "MM=%dt:~4,2%" & set "DD=%dt:~6,2%"
set "HH=%dt:~8,2%" & set "Min=%dt:~10,2%" & set "Sec=%dt:~12,2%"

set "datestamp=%YYYY%%MM%%DD%" & set "timestamp=%HH%%Min%%Sec%"
set "fullstamp=%YYYY%-%MM%-%DD%_%HH%-%Min%-%Sec%"
::echo datestamp: "%datestamp%"
::echo timestamp: "%timestamp%"
::echo fullstamp: "%fullstamp%"

SetLocal EnableDelayedExpansion
set content=
::for /F "delims=" %%i in (C:\FloorPlanName.txt) do set content=!content! %%i




cls
echo DO NOT UNPLUG THE USB CABLE DURING THIS PROCESS
echo OBTAINING LOG FILES NOW
echo.
echo.
adb devices 2>&1
echo.
echo.
echo.
md "C:\Drive\%datestamp%\%fullstamp%"
adb logcat -v time -d > "C:\Drive\%datestamp%\%fullstamp%\LogcatScan.txt"
adb shell dumpsys wifi > "C:\Drive\%datestamp%\%fullstamp%\WiFiDumpsys.txt"
cls
echo.
echo.
echo Files saved as: 
echo "C:\Drive\%datestamp%\%fullstamp%\WiFiDumpsys.txt"
echo "C:\Drive\%datestamp%\%fullstamp%\LogcatScan.txt"

timeout 5 > nul
cls
echo Process Completed!
echo.
echo This window will close automatically.
timeout 3 
exit
