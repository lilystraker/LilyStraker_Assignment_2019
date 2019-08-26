using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilyStraker_Assignment_2019
{
    class HighScores
    {
        public HighScores(string name, int score)
        {
            Name = name;
            Score = score;
        }
        
        //able to access name and score
        public string Name { get; set; }

        public int Score { get; set; }
    }
    }



