REM CD to the proper directory
cd "C:\Program Files\Oracle\VirtualBox"
REM Save the Win7Dev VM state
VBoxManage.exe controlvm "Win7Dev" savestate
REM Time to exit
exit