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
            jf1Rec = new Rectangle(x, y, width, height);
            g.DrawImage(jf1, jf1Rec);
        }

        public void moveJf1(string move1)
        {
            jf1Rec.Location = new Point(x, y);
            if (move1 =="right")
            {
                x += 5;
                jf1Rec.Location = new Point(x, y);
            }
            if (move1 == "left")
            {
                x -= 5;
                jf1Rec.Location = new Point(x, y);
            }
        }

    }
}
