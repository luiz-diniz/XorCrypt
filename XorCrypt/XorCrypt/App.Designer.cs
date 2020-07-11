namespace XorCrypt
{
    partial class App
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
            this.btnKey = new System.Windows.Forms.Button();
            this.btnEncryptDecrypt = new System.Windows.Forms.Button();
            this.txtEncryptDecrypt = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKeySize = new System.Windows.Forms.Label();
            this.txtKeySize = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.smInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.smReport = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAutoSizeKey = new System.Windows.Forms.Label();
            this.cbAutoSizeKey = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKey
            // 
            this.btnKey.Location = new System.Drawing.Point(15, 89);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(148, 34);
            this.btnKey.TabIndex = 1;
            this.btnKey.Text = "Generate Key";
            this.btnKey.UseVisualStyleBackColor = true;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // btnEncryptDecrypt
            // 
            this.btnEncryptDecrypt.Location = new System.Drawing.Point(12, 232);
            this.btnEncryptDecrypt.Name = "btnEncryptDecrypt";
            this.btnEncryptDecrypt.Size = new System.Drawing.Size(148, 34);
            this.btnEncryptDecrypt.TabIndex = 5;
            this.btnEncryptDecrypt.Text = "Encrypt/Decrypt Message";
            this.btnEncryptDecrypt.UseVisualStyleBackColor = true;
            this.btnEncryptDecrypt.Click += new System.EventHandler(this.btnEncryptDecrypt_Click);
            // 
            // txtEncryptDecrypt
            // 
            this.txtEncryptDecrypt.Location = new System.Drawing.Point(166, 202);
            this.txtEncryptDecrypt.Multiline = true;
            this.txtEncryptDecrypt.Name = "txtEncryptDecrypt";
            this.txtEncryptDecrypt.Size = new System.Drawing.Size(344, 97);
            this.txtEncryptDecrypt.TabIndex = 4;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(166, 89);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(344, 97);
            this.txtKey.TabIndex = 6;
            // 
            // lblKeySize
            // 
            this.lblKeySize.AutoSize = true;
            this.lblKeySize.Location = new System.Drawing.Point(187, 47);
            this.lblKeySize.Name = "lblKeySize";
            this.lblKeySize.Size = new System.Drawing.Size(48, 13);
            this.lblKeySize.TabIndex = 7;
            this.lblKeySize.Text = "Key Size";
            // 
            // txtKeySize
            // 
            this.txtKeySize.Location = new System.Drawing.Point(190, 63);
            this.txtKeySize.Name = "txtKeySize";
            this.txtKeySize.Size = new System.Drawing.Size(62, 20);
            this.txtKeySize.TabIndex = 8;
            this.txtKeySize.Text = "50";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smHelp,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smHelp
            // 
            this.smHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smInstructions,
            this.smReport});
            this.smHelp.Name = "smHelp";
            this.smHelp.Size = new System.Drawing.Size(44, 20);
            this.smHelp.Text = "Help";
            // 
            // smInstructions
            // 
            this.smInstructions.Name = "smInstructions";
            this.smInstructions.Size = new System.Drawing.Size(187, 22);
            this.smInstructions.Text = "Instructions";
            // 
            // smReport
            // 
            this.smReport.Name = "smReport";
            this.smReport.Size = new System.Drawing.Size(187, 22);
            this.smReport.Text = "Report Bugs - GitHub";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblAutoSizeKey
            // 
            this.lblAutoSizeKey.AutoSize = true;
            this.lblAutoSizeKey.Location = new System.Drawing.Point(187, 23);
            this.lblAutoSizeKey.Name = "lblAutoSizeKey";
            this.lblAutoSizeKey.Size = new System.Drawing.Size(73, 13);
            this.lblAutoSizeKey.TabIndex = 10;
            this.lblAutoSizeKey.Text = "Auto Size Key";
            // 
            // cbAutoSizeKey
            // 
            this.cbAutoSizeKey.AutoSize = true;
            this.cbAutoSizeKey.Location = new System.Drawing.Point(266, 23);
            this.cbAutoSizeKey.Name = "cbAutoSizeKey";
            this.cbAutoSizeKey.Size = new System.Drawing.Size(15, 14);
            this.cbAutoSizeKey.TabIndex = 11;
            this.cbAutoSizeKey.UseVisualStyleBackColor = true;
            this.cbAutoSizeKey.CheckedChanged += new System.EventHandler(this.cbAutoSizeKey_CheckedChanged);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 311);
            this.Controls.Add(this.cbAutoSizeKey);
            this.Controls.Add(this.lblAutoSizeKey);
            this.Controls.Add(this.txtKeySize);
            this.Controls.Add(this.lblKeySize);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnEncryptDecrypt);
            this.Controls.Add(this.txtEncryptDecrypt);
            this.Controls.Add(this.btnKey);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XorCrypt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKey;
        private System.Windows.Forms.Button btnEncryptDecrypt;
        private System.Windows.Forms.TextBox txtEncryptDecrypt;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKeySize;
        private System.Windows.Forms.TextBox txtKeySize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smHelp;
        private System.Windows.Forms.ToolStripMenuItem smInstructions;
        private System.Windows.Forms.ToolStripMenuItem smReport;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblAutoSizeKey;
        private System.Windows.Forms.CheckBox cbAutoSizeKey;
    }
}

