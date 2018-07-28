@echo off
:start
echo type 1 to sync the class libary
echo type 2 to sync the mod files
echo type 3 to quit

set /p op=Type option:
if "%op%"=="1" goto classlibary
if "%op%"=="2" goto modfiles
if "%op%"=="3" goto quit

:classlibary
start SyncClassLibary.ffs_batch
goto start

:modfiles
start SyncModFiles.ffs_batch
goto start

:quit