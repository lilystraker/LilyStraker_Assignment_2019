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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnlBG = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.mnuHome = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHomeBG = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlTopBar.SuspendLayout();
            this.mnuHome.SuspendLayout();
            this.pnlHomeBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBG
            // 
            this.pnlBG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlBG.AutoSize = true;
            this.pnlBG.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.space;
            this.pnlBG.Location = new System.Drawing.Point(0, 51);
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
            this.pnlTopBar.Size = new System.Drawing.Size(0, 0);
            this.pnlTopBar.TabIndex = 4;
            this.pnlTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopBar_Paint);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitle.BackgroundImage")));
            this.pnlTitle.Location = new System.Drawing.Point(336, 27);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(0, 0);
            this.pnlTitle.TabIndex = 5;
            // 
            // mnuHome
            // 
            this.mnuHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mnuHome.AutoSize = false;
            this.mnuHome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mnuHome.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mnuHome.Location = new System.Drawing.Point(0, 0);
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(1000, 24);
            this.mnuHome.TabIndex = 7;
            this.mnuHome.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlay.Font = new System.Drawing.Font("Eras Medium ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(473, 256);
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
            this.btnInstructions.Location = new System.Drawing.Point(415, 351);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(219, 49);
            this.btnInstructions.TabIndex = 1;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.BtnInstructions_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(368, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 90);
            this.panel1.TabIndex = 6;
            // 
            // pnlHomeBG
            // 
            this.pnlHomeBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHomeBG.AutoSize = true;
            this.pnlHomeBG.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.space1;
            this.pnlHomeBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHomeBG.Controls.Add(this.panel1);
            this.pnlHomeBG.Controls.Add(this.btnInstructions);
            this.pnlHomeBG.Controls.Add(this.btnPlay);
            this.pnlHomeBG.Controls.Add(this.pictureBox2);
            this.pnlHomeBG.Controls.Add(this.pictureBox1);
            this.pnlHomeBG.Location = new System.Drawing.Point(0, 0);
            this.pnlHomeBG.Name = "pnlHomeBG";
            this.pnlHomeBG.Size = new System.Drawing.Size(1003, 703);
            this.pnlHomeBG.TabIndex = 5;
            this.pnlHomeBG.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHomeBG_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.stars_big;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1000, 700);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.stars;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 700);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.mnuHome);
            this.Controls.Add(this.pnlHomeBG);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlTopBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuHome;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHome_KeyDown);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.mnuHome.ResumeLayout(false);
            this.mnuHome.PerformLayout();
            this.pnlHomeBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.MenuStrip mnuHome;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlHomeBG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}