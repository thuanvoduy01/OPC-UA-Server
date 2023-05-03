using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Microsoft.AspNetCore.Hosting.Server;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;



namespace MyOPCUAServer
{
    public partial class MyServerForm : Form
    {
        #region declare
        #region const & readonly variable
        readonly Font FONT_DEFAULT = new Font("Century Gothic", 12, FontStyle.Bold);
        readonly float FONT_SIZE_INC = 4;
        readonly Color COLOR_CLICKED_BUTTON = Color.FromArgb(63, 88, 129);
        #endregion

        private static bool isServerLoadedOnce = false;


        #region User Control 
        private MyServerDesignerUC myServerDesignerUC;
        private MyServerStatusUC myServerStatusUC;
        
        #endregion

        #region Private field
        ApplicationInstance m_application;
        ApplicationInstance m_applicationStatusUc;
        #endregion
        #endregion
        public MyServerForm()
        {
            InitializeComponent();
        }
        public MyServerForm(ApplicationInstance application)
        {
            InitializeComponent();

            m_application = application;

            myServerDesignerUC = new MyServerDesignerUC(m_application);
        }

        private void MyServerForm_Load(object sender, EventArgs e)
        {
            AddUserControl(myServerDesignerUC);
        }
        
        private void btnDesigner_Click(object sender, EventArgs e)
        {
            #region Animation UI
            RemoveTabControlButtonBackColor();
            btnDesigner.BackColor = COLOR_CLICKED_BUTTON;

            //btnDesigner.Font = new Font(FONT_DEFAULT.OriginalFontName, FONT_DEFAULT.Size + FONT_SIZE_INC, FONT_DEFAULT.Style);
            //btnStatus.Font = new Font(FONT_DEFAULT.OriginalFontName, FONT_DEFAULT.Size, FONT_DEFAULT.Style);
            #endregion

            AddUserControl(myServerDesignerUC);
        }

        #region custom UI method
        public void RemoveTabControlButtonBackColor()
        {
            btnDesigner.BackColor = Color.FromArgb(227, 246, 245);
            btnStatus.BackColor = Color.FromArgb(227, 246, 245);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            #region Animation UI
            RemoveTabControlButtonBackColor();
            btnStatus.BackColor = COLOR_CLICKED_BUTTON;

            //btnStatus.Font = new Font(FONT_DEFAULT.OriginalFontName, FONT_DEFAULT.Size + FONT_SIZE_INC, FONT_DEFAULT.Style);
            //btnDesigner.Font = new Font(FONT_DEFAULT.OriginalFontName, FONT_DEFAULT.Size, FONT_DEFAULT.Style);
            #endregion

            // if server is not null then generate usercontrol
            m_applicationStatusUc = myServerDesignerUC.GetApplication();
            StandardServer standardServer = m_applicationStatusUc.Server as StandardServer;
            // if server is created then new `MyServerStatusUC`
            if (standardServer != null)
            {
                // if server has been created once, then no need to new another UC
                if(isServerLoadedOnce == false)
                {
                    myServerStatusUC = new MyServerStatusUC(m_applicationStatusUc);
                    isServerLoadedOnce = true;
                }
                AddUserControl(myServerStatusUC);
            }
            else
            {
                //Server still not be build
                //Turn back to designer
                MessageBox.Show("Server has not been created\nPlease build one or import XML Information Model File");
                AddUserControl(myServerDesignerUC);
            }
        }

        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


        #endregion

        
    }
}
