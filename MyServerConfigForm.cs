using Opc.Ua.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyOPCUAServer
{
    public partial class MyServerConfigForm : Form
    {
        #region Private field
        ApplicationInstance m_application;
        #endregion

        #region Construtors
        public MyServerConfigForm()
        {
            InitializeComponent();
        }

        public MyServerConfigForm(ApplicationInstance application)
        {
            InitializeComponent();

            m_application = application;
        }
        #endregion

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {

            /***********Check if xml file exist *********/


            #region Load xml configuration file to generate ua.nodes file
            try
            {
                string batDir = @"D:\Proj\VStudio\MyOPCUAServer\InformationModelling\MyOPCUAServerBuildDesignFullPath.bat";
                /* cmd /c -> run command then terminate
                   cmd /k -> run command then return to CMD prompt => useful for debugging*/
                string para = $"/c \"{batDir}\"";
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", para);
                procStartInfo.CreateNoWindow = true;
                Process proc = Process.Start(procStartInfo);
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} \n {ex.StackTrace.ToString()}");
            }
            #endregion

            #region Create OPC UA Server from ua.nodes file
            try
            {
                // process and command line arguments.
                if (m_application.ProcessCommandLine())
                {
                    return;
                }

                // check if running as a service.
                if (!Environment.UserInteractive)
                {
                    m_application.StartAsService(new MyServer());
                    return;
                }

                //load the application configuration
                m_application.LoadApplicationConfiguration(@"..\..\MyOPCUAServer.Config.xml", false).Wait();

                //check the application certification
                m_application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // start the server.
                m_application.Start(new MyServer()).Wait();

                // run the application interactively.
                //Application.Run(new MyOPCUAServerForm(m_application));

                
                MyOPCUAServerForm myOPCUAServerForm = new MyOPCUAServerForm(m_application);
                myOPCUAServerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                string text = "Exception: " + ex.Message;
                if (ex.InnerException != null)
                {
                    text += "\r\nInner exception: ";
                    text += ex.InnerException.Message;
                }
                MessageBox.Show(text, m_application.ApplicationName);
            }
            #endregion

            
            //MyOPCUAServerForm myOPCUAServerForm = new MyOPCUAServerForm();
            //ShowDialog(MyOPCUAServerForm);
        }
    }
}
