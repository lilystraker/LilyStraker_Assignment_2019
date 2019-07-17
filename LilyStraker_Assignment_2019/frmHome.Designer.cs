namespace LilyStraker_Assignment_2019
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnlBG = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHomeBG = new System.Windows.Forms.Panel();
            this.pnlTopBar.SuspendLayout();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBG
            // 
            this.pnlBG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlBG.AutoSize = true;
            this.pnlBG.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.space;
            this.pnlBG.Location = new System.Drawing.Point(0, 96);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(2000, 444);
            this.pnlBG.TabIndex = 4;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlTopBar.BackColor = System.Drawing.Color.Navy;
            this.pnlTopBar.Controls.Add(this.pnlBG);
            this.pnlTopBar.Controls.Add(this.pnlTitle);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 27);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(2000, 90);
            this.pnlTopBar.TabIndex = 4;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.PlanetJamiro_Logo_Dark_Blue;
            this.pnlTitle.Location = new System.Drawing.Point(836, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(326, 90);
            this.pnlTitle.TabIndex = 5;
            // 
            // mnuStrip
            // 
            this.mnuStrip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mnuStrip.AutoSize = false;
            this.mnuStrip.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mnuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.mnuStop});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(2000, 24);
            this.mnuStrip.TabIndex = 3;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mnuStart
            // 
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(55, 20);
            this.mnuStart.Text = "Restart";
            // 
            // mnuStop
            // 
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(43, 20);
            this.mnuStop.Text = "Stop";
            // 
            // pnlHomeBG
            // 
            this.pnlHomeBG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlHomeBG.AutoSize = true;
            this.pnlHomeBG.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.space;
            this.pnlHomeBG.Location = new System.Drawing.Point(0, 120);
            this.pnlHomeBG.Name = "pnlHomeBG";
            this.pnlHomeBG.Size = new System.Drawing.Size(2000, 546);
            this.pnlHomeBG.TabIndex = 5;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlHomeBG);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.mnuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.Panel pnlHomeBG;
    }
}