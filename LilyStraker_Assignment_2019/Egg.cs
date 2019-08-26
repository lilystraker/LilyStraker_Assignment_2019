using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LilyStraker_Assignment_2019
{
    class Egg
    {

        public int x, y, width, height;
        public double xSpeed, ySpeed;
        public Image egg;
        public Rectangle eggRec;
        Point centreEgg;

        public int eggRotate;

        public Egg(Rectangle turtleRec)
        {
            width = 10;
            height = 10;
            egg = Image.FromFile("egg.png");
            eggRec = new Rectangle(x, y, width, height);

            //Centre of turtle
            x = turtleRec.X + turtleRec.Width / 2;
            y = turtleRec.Y + turtleRec.Height / 2;

            //Rotate eggs
            ySpeed = 20 * (Math.Cos((eggRotate - 90) * Math.PI / 180));
            xSpeed = 20 * (Math.Sin((eggRotate + 90) * Math.PI / 180));



        }

        public void drawEgg(Graphics g)
        {
            //Shoot eggs from centre of turtle
            centreEgg = new Point(x, y);
            centreEgg = new Point(eggRec.X + width / 2, eggRec.Y + width / 2);

            g.DrawImage(egg, eggRec);


        }
        public void moveEgg(Graphics g)
        {
            x += (int)xSpeed;//add xspeed to x value (move to the right)
            y += (int)ySpeed;//add yspeed to y value

            eggRec.Location = new Point(x, y);

        }
    }

}

