using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace LilyStraker_Assignment_2019
{
    public partial class frmPlanetJamiro : Form
    {
        Graphics g;
        Enemy[] enemy = new Enemy[7]; //An array of 7 planets
        Turtle[] turtle = new Turtle[2]; //An array of 2 turtles
        Random yspeed = new Random(); //y speed for turtles
        Random xspeed = new Random();//x speed for turtles

        public static string jf1name; //Create a string variable for player one's name (so that it can be passed onto the game over form when the game ends)
        public static int endscore1;//Integer variable for player one's final score

        public static string jf2name; //String for player two's name
        public static int endscore2;//Int for player two's final score

        //Set the y coordinate value of the turtles to random
        Random yc = new Random();

        //Jellyfish1
        Jf1 jf1 = new Jf1();
        //Jellyfish2
        Jf2 jf2 = new Jf2();
        //Background stars
        Stars stars = new Stars();    
        //Create a list for player one's bubbles
        List<Bubble> bubbles = new List<Bubble>();
        //Create a list for player two's bubbles
        List<Bubble2> bubbles2 = new List<Bubble2>();
        //Create a list for the turtle eggs
        List<Egg> eggs = new List<Egg>();

        //Boolean variables for player one and player two's movement, and player two's shooting
        bool left, right, up, down, left2, right2, up2, down2, shoot2;
        int score1, lives1, score2, lives2;
        string move1;
        string move2;

        //Player one's bubbles
        //Used to set a delay between each bubble shot so that the player cannot continuously shoot a stream of bubbles
        int bubbleuse = 1;
        //Amount of bubbles that player one has left before recharging
        int bubblenumber = 10;
        //Recharging time (3 seconds)
        int bubbletime = 3;

        //Player two's bubbles
        int bubbleuse2 = 1;
        //Amount of bubbles that player two has left before recharging
        int bubblenumber2 = 10;
        //Recharging time (3 seconds)
        int bubbletime2 = 3;

        //Player one is alive
        public static bool alive = true;
        //Player two is alive
        public static bool alive2 = true;

        public frmPlanetJamiro()
        {
            InitializeComponent();

            //Minimise flickering
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlBG, new object[] { true });

            for (int i = 0; i < 7; i++)
            {
                //Set the x coordinate of the planets (each placed in a 1/7 of the panel width apart from each other)
                int x = 70 + (i * (pnlBG.Width / 7)); 
                enemy[i] = new Enemy(x);
            }
            for (int i = 0; i < 2; i++)
            {
                //Set the starting positions of the turtles
                int x = 70 + (i * (pnlBG.Width / 4)); ;
                turtle[i] = new Turtle(x);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //When the form loads
            
            //Select player one's name textbox
            txtName1.Focus();

            //Ensure timers are off
            tmrJf1.Enabled = false;
            tmrJf2.Enabled = false;
            tmrEnemy.Enabled = false;
            tmrBubble.Enabled = false;
            tmrBubbleUse.Enabled = false;
            tmrBubbleRecharge.Enabled = false;
            tmrEgg.Enabled = false;
            tmrBubble2.Enabled = false;
            tmrBubble2Use.Enabled = false;
            tmrBubble2Recharge.Enabled = false;

            btnPlay.Visible = false;
            lblTitle.Visible = true;

//Set font colour of each textbox to white
            txtName1.Text = "Player1's name";//What appears in the textbox before the player enters anything
            txtName1.ForeColor = Color.White;

            txtName1.SelectionStart = 0;
            txtName1.SelectionLength = 0;
            txtName1.ForeColor = Color.White;

            txtName2.Text = "Player2's name";
            txtName2.ForeColor = Color.White;

            txtName2.SelectionStart = 0; //If the text was selected, this is the value it will start at.
            txtName2.SelectionLength = 0; //This is the length of the selection. It is set to 0 so that there is no selection/highlight.
            txtName2.ForeColor = Color.White;

            txtLives1.Text = "Lives";
            txtLives1.ForeColor = Color.White;

            txtLives1.SelectionStart = 0;
            txtLives1.SelectionLength = 0;
            txtLives1.ForeColor = Color.White;

            txtLives2.Text = "Lives";
            txtLives2.ForeColor = Color.White;

            txtLives2.SelectionStart = 0;
            txtLives2.SelectionLength = 0;
            txtLives2.ForeColor = Color.White;

            //Starting positions of jellyfish1 and jellyfish2
            jf1.x = 443;
            jf1.y = 350;

            jf2.x = 523;
            jf2.y = 350;

        }

        private void pnlTopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBG_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            for (int i = 0; i < 7; i++)
            {
                int yrndmspeed = yspeed.Next(5, 10); //Set default speed of planets
                enemy[i].y += yrndmspeed; //Adds the speed value so that the planets move down
                enemy[i].drawEnemy(g); //Draw planets

                if ((score1 >= 0 && score1 < 30) || (score2 >= 0 && score2 < 30)) //If either player1 or player2's scores is between 0 and 30
                {
                    int rspeed = yspeed.Next(1, 5); //set the speed of each planet to a random value between 1 and 5
                    enemy[i].y += rspeed;
                }

                if ((score1 >= 30 && score1 < 50) || (score2 >= 30 && score2 < 50))//If either player1 or player2's scores is between 30 and 50
                {
                    int rspeed = yspeed.Next(5, 10);//set the speed of each planet to a random value between 5 and 10
                    enemy[i].y += rspeed;
                }


                if ((score2 >= 50 && score2 < 100) || (score1 >= 50 && score1 < 100))//If either player1 or player2's scores is between 50 and 100
                {
                    int rspeed = yspeed.Next(10, 20);//set the speed of each planet to a random value between 10 and 20
                    enemy[i].y += rspeed;
                }

                if ((score2 >= 100 && score2 < 200) || (score1 >= 100 && score1 < 200))//If either player1 or player2's scores is between 100 and 200
                {
                    int rspeed = yspeed.Next(20, 40);//set the speed of each planet to a random value between 20 and 40
                    enemy[i].y += rspeed;
                }

                if ((score2 >= 200) || (score1 >= 200)) //If either player1 or player2's scores is greater than 200
                {
                    int rspeed = yspeed.Next(30, 50);//set the speed of each planet to a random value between 30 and 50
                    enemy[i].y += rspeed;
                }

            }
            for (int i = 0; i < 2; i++)
            {
                int xrndmspeed = xspeed.Next(5, 10);//Set the speed of the turtles to a random value between 5 and 10
                turtle[i].x += xrndmspeed;//Add the speed value so that the turtles move to the right
                turtle[i].drawEnemy(g); //Draw turtles
            }

            //If player one is alive
            if (alive == true)
            {
                jf1.drawJf1(g); //Draw jellyfish1
            }
            //If player one is not alive
            if (alive == false)
                {
                    MessageBox.Show("Player2 wins!", "Game Over"); //Show message box saying that player2 wins

                //Disable timers
                    tmrJf1.Enabled = false;
                    tmrJf2.Enabled = false;
                    tmrEnemy.Enabled = false;
                    tmrBubble.Enabled = false;
                    tmrBubbleRecharge.Enabled = false;
                    tmrBubbleUse.Enabled = false;
                    tmrBubble2.Enabled = false;
                    tmrBubble2Recharge.Enabled = false;
                    tmrBubble2Use.Enabled = false;
                    tmrEgg.Enabled = false;
                    lblScore1.Enabled = false;

                //Set the final scores 
                endscore1 = score1;
                endscore2 = score2;

                //Close the game form and show the game over screen
                frmGameOver GOform = new frmGameOver();
                    this.Close();
                    GOform.Show();
                }

            //Same thing but when player two dies first
            if (alive2 == true)
            {
                jf2.drawJf2(g);
            }
            if (alive2 == false)
            {
                MessageBox.Show("Player1 wins!", "Game Over");

                tmrJf1.Enabled = false;
                tmrJf2.Enabled = false;
                tmrEnemy.Enabled = false;
                tmrBubble.Enabled = false;
                tmrBubbleRecharge.Enabled = false;
                tmrBubbleUse.Enabled = false;
                tmrBubble2.Enabled = false;
                tmrBubble2Recharge.Enabled = false;
                tmrBubble2Use.Enabled = false;
                tmrEgg.Enabled = false;
                lblScore1.Enabled = false;

                endscore1 = score1;
                endscore2 = score2;

                frmGameOver GOform = new frmGameOver();
                this.Close();
                GOform.Show();
            }


            foreach (Bubble b in bubbles)
            {
                b.drawBubble(g); //Draw player one's bubbles
                b.moveBubble(g); //Bubble move upwards
            }

            foreach (Bubble2 b2 in bubbles2)
            {
                b2.drawBubble2(g); //Draw player two's bubbles
                b2.moveBubble2(g); //Bubbles move upwards
            }
            foreach (Egg s in eggs)
            {
              s.drawEgg(g); //Draw turtle egg
              s.moveEgg(g);//Turtle egg moves to the right
            }

            stars.drawStars(g); //Draw the background stars

        }

        //Minimise flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      
                return handleParam;
            }
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlBottomBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPlanetJamiro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Escape)
            {
                Cursor.Show();

                tmrJf1.Enabled = false;
                tmrJf2.Enabled = false;
                tmrEnemy.Enabled = false;
                tmrBubble.Enabled = false;
                tmrBubbleRecharge.Enabled = false;
                tmrBubbleUse.Enabled = false;
                tmrBubble2.Enabled = false;
                tmrBubble2Recharge.Enabled = false;
                tmrBubble2Use.Enabled = false;
                tmrEgg.Enabled = false;

                DialogResult result1 = MessageBox.Show("Are you sure you want to exit to the main menu?",
                  "Going already?",
                   MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning,
                  MessageBoxDefaultButton.Button2);

             
                if (result1 == DialogResult.Yes)
                {
                    frmHome homeform = new frmHome();             
                    this.Close();
                    homeform.Show();
                }
                if (result1 == DialogResult.No)
                {
                    tmrJf1.Enabled = true;
                    tmrJf2.Enabled = true;
                    tmrEnemy.Enabled = true;
                    tmrBubble.Enabled = true;
                    tmrBubbleRecharge.Enabled = true;
                    tmrBubbleUse.Enabled = true;
                    tmrBubble2.Enabled = true;
                    tmrBubble2Recharge.Enabled = true;
                    tmrBubble2Use.Enabled = true;
                    tmrEgg.Enabled = true;
                }

         

            }


            //If the arrow keys are pressed
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }

            //If the WASD keys are pressed
            if (e.KeyData == Keys.A) { left2 = true; }
            if (e.KeyData == Keys.D) { right2 = true; }
            if (e.KeyData == Keys.W) { up2 = true; }
            if (e.KeyData == Keys.S) { down2 = true; }
            if (e.KeyData == Keys.Space) { shoot2 = true; }

            //If player two has no more bubbles left
            if (bubblenumber2 == 0)
            {
                tmrBubble2Recharge.Start(); //Countdown 3 seconds
            }

            //If player2 shoots a bubble
            if (shoot2 && bubblenumber2 > 0 && bubbleuse2 > 0)
            {
                
                bubblenumber2--; //Decrease bubble amount by one
                bubbleuse2 -= 1; //No more bubbles left to use
                lblBubbleCount2.Text = bubblenumber2.ToString(); //Show on textbox that player two has one less bubble left
                bubbles2.Add(new Bubble2(jf2.jf2Rec));//Draw a bubble
            }
            //Cause a delay so that they can't shoot another bubble straight away
            if (bubbleuse2 == 0)
            {
                tmrBubble2Use.Start();
            }

        }

        private void mnuStart_Click(object sender, EventArgs e)
        {
            jf1name = txtName1.Text;
            jf2name = txtName2.Text;

            alive = true;
            alive2 = true;

            //If nothing has been entered for player one's name, player two's name, or player one's lives
            if (txtName1.Text == "" || txtName2.Text == "" || txtLives1.Text == "")
            {
                //Show error message box
                MessageBox.Show("Check that both names have been entered and the lives have been set.", "Error!");

                //Disable timers
                tmrEnemy.Enabled = false;
                tmrJf1.Enabled = false;
                tmrJf2.Enabled = false;
                tmrBubble.Enabled = false;
                tmrEgg.Enabled = false;
                tmrBubbleRecharge.Enabled = false;
                tmrBubbleUse.Enabled = false;
                tmrBubble2.Enabled = false;
                tmrBubble2Use.Enabled = false;
                tmrBubble2Recharge.Enabled = false;
            }
            else
            {
                //Enable timers (game starts)
                score1 = 0;
                lblScore1.Text = score1.ToString();
                score2 = 0;
                lblScore2.Text = score2.ToString();
                lives1 = int.Parse(txtLives1.Text); //Set lives to what player one set them as
                lives2 = int.Parse(txtLives1.Text);//Lives starts with the same amount as player one
                tmrEnemy.Enabled = true;
                tmrJf1.Enabled = true;
                tmrJf2.Enabled = true;
                tmrBubble.Enabled = true;
                tmrEgg.Enabled = true;
                tmrBubbleRecharge.Enabled = true;
                tmrBubbleUse.Enabled = true;
                tmrBubble2.Enabled = true;
                tmrBubble2Use.Enabled = true;
                tmrBubble2Recharge.Enabled = true;

                //Player can no longer edit their names or amount of lives
                txtName1.Enabled = false;
                txtName2.Enabled = false;
                txtLives1.Enabled = false;
                txtLives2.Enabled = false;

            //    btnPlay.Visible = true;
             //   lblTitle.Visible = false;
            }
        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
            //When the pause button is pressed, stop all timers
            tmrJf1.Enabled = false;
            tmrJf2.Enabled = false;
            tmrEnemy.Enabled = false;
            tmrBubble.Enabled = false;
            tmrBubbleRecharge.Enabled = false;
            tmrBubbleUse.Enabled = false;
            tmrEgg.Enabled = false;
            tmrBubble2.Enabled = false;
            tmrBubble2Recharge.Enabled = false;
            tmrBubble2Use.Enabled = false;

            btnPlay.Visible = false;
            lblTitle.Visible = true;
        }

        private void txtName1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Can only enter alpabet, enter key, backspace key into player one's name
            if (e.KeyChar == 8 || e.KeyChar > 64 && e.KeyChar < 91 || e.KeyChar > 96 && e.KeyChar < 123 || e.KeyChar == 13) 
            {
              //  mnuStart.Visible = true;
            }
            else
            {
                //Remove characters that were entered
                //Show error message box
                MessageBox.Show("Please only enter alphabetical characters", "Error");
                e.Handled = true;
                txtName1.Focus();
              //  btnPlay.Visible = false;
            }

            //If enter key is pressed, focus on player two's name
            if (e.KeyChar == 13)
            {
                txtName2.Focus();
            }
        }

        private void txtName2_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Can only enter alpabet, enter key, backspace key into player two's name
            if (e.KeyChar == 8 || e.KeyChar > 64 && e.KeyChar < 91 || e.KeyChar > 96 && e.KeyChar < 123 || e.KeyChar == 13)
            { 

            }
            else
            {
                MessageBox.Show("Please only enter alphabetical characters", "Error");
                e.Handled = true;
                txtName2.Focus();
            }

            if (e.KeyChar == 13)
            {
                txtLives1.Focus();
            }
        }

        private void txtName1_KeyDown(object sender, KeyEventArgs e)
        {
            //If nothing has been entered into player one's name textbox yet, show default text
            if (txtName1.Text.Equals("Player1's name") == true)
            {
                txtName1.Text = "";
                txtName1.ForeColor = Color.White;
            }
        }

        private void txtName1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtName1.Text.Equals(null) == true || txtName1.Text.Equals("") == true)
            {
                txtName1.Text = "Player1's name";
                txtName1.ForeColor = Color.White;
            }
        }

        private void txtName2_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtName2.Text.Equals("Player2's name") == true)
            {
                txtName2.Text = "";
                txtName2.ForeColor = Color.White;
            }
        }

        private void txtName2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtName2.Text.Equals(null) == true || txtName2.Text.Equals("") == true)
            {
                txtName2.Text = "Player2's name";
                
            }
        }

        private void txtLives1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLives1.MaxLength = 1; //limits the amount of digits allowed in text box to 1

            //Only numbers 3 - 9 can be entered as the number of lives
            if (e.KeyChar > 50 && e.KeyChar < 58 || e.KeyChar == 13 || e.KeyChar == 8)
            {
                txtLives2.Text = txtLives1.Text;
                btnPlay.Visible = true;
                lblTitle.Visible = false;
            }
            else
            {
                //If other characters are entered, showed error box, and remove characters entered
                MessageBox.Show("Please only enter numerical characters", "Error");
                e.Handled = true;
                btnPlay.Visible = false;

            }

            //If there is a value entered in the lives textbox when the enter key is pressed
            if (e.KeyChar == 13 && txtLives1.Text != "")
            {
                btnPlay.Visible = true;
                btnPlay.Focus();
             
            }
            else
            {
                btnPlay.Visible = false;
                lblTitle.Visible = true;
            }

        }

        private void txtLives1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtLives1.Text.Equals("Lives") == true)
            {
                txtLives1.Text = "";
                txtLives1.ForeColor = Color.White;
            }
        }

        private void txtLives1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtLives1.Text.Equals(null) == true || txtLives1.Text.Equals("") == true)
            {
                txtLives1.Text = "Lives";
                txtLives1.ForeColor = Color.White;
            }
        }

        private void txtLives2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLives2_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtLives2.Text.Equals("Lives") == true)
            {
                txtLives2.Text = "";
                txtLives2.ForeColor = Color.White;
            }
        }

        private void txtLives2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtLives2.Text.Equals(null) == true || txtLives2.Text.Equals("") == true)
            {
                txtLives2.Text = "Lives";
                txtLives2.ForeColor = Color.White;
            }

            if (txtLives2.Text.Equals(null) == false || txtLives2.Text.Equals("") == true)
            {
                txtLives2.ForeColor = Color.White;
            }
        }

        private void pnlBG_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (tmrBubbleUse.Enabled == true || tmrBubble2Use.Enabled == true)
                {
                    if (bubblenumber == 0)
                    {
                        tmrBubbleRecharge.Start();
                    }

                    if (bubblenumber > 0 && bubbleuse > 0)
                    {
                        bubblenumber--;
                        bubbleuse -= 1;
                        lblBubbleCount.Text = bubblenumber.ToString();
                        bubbles.Add(new Bubble(jf1.jf1Rec));
                    }
                    if (bubbleuse == 0)
                    {
                        tmrBubbleUse.Start();
                    }
                }
            }
            
        }

        //Timer for player one's bubbles
        private void tmrBubble_Tick(object sender, EventArgs e)
        {

            foreach (Enemy n in enemy)
            {

                foreach (Bubble b in bubbles)
                {
                    //If the bubble collides with a planet
                    if (n.enemyRec.IntersectsWith(b.bubbleRec))
                    {
                        bubbles.Remove(b);//Remove the bubble
                        n.y = 20; //Move the planet back to its starting position
                        score1 += 1; //Add one to player one's score
                        lblScore1.Text = score1.ToString();
                        break;//stop loop
                    }
                }
                this.Invalidate();

            }


            //Collision code for player two's bubbles
            foreach (Enemy n in enemy)
            {

                foreach (Bubble2 b2 in bubbles2)
                {
                    //If the bubble collides with a planet
                    if (n.enemyRec.IntersectsWith(b2.bubble2Rec))
                    {
                        bubbles2.Remove(b2);
                        n.y = 20;
                        score2 += 1;
                       lblScore2.Text = score2.ToString();
                        break;
                    }
                }
                this.Invalidate();

            }

            //Collision code for player one's bubble and the turtles
            foreach (Turtle t in turtle)
            {
                foreach (Bubble b in bubbles)
                {
                    if (t.enemyRec.IntersectsWith(b.bubbleRec))
                    {
                        bubbles.Remove(b);
                        t.x = 10; //turtle moves back to their starting position
                       score1 += 1;
                        lblScore1.Text = score1.ToString();
                        break;
                    }
                }
                this.Invalidate();
            }

            foreach (Turtle t in turtle)
            {

                foreach (Bubble2 b2 in bubbles2)
                {
                    if (t.enemyRec.IntersectsWith(b2.bubble2Rec))
                    {
                        bubbles2.Remove(b2);
                        t.x = 10;
                        score2 += 1;
                        lblScore2.Text = score2.ToString();
                        break;
                    }
                }
                this.Invalidate();

            }

        }

        private void txtLives1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmrBubble2Recharge_Tick(object sender, EventArgs e)
        {
            //When player2 has no more bubbles left 
            //Timer started so it counts down 3 seconds

            //Change text in the charge label to show that the bubbles are recharging
            lblCharge2.Text = "Recharging\nBubbles";
            bubbletime2--;
            lblBubbletime2.Text = bubbletime2.ToString();

            //Once 3 seconds has counted down
            if (bubbletime2 == 0)
            {
                tmrBubble2Recharge.Stop(); //Stop the timer
                bubblenumber2 = 10; //Player2 has 10 bubbles again
                lblBubbleCount2.Text = bubblenumber2.ToString();
                bubbletime2 = 3; 
                lblCharge2.Text = "Charged";//Text to show that the bubbles are charged
            }
        }

        private void tmrBubble2Use_Tick(object sender, EventArgs e)
        {
            //Delay between each bubble shot

            //If delay has passed
            if (bubbleuse2 == 0)
            {
                tmrBubble2Use.Stop(); //Stop timer
                bubbleuse2 = 1;//Player2 can shoot again
            }
        }

        private void txtName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If the exit button is pressed
            //Disable all timers
            tmrJf1.Enabled = false;
            tmrJf2.Enabled = false;
            tmrEnemy.Enabled = false;
            tmrBubble.Enabled = false;
            tmrBubbleRecharge.Enabled = false;
            tmrBubbleUse.Enabled = false;
            tmrBubble2.Enabled = false;
            tmrBubble2Recharge.Enabled = false;
            tmrBubble2Use.Enabled = false;
            tmrEgg.Enabled = false;

            //Show confirmation box
            DialogResult result1 = MessageBox.Show("Are you sure you want to exit to the main menu?",
                  "Already going?",
                   MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning,
                  MessageBoxDefaultButton.Button2);

            //If player agrees to leave game
            if (result1 == DialogResult.Yes)
            {
                //Close game form
                //Open menu form
                frmHome homeform = new frmHome();
                this.Close();
                homeform.Show();
            }

            //If player clicks no, then enable all timers again and game resumes
            if (result1 == DialogResult.No)
            {
                tmrJf1.Enabled = true;
                tmrJf2.Enabled = true;
                tmrEnemy.Enabled = true;
                tmrBubble.Enabled = true;
                tmrBubbleRecharge.Enabled = true;
                tmrBubbleUse.Enabled = true;
                tmrBubble2.Enabled = true;
                tmrBubble2Recharge.Enabled = true;
                tmrBubble2Use.Enabled = true;
                tmrEgg.Enabled = true;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtName1.Text == "" || txtName2.Text == "" || txtLives1.Text == "")
            {
                MessageBox.Show("Check that both names have been entered and the lives have been set.", "Error!");

                tmrEnemy.Enabled = false;
                tmrJf1.Enabled = false;
                tmrJf2.Enabled = false;

                tmrBubble.Enabled = false;
                tmrBubbleRecharge.Enabled = false;
                tmrBubbleUse.Enabled = false;

                tmrBubble2.Enabled = false;
                tmrBubble2Recharge.Enabled = false;
                tmrBubble2Use.Enabled = false;

                btnPlay.Visible = false;


            }
            else
            {
                score1 = 0;
                score2 = 0;
                lblScore1.Text = score1.ToString();
                lblScore2.Text = score2.ToString();
             //   lives1 = int.Parse(txtLives1.Text);
            //    lives2 = int.Parse(txtLives2.Text);
                tmrEnemy.Enabled = true;
                tmrJf1.Enabled = true;
                tmrJf2.Enabled = true;

                tmrBubble.Enabled = true;
                tmrBubbleRecharge.Enabled = true;
                tmrBubbleUse.Enabled = true;

                tmrBubble2.Enabled = true;
                tmrBubble2Recharge.Enabled = true;
                tmrBubble2Use.Enabled = true;

                txtName1.Enabled = false;
                txtName2.Enabled = false;
                txtLives1.Enabled = false;
                txtLives2.Enabled = false;

                btnPlay.Visible = false;
                lblTitle.Visible = true;


            }
        }

        private void BtnPlay1_Click(object sender, EventArgs e)
        {
            //If there is nothing set for player1's name, player2's name, or the lives
            if (txtName1.Text == "" || txtName2.Text == "" || txtLives1.Text == "")
            {
                MessageBox.Show("Check that both names have been entered and the lives have been set.", "Error!"); //Show error message

                tmrEnemy.Enabled = false;
                tmrJf1.Enabled = false;
                tmrJf2.Enabled = false;

                tmrBubble.Enabled = false;
                tmrBubbleRecharge.Enabled = false;
                tmrBubbleUse.Enabled = false;

                tmrBubble2.Enabled = false;
                tmrBubble2Recharge.Enabled = false;
                tmrBubble2Use.Enabled = false;

                btnPlay.Visible = false; //Do not show play button


            }
            else
            {
                lives1 = int.Parse(txtLives1.Text); //Display the number of player1's lives in the textbox
                lives2 = int.Parse(txtLives2.Text);//Display the number of player2's lives in the textbox

                tmrEnemy.Enabled = true;
                tmrJf1.Enabled = true;
                tmrJf2.Enabled = true;

                tmrBubble.Enabled = true;

                tmrBubble2.Enabled = true;

                txtName1.Enabled = false;
                txtName2.Enabled = false;
                txtLives1.Enabled = false;
                txtLives2.Enabled = false;

                btnPlay.Visible = false; //Do not show play button
                lblTitle.Visible = true; //Show title
            }
        }

        private void tmrBubbleRecharge_Tick(object sender, EventArgs e)
        {
            //Same code as player two's bubbles, but for player one
            lblCharge1.Text = "Recharging\nBubbles";
            bubbletime--;
            lblBubbletime.Text = bubbletime.ToString();

            if (bubbletime == 0)
            {
                tmrBubbleRecharge.Stop();
                bubblenumber = 10;
                lblBubbleCount.Text = bubblenumber.ToString();
                bubbletime = 3;
                lblCharge1.Text = "Charged";
            }

        }

        private void frmPlanetJamiro_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void tmrBubbleUse_Tick(object sender, EventArgs e)
        {
            if (bubbleuse == 0)
            {
                tmrBubbleUse.Stop();
                bubbleuse = 1;
            }
        }

        private void tmrEgg_Tick(object sender, EventArgs e)
        {
            foreach (Turtle t in turtle)
            {
                eggs.Add(new Egg(t.enemyRec));//Turtles shoot eggs
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tmrJf2_Tick(object sender, EventArgs e)
        {
            //Movement for player two

            //When the D key is pressed
            if (right2)
            {
                //Move jellyfish2 to the right
                move2 = "right2";
                jf2.moveJf2(move2);                
            }

            //When the A key is pressed
            if (left2)
            {
                //Jellyfish2 moves to the left
                move2 = "left2";
                jf2.moveJf2(move2);
            }

            //If the W key is pressed
            if (up2)
            {
                //Move jellyfish2 upwards
                move2 = "up2";
                jf2.moveJf2(move2);
            }

            //If the S key is pressed
            if (down2)
            {
                //Move jellyfish2 downwards
                move2 = "down2";
                jf2.moveJf2(move2);
            }
        }

        private void tmrBubble2_Tick(object sender, EventArgs e)
        {
           
        }

        private void FrmPlanetJamiro_KeyUp(object sender, KeyEventArgs e)
        {
            //If no keys are pressed
            //Jellyfish1 and jellyfish cannot move, and jellyfish2 cannot shoot
           if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }

            if (e.KeyData == Keys.A) { left2 = false; }
            if (e.KeyData == Keys.D) { right2 = false; }
            if (e.KeyData == Keys.W) { up2 = false; }
            if (e.KeyData == Keys.S) { down2 = false; }
            if (e.KeyData == Keys.Space) { shoot2 = false; }
        }

        private void TmrJf1_Tick(object sender, EventArgs e)
        {
            //If the right arrow key is pressed
            if (right)
            {
                //Jellyfish1 moves to the right and stars move to the left
                move1 = "right";
                jf1.moveJf1(move1);
                stars.moveStar(move1);

            }

            //If the left arrow key is pressed
            if (left)
            {
                //Jellyfish1 moves to the left and stars move to the right
                move1 = "left";
                jf1.moveJf1(move1);
                stars.moveStar(move1);
            }

            //If the up arrow key is pressed
            if (up)
            {
                //Jellyfish1 moves up and stars move down
                move1 = "up";
                jf1.moveJf1(move1);
                stars.moveStar(move1);
            }

            //If the down arrow key is pressed
            if (down)
            {
                //Jellyfish1 moves down and stars move to the up
                move1 = "down";
                jf1.moveJf1(move1);
                stars.moveStar(move1);
            }

            //If jellyfish collide with a turtle egg
            foreach (Egg s in eggs)
            {
                //Jellyfish1
                if (jf1.jf1Rec.IntersectsWith(s.eggRec))
                {
                    eggs.Remove(s);//Remove the egg
                    lives1 -= 1; //Subtract one from player one's lives
                    txtLives1.Text = lives1.ToString(); //Show this in player1's lives textbox
                    checkLives();

                    break;
                }

                //Jellyfish2
                if (jf2.jf2Rec.IntersectsWith(s.eggRec))
                {
                    eggs.Remove(s);
                    lives2 -= 1;
                    txtLives2.Text = lives2.ToString();
                    checkLives();

                    break;
                }

                //If the eggs go past the right side of the panel
                if ((s.x > 985))
                {
                    eggs.Remove(s); //Remove them
                    break;
                }
            }
        }

        private void TmrEnemy_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                enemy[i].moveEnemy();

                if (tmrJf1.Enabled == true)
                    {
                    //If jellyfish1 collides with a planet
                    if (jf1.jf1Rec.IntersectsWith(enemy[i].enemyRec))
                    {
                        enemy[i].y = 30; //planet moves back to the top
                        lives1 -= 1; //Jellyfish1 loses a life
                        txtLives1.Text = lives1.ToString();//Display the lives in the player one's lives textbox
                        checkLives();
                    }
                }

                if (tmrJf2.Enabled == true)
                {
                    //If jellyfish2 collides with a planet
                    if (jf2.jf2Rec.IntersectsWith(enemy[i].enemyRec))
                    {
                 
                        enemy[i].y = 30;
                        lives2 -= 1;
                        txtLives2.Text = lives2.ToString();
                        checkLives();
                    }
                }
                else
                {

                }

                foreach (Enemy n in enemy)
                {
                    //If the planets reach the bottom of the panel
                    if (n.y > 444)
                    {
                        score1 += 1; //Add one to player one's score
                        lblScore1.Text = score1.ToString(); //Display this in player one's score textbox
                        score2 += 1; //Add one to player two's score
                        lblScore2.Text = score2.ToString(); //Display this in player two's score textbox
                        n.y = 20; //Move back to the starting position
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (Turtle t in turtle)
                {
                    //if the turtles reach the right side of the panel
                    if (t.x > 987)
                    {
                        t.y = yc.Next(20, 400); //Move turtle back to the left side of the panel at a random y coordinate between 20 and 400
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                turtle[i].moveEnemy();

                //If jellyfish1 collides with a turtle
                if (jf1.jf1Rec.IntersectsWith(turtle[i].enemyRec))
                {
                    turtle[i].x = 10; //turtle moves back to starting position
                    lives1 -= 1; //Jellyfish1 loses a lives
                    txtLives1.Text = lives1.ToString();//Display this
                    checkLives();
                }
                //If jellyfish2 collides with a turtle
                if (jf2.jf2Rec.IntersectsWith(turtle[i].enemyRec))
                {
                    turtle[i].x = 10; 
                    lives2 -= 1;
                    txtLives2.Text = lives2.ToString();
                    checkLives();
                }

            }
            pnlBG.Invalidate();
        }

        private void checkLives()
        {
            //If jellyfish1 has no more lives left
            if (lives1 <= 0)
            {
                lives1 = 0;
                tmrBubble.Enabled = false;
                txtLives1.Text = lives1.ToString(); 
                alive = false; //Jellyfish1 is no longer alive
                lblScore1.Enabled = false; //Jellyfish1's score no longer increases
                tmrBubble.Enabled = false; //Disable bubble timers
                tmrBubbleRecharge.Enabled = false;
                tmrBubbleUse.Enabled = false;
            }

            //If jellyfish2 has no more lives left
            if (lives2 <= 0)
            {
                lives2 = 0;
                txtLives2.Text = lives2.ToString();
                  tmrBubble2.Enabled = false;
                  tmrBubble2Recharge.Enabled = false;
                  tmrBubble2Use.Enabled = false;
                alive2 = false; 
            }

            }

        }

    }

