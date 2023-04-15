using Opc.Ua;
using Opc.Ua.Configuration;
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

        }
    }
}
