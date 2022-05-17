xcopy %~dp0\WcfServiceCustom C:\inetpub\wwwroot\WcfServiceCustom\ /E /H 
C:\Windows\System32\inetsrv\appcmd add site /name:tp1_uc3_ws_2022 /bindings:http://*:81 /physicalpath:"C:\inetpub\wwwroot\WcfServiceCustom"
pause