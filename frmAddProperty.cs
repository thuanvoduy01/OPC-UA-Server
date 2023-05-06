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
    }
}
