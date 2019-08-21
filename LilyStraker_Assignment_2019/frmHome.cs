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
    public partial class frmHome : Form
    {

        public frmHome()
        {
            
            InitializeComponent();
        }

        private void BtnInstructions_Click(object sender, EventArgs e)
        {

        }


     
    
    //  frmHome homeForm = new frmHome();
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            
        }

  

        private void PnlHomeBG_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }

        private void frmHome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Cursor.Show();
                DialogResult result1 = MessageBox.Show("Are you sure you want to exit the game?",
                  "Going already?",
                   MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning,
                  MessageBoxDefaultButton.Button2);
                if (result1 == DialogResult.Yes)
                {
                   // frmHome homeform = new frmHome();
                    //Application.Exit();
                    this.Close();
                 //   homeform.Show();
                }


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure you want to exit the game?",
                  "Already going?",
                   MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning,
                  MessageBoxDefaultButton.Button2);
            if (result1 == DialogResult.Yes)
            {
               // frmHome homeform = new frmHome();
                //Application.Exit();
                this.Close();
              //  homeform.Show();
            }
          //  Application.Exit();
        }

        private void BtnPlay1_Click(object sender, EventArgs e)
        {
            frmPlanetJamiro playForm = new frmPlanetJamiro();
            this.Close();
            playForm.Show();

        }

        private void BtnInstructions1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are trying to colonise planet Jamiro, but the alien race Jamirons have a solid defense and won't let you in easily. When you start the game, you enter your name, the other player's name, and amount of lives for both of you. After pressing start, you and the other player will be able to control the 2 main aliens whose goal is to dodge and shoot as many aliens as they can. Try to score the most points so you can get on the leaderboard before you die. \n\nPlayer One \nMOVE: Arrow keys \nSHOOT: Left click \n\nPlayer Two \nMOVE: WASD keys \nSHOOT: Spacebar", "Instructions");
        }

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
           

    }
}
