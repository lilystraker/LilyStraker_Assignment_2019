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
            frmHighScores frmHighScore2 = new frmHighScores(txtName.Text, txtScore.Text);
          //  Hide();
            frmHighScore2.ShowDialog();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            //  Hide();
            this.Close();
            frmHome.Show();
        }
    }
}
