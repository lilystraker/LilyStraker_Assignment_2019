using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;


namespace LilyStraker_Assignment_2019
{
    class Enemy
    {

        public int x, y, width, height;
        public Image enemyImage;
        public Rectangle enemyRec;
        public int score1;
        public int score2;

        public Enemy()
        {
            x = 10;
            y = 10;
            width = 50;
            height = 50;
            enemyImage = Image.FromFile("planet.png");
            enemyRec = new Rectangle(x, y, width, height);

        }
    }
}
