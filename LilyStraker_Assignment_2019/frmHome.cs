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
            frmPlanetJamiro playForm = new frmPlanetJamiro();         
              this.Close();
            playForm.Show();

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
                DialogResult result1 = MessageBox.Show("Are you sure you want to Exit to the main menu?",
                  "Bruh?",
                   MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning,
                  MessageBoxDefaultButton.Button2);
                if (result1 == DialogResult.Yes)
                {
                    frmHome homeform = new frmHome();
                    //Application.Exit();
                    this.Close();
                    homeform.Show();
                }


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
