using Opc.Ua.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyOPCUAServer
{
    public partial class MyServerDesignerUC : UserControl
    {
        #region Private field
        ApplicationInstance m_application;

        #endregion

        public MyServerDesignerUC()
        {
            InitializeComponent();
        }
        public MyServerDesignerUC(ApplicationInstance application)
        {
            InitializeComponent();

            m_application = application;
        }

        public ApplicationInstance GetApplication()
        {
            return m_application;
        }

        private void btnImportXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "All files (*.*)|*.* | XML files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 2;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != String.Empty)
            { 
                txtFilePath.Text = openFileDialog.FileName; 
            }
            else
            { 
                txtFilePath.Text = "You didn't select the file!"; 
            }
        }

        private void btnRunServer_Click(object sender, EventArgs e)
        {
            string selectedFileDir;
            string xmlModelDesignDir = MyOPCUAServer.Const.MODEL_DESIGN_DIRECTORY;
            string modelCompilerOutputsDir = MyOPCUAServer.Const.MODEL_COMPILER_OUTPUTS_DIRECTORY;

            #region Delete old generated file
            string[] files = Directory.GetFiles(modelCompilerOutputsDir);
            foreach(string file in files)
            {
                File.Delete(file);
            }
            #endregion

            #region Update ModelDesign file
            if (chkImport.Checked == false)
            {
                //Using Designer
            }
            else
            {
                //Using import XML
                selectedFileDir = txtFilePath.Text;
                if (Path.GetExtension(selectedFileDir) == ".xml")
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(selectedFileDir);                    
                    xmlDoc.Save(xmlModelDesignDir);
                }
                else
                {
                    MessageBox.Show("Selected file is not compatible!\nSelected file must be formated in XML!");
                }
            }
            #endregion

            
            #region Calling ModelCompiler to generate ua.nodes file
            try
            {
                string batDir = MyOPCUAServer.Const.BATCH_DIRECTORY_MODEL_COMPILER;
                //string batDir = @"D:\Proj\VStudio\MyOPCUAServer\InformationModelling\MyOPCUAServerBuildDesignFullPath.bat";
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
                string confDir = MyOPCUAServer.Const.CONFIG_SERVER_DIRECTORY;
                //string confDir = @"..\..\MyOPCUAServer.Config.xml";
                m_application.LoadApplicationConfiguration(confDir, false).Wait();

                //check the application certification
                m_application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // start the server.
                m_application.Start(new MyServer()).Wait();


                // run the application interactively.
                //Application.Run(new MyOPCUAServerForm(m_application));

                //MyOPCUAServerForm myOPCUAServerForm = new MyOPCUAServerForm(m_application);
                //myOPCUAServerForm.ShowDialog();
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
