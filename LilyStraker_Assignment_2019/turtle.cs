using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

//Turtles
//(enemies)

namespace LilyStraker_Assignment_2019
{
    class Turtle
    {
        public int x, y, width, height;
        public Image enemyImage;
        public Rectangle enemyRec;

        public int score1;
        public int score2;

        public Turtle(int yc)
        {
            x = 10;
            y = yc; //random y coordinate
            width = 100;
            height = 50;
            enemyImage = Image.FromFile("turtle.png");
            enemyRec = new Rectangle(x, y, width, height);
        }

        public void drawEnemy(Graphics g)
        {
            enemyRec = new Rectangle(x, y, width, height);
            g.DrawImage(enemyImage, enemyRec);
        }

        public void moveEnemy()
        {

            enemyRec.Location = new Point(x, y);
            //When the turtles reach the right side of the panel
            if (enemyRec.Location.X > 987)
            {
                //Add one to both players scores
                score1 += 1;
                score2 += 1;
                x = 10;//Move turtles back to left side of the screen

                enemyRec.Location = new Point(x, y);
            }
        }
    }
}
