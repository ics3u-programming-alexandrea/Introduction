namespace ProgramMenuAlex
{
    partial class frmProgramMenu
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
            this.lblFavoriteSoccerTeam = new System.Windows.Forms.Label();
            this.lblFavouriteSoccerPlayer = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFavoriteSoccerTeam
            // 
            this.lblFavoriteSoccerTeam.AutoSize = true;
            this.lblFavoriteSoccerTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoriteSoccerTeam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFavoriteSoccerTeam.Location = new System.Drawing.Point(282, 31);
            this.lblFavoriteSoccerTeam.Name = "lblFavoriteSoccerTeam";
            this.lblFavoriteSoccerTeam.Size = new System.Drawing.Size(251, 108);
            this.lblFavoriteSoccerTeam.TabIndex = 1;
            this.lblFavoriteSoccerTeam.Text = "PSG";
            // 
            // lblFavouriteSoccerPlayer
            // 
            this.lblFavouriteSoccerPlayer.AutoSize = true;
            this.lblFavouriteSoccerPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavouriteSoccerPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFavouriteSoccerPlayer.Location = new System.Drawing.Point(308, 158);
            this.lblFavouriteSoccerPlayer.Name = "lblFavouriteSoccerPlayer";
            this.lblFavouriteSoccerPlayer.Size = new System.Drawing.Size(198, 42);
            this.lblFavouriteSoccerPlayer.TabIndex = 2;
            this.lblFavouriteSoccerPlayer.Text = "Neymar Jr";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProgramMenuAlex.Properties.Resources.neymararrivesparis17v;
            this.pictureBox4.Location = new System.Drawing.Point(421, 224);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(382, 269);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProgramMenuAlex.Properties.Resources.as_neymar_0206;
            this.pictureBox1.Location = new System.Drawing.Point(3, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniProgram});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMenu.TabIndex = 7;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mniProgram
            // 
            this.mniProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniProgram.Name = "mniProgram";
            this.mniProgram.Size = new System.Drawing.Size(65, 20);
            this.mniProgram.Text = "Program";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // frmProgramMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFavouriteSoccerPlayer);
            this.Controls.Add(this.lblFavoriteSoccerTeam);
            this.Controls.Add(this.mnuMenu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmProgramMenu";
            this.Text = "Program Menu by Alex";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFavoriteSoccerTeam;
        private System.Windows.Forms.Label lblFavouriteSoccerPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

