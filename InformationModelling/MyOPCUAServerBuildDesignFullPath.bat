@echo off
setlocal

set MODELROOT= D:\Proj\VStudio\MyOPCUAServer\InformationModelling
set MODELCOMPILER= %MODELROOT%\net6.0\Opc.Ua.ModelCompiler.exe
set MODELDESIGNXML= %MODELROOT%\ModelDesign.xml
set MODELDESIGNCSV= %MODELROOT%\ModelCompilerOutputs\ModelDesign.csv
set OUTPUTS= D:\Proj\VStudio\MyOPCUAServer\InformationModelling\ModelCompilerOutputs\TestOutput

echo Building ModelDesign for MyOPCUAServer

%MODELCOMPILER% compile -d2 "D:\Proj\VStudio\MyOPCUAServer\InformationModelling\ModelDesign.xml" -cg "D:\Proj\VStudio\MyOPCUAServer\InformationModelling\ModelCompilerOutputs\ModelDesign.csv" -o2 "D:\Proj\VStudio\MyOPCUAServer\InformationModelling\ModelCompilerOutputs"

REM %MODELCOMPILER% compile -d2 "D:\Proj\VStudio\MyOPCUAServer\InformationModelling\ModelCompilerOutputs\ModelDesign.xml" -cg "D:\Proj\VStudio\MyOPCUAServer\InformationModelling\ModelCompilerOutputs\Model\ModelDesign.csv" -o2 "D:\Proj\VStudio\MyOPCUAServer\InformationModelling\ModelCompilerOutputs\Data"

REM %MODELCOMPILER% compile -d2 "%MODELDESIGNXML%" -cg "%MODELDESIGNXML%" -o2 "%OUTPUTS%"

IF %ERRORLEVEL% EQU 0 echo Success!
IF %ERRORLEVEL% NEQ 0 pause
