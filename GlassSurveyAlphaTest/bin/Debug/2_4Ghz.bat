@echo off
Title 2.4Ghz Band Select
echo PLEASE MAKE SURE GLASS IS CONNECTED AND THE SCREEN IS ON!!!
echo PLEASE MAKE SURE GLASS IS CONNECTED AND THE SCREEN IS ON!!!
echo PLEASE MAKE SURE GLASS IS CONNECTED AND THE SCREEN IS ON!!!
echo PLEASE MAKE SURE GLASS IS CONNECTED AND THE SCREEN IS ON!!!
echo PLEASE MAKE SURE GLASS IS CONNECTED AND THE SCREEN IS ON!!!
echo.
echo.
echo.
echo.
timeout 3

cls
echo DO NOT UNPLUG THE USB CABLE DURING THIS PROCESS
echo.
echo.
adb devices 2>&1
echo.
echo.
echo.
adb shell am start -a com.google.glass.action.SET_FREQUENCY_BAND --es band 2.4 > nul
cls
echo Process Completed! The glass unit will now only connect to 2.4Ghz WiFi networks. 
echo.
echo This window will close automatically.
timeout 3
exit
