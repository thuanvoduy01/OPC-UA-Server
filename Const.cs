using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOPCUAServer
{
    public class Const
    {
<<<<<<< HEAD
        public readonly static string PROJECT_DIRECTORY = @"D:\Proj\VStudio\MyOPCUAServer";

=======
        //public readonly static string PROJECT_DIRECTORY = @"D:\Proj\VStudio\MyOPCUAServer";
        //start from folder containing execute file, then up to 2 levels to the project folder
        //In detail: Folder MyOPCUAServer(ProjectFolder)/bin/Debug(this folder is having MyOPCUAServer.exe)
        public readonly static string PROJECT_DIRECTORY = @"..\..\"; 
>>>>>>> minor
        public readonly static string INFORMATION_MODELLING_DIRECTORY = PROJECT_DIRECTORY + @"\InformationModelling";
        public readonly static string TEMP = INFORMATION_MODELLING_DIRECTORY + @"\InformationModelling";

        public readonly static string BATCH_DIRECTORY_MODEL_COMPILER = INFORMATION_MODELLING_DIRECTORY + @"\MyOPCUAServerBuildDesign.bat";
        public readonly static string BATCH_DIRECTORY_MODEL_COMPILER_FULL_PATH = INFORMATION_MODELLING_DIRECTORY + @"\MyOPCUAServerBuildDesignFullPath.bat";
        public readonly static string MODEL_COMPILER_OUTPUTS_DIRECTORY = INFORMATION_MODELLING_DIRECTORY + @"\ModelCompilerOutputs";
        public readonly static string MODEL_DESIGN_DIRECTORY = INFORMATION_MODELLING_DIRECTORY + @"\ModelDesign.xml";
        public readonly static string MODEL_DESIGN_UC_DIRECTORY = INFORMATION_MODELLING_DIRECTORY + @"\DesignerUcModel.xml";

        public readonly static string CONFIG_SERVER_DIRECTORY = PROJECT_DIRECTORY + @"\MyOPCUAServer.Config.xml";
    }
}
