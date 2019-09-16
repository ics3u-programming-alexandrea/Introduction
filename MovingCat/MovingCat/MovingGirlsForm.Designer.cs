namespace MovingCat
{
    partial class frmMovingGirls
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
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGirls = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGirls1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGirls2 = new System.Windows.Forms.ToolStripMenuItem();
            this.picGirls = new System.Windows.Forms.PictureBox();
            this.mnuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGirls)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mnuGirls});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(800, 24);
            this.mnuFile.TabIndex = 0;
            this.mnuFile.Text = "File";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // mnuGirls
            // 
            this.mnuGirls.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGirls1,
            this.mniGirls2});
            this.mnuGirls.Name = "mnuGirls";
            this.mnuGirls.Size = new System.Drawing.Size(42, 20);
            this.mnuGirls.Text = "Girls";
            // 
            // mniGirls1
            // 
            this.mniGirls1.Name = "mniGirls1";
            this.mniGirls1.Size = new System.Drawing.Size(180, 22);
            this.mniGirls1.Text = "Girls1";
            this.mniGirls1.Click += new System.EventHandler(this.MniGirls1_Click);
            // 
            // mniGirls2
            // 
            this.mniGirls2.Name = "mniGirls2";
            this.mniGirls2.Size = new System.Drawing.Size(180, 22);
            this.mniGirls2.Text = "Girls2";
            this.mniGirls2.Click += new System.EventHandler(this.MniGirls2_Click);
            // 
            // picGirls
            // 
            this.picGirls.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picGirls.Image = global::MovingCat.Properties.Resources.ppg;
            this.picGirls.Location = new System.Drawing.Point(244, 143);
            this.picGirls.Name = "picGirls";
            this.picGirls.Size = new System.Drawing.Size(247, 185);
            this.picGirls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGirls.TabIndex = 1;
            this.picGirls.TabStop = false;
            // 
            // frmMovingGirls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picGirls);
            this.Controls.Add(this.mnuFile);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmMovingGirls";
            this.Text = "MovingGirls";
            this.Load += new System.EventHandler(this.FrmMovingGirls_Load);
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGirls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mnuGirls;
        private System.Windows.Forms.ToolStripMenuItem mniGirls1;
        private System.Windows.Forms.ToolStripMenuItem mniGirls2;
        private System.Windows.Forms.PictureBox picGirls;
    }
}

