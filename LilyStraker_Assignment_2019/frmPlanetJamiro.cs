using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Reflection;

namespace LilyStraker_Assignment_2019
{
    public partial class frmPlanetJamiro : Form
    {
        Graphics g;
        Enemy[] enemy = new Enemy[7];
        Random yspeed = new Random();
       Jf1 jf1 = new Jf1();

        bool left, right, up, down;
        int score1, lives1;
        string move1;

        public frmPlanetJamiro()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlBG, new object[] { true });

            for (int i = 0; i < 7; i++)
            {
                int x = 70 + (i * (pnlBG.Width / 7)); ;
                enemy[i] = new Enemy(x);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tmrJf1.Enabled = false;
            tmrEnemy.Enabled = false;

            MessageBox.Show("Instructions", "Instructions");
            txtName1.Focus();

            txtName1.Text = "Player1's name";
            txtName1.ForeColor = Color.Gray;

            txtName1.SelectionStart = 0;
            txtName1.SelectionLength = 0;
            txtName1.ForeColor = Color.Gray;

            txtName2.Text = "Player2's name";
            txtName2.ForeColor = Color.Gray;

            txtName2.SelectionStart = 0; //If the text was selected, this is the value it will start at.
            txtName2.SelectionLength = 0; //This is the length of the selection. It is set to 0 so that there is no selection/highlight.
            txtName2.ForeColor = Color.Gray;

            txtLives1.Text = "Lives";
            txtLives1.ForeColor = Color.Gray;

            txtLives1.SelectionStart = 0;
            txtLives1.SelectionLength = 0;
            txtLives1.ForeColor = Color.Gray;

            txtLives2.Text = "Lives";
            txtLives2.ForeColor = Color.Gray;

            txtLives2.SelectionStart = 0;
            txtLives2.SelectionLength = 0;
            txtLives2.ForeColor = Color.Gray;

            jf1.x = 443;
            jf1.y = 350;

            tmrJf1.Enabled = false;
        }

        private void pnlTopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBG_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            for (int i = 0; i <7; i++)
            {
                int rndmspeed = yspeed.Next(5, 20);
                enemy[i].y += rndmspeed;
                enemy[i].drawEnemy(g);

            }

