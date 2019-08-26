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

//HighScores form

namespace LilyStraker_Assignment_2019
{
    public partial class frmHighScores : Form
    {
        //Where the file of saved highscores is 
        string binPath = Application.StartupPath + @"\highScores.txt";

        List<HighScores> highScores = new List<HighScores>();

        //Take value of jf1name from the main game form and set it as the value of playerName
        string playerName = frmPlanetJamiro.jf1name;
        //Take value of endscore1 from the main game form and set it as the value of playerScore
        int playerScore = frmPlanetJamiro.endscore1;

        //Take value of jf2name from the main game form and set it as the value of playerName2
        string playerName2 = frmPlanetJamiro.jf2name;
        //Take value of playerScore2 from the main game form and set it as the value of endscore2
        int playerScore2 = frmPlanetJamiro.endscore2;

            public frmHighScores(string playerName, int playerScore, string playerName2, int playerScore2)
            {
            InitializeComponent();  
            //Show player one's name 
            lblPlayerName.Text = playerName;
            //Show player one's score
            lblPlayerScore.Text = frmPlanetJamiro.endscore1.ToString();

            //Show player two's name
            lblPlayerName2.Text = playerName2;
            //Show player two's score
            lblPlayerScore2.Text = frmPlanetJamiro.endscore2.ToString();

            //Read the text file to get the highscores
            var reader = new StreamReader(binPath);

            //This takes parts of the high score file and sets it as certain variables
            //So on each line, the characters before the comma will be set as the name, and the characters...
            //...after the comma will be set as the score
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine(); //Each different line is a new set of values 
                var values = line.Split(','); //Names and scores are seperated by a comma
                highScores.Add(new HighScores(values[0], Int32.Parse(values[1])));//Add high score values
            }

            reader.Close();//Stop file reader
        }

        private void frmHighScores_Load(object sender, EventArgs e)
        {
            //Set variable for the lowest score
            int lowest_score = highScores[(highScores.Count - 1)].Score;

            //Compare lowest score with player one's score
            //If player one's score is greater than the lowest score, add it to the leaderboard
            if (int.Parse(lblPlayerScore.Text) > lowest_score)
            {
                lblMessage1.Text = "Player one has made the top ten!\nWell done!";
                highScores.Add(new HighScores(lblPlayerName.Text, int.Parse(lblPlayerScore.Text)));
            }
            //If player one's score is less than the lowest score on the leaderboard, leave it 
            //Let them down nicely
            else
            {
                lblMessage1.Text = "Keep trying to make the top ten,\nplayer one!";
            }

            //Compare lowest score with player two's score
            //If player two's score is greater than the lowest score, add it to the leaderboard
            if (int.Parse(lblPlayerScore2.Text) > lowest_score)
            {
                lblMessage2.Text = "Player two has made the top ten!\nWell done!";
                highScores.Add(new HighScores(lblPlayerName2.Text, int.Parse(lblPlayerScore2.Text)));
            }
            //If player two's score is less than the lowest score on the leaderboard, leave it 
            else
            {
                lblMessage2.Text = "Keep trying to make the top ten,\nplayer two!";//show encouraging message
            }

            //Sort high scores
            SortHighScores();
            DisplayHighScores();

        }

        public void SortHighScores()
        {
            //Sort highscores in descending order
            //Only show/save top 10 scores
            highScores = highScores.OrderByDescending(hs => hs.Score).Take(10).ToList();
        }


        public void DisplayHighScores()
        {
            foreach (HighScores s in highScores)
            {
                //Add names to first listbox
                ListBoxName.Items.Add(s.Name);
                //Add scores to second listbox
                ListBoxScore.Items.Add(s.Score);

            }
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
         
        }

        public void SaveHighScores()
        {
            //Allows more characters in a string (like for the names)
            StringBuilder builder = new StringBuilder();
            foreach (HighScores score in highScores)
            {
                //Each different part from the highscore file
                //0 is for the first part, which is the name
                //1 is the second part which goes after the comma, which is the score
                //2 is for a new line 
                builder.Append(string.Format("{0},{1}{2}", score.Name, score.Score, Environment.NewLine));
            }
            File.WriteAllText(binPath, builder.ToString());
        }

        //When the back button is pressed
        private void btnReturn_Click(object sender, EventArgs e)
        {
            SaveHighScores(); //Save the new high scores (if they qualify for a position on the leaderboard)
            frmGameOver frmGame2 = new frmGameOver(); 
            Hide(); //Close the high scores form
            frmGame2.ShowDialog(); //Show the game over form

        }

        private void lblPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmHighScores_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If the player exits the game, save the high scores (if applicable)
            SaveHighScores();
        }
    }
}
