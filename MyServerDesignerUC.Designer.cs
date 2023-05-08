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
            this.components = new System.ComponentModel.Container();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnImportXml = new System.Windows.Forms.Button();
            this.btnRunServer = new System.Windows.Forms.Button();
            this.chkImport = new System.Windows.Forms.CheckBox();
            this.btnAddObject = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnAddVariable = new System.Windows.Forms.Button();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tvwModel = new System.Windows.Forms.TreeView();
            this.btnNew = new System.Windows.Forms.Button();
            this.timerUpdateDesigner = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(146, 428);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(395, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnImportXml
            // 
            this.btnImportXml.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnImportXml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnImportXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportXml.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportXml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnImportXml.Location = new System.Drawing.Point(568, 413);
            this.btnImportXml.Name = "btnImportXml";
            this.btnImportXml.Size = new System.Drawing.Size(124, 35);
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
            this.btnRunServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnRunServer.Location = new System.Drawing.Point(285, 483);
            this.btnRunServer.Name = "btnRunServer";
            this.btnRunServer.Size = new System.Drawing.Size(124, 30);
            this.btnRunServer.TabIndex = 2;
            this.btnRunServer.Text = "Server Run";
            this.btnRunServer.UseVisualStyleBackColor = true;
            this.btnRunServer.Click += new System.EventHandler(this.btnRunServer_Click);
            // 
            // chkImport
            // 
            this.chkImport.AutoSize = true;
            this.chkImport.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.chkImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.chkImport.Location = new System.Drawing.Point(415, 488);
            this.chkImport.Name = "chkImport";
            this.chkImport.Size = new System.Drawing.Size(147, 23);
            this.chkImport.TabIndex = 3;
            this.chkImport.Text = "Design/Import";
            this.chkImport.UseVisualStyleBackColor = true;
            // 
            // btnAddObject
            // 
            this.btnAddObject.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnAddObject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddObject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddObject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnAddObject.Location = new System.Drawing.Point(568, 201);
            this.btnAddObject.Name = "btnAddObject";
            this.btnAddObject.Size = new System.Drawing.Size(124, 35);
            this.btnAddObject.TabIndex = 2;
            this.btnAddObject.Text = "Add Object";
            this.btnAddObject.UseVisualStyleBackColor = true;
            this.btnAddObject.Click += new System.EventHandler(this.btnAddObject_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnAddFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnAddFolder.Location = new System.Drawing.Point(568, 160);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(124, 35);
            this.btnAddFolder.TabIndex = 2;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnAddVariable
            // 
            this.btnAddVariable.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnAddVariable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVariable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVariable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnAddVariable.Location = new System.Drawing.Point(568, 242);
            this.btnAddVariable.Name = "btnAddVariable";
            this.btnAddVariable.Size = new System.Drawing.Size(124, 35);
            this.btnAddVariable.TabIndex = 2;
            this.btnAddVariable.Text = "Add Variable";
            this.btnAddVariable.UseVisualStyleBackColor = true;
            this.btnAddVariable.Click += new System.EventHandler(this.btnAddVariable_Click);
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnAddProperty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProperty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnAddProperty.Location = new System.Drawing.Point(568, 283);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(124, 35);
            this.btnAddProperty.TabIndex = 2;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnDelete.Location = new System.Drawing.Point(568, 324);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tvwModel
            // 
            this.tvwModel.Location = new System.Drawing.Point(53, 48);
            this.tvwModel.Name = "tvwModel";
            this.tvwModel.Size = new System.Drawing.Size(488, 342);
            this.tvwModel.TabIndex = 4;
            this.tvwModel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwModel_AfterSelect);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnNew.Location = new System.Drawing.Point(568, 119);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(124, 35);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // timerUpdateDesigner
            // 
            this.timerUpdateDesigner.Tick += new System.EventHandler(this.timerUpdateDesigner_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(49, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "File Path:";
            // 
            // MyServerDesignerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvwModel);
            this.Controls.Add(this.chkImport);
            this.Controls.Add(this.btnRunServer);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.btnAddVariable);
            this.Controls.Add(this.btnAddObject);
            this.Controls.Add(this.btnImportXml);
            this.Controls.Add(this.txtFilePath);
            this.Name = "MyServerDesignerUC";
            this.Size = new System.Drawing.Size(739, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnImportXml;
        private System.Windows.Forms.Button btnRunServer;
        private System.Windows.Forms.CheckBox chkImport;
        private System.Windows.Forms.Button btnAddObject;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnAddVariable;
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TreeView tvwModel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Timer timerUpdateDesigner;
        private System.Windows.Forms.Label label2;
    }
}
