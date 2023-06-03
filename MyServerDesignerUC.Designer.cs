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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyServerDesignerUC));
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnImportXml = new System.Windows.Forms.Button();
            this.imgNode = new System.Windows.Forms.ImageList(this.components);
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
            this.btnExport = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
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
            this.btnImportXml.ImageIndex = 6;
            this.btnImportXml.ImageList = this.imgNode;
            this.btnImportXml.Location = new System.Drawing.Point(553, 413);
            this.btnImportXml.Name = "btnImportXml";
            this.btnImportXml.Size = new System.Drawing.Size(168, 35);
            this.btnImportXml.TabIndex = 2;
            this.btnImportXml.Text = "Import";
            this.btnImportXml.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportXml.UseVisualStyleBackColor = true;
            this.btnImportXml.Click += new System.EventHandler(this.btnImportXml_Click);
            // 
            // imgNode
            // 
            this.imgNode.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgNode.ImageStream")));
            this.imgNode.TransparentColor = System.Drawing.Color.Transparent;
            this.imgNode.Images.SetKeyName(0, "icons8-view-details-50.png");
            this.imgNode.Images.SetKeyName(1, "icons8-variable-48.png");
            this.imgNode.Images.SetKeyName(2, "icons8-object-48.png");
            this.imgNode.Images.SetKeyName(3, "icons8-folder-48.png");
            this.imgNode.Images.SetKeyName(4, "icons8-blank-64.png");
            this.imgNode.Images.SetKeyName(5, "icons8-remove-48.png");
            this.imgNode.Images.SetKeyName(6, "icons8-import-64.png");
            this.imgNode.Images.SetKeyName(7, "icons8-new-copy-80.png");
            this.imgNode.Images.SetKeyName(8, "icons8-export-64.png");
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
            this.btnAddObject.ImageIndex = 2;
            this.btnAddObject.ImageList = this.imgNode;
            this.btnAddObject.Location = new System.Drawing.Point(553, 151);
            this.btnAddObject.Name = "btnAddObject";
            this.btnAddObject.Size = new System.Drawing.Size(168, 35);
            this.btnAddObject.TabIndex = 2;
            this.btnAddObject.Text = "Add Object";
            this.btnAddObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnAddFolder.ImageIndex = 3;
            this.btnAddFolder.ImageList = this.imgNode;
            this.btnAddFolder.Location = new System.Drawing.Point(553, 105);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddFolder.Size = new System.Drawing.Size(168, 35);
            this.btnAddFolder.TabIndex = 2;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnAddVariable.ImageIndex = 1;
            this.btnAddVariable.ImageList = this.imgNode;
            this.btnAddVariable.Location = new System.Drawing.Point(553, 197);
            this.btnAddVariable.Name = "btnAddVariable";
            this.btnAddVariable.Size = new System.Drawing.Size(168, 35);
            this.btnAddVariable.TabIndex = 2;
            this.btnAddVariable.Text = "Add Variable";
            this.btnAddVariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnAddProperty.ImageIndex = 0;
            this.btnAddProperty.ImageList = this.imgNode;
            this.btnAddProperty.Location = new System.Drawing.Point(553, 243);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(168, 35);
            this.btnAddProperty.TabIndex = 2;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnDelete.ImageIndex = 5;
            this.btnDelete.ImageList = this.imgNode;
            this.btnDelete.Location = new System.Drawing.Point(553, 289);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tvwModel
            // 
            this.tvwModel.ImageIndex = 0;
            this.tvwModel.ImageList = this.imgNode;
            this.tvwModel.Location = new System.Drawing.Point(53, 48);
            this.tvwModel.Name = "tvwModel";
            this.tvwModel.SelectedImageIndex = 0;
            this.tvwModel.Size = new System.Drawing.Size(451, 342);
            this.tvwModel.TabIndex = 4;
            this.tvwModel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwModel_AfterSelect);
            this.tvwModel.DoubleClick += new System.EventHandler(this.tvwModel_DoubleClick);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnNew.ImageIndex = 7;
            this.btnNew.ImageList = this.imgNode;
            this.btnNew.Location = new System.Drawing.Point(553, 59);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(168, 35);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            // btnExport
            // 
            this.btnExport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnExport.ImageIndex = 8;
            this.btnExport.ImageList = this.imgNode;
            this.btnExport.Location = new System.Drawing.Point(553, 335);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(168, 35);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnOpen.ImageIndex = 7;
            this.btnOpen.Location = new System.Drawing.Point(657, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(64, 35);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Visible = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
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
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExport);
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
        private System.Windows.Forms.ImageList imgNode;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnOpen;
    }
}
