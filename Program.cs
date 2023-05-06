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
    public static class Program
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
                Application.Run(new MyServerForm(application));

                //Application.Run(new MyServerConfigForm(application));

            }
            catch (Exception ex)
            {
                MessageBox.Show($"MyServerDesigner Failed: {ex.Message}\n {ex.StackTrace.ToString()}");
            }

            
        }
    }
}
