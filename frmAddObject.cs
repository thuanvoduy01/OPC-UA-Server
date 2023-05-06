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
    public partial class frmAddObject : Form
    {
        public string SymbolicName { get; set; }
        public string TypeDefinition { get; set; }

        enum TypeDefinitionValue
        {
            BaseObjectType
        }
        public frmAddObject()
        {
            InitializeComponent();

            cmbTypeDefinition.DataSource = Enum.GetValues(typeof(TypeDefinitionValue));
            cmbTypeDefinition.SelectedIndex = 0;
        }

        

        private void btnOK_Click(object sender, EventArgs e)
        {
            SymbolicName = txtSymbolicName.Text;
            TypeDefinition = cmbTypeDefinition.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SymbolicName = null;
            TypeDefinition= null;
            this.Close();
        }
    }
}
