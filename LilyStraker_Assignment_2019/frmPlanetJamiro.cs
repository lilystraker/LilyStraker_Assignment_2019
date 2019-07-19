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
            //test2
            
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

        private void TmrEnemy_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                enemy[i].moveEnemy();
            }

            pnlBG.Invalidate();
        }
    }
}
