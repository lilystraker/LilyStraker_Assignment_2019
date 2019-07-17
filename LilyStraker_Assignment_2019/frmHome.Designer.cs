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
            this.pnlHomeBG = new System.Windows.Forms.Panel();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripHome = new System.Windows.Forms.MenuStrip();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlHomeBG.SuspendLayout();
            this.mnuStripHome.SuspendLayout();
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
            this.pnlTopBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTopBar.BackColor = System.Drawing.Color.Navy;
            this.pnlTopBar.Controls.Add(this.pnlBG);
            this.pnlTopBar.Location = new System.Drawing.Point(-500, 27);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(2000, 90);
            this.pnlTopBar.TabIndex = 4;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.PlanetJamiro_Logo_Dark_Blue;
            this.pnlTitle.Location = new System.Drawing.Point(336, 27);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(326, 90);
            this.pnlTitle.TabIndex = 5;
            // 
            // pnlHomeBG
            // 
            this.pnlHomeBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHomeBG.AutoSize = true;
            this.pnlHomeBG.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.space;
            this.pnlHomeBG.Controls.Add(this.btnInstructions);
            this.pnlHomeBG.Controls.Add(this.btnPlay);
            this.pnlHomeBG.Location = new System.Drawing.Point(-500, 120);
            this.pnlHomeBG.Name = "pnlHomeBG";
            this.pnlHomeBG.Size = new System.Drawing.Size(2000, 546);
            this.pnlHomeBG.TabIndex = 5;
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            // 
            // mnuStripHome
            // 
            this.mnuStripHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mnuStripHome.AutoSize = false;
            this.mnuStripHome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mnuStripHome.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuStripHome.Location = new System.Drawing.Point(0, 0);
            this.mnuStripHome.Name = "mnuStripHome";
            this.mnuStripHome.Size = new System.Drawing.Size(2000, 24);
            this.mnuStripHome.TabIndex = 3;
            this.mnuStripHome.Text = "menuStrip1";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlay.Font = new System.Drawing.Font("Eras Medium ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(954, 170);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(101, 49);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInstructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInstructions.Font = new System.Drawing.Font("Eras Medium ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.Color.White;
            this.btnInstructions.Location = new System.Drawing.Point(893, 279);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(219, 49);
            this.btnInstructions.TabIndex = 1;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.BtnInstructions_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlHomeBG);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.mnuStripHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlHomeBG.ResumeLayout(false);
            this.mnuStripHome.ResumeLayout(false);
            this.mnuStripHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlHomeBG;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.MenuStrip mnuStripHome;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnInstructions;
    }
}