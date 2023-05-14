using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOPCUAServer
{
    public partial class frmAddFolder : Form
    {
        #region Properties
        public string SymbolicName { get; set; }
        #endregion

        #region Constructor
        public frmAddFolder()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
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

        private void txtSymbolicName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //// Block space and special characters
            //if (char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtSymbolicName_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtSymbolicName.Text, "^[a-zA-Z0-9_]*$"))
            {
                MessageBox.Show("Input contains invalid characters. Please use only alphanumeric characters and underscores.");
                txtSymbolicName.Text = Regex.Replace(txtSymbolicName.Text, "[^a-zA-Z0-9_]", "");
                txtSymbolicName.SelectionStart = txtSymbolicName.TextLength;
            }
        }
        #endregion
    }
}
