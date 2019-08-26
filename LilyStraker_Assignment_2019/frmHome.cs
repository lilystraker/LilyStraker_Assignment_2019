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
            //If the ESC key is pressed, show a confirmation message to allow the player to say whether they want to leave the game or stay on it 
            if (e.KeyData == Keys.Escape)
            {
                Cursor.Show();
                DialogResult result1 = MessageBox.Show("Are you sure you want to exit the game?",
                  "Going already?",
                   MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning,
                  MessageBoxDefaultButton.Button2);

                //If the player clicks yes, the game will close
                if (result1 == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Same code for leaving the game as when the ESC key is pressed
            DialogResult result1 = MessageBox.Show("Are you sure you want to exit the game?",
                  "Already going?",
                   MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning,
                  MessageBoxDefaultButton.Button2);

            if (result1 == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnPlay1_Click(object sender, EventArgs e)
        {
            //When the play button is pressed
            frmPlanetJamiro playForm = new frmPlanetJamiro(); //Create an object that is for the game form
            this.Close(); //Close the menu screen
            playForm.Show(); //Show the game

        }

        private void BtnInstructions1_Click(object sender, EventArgs e)
        {
            //When the instruction button is pressed, the instructions will be shown in a message box
            MessageBox.Show("You are trying to colonise planet Jamiro, but the alien race Jamirons have a solid defense and won't let you in easily. When you start the game, you enter your name, the other player's name, and amount of lives for both of you. After pressing start, you and the other player will be able to control the 2 main aliens whose goal is to dodge and shoot as many aliens as they can. Try to score the most points so you can get on the leaderboard before you die. \n\nPlayer One \nMOVE: Arrow keys \nSHOOT: Left click \n\nPlayer Two \nMOVE: WASD keys \nSHOOT: Spacebar", "Instructions");
        }

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
           

    }
}
