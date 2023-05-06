namespace MyOPCUAServer
{
    partial class MyOPCUAServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbEndpoint = new System.Windows.Forms.ComboBox();
            this.BrowseList = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // cmbEndpoint
            // 
            this.cmbEndpoint.FormattingEnabled = true;
            this.cmbEndpoint.Location = new System.Drawing.Point(125, 68);
            this.cmbEndpoint.Name = "cmbEndpoint";
            this.cmbEndpoint.Size = new System.Drawing.Size(570, 21);
            this.cmbEndpoint.TabIndex = 0;
            // 
            // BrowseList
            // 
            this.BrowseList.Location = new System.Drawing.Point(39, 95);
            this.BrowseList.Name = "BrowseList";
            this.BrowseList.Size = new System.Drawing.Size(665, 275);
            this.BrowseList.TabIndex = 1;
            // 
            // MyOPCUAServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrowseList);
            this.Controls.Add(this.cmbEndpoint);
            this.Name = "MyOPCUAServerForm";
            this.Text = "MyOPCUAServerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEndpoint;
        private System.Windows.Forms.TreeView BrowseList;
    }
}