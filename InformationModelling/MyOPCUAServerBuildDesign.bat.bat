@echo off
setlocal

echo Building ModelDesign for MyOPCUAServer
.\net6.0\Opc.Ua.ModelCompiler.exe compile -d2 ".\ModelCompilerOutputs\ModelDesign.xml" -cg ".\ModelCompilerOutputs\ModelDesign.csv" -o2 .\ModelCompilerOutputs
echo Success!


