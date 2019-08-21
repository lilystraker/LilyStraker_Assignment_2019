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
        public frmGameOver()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtScore.Text == "")
            {
                MessageBox.Show("Check that both names have been entered and the lives have been set.", "Error!");
                
            }
            else
            {
                frmHighScores frmHighScore2 = new frmHighScores(txtName.Text, txtScore.Text);
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
            if (e.KeyChar == 8 || e.KeyChar > 64 && e.KeyChar < 91 || e.KeyChar > 96 && e.KeyChar < 123 || e.KeyChar == 13) //alpabet, enter key, backspace key
            {
                //mnuStart.Visible = true;
            }
            else
            {
                MessageBox.Show("Please only enter alphabetical characters", "Error");
                //event Handled is set to true, user input is suppressed and not reflected in the text box
                e.Handled = true;
                txtScore.Focus();
            }

            if (e.KeyChar == 13)
            {
                txtScore.Focus();
            }
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
    }
}
