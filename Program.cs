using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Hosting.Server;
using Opc.Ua;
using Opc.Ua.Configuration;

namespace MyOPCUAServer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Server;
            application.ApplicationName = "MyOPCUAServer";


            try
            {
                // process and command line arguments.
                if (application.ProcessCommandLine())
                {
                    return;
                }

                // check if running as a service.
                if (!Environment.UserInteractive)
                {
                    application.StartAsService(new MyServer());
                    return;
                }

                //load the application configuration
                application.LoadApplicationConfiguration(@"..\..\MyOPCUAServer.Config.xml", false).Wait();

                //check the application certification
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // start the server.
                application.Start(new MyServer()).Wait();

                // run the application interactively.
                Application.Run(new MyOPCUAServerForm(application));
            }
            catch(Exception e)
            {
                string text = "Exception: " + e.Message;
                if (e.InnerException != null)
                {
                    text += "\r\nInner exception: ";
                    text += e.InnerException.Message;
                }
                MessageBox.Show(text, application.ApplicationName);
            }
        }
    }
}
