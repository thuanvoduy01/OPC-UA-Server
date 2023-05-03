namespace MyOPCUAServer
{
    partial class MyServerDesignerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnImportXml = new System.Windows.Forms.Button();
            this.btnRunServer = new System.Windows.Forms.Button();
            this.chkImport = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(133, 284);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(168, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnImportXml
            // 
            this.btnImportXml.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnImportXml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnImportXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportXml.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportXml.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImportXml.Location = new System.Drawing.Point(28, 279);
            this.btnImportXml.Name = "btnImportXml";
            this.btnImportXml.Size = new System.Drawing.Size(82, 35);
            this.btnImportXml.TabIndex = 2;
            this.btnImportXml.Text = "Import";
            this.btnImportXml.UseVisualStyleBackColor = true;
            this.btnImportXml.Click += new System.EventHandler(this.btnImportXml_Click);
            // 
            // btnRunServer
            // 
            this.btnRunServer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnRunServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRunServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunServer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunServer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRunServer.Location = new System.Drawing.Point(382, 284);
            this.btnRunServer.Name = "btnRunServer";
            this.btnRunServer.Size = new System.Drawing.Size(111, 30);
            this.btnRunServer.TabIndex = 2;
            this.btnRunServer.Text = "Server Run";
            this.btnRunServer.UseVisualStyleBackColor = true;
            this.btnRunServer.Click += new System.EventHandler(this.btnRunServer_Click);
            // 
            // chkImport
            // 
            this.chkImport.AutoSize = true;
            this.chkImport.Location = new System.Drawing.Point(327, 246);
            this.chkImport.Name = "chkImport";
            this.chkImport.Size = new System.Drawing.Size(93, 17);
            this.chkImport.TabIndex = 3;
            this.chkImport.Text = "Design/Import";
            this.chkImport.UseVisualStyleBackColor = true;
            // 
            // MyServerDesignerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Controls.Add(this.chkImport);
            this.Controls.Add(this.btnRunServer);
            this.Controls.Add(this.btnImportXml);
            this.Controls.Add(this.txtFilePath);
            this.Name = "MyServerDesignerUC";
            this.Size = new System.Drawing.Size(773, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnImportXml;
        private System.Windows.Forms.Button btnRunServer;
        private System.Windows.Forms.CheckBox chkImport;
    }
}
