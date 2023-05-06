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
    public partial class frmAddFolder : Form
    {
        public string SymbolicName { get; set; }

        
        public frmAddFolder()
        {
            InitializeComponent();

            
        }

        

        private void btnOK_Click(object sender, EventArgs e)
        {
            SymbolicName = txtSymbolicName.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SymbolicName = null;
            this.Close();
        }
    }
}
