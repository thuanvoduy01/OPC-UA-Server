@echo off
setlocal

echo Building ModelDesign
.\net6.0\Opc.Ua.ModelCompiler.exe compile -version v104 -d2 ".\ModelDesign.xml" -cg ".\outputs\ModelDesign.csv" -o2 .\outputs 
echo Success!


