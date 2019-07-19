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
        public Image jf;

        public Rectangle jfRec;

        public Jf1()
        {
            x = 10;
            y = 360;
            width = 50;
            height = 50;
            jf = Image.FromFile("jellyfish.png");
            jfRec = new Rectangle(x, y, width, height);
        }

    }
}
