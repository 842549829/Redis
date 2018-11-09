::%1 = $(ProjectDir)bin\Release\*.nupkg
::nuget push %1 -ApiKey localhostnuget -src http://192.168.100.142:777/nuget/
nuget push %1 -ApiKey D682034448F84B3FBBCF5FEB45E5FA5A -src http://nuget.holderzone.cn/nuget/