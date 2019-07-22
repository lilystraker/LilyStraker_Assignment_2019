using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
          
            for (int i = 0; i < 7; i++)
            {
                int x = 70 + (i * (pnlBG.Width / 7)); ;
                enemy[i] = new Enemy(x);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lives1 = int.Parse(txtLives1.Text);
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
