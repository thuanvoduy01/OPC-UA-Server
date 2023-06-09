﻿using System;
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
    public partial class frmAddObject : Form
    {
        #region Properties
        public string SymbolicName { get; set; }
        public string TypeDefinition { get; set; }
        #endregion

        #region Enum
        enum TypeDefinitionValue
        {
            BaseObjectType
        }
        #endregion

        #region Constructor
        public frmAddObject()
        {
            InitializeComponent();

            cmbTypeDefinition.DataSource = Enum.GetValues(typeof(TypeDefinitionValue));
            cmbTypeDefinition.SelectedIndex = 0;
            cmbTypeDefinition.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Events
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
