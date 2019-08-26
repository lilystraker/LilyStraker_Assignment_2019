using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

//Stars (background)
namespace LilyStraker_Assignment_2019
{
    class Stars
    {
        public int x, y, width, height;
        public Image starImage;
        public Rectangle starRec;

        public Stars()
        {
            x = 0;
            y = 0;
            width = 985;
            height = 444;
            starImage = Image.FromFile("stars_big.png");
            starRec = new Rectangle(x, y, width, height);

        }

        public void drawStars(Graphics g)
        {
            //Draw stars and rectangle
            starRec = new Rectangle(x, y, width, height);
            g.DrawImage(starImage, starRec);
        }

        public void moveStar(string move1)
        {
            //Restricts the stars from continuously moving
            starRec.Location = new Point(x, y);
            if (move1 == "right")
            {
                if (starRec.Location.X < -100)
                {
                    x = -100;
                    starRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 2;
                    starRec.Location = new Point(x, y);
                }
            }
            if (move1 == "left")
            {
                if (starRec.Location.X > 100)
                {
                    x = 100;
                    starRec.Location = new Point(x, y);
                }
                else
                {
                    x += 2;
                    starRec.Location = new Point(x, y);
                }
            }
            if (move1 == "up")
            {
                if (starRec.Location.Y > 70)
                {
                    y = 70;
                    starRec.Location = new Point(x, y);
                }
                else
                {
                    y += 2;
                    starRec.Location = new Point(x, y);
                }
            }
            if (move1 == "down")
            {
                if (starRec.Location.Y < -15)
                {
                    y = -15;
                    starRec.Location = new Point(x, y);
                }
                else
                {
                    y -= 2;
                    starRec.Location = new Point(x, y);
                }
            }
        }
    }
}
