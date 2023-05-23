@echo off
setlocal

SET "scriptDir=%~dp0"
IF NOT "%scriptDir:~-1%"=="\" SET "scriptdir=%scriptDir%\"
SET "MODELROOT=%scriptDir%"
SET "MODELCOMPILER=%MODELROOT%net6.0\Opc.Ua.ModelCompiler.exe"
SET "MODELDESIGNXML=%MODELROOT%ModelDesign.xml"
SET "MODELDESIGNCSV=%MODELROOT%ModelCompilerOutputs\ModelDesign.csv"
SET "OUTPUTS=%MODELROOT%ModelCompilerOutputs"

ECHO Building ModelDesign for MyOpcUaServer.

%MODELCOMPILER% compile -d2 "%MODELDESIGNXML%" -cg "%MODELDESIGNCSV%" -o2 "%OUTPUTS%"
IF %ERRORLEVEL% EQU 0 echo Success!
IF %ERRORLEVEL% NEQ 0 pause





REM %MODELCOMPILER% compile -d2 "D:\Proj\VStudio\MyOPCUAServer\InformationModelling\ModelDesign.xml" -cg "D:\Proj\VStudio\MyOPCUAServer\InformationModelling\ModelCompilerOutputs\ModelDesign.csv" -o2 "D:\Proj\VStudio\MyOPCUAServer\InformationModelling\ModelCompilerOutputs"

REM ECHO FOR TESTING
REM ECHO %MODELROOT%
REM ECHO %MODELCOMPILER%
REM ECHO %MODELDESIGNXML%
REM ECHO %MODELDESIGNCSV%
REM ECHO %OUTPUTS%
REM 