            jf1.drawJf1(g);

         

        }

        //For flickering
        //However, flickering still occurs when in fullscreen...?
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlBottomBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPlanetJamiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }
        }

        private void mnuStart_Click(object sender, EventArgs e)
        {
            if (txtName1.Text == "" || txtName2.Text == "" || txtLives1.Text == "")
            {
                MessageBox.Show("Check that both names have been entered and the lives have been set.", "Error!");

                tmrEnemy.Enabled = false;
                tmrJf1.Enabled = false;

            }
            else
            {
                score1 = 0;
                lblScore1.Text = score1.ToString();
                lives1 = int.Parse(txtLives1.Text);
                tmrEnemy.Enabled = true;
                tmrJf1.Enabled = true;
                txtName1.Enabled = false;
                txtName2.Enabled = false;
                txtLives1.Enabled = false;
                txtLives2.Enabled = false;


            }

        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
            tmrJf1.Enabled = false;
            tmrEnemy.Enabled = false;

        }

        private void txtName1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 8 || e.KeyChar > 64 && e.KeyChar < 91 || e.KeyChar > 96 && e.KeyChar < 123 || e.KeyChar == 13) //alpabet, enter key, backspace key
            {
                mnuStart.Visible = true;
            }
            else
            {
                MessageBox.Show("Please only enter alphabetical characters", "Error");
                //event Handled is set to true, user input is suppressed and not reflected in the text box
                e.Handled = true;
                txtName1.Focus();
            }

            if (e.KeyChar == 13)
            {
                txtName2.Focus();
            }
        }

        private void txtName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar > 64 && e.KeyChar < 91 || e.KeyChar > 96 && e.KeyChar < 123 || e.KeyChar == 13) //alpabet, enter key, backspace key
            {

            }
            else
            {
                MessageBox.Show("Please only enter alphabetical characters", "Error");
                //event Handled is set to true, user input is suppressed and not reflected in the text box
                e.Handled = true;
                txtName2.Focus();
            }

            if (e.KeyChar == 13)
            {
                txtLives1.Focus();
            }
        }

        private void txtName1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtName1.Text.Equals("Player1's name") == true)
            {
                txtName1.Text = "";
                txtName1.ForeColor = Color.Black;
            }
        }

        private void txtName1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtName1.Text.Equals(null) == true || txtName1.Text.Equals("") == true)
            {
                txtName1.Text = "Player1's name";
                txtName1.ForeColor = Color.Gray;
            }
        }

        private void txtName2_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtName2.Text.Equals("Player2's name") == true)
            {
                txtName2.Text = "";
                txtName2.ForeColor = Color.Black;
            }
        }

        private void txtName2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtName2.Text.Equals(null) == true || txtName2.Text.Equals("") == true)
            {
                txtName2.Text = "Player2's name";
                txtName2.ForeColor = Color.Gray;
            }
        }

        private void txtLives1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLives1.MaxLength = 1; //limits the amount of digits allowed in text box to 1

            if (e.KeyChar > 50 && e.KeyChar < 58 || e.KeyChar == 13)
            {
                txtLives2.Text = txtLives1.Text;

            }
            else
            {
                MessageBox.Show("Please only enter numerical characters", "Error");
                e.Handled = true;
            }

            if (e.KeyChar == 13 && txtLives1.Text != "")
            {

            }
            else
            {
            }

        }

        private void txtLives1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtLives1.Text.Equals("Lives") == true)
            {
                txtLives1.Text = "";
                txtLives1.ForeColor = Color.Black;
            }
        }

        private void txtLives1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtLives1.Text.Equals(null) == true || txtLives1.Text.Equals("") == true)
            {
                txtLives1.Text = "Lives";
                txtLives1.ForeColor = Color.Gray;
            }
        }

        private void txtLives2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLives2_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtLives2.Text.Equals("Lives") == true)
            {
                txtLives2.Text = "";
                txtLives2.ForeColor = Color.Black;
            }
        }

        private void txtLives2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtLives2.Text.Equals(null) == true || txtLives2.Text.Equals("") == true)
            {
                txtLives2.Text = "Lives";
                txtLives2.ForeColor = Color.Gray;
            }
        }

        private void FrmPlanetJamiro_KeyUp(object sender, KeyEventArgs e)
        {
           if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
        }

        private void TmrJf1_Tick(object sender, EventArgs e)
        {
            if (right)
            {
                move1 = "right";
                jf1.moveJf1(move1);
 
            }
            if (left)
            {
                move1 = "left";
                jf1.moveJf1(move1);
            }
            if (up)
            {
                move1 = "up";
                jf1.moveJf1(move1);
            }
            if (down)
            {
                move1 = "down";
                jf1.moveJf1(move1);
            }
        }

        private void TmrEnemy_Tick(object sender, EventArgs e)
        {
            score1 = 0;
            for (int i = 0; i < 7; i++)
            {
                enemy[i].moveEnemy();

                if (jf1.jf1Rec.IntersectsWith(enemy[i].enemyRec))
                {
                    //reset planet[i] back to top of panel
                    enemy[i].y = 30; // set  y value of planetRec
                    lives1 -= 1;// lose a life
                    txtLives1.Text = lives1.ToString();// display number of lives
                    checkLives();
                }

                score1 += enemy[i].score1;// get score from Planet class (in movePlanet method)
                lblScore1.Text = score1.ToString();

            }

            pnlBG.Invalidate();
        }

        private void checkLives()
        {
            if (lives1 == 0)
            {
                tmrEnemy.Enabled = false;
                tmrJf1.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }

    }
}
