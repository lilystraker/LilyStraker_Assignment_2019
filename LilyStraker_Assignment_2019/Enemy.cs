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

        public Enemy(int spacing)
        {
            x = spacing;
            y = 10;
            width = 50;
            height = 50;
            enemyImage = Image.FromFile("Planet.png");
            enemyRec = new Rectangle(x, y, width, height);

        }

        public void drawEnemy(Graphics g)
        {
            enemyRec = new Rectangle(x,y, width, height);
            g.DrawImage(enemyImage, enemyRec);
        }

        public void moveEnemy()
        {
          
            enemyRec.Location = new Point(x, y);

            if (enemyRec.Location.Y > 444)
            {
                score1 += 1;
                y = 20;
                enemyRec.Location = new Point(x, y);
            }
        }
    }
}
