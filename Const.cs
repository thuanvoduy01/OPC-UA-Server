using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOPCUAServer
{
    public class Const
    {
        public readonly static string PROJECT_DIRECTORY = @"D:\Proj\VStudio\MyOPCUAServer";
        public readonly static string INFORMATION_MODELLING_DIRECTORY = PROJECT_DIRECTORY + @"\InformationModelling";
        public readonly static string TEMP = INFORMATION_MODELLING_DIRECTORY + @"\InformationModelling";

        public readonly static string BATCH_DIRECTORY_MODEL_COMPILER = INFORMATION_MODELLING_DIRECTORY + @"\MyOPCUAServerBuildDesignFullPath.bat";
        public readonly static string MODEL_COMPILER_OUTPUTS_DIRECTORY = INFORMATION_MODELLING_DIRECTORY + @"\ModelCompilerOutputs";
        public readonly static string MODEL_DESIGN_DIRECTORY = INFORMATION_MODELLING_DIRECTORY + @"\ModelDesign.xml";
        public readonly static string MODEL_DESIGN_UC_DIRECTORY = INFORMATION_MODELLING_DIRECTORY + @"\DesignerUcModel.xml";

        //public readonly static string BATCH_DIRECTORY_MODEL_COMPILER = PROJECT_DIRECTORY + @"\InformationModelling\MyOPCUAServerBuildDesignFullPath.bat";
        //public readonly static string MODEL_COMPILER_OUTPUTS_DIRECTORY = PROJECT_DIRECTORY + @"\InformationModelling\ModelCompilerOutputs";
        //public readonly static string MODEL_DESIGN_DIRECTORY = PROJECT_DIRECTORY + @"\InformationModelling\ModelDesign.xml";
        //public readonly static string MODEL_DESIGN_UC_DIRECTORY = PROJECT_DIRECTORY + @"\InformationModelling\DesignerUcModel.xml";

        public readonly static string CONFIG_SERVER_DIRECTORY = PROJECT_DIRECTORY + @"\MyOPCUAServer.Config.xml";


        //public readonly static string BATCH_DIRECTORY_MODEL_COMPILER = @"D:\Proj\VStudio\MyOPCUAServer\InformationModelling\MyOPCUAServerBuildDesignFullPath.bat";
        //public readonly static string CONFIG_SERVER_DIRECTORY = @"D:\Proj\VStudio\MyOPCUAServer\MyOPCUAServer.Config.xml";
        //public readonly static string MODEL_COMPILER_OUTPUTS_DIRECTORY = @"D:\Proj\VStudio\MyOPCUAServer\InformationModelling\ModelCompilerOutputs";
        //public readonly static string MODEL_DESIGN_DIRECTORY = @"D:\Proj\VStudio\MyOPCUAServer\InformationModelling\ModelDesign.xml";
        //public readonly static string MODEL_DESIGN_UC_DIRECTORY = @"D:\Proj\VStudio\MyOPCUAServer\InformationModelling\DesignerUcModel.xml";
    }
}
