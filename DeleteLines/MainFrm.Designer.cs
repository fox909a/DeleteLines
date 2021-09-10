namespace DeleteLines
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            this.fileScanBTN = new System.Windows.Forms.Button();
            this.folderTXTBX = new System.Windows.Forms.TextBox();
            this.extensionsTXTBX = new System.Windows.Forms.TextBox();
            this.lineTXTBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.browseBTN = new System.Windows.Forms.Button();
            this.fileListLSTBOX = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileScanBTN
            // 
            this.fileScanBTN.Location = new System.Drawing.Point(91, 118);
            this.fileScanBTN.Name = "fileScanBTN";
            this.fileScanBTN.Size = new System.Drawing.Size(221, 23);
            this.fileScanBTN.TabIndex = 0;
            this.fileScanBTN.Text = "Scan For Files";
            this.fileScanBTN.UseVisualStyleBackColor = true;
            this.fileScanBTN.Click += new System.EventHandler(this.fileScanBTN_Click);
            // 
            // folderTXTBX
            // 
            this.folderTXTBX.Location = new System.Drawing.Point(91, 39);
            this.folderTXTBX.Name = "folderTXTBX";
            this.folderTXTBX.Size = new System.Drawing.Size(221, 20);
            this.folderTXTBX.TabIndex = 1;
            this.folderTXTBX.Text = "C:\\Users\\waitchison\\Desktop";
            // 
            // extensionsTXTBX
            // 
            this.extensionsTXTBX.Location = new System.Drawing.Point(91, 65);
            this.extensionsTXTBX.Name = "extensionsTXTBX";
            this.extensionsTXTBX.Size = new System.Drawing.Size(221, 20);
            this.extensionsTXTBX.TabIndex = 2;
            this.extensionsTXTBX.Text = "*.txt,*.aspx";
            this.extensionsTXTBX.Validating += new System.ComponentModel.CancelEventHandler(this.extensionsTXTBX_Validating);
            // 
            // lineTXTBX
            // 
            this.lineTXTBX.Location = new System.Drawing.Point(91, 92);
            this.lineTXTBX.Name = "lineTXTBX";
            this.lineTXTBX.Size = new System.Drawing.Size(221, 20);
            this.lineTXTBX.TabIndex = 3;
            this.lineTXTBX.Validating += new System.ComponentModel.CancelEventHandler(this.lineTXTBX_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File Extensions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Line Number";
            // 
            // browseBTN
            // 
            this.browseBTN.Location = new System.Drawing.Point(334, 39);
            this.browseBTN.Name = "browseBTN";
            this.browseBTN.Size = new System.Drawing.Size(72, 23);
            this.browseBTN.TabIndex = 7;
            this.browseBTN.Text = "Browse...";
            this.browseBTN.UseVisualStyleBackColor = true;
            this.browseBTN.Click += new System.EventHandler(this.browseBTN_Click);
            // 
            // fileListLSTBOX
            // 
            this.fileListLSTBOX.FormattingEnabled = true;
            this.fileListLSTBOX.Location = new System.Drawing.Point(91, 144);
            this.fileListLSTBOX.Name = "fileListLSTBOX";
            this.fileListLSTBOX.Size = new System.Drawing.Size(221, 134);
            this.fileListLSTBOX.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Files";
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(91, 307);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(221, 24);
            this.deleteBTN.TabIndex = 11;
            this.deleteBTN.Text = "Perform Delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(91, 284);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(187, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Create Copy of Files Before Action";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 337);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileListLSTBOX);
            this.Controls.Add(this.browseBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineTXTBX);
            this.Controls.Add(this.extensionsTXTBX);
            this.Controls.Add(this.folderTXTBX);
            this.Controls.Add(this.fileScanBTN);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "Delete Lines";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileScanBTN;
        private System.Windows.Forms.TextBox folderTXTBX;
        private System.Windows.Forms.TextBox extensionsTXTBX;
        private System.Windows.Forms.TextBox lineTXTBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button browseBTN;
        private System.Windows.Forms.ListBox fileListLSTBOX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

