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
            this.pnlTopBar = new System.Windows.Forms.Panel();
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlBottomBar = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblCharged2 = new System.Windows.Forms.Label();
            this.lblAmmo2 = new System.Windows.Forms.Label();
            this.labelAmmo2 = new System.Windows.Forms.Label();
            this.labelCharged2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCharged1 = new System.Windows.Forms.Label();
            this.lblAmmo1 = new System.Windows.Forms.Label();
            this.labelAmmo1 = new System.Windows.Forms.Label();
            this.labelCharged1 = new System.Windows.Forms.Label();
            this.pnlBG = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.tmrJf1 = new System.Windows.Forms.Timer(this.components);
            this.mnuStrip.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBottomBar.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.mnuStop});
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
            this.mnuStart.Size = new System.Drawing.Size(55, 20);
            this.mnuStart.Text = "Restart";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(43, 20);
            this.mnuStop.Text = "Stop";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTopBar.BackColor = System.Drawing.Color.Navy;
            this.pnlTopBar.Controls.Add(this.panel1);
            this.pnlTopBar.Controls.Add(this.panel2);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 27);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(985, 90);
            this.pnlTopBar.TabIndex = 2;
            this.pnlTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopBar_Paint);
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
            this.txtLives1.Location = new System.Drawing.Point(67, 61);
            this.txtLives1.Name = "txtLives1";
            this.txtLives1.Size = new System.Drawing.Size(33, 20);
            this.txtLives1.TabIndex = 10;
            this.txtLives1.Text = "5";
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
            this.txtName1.Location = new System.Drawing.Point(67, 3);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(122, 20);
            this.txtName1.TabIndex = 8;
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
            // pnlTitle
            // 
            this.pnlTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.BackgroundImage = global::LilyStraker_Assignment_2019.Properties.Resources.PlanetJamiro_Logo_Dark_Blue;
            this.pnlTitle.Location = new System.Drawing.Point(336, 27);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(326, 90);
            this.pnlTitle.TabIndex = 5;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
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
            this.panel8.BackColor = System.Drawing.Color.Navy;
            this.panel8.Controls.Add(this.lblCharged2);
            this.panel8.Controls.Add(this.lblAmmo2);
            this.panel8.Controls.Add(this.labelAmmo2);
            this.panel8.Controls.Add(this.labelCharged2);
            this.panel8.Location = new System.Drawing.Point(781, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 84);
            this.panel8.TabIndex = 12;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel8_Paint);
            // 
            // lblCharged2
            // 
            this.lblCharged2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCharged2.AutoSize = true;
            this.lblCharged2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharged2.ForeColor = System.Drawing.Color.White;
            this.lblCharged2.Location = new System.Drawing.Point(94, 46);
            this.lblCharged2.Name = "lblCharged2";
            this.lblCharged2.Size = new System.Drawing.Size(16, 18);
            this.lblCharged2.TabIndex = 10;
            this.lblCharged2.Text = "3";
            this.lblCharged2.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblAmmo2
            // 
            this.lblAmmo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmmo2.AutoSize = true;
            this.lblAmmo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmo2.ForeColor = System.Drawing.Color.White;
            this.lblAmmo2.Location = new System.Drawing.Point(89, 11);
            this.lblAmmo2.Name = "lblAmmo2";
            this.lblAmmo2.Size = new System.Drawing.Size(24, 18);
            this.lblAmmo2.TabIndex = 9;
            this.lblAmmo2.Text = "10";
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
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.lblCharged1);
            this.panel6.Controls.Add(this.lblAmmo1);
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
            // lblCharged1
            // 
            this.lblCharged1.AutoSize = true;
            this.lblCharged1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharged1.ForeColor = System.Drawing.Color.White;
            this.lblCharged1.Location = new System.Drawing.Point(92, 47);
            this.lblCharged1.Name = "lblCharged1";
            this.lblCharged1.Size = new System.Drawing.Size(16, 18);
            this.lblCharged1.TabIndex = 10;
            this.lblCharged1.Text = "3";
            // 
            // lblAmmo1
            // 
            this.lblAmmo1.AutoSize = true;
            this.lblAmmo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmo1.ForeColor = System.Drawing.Color.White;
            this.lblAmmo1.Location = new System.Drawing.Point(90, 15);
            this.lblAmmo1.Name = "lblAmmo1";
            this.lblAmmo1.Size = new System.Drawing.Size(24, 18);
            this.lblAmmo1.TabIndex = 9;
            this.lblAmmo1.Text = "10";
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
            this.pnlBG.Size = new System.Drawing.Size(988, 447);
            this.pnlBG.TabIndex = 3;
            this.pnlBG.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBG_Paint);
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
            this.tmrEnemy.Enabled = true;
            this.tmrEnemy.Tick += new System.EventHandler(this.TmrEnemy_Tick);
            // 
            // tmrJf1
            // 
            this.tmrJf1.Enabled = true;
            this.tmrJf1.Interval = 50;
            this.tmrJf1.Tick += new System.EventHandler(this.TmrJf1_Tick);
            // 
            // frmPlanetJamiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pnlTitle);
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
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlBottomBar.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.Panel pnlTitle;
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
        private System.Windows.Forms.Label lblAmmo1;
        private System.Windows.Forms.Label labelAmmo1;
        private System.Windows.Forms.Label labelCharged1;
        private System.Windows.Forms.Label lblCharged1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCharged2;
        private System.Windows.Forms.Label lblAmmo2;
        private System.Windows.Forms.Label labelAmmo2;
        private System.Windows.Forms.Label labelCharged2;
        private System.Windows.Forms.Timer tmrEnemy;
        private System.Windows.Forms.Timer tmrJf1;
        private System.Windows.Forms.TextBox txtLives1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtLives2;
        private System.Windows.Forms.TextBox txtName2;
    }
}

