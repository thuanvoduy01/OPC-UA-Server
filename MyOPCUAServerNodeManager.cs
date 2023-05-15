using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Extensions.Configuration;
using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOPCUAServer
{
    public class MyOPCUAServerNodeManager : CustomNodeManager2
    {
        public MyOPCUAServerNodeManager(IServerInternal server, ApplicationConfiguration configuration) 
            : base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;

            // set one namespace for the type model and one names for dynamically created nodes.
            string[] namespaceUrls = new string[2];

            //namespaceUrls[0] = BatchPlant.Namespaces.BatchPlant;              dT
            //namespaceUrls[1] = BatchPlant.Namespaces.BatchPlant + "/Instance";

            //namespaceUrls[0] = Namespaces.MyOPCUAServer;
            //namespaceUrls[1] = Namespaces.MyOPCUAServer + "/Instance";

            namespaceUrls[0] = "http://opcfoundation.org/OPCUAServer";
            namespaceUrls[1] = "http://opcfoundation.org/OPCUAServer" + "/Instance";
            SetNamespaces(namespaceUrls);

            // get the configuration for the node manager.
            m_configuration = configuration.ParseExtension<MyOPCUAServerConfiguration>();

            // use suitable defaults if no configuration exists.
            if (m_configuration == null)
            {
                m_configuration = new MyOPCUAServerConfiguration();
            }

        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();

            #region Find the first .uanodes file
            string resourcePath = String.Empty;
            string modelCompilerOutputsDir = MyOPCUAServer.Const.MODEL_COMPILER_OUTPUTS_DIRECTORY;
            string[] files = Directory.GetFiles(modelCompilerOutputsDir);
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".uanodes")
                {
                    resourcePath = file;
                    break;
                }
            }
            #endregion

            predefinedNodes.LoadFromBinaryResource(context,
                resourcePath,
                typeof(MyOPCUAServerNodeManager).GetTypeInfo().Assembly,
                true);
            
            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);

                //// find the untyped Batch Plant 1 node that was created when the model was loaded.
                //BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(BatchPlant.Objects.BatchPlant1, NamespaceIndexes[0]), typeof(BaseObjectState));

                //// convert the untyped node to a typed node that can be manipulated within the server.
                //m_batchPlant1 = new BatchPlantState(null);
                //m_batchPlant1.Create(SystemContext, passiveNode);

                //// replaces the untyped predefined nodes with their strongly typed versions.
                //AddPredefinedNode(SystemContext, m_batchPlant1);

                //m_batchPlant1.StartProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStartProcess);
                //m_batchPlant1.StopProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStopProcess);
                //m_batchPlant1.Conveyor.ConveyorMotor.Speed.Value = 99;
                //m_simulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);
            }
        }

        private MyOPCUAServerConfiguration m_configuration;
        //private static MyOPCUAServerState m_batchPlant1;
        private System.Threading.Timer m_simulationTimer;

    }
}
