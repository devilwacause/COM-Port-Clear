namespace COMPort_Reset
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnF1COMClear = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnF1ImportReg = new System.Windows.Forms.Button();
            this.btnF1RegistryExport = new System.Windows.Forms.Button();
            this.btnRefreshCOM = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registryActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCOMPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port Cleaner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ver. 0.1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 134);
            this.listBox1.TabIndex = 2;
            // 
            // btnF1COMClear
            // 
            this.btnF1COMClear.Location = new System.Drawing.Point(203, 194);
            this.btnF1COMClear.Name = "btnF1COMClear";
            this.btnF1COMClear.Size = new System.Drawing.Size(78, 53);
            this.btnF1COMClear.TabIndex = 4;
            this.btnF1COMClear.Text = "Clear COM Ports";
            this.btnF1COMClear.UseVisualStyleBackColor = true;
            this.btnF1COMClear.Click += new System.EventHandler(this.btnF1COMClear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Registry Files | *.reg";
            // 
            // btnF1ImportReg
            // 
            this.btnF1ImportReg.Image = global::COMPort_Reset.Properties.Resources.Import;
            this.btnF1ImportReg.Location = new System.Drawing.Point(203, 133);
            this.btnF1ImportReg.Name = "btnF1ImportReg";
            this.btnF1ImportReg.Size = new System.Drawing.Size(78, 55);
            this.btnF1ImportReg.TabIndex = 6;
            this.btnF1ImportReg.UseVisualStyleBackColor = true;
            this.btnF1ImportReg.Click += new System.EventHandler(this.btnF1ImportReg_Click);
            // 
            // btnF1RegistryExport
            // 
            this.btnF1RegistryExport.Image = global::COMPort_Reset.Properties.Resources.Export2;
            this.btnF1RegistryExport.Location = new System.Drawing.Point(203, 74);
            this.btnF1RegistryExport.Name = "btnF1RegistryExport";
            this.btnF1RegistryExport.Size = new System.Drawing.Size(78, 53);
            this.btnF1RegistryExport.TabIndex = 5;
            this.btnF1RegistryExport.UseVisualStyleBackColor = true;
            this.btnF1RegistryExport.Click += new System.EventHandler(this.btnF1RegistryExport_Click);
            // 
            // btnRefreshCOM
            // 
            this.btnRefreshCOM.Image = global::COMPort_Reset.Properties.Resources.refresh1;
            this.btnRefreshCOM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshCOM.Location = new System.Drawing.Point(12, 215);
            this.btnRefreshCOM.Name = "btnRefreshCOM";
            this.btnRefreshCOM.Size = new System.Drawing.Size(185, 32);
            this.btnRefreshCOM.TabIndex = 3;
            this.btnRefreshCOM.Text = "Refresh Active COM Ports";
            this.btnRefreshCOM.UseVisualStyleBackColor = true;
            this.btnRefreshCOM.Click += new System.EventHandler(this.btnRefreshCOM_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.registryActionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(291, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // registryActionsToolStripMenuItem
            // 
            this.registryActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.clearCOMPortsToolStripMenuItem});
            this.registryActionsToolStripMenuItem.Name = "registryActionsToolStripMenuItem";
            this.registryActionsToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.registryActionsToolStripMenuItem.Text = "Registry Actions";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // clearCOMPortsToolStripMenuItem
            // 
            this.clearCOMPortsToolStripMenuItem.Name = "clearCOMPortsToolStripMenuItem";
            this.clearCOMPortsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clearCOMPortsToolStripMenuItem.Text = "Clear COM Ports";
            this.clearCOMPortsToolStripMenuItem.Click += new System.EventHandler(this.clearCOMPortsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 256);
            this.Controls.Add(this.btnF1ImportReg);
            this.Controls.Add(this.btnF1RegistryExport);
            this.Controls.Add(this.btnF1COMClear);
            this.Controls.Add(this.btnRefreshCOM);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "COM Port Cleaner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRefreshCOM;
        private System.Windows.Forms.Button btnF1COMClear;
        private System.Windows.Forms.Button btnF1RegistryExport;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnF1ImportReg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registryActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCOMPortsToolStripMenuItem;
    }
}

