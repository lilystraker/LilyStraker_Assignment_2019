using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

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
            starImage = Image.FromFile("stars.png");
            starRec = new Rectangle(x, y, width, height);

        }

        public void drawStars(Graphics g)
        {
            starRec = new Rectangle(x, y, width, height);
            g.DrawImage(starImage, starRec);
        }

    }
}
