namespace LilyStraker_Assignment_2019
{
    partial class frmInstructions
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
            this.pnlHomeBG = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pnlBG = new System.Windows.Forms.Panel();
            this.mnuStripHome = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblInstructionTitle = new System.Windows.Forms.Label();
            this.pnlHomeBG.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.mnuStripHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHomeBG
            // 
            this.pnlHomeBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHomeBG.AutoSize = true;
            this.pnlHomeBG.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.space;
            this.pnlHomeBG.Controls.Add(this.lblInstructionTitle);
            this.pnlHomeBG.Controls.Add(this.textBox1);
            this.pnlHomeBG.Location = new System.Drawing.Point(-505, 122);
            this.pnlHomeBG.Name = "pnlHomeBG";
            this.pnlHomeBG.Size = new System.Drawing.Size(2000, 546);
            this.pnlHomeBG.TabIndex = 8;
            this.pnlHomeBG.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHomeBG_Paint);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.PlanetJamiro_Logo_Dark_Blue;
            this.pnlTitle.Location = new System.Drawing.Point(331, 29);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(326, 90);
            this.pnlTitle.TabIndex = 9;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTitle_Paint);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTopBar.BackColor = System.Drawing.Color.Navy;
            this.pnlTopBar.Controls.Add(this.pnlBG);
            this.pnlTopBar.Location = new System.Drawing.Point(-505, 29);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(2000, 90);
            this.pnlTopBar.TabIndex = 7;
            this.pnlTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTopBar_Paint);
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
            // mnuStripHome
            // 
            this.mnuStripHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mnuStripHome.AutoSize = false;
            this.mnuStripHome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mnuStripHome.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuStripHome.Location = new System.Drawing.Point(-5, 2);
            this.mnuStripHome.Name = "mnuStripHome";
            this.mnuStripHome.Size = new System.Drawing.Size(2000, 24);
            this.mnuStripHome.TabIndex = 6;
            this.mnuStripHome.Text = "menuStrip1";
            this.mnuStripHome.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MnuStripHome_ItemClicked);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblInstructionTitle
            // 
            this.lblInstructionTitle.AutoSize = true;
            this.lblInstructionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionTitle.Location = new System.Drawing.Point(913, 38);
            this.lblInstructionTitle.Name = "lblInstructionTitle";
            this.lblInstructionTitle.Size = new System.Drawing.Size(155, 31);
            this.lblInstructionTitle.TabIndex = 1;
            this.lblInstructionTitle.Text = "Instructions";
            this.lblInstructionTitle.Click += new System.EventHandler(this.LblInstructionTitle_Click);
            // 
            // frmInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlHomeBG);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.mnuStripHome);
            this.Name = "frmInstructions";
            this.Text = "frmInstructions";
            this.pnlHomeBG.ResumeLayout(false);
            this.pnlHomeBG.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.mnuStripHome.ResumeLayout(false);
            this.mnuStripHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHomeBG;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.MenuStrip mnuStripHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblInstructionTitle;
    }
}