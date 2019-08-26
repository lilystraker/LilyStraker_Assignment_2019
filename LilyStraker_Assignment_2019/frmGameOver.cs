using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//GameOver form
namespace LilyStraker_Assignment_2019
{
    public partial class frmGameOver : Form
    {
        //Take value of jf1name from the main game form and set it as the value of name1
        string name1 = frmPlanetJamiro.jf1name;
        //Take value of endscore1 from the main game form and set it as the value of score1
        int score1 = frmPlanetJamiro.endscore1;
        string jf1score;

        //Take value of jf2name from the main game form and set it as the value of name2
        string name2 = frmPlanetJamiro.jf2name;
        //Take value of endscore2 from the main game form and set it as the value of score2
        int score2 = frmPlanetJamiro.endscore2;
        string jf2score;

        public frmGameOver()
        {
            InitializeComponent();

            //Convert jf1score from an int to string
            jf1score = frmPlanetJamiro.endscore1.ToString();
            //Convert jf2score from an int to string
            jf2score = frmPlanetJamiro.endscore2.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //When the quit button is pressed, exit the game
            Application.Exit();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //If nothing has been entered into player1's/player2's name or score textboxes
            if (txtName.Text == "" || lblScore1.Text == "" || txtName2.Text == "" || lblScore2.Text == "")
            {
                MessageBox.Show("Check that both names have been entered and the lives have been set.", "Error!");
                
            }
            else
            {
                //Display the high score form over the game over form
                frmHighScores frmHighScore2 = new frmHighScores(txtName.Text, Int32.Parse(lblScore1.Text), txtName2.Text, Int32.Parse(lblScore2.Text));
                frmHighScore2.ShowDialog();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only the alpabet, enter key, and backspace key are allowed to be inputted into player one's name textbox
            if (e.KeyChar == 8 || e.KeyChar > 64 && e.KeyChar < 91 || e.KeyChar > 96 && e.KeyChar < 123 || e.KeyChar == 13)
            {
            }
            else
            {
                //If other characters are entered, text is removed from inside the textbox, and a message box appears
                MessageBox.Show("Please only enter alphabetical characters", "Error");
                e.Handled = true;
                txtScore.Focus();//Select player one's score textbox
            }

            //If enter key is pressed
            if (e.KeyChar == 13)
          {
               txtScore.Focus();
            }
        }

        private void TxtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only numbers, the enter key, and backspace key can be entered into player one's score textbox
            if (e.KeyChar == 8 || e.KeyChar > 47 && e.KeyChar < 58 || e.KeyChar == 13) 
            {
            }
            else
            {
                //If other characters are entered, text is removed from inside the textbox, and a message box appears
                MessageBox.Show("Please only enter numbers", "Error");
                e.Handled = true;
            }
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            //When the exit button is pressed, a messagebox appears to confirm whether the player wants to leave
            DialogResult result1 = MessageBox.Show("Are you sure you want to exit the game?",
                 "Already going?",
                  MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button2);

            //If player presses 'yes'
            if (result1 == DialogResult.Yes)
            {
                //Close game
                this.Close();
            }
        }

        private void frmGameOver_Load(object sender, EventArgs e)
        {
            //name1 appears in player one's name textbox
           txtName.Text = name1;
            //player one's score appears in the label
            lblScore1.Text = jf1score;

            //player two's name appears in their name textbox
            txtName2.Text = name2;
            //player two's score appears in their score label
            lblScore2.Text = jf2score;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCheck2_Click(object sender, EventArgs e)
        {
         
        }

        private void TxtName2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow alpabet characters, enter key, backspace key into player2's name textbox
            if (e.KeyChar == 8 || e.KeyChar > 64 && e.KeyChar < 91 || e.KeyChar > 96 && e.KeyChar < 123 || e.KeyChar == 13) 
            {
                //Focus on the next input box (player 1's score)
                txtScore.Focus();
            }
            else
            {
                //If other characters are entered, text is removed from inside the textbox, and a message box appears
                MessageBox.Show("Please only enter alphabetical characters", "Error");
                e.Handled = true;
            }

            //If enter key is pressed
            if (e.KeyChar == 13)
            {
                txtScore.Focus();
            }

        }
    }
}
