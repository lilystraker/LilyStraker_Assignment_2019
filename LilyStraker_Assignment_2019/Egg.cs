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
        public Image egg;//variable for the missile's image
        public Rectangle eggRec;//variable for a rectangle to place our image in
        Point centreEgg;//centre of missile


        public int eggRotate;

        public Egg(Rectangle turtleRec)
        {
            width = 10;
            height = 10;
            egg = Image.FromFile("egg.png");
            eggRec = new Rectangle(x, y, width, height);

            //calculate x,y to move missile to middle of spaceship in drawMissile method
            x = turtleRec.X + turtleRec.Width / 2;
            y = turtleRec.Y + turtleRec.Height / 2;

            ySpeed = 20 * (Math.Cos((eggRotate - 90) * Math.PI / 180));
            xSpeed = 20 * (Math.Sin((eggRotate + 90) * Math.PI / 180));



        }

        public void drawEgg(Graphics g)
        {
            //centre missile 
            centreEgg = new Point(x, y);

            //find the centre point of spaceRec
            centreEgg = new Point(eggRec.X + width / 2, eggRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            //rotate the matrix (spaceRec) about its centre
    
            //Set the current draw location to the rotated matrix point
   
            //draw the spaceship




            g.DrawImage(egg, eggRec);


        }
        public void moveEgg(Graphics g)
        {
            x += (int)xSpeed;//cast double to an integer value
            y += (int)ySpeed;

            eggRec.Location = new Point(x, y);//missiles new location

        }
    }

}

