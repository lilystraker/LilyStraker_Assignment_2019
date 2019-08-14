using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LilyStraker_Assignment_2019
{
    class Turtle
    {
        public int x, y, width, height;
        public Image enemyImage;
        public Rectangle enemyRec;

        public int score1;
        public int score2;

        public Turtle(int spacing)
        {
            x = 10;
            y = spacing;
            width = 100;
            height = 50;
            enemyImage = Image.FromFile("turtle.png");
            enemyRec = new Rectangle(x, y, width, height);

            //   Enemy enemyImage1 = new Enemy();
            //   enemyImage.ImageLocation = paths[random.Next(0, images.Count - 1)];

        }

        public void drawEnemy(Graphics g)
        {
            enemyRec = new Rectangle(x, y, width, height);
            g.DrawImage(enemyImage, enemyRec);
        }

        public void moveEnemy()
        {

            enemyRec.Location = new Point(x, y);

            if (enemyRec.Location.X > 987)
            {
                score1 += 1;

                x = 10;
                enemyRec.Location = new Point(x, y);
            }
        }
    }
}
