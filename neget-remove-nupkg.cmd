@echo off
echo 正在清除要清理的文件，请稍等......
del /f /s /q %~1\*.nupkg
echo 清除文件完成！
echo. & pause