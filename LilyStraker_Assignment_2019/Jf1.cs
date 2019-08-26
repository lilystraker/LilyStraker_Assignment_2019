using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace LilyStraker_Assignment_2019
{
    //Jellyfish1
    class Jf1
    {
        //Declare variables
        public int x, y, width, height;
        public Image jf1;
        public Rectangle jf1Rec;

        //Alive variable for this class (same as alive variable from frmPlanetJamiro.cs)
        bool alivePriv = frmPlanetJamiro.alive;

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
            //If jellyfish1 is alive, draw him
            if (alivePriv == true)
            {
                jf1Rec = new Rectangle(x, y, width, height);
                g.DrawImage(jf1, jf1Rec);
            }
        }

        public void moveJf1(string move1)
        {
            jf1Rec.Location = new Point(x, y);

            //If the right arrow key is pressed
            if (move1 == "right")
            {
                //If jellyfish1 is on the right side of the panel
                if (jf1Rec.Location.X > 925)
                {
                    x = 935; //Don't let him outside the panel
                    jf1Rec.Location = new Point(x, y);
                  
                }
                else
                {
                    x += 10; //Move right
                    jf1Rec.Location = new Point(x, y);
                }
            }

            //If the left arrow key is pressed
            if (move1 == "left")
            {
                //If jellyfish1 is on the left side of the panel
                if (jf1Rec.Location.X < 10)
                {
                    x = 0;//Keep him in the panel
                    jf1Rec.Location = new Point(x, y);
                }
                else
                { 
                    x -= 10;//Move left
                    jf1Rec.Location = new Point(x, y);
                }
            }

            //Same thing (restricting jellyfish1 from leaving the game panel) when he moves
            if (move1 == "up")
            {
                if (jf1Rec.Location.Y < 50)
                {
                    y = 40;
                    jf1Rec.Location = new Point(x, y);
                }
                else
                {
                    y -= 10;
                    jf1Rec.Location = new Point(x, y);
                }
            }

            if (move1 == "down")
            {
                if (jf1Rec.Location.Y > 384)
                {
                    y = 394;
                    jf1Rec.Location = new Point(x, y);
                }
                else
                {
                    y += 10;
                    jf1Rec.Location = new Point(x, y);
                }
            }
        }

    }
}
