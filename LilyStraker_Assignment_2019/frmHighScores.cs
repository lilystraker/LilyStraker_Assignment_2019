using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LilyStraker_Assignment_2019
{
    public partial class frmHighScores : Form
    {
        string binPath = Application.StartupPath + @"\highScores.txt";

        List<HighScores> highScores = new List<HighScores>();

        string playerName = frmPlanetJamiro.jf1name;
        int playerScore = frmPlanetJamiro.endscore1;

        string playerName2 = frmPlanetJamiro.jf2name;
        int playerScore2 = frmPlanetJamiro.endscore2;


            public frmHighScores(string playerName, int playerScore, string playerName2, int playerScore2)
        {
            InitializeComponent();  
            lblPlayerName.Text = playerName;
            lblPlayerScore.Text = frmPlanetJamiro.endscore1.ToString();

            lblPlayerName2.Text = playerName2;
            lblPlayerScore2.Text = frmPlanetJamiro.endscore2.ToString();


            var reader = new StreamReader(binPath);

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                highScores.Add(new HighScores(values[0], Int32.Parse(values[1])));
            }

            reader.Close();
        }

        private void frmHighScores_Load(object sender, EventArgs e)
        {
            int lowest_score = highScores[(highScores.Count - 1)].Score;

            if (int.Parse(lblPlayerScore.Text) > lowest_score)
            {
                lblMessage1.Text = "Player one has made the top ten!\nWell done!";
                highScores.Add(new HighScores(lblPlayerName.Text, int.Parse(lblPlayerScore.Text)));
            }
            else
            {
                lblMessage1.Text = "Keep trying to make the top ten,\nplayer one!";
            }

            if (int.Parse(lblPlayerScore2.Text) > lowest_score)
            {
                lblMessage2.Text = "Player two has made the top ten!\nWell done!";
                highScores.Add(new HighScores(lblPlayerName2.Text, int.Parse(lblPlayerScore2.Text)));
            }
            else
            {
                lblMessage2.Text = "Keep trying to make the top ten,\nplayer two!";
            }


            SortHighScores();
            DisplayHighScores();

        }

        public void SortHighScores()
        {
            highScores = highScores.OrderByDescending(hs => hs.Score).Take(10).ToList();
        }


        public void DisplayHighScores()
        {
            foreach (HighScores s in highScores)
            {
                ListBoxName.Items.Add(s.Name);
                ListBoxScore.Items.Add(s.Score);

            }
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
         
        }

        public void SaveHighScores()
        {
            StringBuilder builder = new StringBuilder();
            foreach (HighScores score in highScores)
            {
                //{0} is for the Name, {1} is for the Score and {2} is for a new line
                builder.Append(string.Format("{0},{1}{2}", score.Name, score.Score, Environment.NewLine));
            }
            File.WriteAllText(binPath, builder.ToString());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SaveHighScores();
            frmGameOver frmGame2 = new frmGameOver();
            Hide();
            frmGame2.ShowDialog();

        }

        private void lblPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmHighScores_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveHighScores();
           // frmGameOver frmGame2 = new frmGameOver();
          //  Hide();
           // frmGame2.ShowDialog();
        }
    }
}
