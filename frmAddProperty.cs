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
    public partial class frmAddProperty : Form
    {
        public string SymbolicName { get; set; }
        public string DataType { get; set; }

        enum DataTypeValue
        {
            Boolean,
            SByte,
            Byte,
            Int16,
            UInt16,
            Int32,
            UInt32,
            Int64,
            UInt64,
            Float,
            Double,
            String,
            DateTime,
            Guid,
            ByteString,
            XmlElement,
            NodeId,
            ExpandedNodeId,
            StatusCode,
            QualifiedName,
            LocalizedText,
            ExtensionObject,
            DataValue,
            Variant,
            DiagnosticInfo,
        }
        public frmAddProperty()
        {
            InitializeComponent();

            cmbDataType.DataSource = Enum.GetValues(typeof(DataTypeValue));
            cmbDataType.SelectedIndex = 0;
        }

        

        private void btnOK_Click(object sender, EventArgs e)
        {
            SymbolicName = txtSymbolicName.Text;
            DataType = cmbDataType.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SymbolicName = null;
            DataType= null;
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
    }
}
