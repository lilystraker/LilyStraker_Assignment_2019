using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

//Player One's bubbles

namespace LilyStraker_Assignment_2019
{
    class Bubble
    {
        public int x, y, width, height;
        public double xSpeed, ySpeed;
        public Image bubble;
        public Rectangle bubbleRec;
        Point centreBubble;

       public int bubbleRotate;

        public Bubble(Rectangle Jf1Rec)
        {
            width = 20;
            height = 20;
            bubble = Image.FromFile("bubble.png");
            bubbleRec = new Rectangle(x, y, width, height);

            //Centre of jf1
            x = Jf1Rec.X + Jf1Rec.Width / 2;
            y = Jf1Rec.Y + Jf1Rec.Height / 2;

            //Sets value of xspeed and yspeed
            xSpeed = 30 * (Math.Cos((bubbleRotate - 90) * Math.PI / 180)); //Rotates bubble
            ySpeed = 30;
        }

        public void drawBubble(Graphics g)
        {
            //Draws bubbles in the centre of jf1
            centreBubble = new Point(x, y); 
            centreBubble = new Point(bubbleRec.X + width / 2, bubbleRec.Y + width / 2);

            g.DrawImage(bubble, bubbleRec); //draw the bubble

        }
        public void moveBubble(Graphics g)
        {
            x += (int)xSpeed; //add xspeed to x value
            y -= (int)ySpeed; //minus yspeed from yvalue (move up the screen)

            bubbleRec.Location = new Point(x, y);

        }
    }



}
