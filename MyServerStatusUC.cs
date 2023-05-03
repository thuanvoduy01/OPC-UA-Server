﻿using Opc.Ua;
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

namespace MyOPCUAServer
{
    public partial class MyServerStatusUC : UserControl
    {
        #region Private field
        private ApplicationInstance m_application;
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        #endregion
        public MyServerStatusUC()
        {
            InitializeComponent();
        }
        public MyServerStatusUC(ApplicationInstance application)
        {
            InitializeComponent();

            m_application = application;
            m_server = m_application.Server as StandardServer;
            m_configuration = m_application.ApplicationConfiguration;

            lblStartTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lblCurrentTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        }

        public void UpdateServer()
        {            
            if ( m_server.CurrentInstance.IsRunning == true)
            {
                lblServerStatus.Text = "Running";

            } 
            else
            {
                lblServerStatus.Text = "Not Running";
            }

            foreach (EndpointDescription endpoint in m_server.GetEndpoints())
            {
                lblConnAddr.Text = endpoint.EndpointUrl;
            }

            lblCurrentTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateServer();
        }
    }
}