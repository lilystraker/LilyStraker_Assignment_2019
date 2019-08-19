using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace LilyStraker_Assignment_2019
{
    class Jf2
    {
        public int x, y, width, height;
        public Image jf2;

        public Rectangle jf2Rec;

        bool alivePriv2 = frmPlanetJamiro.alive2;

        public Jf2()
        {
            x = 50;
            y = 360;
            width = 50;
            height = 50;
            jf2 = Image.FromFile("jellyfish2.png");
            jf2Rec = new Rectangle(x, y, width, height);

        }

        public void drawJf2(Graphics g)
        {
            if (alivePriv2 == true)
            {
                jf2Rec = new Rectangle(x, y, width, height);
                g.DrawImage(jf2, jf2Rec);
            }
        }

        public void moveJf2(string move2)
        {
            jf2Rec.Location = new Point(x, y);
            if (move2 == "right2")
            {

                if (jf2Rec.Location.X > 925)
                {
                    x = 935;
                    jf2Rec.Location = new Point(x, y);

                }
                else
                {
                    x += 10;
                    jf2Rec.Location = new Point(x, y);
                }
            }

            if (move2 == "left2")
            {
                if (jf2Rec.Location.X < 10)
                {
                    x = 0;
                    jf2Rec.Location = new Point(x, y);
                }
                else
                {
                    x -= 10;
                    jf2Rec.Location = new Point(x, y);
                }
            }

            if (move2 == "up2")
            {
                if (jf2Rec.Location.Y < 10)
                {
                    y = 0;
                    jf2Rec.Location = new Point(x, y);
                }
                else
                {
                    y -= 10;//change back to lower number
                    jf2Rec.Location = new Point(x, y);
                }
            }

            if (move2 == "down2")
            {
                if (jf2Rec.Location.Y > 384)
                {
                    y = 394;
                    jf2Rec.Location = new Point(x, y);
                }
                else
                {
                    y += 10;//change back to lower number
                    jf2Rec.Location = new Point(x, y);
                }
            }
        }
    }
}
