

adb shell dumpsys battery > battraw.txt
adb shell cat sys/class/thermal/thermal_zone0/temp > tempraw.txt


FINDSTR /L "level:" battraw.txt > batteryvalue.txt
::FINDSTR /L "freq=" rssiraw.txt > channeltemp.txt
::bash -c "grep "RSSI:" rssiraw.txt > value.txt"

for /f "delims= " %%a in (batteryvalue.txt) do (echo %%a > battery.txt)

::for /f "tokens=1 delims=," %%a in (value.txt) do (echo %%a > ssidtemp.txt)
::(for /f "tokens=3" %%i in (ssidtemp.txt) do @echo %%i)>ssid.txt

exit
