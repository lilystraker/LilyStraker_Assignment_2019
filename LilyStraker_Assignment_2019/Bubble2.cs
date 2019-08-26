using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

//Player Two's bubbles

namespace LilyStraker_Assignment_2019
{
    class Bubble2
    {
        public int x, y, width, height;
        public double xSpeed, ySpeed;
        public Image bubble2;
        public Rectangle bubble2Rec;
        Point centreBubble2;

        public int bubble2Rotate;

        public Bubble2(Rectangle Jf2Rec)
        {
            width = 20;
            height = 20;
            bubble2 = Image.FromFile("bubble.png");
            bubble2Rec = new Rectangle(x, y, width, height);

            //Centre of jf2
            x = Jf2Rec.X + Jf2Rec.Width / 2;
            y = Jf2Rec.Y + Jf2Rec.Height / 2;

            //Set value of x and y speed
            xSpeed = 30 * (Math.Cos((bubble2Rotate - 90) * Math.PI / 180)); //Rotates bubble
            ySpeed = 30;
        }

        public void drawBubble2(Graphics g)
        {
            //Shoot bubble from the centre of jf2
            centreBubble2 = new Point(x, y);
            centreBubble2 = new Point(bubble2Rec.X + width / 2, bubble2Rec.Y + width / 2);

            g.DrawImage(bubble2, bubble2Rec);

        }
        public void moveBubble2(Graphics g)
        {
            x += (int)xSpeed;//add xspeed to x value
            y -= (int)ySpeed;//minus yspeed from y value (move upwards)

            bubble2Rec.Location = new Point(x, y);

        }
    }
}
