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
    public partial class frmGameOver : Form
    {

        string name1 = frmPlanetJamiro.jf1name;
        int score1 = frmPlanetJamiro.endscore1;
        string jf1score;



        public frmGameOver()
        {
            InitializeComponent();

            jf1score = frmPlanetJamiro.endscore1.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || lblScore1.Text == "")
            {
                MessageBox.Show("Check that both names have been entered and the lives have been set.", "Error!");
                
            }
            else
            {
                frmHighScores frmHighScore2 = new frmHighScores(txtName.Text, Int32.Parse(lblScore1.Text));
                //  Hide();
                frmHighScore2.ShowDialog();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            //  Hide();
            this.Close();
            frmHome.Show();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
         
          
            
            
            
            //  if (e.KeyChar == 8 || e.KeyChar > 64 && e.KeyChar < 91 || e.KeyChar > 96 && e.KeyChar < 123 || e.KeyChar == 13) //alpabet, enter key, backspace key
          //  {
                //mnuStart.Visible = true;
         //   }
         //   else
          //  {
           //     MessageBox.Show("Please only enter alphabetical characters", "Error");
                //event Handled is set to true, user input is suppressed and not reflected in the text box
          //      e.Handled = true;
        //        txtScore.Focus();
         //   }

      //      if (e.KeyChar == 13)
       //     {
        //        txtScore.Focus();
        //    }
        }

        private void TxtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar > 47 && e.KeyChar < 58 || e.KeyChar == 13) //alpabet, enter key, backspace key
            {
                //mnuStart.Visible = true;
            }
            else
            {
                MessageBox.Show("Please only enter numbers", "Error");
                //event Handled is set to true, user input is suppressed and not reflected in the text box
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                
            }
        }

        private void MnuExit_Click(object sender, EventArgs e)
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
        }

        private void frmGameOver_Load(object sender, EventArgs e)
        {
           txtName.Text = name1;
           lblScore1.Text = jf1score;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
