using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace LilyStraker_Assignment_2019
{
    class Jf1
    {

        public int x, y, width, height;
        public Image jf1;

        public Rectangle jf1Rec;

        bool alivePriv = frmPlanetJamiro.alive;

        public Jf1()
        {
            x = 10;
            y = 360;
            width = 50;
            height = 50;
            jf1 = Image.FromFile("jellyfish.png");
            jf1Rec = new Rectangle(x, y, width, height);
 
        }

        public void drawJf1(Graphics g)
        {

            if (alivePriv == true)
            {
                jf1Rec = new Rectangle(x, y, width, height);
                g.DrawImage(jf1, jf1Rec);
            }
        }

        public void moveJf1(string move1)
        {
            jf1Rec.Location = new Point(x, y);
            if (move1 == "right")
            {
               
                if (jf1Rec.Location.X > 925)
                {
                    x = 935;
                    jf1Rec.Location = new Point(x, y);
                  
                }
                else
                {
                    x += 10;
                    jf1Rec.Location = new Point(x, y);
                }
            }

            if (move1 == "left")
            {
                if (jf1Rec.Location.X < 10)
                {
                    x = 0;
                    jf1Rec.Location = new Point(x, y);
                }
                else
                { 
                    x -= 10;
                    jf1Rec.Location = new Point(x, y);
                }
            }

            if (move1 == "up")
            {
                if (jf1Rec.Location.Y < 10)
                {
                    y = 0;
                    jf1Rec.Location = new Point(x, y);
                }
                else
                {
                    y -= 10;//change back to lower number
                    jf1Rec.Location = new Point(x, y);
                }
            }

            if (move1 == "down")
            {
                if (jf1Rec.Location.Y > 384)
                {
                    y = 394;
                    jf1Rec.Location = new Point(x, y);
                }
                else
                {
                    y += 10;//change back to lower number
                    jf1Rec.Location = new Point(x, y);
                }
            }
        }

    }
}
