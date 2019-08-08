using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace LilyStraker_Assignment_2019
{
    class Bubble2
    {

        public int x, y, width, height;
        public double xSpeed, ySpeed;
        public Image bubble2;//variable for the missile's image
        public Rectangle bubble2Rec;//variable for a rectangle to place our image in
        Point centreBubble2;//centre of missile
        public int rotationAngle2;
        public Matrix matrix;

        public int bubble2Rotate;

        public Bubble2(Rectangle Jf2Rec)
        {
            width = 20;
            height = 20;
            rotationAngle2 = 0;
            bubble2 = Image.FromFile("bubble.png");
            bubble2Rec = new Rectangle(x, y, width, height);

            //calculate x,y to move missile to middle of spaceship in drawMissile method
            x = Jf2Rec.X + Jf2Rec.Width / 2;
            y = Jf2Rec.Y + Jf2Rec.Height / 2;

            xSpeed = 30 * (Math.Cos((bubble2Rotate - 90) * Math.PI / 180));
            ySpeed = 30 * (Math.Sin((bubble2Rotate + 90) * Math.PI / 180));



        }

        public void drawBubble2(Graphics g)
        {
            //centre missile 
            centreBubble2 = new Point(x, y);

            //find the centre point of spaceRec
            centreBubble2 = new Point(bubble2Rec.X + width / 2, bubble2Rec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle2, centreBubble2);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship




            g.DrawImage(bubble2, bubble2Rec);

        }
        public void moveBubble2(Graphics g)
        {
            x += (int)xSpeed;//cast double to an integer value
            y -= (int)ySpeed;

            bubble2Rec.Location = new Point(x, y);//missiles new location

        }
    }
}
