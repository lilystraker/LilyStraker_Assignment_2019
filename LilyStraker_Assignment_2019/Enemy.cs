using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

//Enemy class
//For planets

namespace LilyStraker_Assignment_2019
{
    class Enemy
    {
        public int x, y, width, height;
        public Image enemyImage;
        public Rectangle enemyRec;
        public Enemy(int spacing)
        {
            x = spacing;//Set amount of space between planets so that they are spread evenly across the panel
            y = 0;
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
        }
    }
}
