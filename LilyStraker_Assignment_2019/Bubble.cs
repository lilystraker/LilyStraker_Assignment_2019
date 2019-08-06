using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace LilyStraker_Assignment_2019
{
    class Bubble
    {
        public int x, y, width, height;
        public double xSpeed, ySpeed;
        public Image bubble;//variable for the missile's image
        public Rectangle bubbleRec;//variable for a rectangle to place our image in
        Point centreBubble;//centre of missile
        public int rotationAngle;
        public Matrix matrix;

        public int bubbleRotate;

        public Bubble(Rectangle Jf1Rec)
        {
            width = 20;
            height = 20;
            rotationAngle = 0;
            bubble = Image.FromFile("bubble.png");
            bubbleRec = new Rectangle(x, y, width, height);

            //calculate x,y to move missile to middle of spaceship in drawMissile method
            x = Jf1Rec.X + Jf1Rec.Width / 2;
            y = Jf1Rec.Y + Jf1Rec.Height / 2;

            xSpeed = 30 * (Math.Cos((bubbleRotate - 90) * Math.PI / 180));
            ySpeed = 30 * (Math.Sin((bubbleRotate + 90) * Math.PI / 180));



        }

        public void drawBubble(Graphics g)
        {
            //centre missile 
            centreBubble = new Point(x, y);

            //find the centre point of spaceRec
            centreBubble = new Point(bubbleRec.X + width / 2, bubbleRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle, centreBubble);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship




            g.DrawImage(bubble, bubbleRec);

        }
        public void moveBubble(Graphics g)
        {
            x += (int)xSpeed;//cast double to an integer value
            y -= (int)ySpeed;

            bubbleRec.Location = new Point(x, y);//missiles new location

        }
    }



}
