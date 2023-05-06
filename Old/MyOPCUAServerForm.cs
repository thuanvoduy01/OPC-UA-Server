using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Export;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyOPCUAServer
{
    public partial class MyOPCUAServerForm : Form
    {
        private ApplicationInstance m_application;
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;

        public MyOPCUAServerForm()
        {
            InitializeComponent();
        }

        public MyOPCUAServerForm(ApplicationInstance application)
        {
            InitializeComponent();

            m_application = application;
            m_server = application.Server as StandardServer;
            m_configuration = application.ApplicationConfiguration;

            // add the urls to the drop down.
            cmbEndpoint.Items.Clear();

            foreach (EndpointDescription endpoint in m_server.GetEndpoints())
            {
                if (cmbEndpoint.FindStringExact(endpoint.EndpointUrl) == -1)
                {
                    cmbEndpoint.Items.Add(endpoint.EndpointUrl);
                }
            }

            if (cmbEndpoint.Items.Count > 0)
            {
                cmbEndpoint.SelectedIndex = 0;
            }

            #region Browse Node
            BrowseDescriptionCollection nodestobrowse = new BrowseDescriptionCollection();
            BrowseDescription nodetobrowse = new BrowseDescription(); nodetobrowse.NodeId = ObjectIds.Server;
            nodetobrowse.ResultMask = (uint)BrowseResultMask.All;
            nodestobrowse.Add(nodetobrowse);

            OperationContext context = new OperationContext(new RequestHeader(), RequestType.Browse);
            BrowseResultCollection results = null;
            DiagnosticInfoCollection diagnosticInfos = null;

            m_server.CurrentInstance.NodeManager.Browse(
                context,
                null,
                0,
                nodestobrowse,
                out results,
                out diagnosticInfos);

            // Display the results
            ReferenceDescriptionCollection nodeReferences = results[0].References;

            ReferenceDescription dt;
            TreeNode root;
            TreeNode subNode;


            foreach (var reference in nodeReferences)
            {
                dt = new ReferenceDescription();
                root = new TreeNode();
                subNode = new TreeNode();

                dt.NodeId = reference.NodeId;
                dt.NodeClass = reference.NodeClass;
                dt.BrowseName = reference.BrowseName.Name;
                dt.DisplayName = reference.DisplayName.Text;
                root.Tag = dt;
                root.Text = reference.DisplayName.ToString();
                //subNode.Text = reference.BrowseName.Name;
                //root.Nodes.Add(subNode);
                subNode.Text = $"Node Id: {reference.NodeId.ToString()}";
                root.Nodes.Add(subNode);
                //root.Text = reference.NodeId.ToString();
                //root.Nodes.Add(new TreeNode());
                BrowseList.Nodes.Add(root);
                root.Expand();
                // BrowseList.SelectedNode = root;


            }
            #endregion


        }
    }
}
