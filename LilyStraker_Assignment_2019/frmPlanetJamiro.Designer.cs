namespace LilyStraker_Assignment_2019
{
    partial class frmPlanetJamiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanetJamiro));
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLives1 = new System.Windows.Forms.TextBox();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.labelName1 = new System.Windows.Forms.Label();
            this.labelLives1 = new System.Windows.Forms.Label();
            this.labelScore1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtLives2 = new System.Windows.Forms.TextBox();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.labelLives2 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.pnlBottomBar = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblBubbletime2 = new System.Windows.Forms.Label();
            this.lblBubbleCount2 = new System.Windows.Forms.Label();
            this.labelAmmo2 = new System.Windows.Forms.Label();
            this.labelCharged2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblBubbletime = new System.Windows.Forms.Label();
            this.lblBubbleCount = new System.Windows.Forms.Label();
            this.labelAmmo1 = new System.Windows.Forms.Label();
            this.labelCharged1 = new System.Windows.Forms.Label();
            this.pnlBG = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.tmrJf1 = new System.Windows.Forms.Timer(this.components);
            this.tmrBubble = new System.Windows.Forms.Timer(this.components);
            this.tmrBubbleRecharge = new System.Windows.Forms.Timer(this.components);
            this.tmrBubbleUse = new System.Windows.Forms.Timer(this.components);
            this.tmrEgg = new System.Windows.Forms.Timer(this.components);
            this.tmrJf2 = new System.Windows.Forms.Timer(this.components);
            this.tmrBubble2 = new System.Windows.Forms.Timer(this.components);
            this.tmrBubble2Recharge = new System.Windows.Forms.Timer(this.components);
            this.tmrBubble2Use = new System.Windows.Forms.Timer(this.components);
            this.btnPlay1 = new System.Windows.Forms.PictureBox();
            this.mnuStrip.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.lblTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBottomBar.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mnuStrip.AutoSize = false;
            this.mnuStrip.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mnuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.mnuStop,
            this.exitToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(985, 24);
            this.mnuStrip.TabIndex = 0;
            this.mnuStrip.Text = "menuStrip1";
            this.mnuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuStrip_ItemClicked);
            // 
            // mnuStart
            // 
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(43, 20);
            this.mnuStart.Text = "Start";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(43, 20);
            this.mnuStop.Text = "Stop";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTopBar.BackColor = System.Drawing.Color.Navy;
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Controls.Add(this.panel1);
            this.pnlTopBar.Controls.Add(this.panel2);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 27);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(985, 90);
            this.pnlTopBar.TabIndex = 2;
            this.pnlTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopBar_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.PlanetJamiro_Logo;
            this.lblTitle.Controls.Add(this.btnPlay1);
            this.lblTitle.Controls.Add(this.btnPlay);
            this.lblTitle.Location = new System.Drawing.Point(333, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(326, 90);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlay.Font = new System.Drawing.Font("Eras Medium ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(122, 13);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(101, 49);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtLives1);
            this.panel1.Controls.Add(this.lblScore1);
            this.panel1.Controls.Add(this.txtName1);
            this.panel1.Controls.Add(this.labelName1);
            this.panel1.Controls.Add(this.labelLives1);
            this.panel1.Controls.Add(this.labelScore1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 84);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(58, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 90);
            this.panel3.TabIndex = 1;
            // 
            // txtLives1
            // 
            this.txtLives1.BackColor = System.Drawing.Color.Black;
            this.txtLives1.ForeColor = System.Drawing.Color.White;
            this.txtLives1.Location = new System.Drawing.Point(67, 61);
            this.txtLives1.Name = "txtLives1";
            this.txtLives1.Size = new System.Drawing.Size(33, 20);
            this.txtLives1.TabIndex = 10;
            this.txtLives1.Text = "5";
            this.txtLives1.TextChanged += new System.EventHandler(this.txtLives1_TextChanged);
            this.txtLives1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLives1_KeyDown);
            this.txtLives1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLives1_KeyPress);
            this.txtLives1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLives1_KeyUp);
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblScore1.Location = new System.Drawing.Point(65, 32);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(16, 18);
            this.lblScore1.TabIndex = 9;
            this.lblScore1.Text = "0";
            // 
            // txtName1
            // 
            this.txtName1.BackColor = System.Drawing.Color.Black;
            this.txtName1.ForeColor = System.Drawing.Color.White;
            this.txtName1.Location = new System.Drawing.Point(67, 3);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(122, 20);
            this.txtName1.TabIndex = 8;
            this.txtName1.TextChanged += new System.EventHandler(this.txtName1_TextChanged);
            this.txtName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName1_KeyDown);
            this.txtName1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName1_KeyPress);
            this.txtName1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName1_KeyUp);
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.BackColor = System.Drawing.Color.Transparent;
            this.labelName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName1.ForeColor = System.Drawing.Color.White;
            this.labelName1.Location = new System.Drawing.Point(3, 1);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(55, 20);
            this.labelName1.TabIndex = 0;
            this.labelName1.Text = "Name";
            // 
            // labelLives1
            // 
            this.labelLives1.AutoSize = true;
            this.labelLives1.BackColor = System.Drawing.Color.Transparent;
            this.labelLives1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLives1.ForeColor = System.Drawing.Color.White;
            this.labelLives1.Location = new System.Drawing.Point(3, 60);
            this.labelLives1.Name = "labelLives1";
            this.labelLives1.Size = new System.Drawing.Size(50, 20);
            this.labelLives1.TabIndex = 4;
            this.labelLives1.Text = "Lives";
            // 
            // labelScore1
            // 
            this.labelScore1.AutoSize = true;
            this.labelScore1.BackColor = System.Drawing.Color.Transparent;
            this.labelScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore1.ForeColor = System.Drawing.Color.White;
            this.labelScore1.Location = new System.Drawing.Point(3, 30);
            this.labelScore1.Name = "labelScore1";
            this.labelScore1.Size = new System.Drawing.Size(56, 20);
            this.labelScore1.TabIndex = 2;
            this.labelScore1.Text = "Score";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtLives2);
            this.panel2.Controls.Add(this.lblScore2);
            this.panel2.Controls.Add(this.txtName2);
            this.panel2.Controls.Add(this.labelLives2);
            this.panel2.Controls.Add(this.labelName2);
            this.panel2.Controls.Add(this.labelScore2);
            this.panel2.Location = new System.Drawing.Point(779, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 84);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(143, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 90);
            this.panel4.TabIndex = 2;
            // 
            // txtLives2
            // 
            this.txtLives2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLives2.BackColor = System.Drawing.Color.Black;
            this.txtLives2.ForeColor = System.Drawing.Color.White;
            this.txtLives2.Location = new System.Drawing.Point(99, 60);
            this.txtLives2.Name = "txtLives2";
            this.txtLives2.Size = new System.Drawing.Size(33, 20);
            this.txtLives2.TabIndex = 11;
            this.txtLives2.TextChanged += new System.EventHandler(this.txtLives2_TextChanged);
            this.txtLives2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLives2_KeyDown);
            this.txtLives2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLives2_KeyUp);
            // 
            // lblScore2
            // 
            this.lblScore2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblScore2.Location = new System.Drawing.Point(116, 32);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(16, 18);
            this.lblScore2.TabIndex = 11;
            this.lblScore2.Text = "0";
            // 
            // txtName2
            // 
            this.txtName2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName2.BackColor = System.Drawing.Color.Black;
            this.txtName2.ForeColor = System.Drawing.Color.White;
            this.txtName2.Location = new System.Drawing.Point(10, 3);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(122, 20);
            this.txtName2.TabIndex = 11;
            this.txtName2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName2_KeyDown);
            this.txtName2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName2_KeyPress);
            this.txtName2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName2_KeyUp);
            // 
            // labelLives2
            // 
            this.labelLives2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLives2.AutoSize = true;
            this.labelLives2.BackColor = System.Drawing.Color.Transparent;
            this.labelLives2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLives2.ForeColor = System.Drawing.Color.White;
            this.labelLives2.Location = new System.Drawing.Point(150, 60);
            this.labelLives2.Name = "labelLives2";
            this.labelLives2.Size = new System.Drawing.Size(50, 20);
            this.labelLives2.TabIndex = 5;
            this.labelLives2.Text = "Lives";
            // 
            // labelName2
            // 
            this.labelName2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelName2.AutoSize = true;
            this.labelName2.BackColor = System.Drawing.Color.Transparent;
            this.labelName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName2.ForeColor = System.Drawing.Color.White;
            this.labelName2.Location = new System.Drawing.Point(147, 1);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(55, 20);
            this.labelName2.TabIndex = 1;
            this.labelName2.Text = "Name";
            // 
            // labelScore2
            // 
            this.labelScore2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScore2.AutoSize = true;
            this.labelScore2.BackColor = System.Drawing.Color.Transparent;
            this.labelScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore2.ForeColor = System.Drawing.Color.White;
            this.labelScore2.Location = new System.Drawing.Point(147, 30);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(56, 20);
            this.labelScore2.TabIndex = 3;
            this.labelScore2.Text = "Score";
            // 
            // pnlBottomBar
            // 
            this.pnlBottomBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBottomBar.BackColor = System.Drawing.Color.Black;
            this.pnlBottomBar.Controls.Add(this.panel8);
            this.pnlBottomBar.Controls.Add(this.panel6);
            this.pnlBottomBar.Location = new System.Drawing.Point(0, 570);
            this.pnlBottomBar.Name = "pnlBottomBar";
            this.pnlBottomBar.Size = new System.Drawing.Size(985, 91);
            this.pnlBottomBar.TabIndex = 3;
            this.pnlBottomBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBottomBar_Paint);
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel8.Controls.Add(this.lblBubbletime2);
            this.panel8.Controls.Add(this.lblBubbleCount2);
            this.panel8.Controls.Add(this.labelAmmo2);
            this.panel8.Controls.Add(this.labelCharged2);
            this.panel8.Location = new System.Drawing.Point(781, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 84);
            this.panel8.TabIndex = 12;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel8_Paint);
            // 
            // lblBubbletime2
            // 
            this.lblBubbletime2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBubbletime2.AutoSize = true;
            this.lblBubbletime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBubbletime2.ForeColor = System.Drawing.Color.White;
            this.lblBubbletime2.Location = new System.Drawing.Point(94, 46);
            this.lblBubbletime2.Name = "lblBubbletime2";
            this.lblBubbletime2.Size = new System.Drawing.Size(16, 18);
            this.lblBubbletime2.TabIndex = 10;
            this.lblBubbletime2.Text = "3";
            this.lblBubbletime2.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblBubbleCount2
            // 
            this.lblBubbleCount2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBubbleCount2.AutoSize = true;
            this.lblBubbleCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBubbleCount2.ForeColor = System.Drawing.Color.White;
            this.lblBubbleCount2.Location = new System.Drawing.Point(89, 11);
            this.lblBubbleCount2.Name = "lblBubbleCount2";
            this.lblBubbleCount2.Size = new System.Drawing.Size(24, 18);
            this.lblBubbleCount2.TabIndex = 9;
            this.lblBubbleCount2.Text = "10";
            // 
            // labelAmmo2
            // 
            this.labelAmmo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAmmo2.AutoSize = true;
            this.labelAmmo2.BackColor = System.Drawing.Color.Transparent;
            this.labelAmmo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmmo2.ForeColor = System.Drawing.Color.White;
            this.labelAmmo2.Location = new System.Drawing.Point(138, 13);
            this.labelAmmo2.Name = "labelAmmo2";
            this.labelAmmo2.Size = new System.Drawing.Size(59, 20);
            this.labelAmmo2.TabIndex = 0;
            this.labelAmmo2.Text = "Ammo";
            this.labelAmmo2.Click += new System.EventHandler(this.Label3_Click);
            // 
            // labelCharged2
            // 
            this.labelCharged2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCharged2.AutoSize = true;
            this.labelCharged2.BackColor = System.Drawing.Color.Transparent;
            this.labelCharged2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharged2.ForeColor = System.Drawing.Color.White;
            this.labelCharged2.Location = new System.Drawing.Point(122, 44);
            this.labelCharged2.Name = "labelCharged2";
            this.labelCharged2.Size = new System.Drawing.Size(77, 20);
            this.labelCharged2.TabIndex = 2;
            this.labelCharged2.Text = "Charged";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.lblBubbletime);
            this.panel6.Controls.Add(this.lblBubbleCount);
            this.panel6.Controls.Add(this.labelAmmo1);
            this.panel6.Controls.Add(this.labelCharged1);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 84);
            this.panel6.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(82, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 90);
            this.panel5.TabIndex = 1;
            // 
            // lblBubbletime
            // 
            this.lblBubbletime.AutoSize = true;
            this.lblBubbletime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBubbletime.ForeColor = System.Drawing.Color.White;
            this.lblBubbletime.Location = new System.Drawing.Point(92, 47);
            this.lblBubbletime.Name = "lblBubbletime";
            this.lblBubbletime.Size = new System.Drawing.Size(16, 18);
            this.lblBubbletime.TabIndex = 10;
            this.lblBubbletime.Text = "3";
            // 
            // lblBubbleCount
            // 
            this.lblBubbleCount.AutoSize = true;
            this.lblBubbleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBubbleCount.ForeColor = System.Drawing.Color.White;
            this.lblBubbleCount.Location = new System.Drawing.Point(90, 15);
            this.lblBubbleCount.Name = "lblBubbleCount";
            this.lblBubbleCount.Size = new System.Drawing.Size(24, 18);
            this.lblBubbleCount.TabIndex = 9;
            this.lblBubbleCount.Text = "10";
            // 
            // labelAmmo1
            // 
            this.labelAmmo1.AutoSize = true;
            this.labelAmmo1.BackColor = System.Drawing.Color.Transparent;
            this.labelAmmo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmmo1.ForeColor = System.Drawing.Color.White;
            this.labelAmmo1.Location = new System.Drawing.Point(3, 11);
            this.labelAmmo1.Name = "labelAmmo1";
            this.labelAmmo1.Size = new System.Drawing.Size(59, 20);
            this.labelAmmo1.TabIndex = 0;
            this.labelAmmo1.Text = "Ammo";
            this.labelAmmo1.Click += new System.EventHandler(this.Label2_Click);
            // 
            // labelCharged1
            // 
            this.labelCharged1.AutoSize = true;
            this.labelCharged1.BackColor = System.Drawing.Color.Transparent;
            this.labelCharged1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharged1.ForeColor = System.Drawing.Color.White;
            this.labelCharged1.Location = new System.Drawing.Point(3, 45);
            this.labelCharged1.Name = "labelCharged1";
            this.labelCharged1.Size = new System.Drawing.Size(77, 20);
            this.labelCharged1.TabIndex = 2;
            this.labelCharged1.Text = "Charged";
            // 
            // pnlBG
            // 
            this.pnlBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBG.AutoSize = true;
            this.pnlBG.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.space1;
            this.pnlBG.Location = new System.Drawing.Point(0, 120);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(985, 447);
            this.pnlBG.TabIndex = 3;
            this.pnlBG.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBG_Paint);
            this.pnlBG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBG_MouseDown);
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Location = new System.Drawing.Point(901, 570);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 90);
            this.panel7.TabIndex = 1;
            // 
            // tmrEnemy
            // 
            this.tmrEnemy.Tick += new System.EventHandler(this.TmrEnemy_Tick);
            // 
            // tmrJf1
            // 
            this.tmrJf1.Interval = 50;
            this.tmrJf1.Tick += new System.EventHandler(this.TmrJf1_Tick);
            // 
            // tmrBubble
            // 
            this.tmrBubble.Tick += new System.EventHandler(this.tmrBubble_Tick);
            // 
            // tmrBubbleRecharge
            // 
            this.tmrBubbleRecharge.Enabled = true;
            this.tmrBubbleRecharge.Interval = 1000;
            this.tmrBubbleRecharge.Tick += new System.EventHandler(this.tmrBubbleRecharge_Tick);
            // 
            // tmrBubbleUse
            // 
            this.tmrBubbleUse.Enabled = true;
            this.tmrBubbleUse.Interval = 500;
            this.tmrBubbleUse.Tick += new System.EventHandler(this.tmrBubbleUse_Tick);
            // 
            // tmrEgg
            // 
            this.tmrEgg.Interval = 1000;
            this.tmrEgg.Tick += new System.EventHandler(this.tmrEgg_Tick);
            // 
            // tmrJf2
            // 
            this.tmrJf2.Enabled = true;
            this.tmrJf2.Interval = 50;
            this.tmrJf2.Tick += new System.EventHandler(this.tmrJf2_Tick);
            // 
            // tmrBubble2
            // 
            this.tmrBubble2.Tick += new System.EventHandler(this.tmrBubble2_Tick);
            // 
            // tmrBubble2Recharge
            // 
            this.tmrBubble2Recharge.Interval = 1000;
            this.tmrBubble2Recharge.Tick += new System.EventHandler(this.tmrBubble2Recharge_Tick);
            // 
            // tmrBubble2Use
            // 
            this.tmrBubble2Use.Interval = 500;
            this.tmrBubble2Use.Tick += new System.EventHandler(this.tmrBubble2Use_Tick);
            // 
            // btnPlay1
            // 
            this.btnPlay1.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.play;
            this.btnPlay1.Location = new System.Drawing.Point(123, 12);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(100, 50);
            this.btnPlay1.TabIndex = 2;
            this.btnPlay1.TabStop = false;
            // 
            // frmPlanetJamiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pnlBottomBar);
            this.Controls.Add(this.pnlBG);
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.pnlTopBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmPlanetJamiro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPlanetJamiro_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmPlanetJamiro_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPlanetJamiro_MouseDown);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.lblTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlBottomBar.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.Panel pnlBottomBar;
        private System.Windows.Forms.Panel lblTitle;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelLives1;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label labelLives2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBubbleCount;
        private System.Windows.Forms.Label labelAmmo1;
        private System.Windows.Forms.Label labelCharged1;
        private System.Windows.Forms.Label lblBubbletime;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblBubbletime2;
        private System.Windows.Forms.Label lblBubbleCount2;
        private System.Windows.Forms.Label labelAmmo2;
        private System.Windows.Forms.Label labelCharged2;
        private System.Windows.Forms.Timer tmrEnemy;
        private System.Windows.Forms.Timer tmrJf1;
        private System.Windows.Forms.TextBox txtLives1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtLives2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Timer tmrBubble;
        private System.Windows.Forms.Timer tmrBubbleRecharge;
        private System.Windows.Forms.Timer tmrBubbleUse;
        private System.Windows.Forms.Timer tmrEgg;
        private System.Windows.Forms.Timer tmrJf2;
        private System.Windows.Forms.Timer tmrBubble2;
        private System.Windows.Forms.Timer tmrBubble2Recharge;
        private System.Windows.Forms.Timer tmrBubble2Use;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox btnPlay1;
    }
}

