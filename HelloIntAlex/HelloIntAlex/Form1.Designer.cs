namespace HelloIntAlex
{
    partial class frmHelloWorldInt
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
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.grbGreetings = new System.Windows.Forms.GroupBox();
            this.radarabic = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.grbGreetings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Dutch801 XBd BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.Location = new System.Drawing.Point(373, 116);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(433, 77);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello, World!";
            // 
            // grbGreetings
            // 
            this.grbGreetings.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grbGreetings.Controls.Add(this.radarabic);
            this.grbGreetings.Controls.Add(this.radSpanish);
            this.grbGreetings.Controls.Add(this.radFrench);
            this.grbGreetings.Controls.Add(this.radEnglish);
            this.grbGreetings.Location = new System.Drawing.Point(228, 221);
            this.grbGreetings.Name = "grbGreetings";
            this.grbGreetings.Size = new System.Drawing.Size(719, 100);
            this.grbGreetings.TabIndex = 1;
            this.grbGreetings.TabStop = false;
            this.grbGreetings.Text = "Language select";
            this.grbGreetings.Enter += new System.EventHandler(this.GrbGreetings_Enter);
            // 
            // radarabic
            // 
            this.radarabic.AutoSize = true;
            this.radarabic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radarabic.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radarabic.Location = new System.Drawing.Point(595, 30);
            this.radarabic.Name = "radarabic";
            this.radarabic.Size = new System.Drawing.Size(95, 41);
            this.radarabic.TabIndex = 3;
            this.radarabic.TabStop = true;
            this.radarabic.Text = "عربى";
            this.radarabic.UseVisualStyleBackColor = false;
            this.radarabic.CheckedChanged += new System.EventHandler(this.Radarabic_CheckedChanged);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSpanish.Location = new System.Drawing.Point(377, 27);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(175, 43);
            this.radSpanish.TabIndex = 2;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "española";
            this.radSpanish.UseVisualStyleBackColor = false;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.RadSpanish_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFrench.Location = new System.Drawing.Point(180, 27);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(158, 43);
            this.radFrench.TabIndex = 1;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "français";
            this.radFrench.UseVisualStyleBackColor = false;
            this.radFrench.CheckedChanged += new System.EventHandler(this.RadFrench_CheckedChanged);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEnglish.Location = new System.Drawing.Point(6, 27);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(149, 43);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = false;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1181, 584);
            this.Controls.Add(this.grbGreetings);
            this.Controls.Add(this.lblHelloWorld);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello, World! International by Alex";
            this.grbGreetings.ResumeLayout(false);
            this.grbGreetings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.GroupBox grbGreetings;
        private System.Windows.Forms.RadioButton radarabic;
        private System.Windows.Forms.RadioButton radSpanish;
        private System.Windows.Forms.RadioButton radFrench;
        private System.Windows.Forms.RadioButton radEnglish;
    }
}

