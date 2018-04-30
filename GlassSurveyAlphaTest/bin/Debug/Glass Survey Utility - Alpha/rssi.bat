::echo off

::loop
::cd C:\VisualStudio\Builds\GlassSurveyAlphaTest\GlassSurveyAlphaTest\bin\Debug



adb shell dumpsys wifi > rssiraw.txt


FINDSTR /L "RSSI:" rssiraw.txt > value.txt
FINDSTR /L "freq=" rssiraw.txt > channeltemp.txt
::bash -c "grep "RSSI:" rssiraw.txt > value.txt"

for /f "tokens=1 delims=," %%a in (value.txt) do (echo %%a > ssidtemp.txt)
(for /f "tokens=3" %%i in (ssidtemp.txt) do @echo %%i)>ssid.txt

for /f "tokens=2 delims=," %%a in (value.txt) do (echo %%a > bssidtemp.txt)
(for /f "tokens=2" %%i in (bssidtemp.txt) do @echo %%i)>bssid.txt
(for /f "tokens=2" %%i in (bssidtemp.txt) do @echo %%i)>>bssidcount.txt

for /f "tokens=5 delims=," %%a in (value.txt) do (echo %%a > rssitemp.txt)
(for /f "tokens=2" %%i in (rssitemp.txt) do @echo %%i)>rssi.txt

for /f "tokens=1 delims=M" %%a in (channeltemp.txt) do (echo %%a > channeltemp2.txt)
(for /f "tokens=2 delims==" %%i in (channeltemp2.txt) do @echo %%i)>channel.txt

for /f "tokens=6 delims=," %%a in (value.txt) do (echo %%a > linkspeedtemp.txt)
(for /f "tokens=3" %%i in (linkspeedtemp.txt) do @echo %%i)>linkspeed.txt
::goto loop
exit
