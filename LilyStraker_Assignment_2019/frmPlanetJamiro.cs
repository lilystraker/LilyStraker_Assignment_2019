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
        Enemy[] enemy = new Enemy[7];
        Turtle[] turtle = new Turtle[7];
        Random yspeed = new Random();
        Random xspeed = new Random();
        Jf1 jf1 = new Jf1();
        Jf2 jf2 = new Jf2();
        Stars stars = new Stars();    
        List<Bubble> bubbles = new List<Bubble>();
        List<Bubble2> bubbles2 = new List<Bubble2>();
        List<Egg> eggs = new List<Egg>();

        bool left, right, up, down, left2, right2, up2, down2, shoot2;
        int score1, lives1, score2, lives2;
        string move1;
        string move2;

        int bubbleuse = 1;
        int bubblenumber = 10;
        int bubbletime = 3;

        int bubbleuse2 = 1;
        int bubblenumber2 = 10;
        int bubbletime2 = 3;

        public frmPlanetJamiro()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlBG, new object[] { true });

            for (int i = 0; i < 7; i++)
            {
                int x = 70 + (i * (pnlBG.Width / 7)); ;
                enemy[i] = new Enemy(x);
            }
            for (int i = 0; i < 7; i++)
            {
                int x = 70 + (i * (pnlBG.Width / 4)); ;
                turtle[i] = new Turtle(x);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

         //   MessageBox.Show("Instructions", "Instructions");
            txtName1.Focus();

            txtName1.Text = "Player1's name";
            txtName1.ForeColor = Color.Gray;

            txtName1.SelectionStart = 0;
            txtName1.SelectionLength = 0;
            txtName1.ForeColor = Color.Gray;

            txtName2.Text = "Player2's name";
            txtName2.ForeColor = Color.Gray;

            txtName2.SelectionStart = 0; //If the text was selected, this is the value it will start at.
            txtName2.SelectionLength = 0; //This is the length of the selection. It is set to 0 so that there is no selection/highlight.
            txtName2.ForeColor = Color.Gray;

            txtLives1.Text = "Lives";
            txtLives1.ForeColor = Color.Gray;

            txtLives1.SelectionStart = 0;
            txtLives1.SelectionLength = 0;
            txtLives1.ForeColor = Color.Gray;

            txtLives2.Text = "Lives";
            txtLives2.ForeColor = Color.Gray;

            txtLives2.SelectionStart = 0;
            txtLives2.SelectionLength = 0;
            txtLives2.ForeColor = Color.Gray;

            jf1.x = 523;
            jf1.y = 350;

            jf2.x = 443;
            jf2.y = 350;

        }

        private void pnlTopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBG_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            for (int i = 0; i <7; i++)
            {
                int yrndmspeed = yspeed.Next(5, 10);
                enemy[i].y += yrndmspeed;
               enemy[i].drawEnemy(g);

                int xrndmspeed = xspeed.Next(5, 10);
                turtle[i].x += xrndmspeed;
                turtle[i].drawEnemy(g);

            }


            jf1.drawJf1(g);
            jf2.drawJf2(g);

            foreach (Bubble b in bubbles)
            {
                b.drawBubble(g);
                b.moveBubble(g);
            }

            foreach (Bubble2 b2 in bubbles2)
            {
                b2.drawBubble2(g);
                b2.moveBubble2(g);
            }
            foreach (Egg s in eggs)
            {
              s.drawEgg(g);
               s.moveEgg(g);
            }

            stars.drawStars(g);

        }

        //For flickering
        //However, flickering still occurs when in fullscreen...?
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
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
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }


            if (e.KeyData == Keys.A) { left2 = true; }
            if (e.KeyData == Keys.D) { right2 = true; }
            if (e.KeyData == Keys.W) { up2 = true; }
            if (e.KeyData == Keys.S) { down2 = true; }
            if (e.KeyData == Keys.Space) { shoot2 = true; }

            if (bubblenumber2 == 0)
            {
                tmrBubble2Recharge.Start();
            }

            if (shoot2 && bubblenumber2 > 0 && bubbleuse2 > 0)
            {
                bubblenumber2--;
                bubbleuse2 -= 1;
                lblBubbleCount2.Text = bubblenumber2.ToString();
                bubbles2.Add(new Bubble2(jf2.jf2Rec));
            }
            if (bubblenumber2 == 0)
            {
                tmrBubble2Recharge.Start();
            }
            if (bubbleuse2 == 0)
            {
                tmrBubble2Use.Start();
            }

        }

        private void mnuStart_Click(object sender, EventArgs e)
        {
            if (txtName1.Text == "" || txtName2.Text == "" || txtLives1.Text == "")
            {
                MessageBox.Show("Check that both names have been entered and the lives have been set.", "Error!");

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
           score1 = 0;
                lblScore1.Text = score1.ToString();
                score2 = 0;
                lblScore2.Text = score2.ToString();
                lives1 = int.Parse(txtLives1.Text); 
                lives2 = int.Parse(txtLives1.Text);
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


                txtName1.Enabled = false;
                txtName2.Enabled = false;
                txtLives1.Enabled = false;
                txtLives2.Enabled = false;
              


            }

        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
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
      //

        }

        private void txtName1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 8 || e.KeyChar > 64 && e.KeyChar < 91 || e.KeyChar > 96 && e.KeyChar < 123 || e.KeyChar == 13) //alpabet, enter key, backspace key
            {
                mnuStart.Visible = true;
            }
            else
            {
                MessageBox.Show("Please only enter alphabetical characters", "Error");
                //event Handled is set to true, user input is suppressed and not reflected in the text box
                e.Handled = true;
                txtName1.Focus();
            }

            if (e.KeyChar == 13)
            {
                txtName2.Focus();
            }
        }

        private void txtName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar > 64 && e.KeyChar < 91 || e.KeyChar > 96 && e.KeyChar < 123 || e.KeyChar == 13) //alpabet, enter key, backspace key
            {

            }
            else
            {
                MessageBox.Show("Please only enter alphabetical characters", "Error");
                //event Handled is set to true, user input is suppressed and not reflected in the text box
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
            if (txtName1.Text.Equals("Player1's name") == true)
            {
                txtName1.Text = "";
                txtName1.ForeColor = Color.Black;
            }
        }

        private void txtName1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtName1.Text.Equals(null) == true || txtName1.Text.Equals("") == true)
            {
                txtName1.Text = "Player1's name";
                txtName1.ForeColor = Color.Gray;
            }
        }

        private void txtName2_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtName2.Text.Equals("Player2's name") == true)
            {
                txtName2.Text = "";
                txtName2.ForeColor = Color.Black;
            }
        }

        private void txtName2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtName2.Text.Equals(null) == true || txtName2.Text.Equals("") == true)
            {
                txtName2.Text = "Player2's name";
                txtName2.ForeColor = Color.Gray;
            }
        }

        private void txtLives1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLives1.MaxLength = 1; //limits the amount of digits allowed in text box to 1

            if (e.KeyChar > 50 && e.KeyChar < 58 || e.KeyChar == 13 || e.KeyChar == 8)
            {
                txtLives2.Text = txtLives1.Text;

            }
            else
            {
                MessageBox.Show("Please only enter numerical characters", "Error");
                e.Handled = true;
            }

            if (e.KeyChar == 13 && txtLives1.Text != "")
            {

            }
            else
            {
            }

        }

        private void txtLives1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtLives1.Text.Equals("Lives") == true)
            {
                txtLives1.Text = "";
                txtLives1.ForeColor = Color.Black;
            }
        }

        private void txtLives1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtLives1.Text.Equals(null) == true || txtLives1.Text.Equals("") == true)
            {
                txtLives1.Text = "Lives";
                txtLives1.ForeColor = Color.Gray;
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
                txtLives2.ForeColor = Color.Black;
            }
        }

        private void txtLives2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtLives2.Text.Equals(null) == true || txtLives2.Text.Equals("") == true)
            {
                txtLives2.Text = "Lives";
                txtLives2.ForeColor = Color.Gray;
            }
        }

        private void pnlBG_MouseDown(object sender, MouseEventArgs e)
        {
        //    if (e.Button == MouseButtons.Left)
       //     {
       //         bubbles.Add(new Bubble(jf1.jf1Rec));
       //     }

            if (bubblenumber == 0)
            {
                tmrBubbleRecharge.Start();
            }

            if ((e.Button == MouseButtons.Left) && bubblenumber > 0 && bubbleuse > 0)
            {
                bubblenumber--;
                bubbleuse -= 1;
                lblBubbleCount.Text = bubblenumber.ToString();
                bubbles.Add(new Bubble(jf1.jf1Rec));
            }
            if (bubblenumber == 0)
            {
                tmrBubbleRecharge.Start();
            }
            if (bubbleuse == 0)
            {
                tmrBubbleUse.Start();
            }
        }

        private void tmrBubble_Tick(object sender, EventArgs e)
        {
            //score1 = 0;
          //    for (int i = 0; i < 7; i++)
          //   {
           //   bubbles[i].moveBubble(g);


            //     score1 += enemy[i].score1;// get score from Planet class (in movePlanet method)
          //    lblScore1.Text = score1.ToString();

          //   }

            foreach (Enemy n in enemy)
            {

                foreach (Bubble b in bubbles)
                {
                    if (n.enemyRec.IntersectsWith(b.bubbleRec))
                    {
                        bubbles.Remove(b);// remove missile
                        n.y = 20;// relocate planet to the top of the form
                        score1 += 1;
                        lblScore1.Text = score1.ToString();
                        break;
                    }
                }
                this.Invalidate();

            }


            foreach (Enemy n in enemy)
            {

                foreach (Bubble2 b2 in bubbles2)
                {
                    if (n.enemyRec.IntersectsWith(b2.bubble2Rec))
                    {
                        bubbles2.Remove(b2);// remove missile
                        n.y = 20;// relocate planet to the top of the form
                        score2 += 1;
                       lblScore2.Text = score2.ToString();
                        break;
                    }
                }
                this.Invalidate();

            }


            foreach (Turtle t in turtle)
            {

                foreach (Bubble b in bubbles)
                {
                    if (t.enemyRec.IntersectsWith(b.bubbleRec))
                    {
                        bubbles.Remove(b);// remove missile
                        t.x = 10;// relocate planet to the top of the form
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
                        bubbles2.Remove(b2);// remove missile
                        t.x = 10;// relocate planet to the top of the form
                        score2 += 1;
                        lblScore2.Text = score2.ToString();
                        break;
                    }
                }
                this.Invalidate();

            }


            //   pnlBG.Invalidate();
        }

        private void txtLives1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmrBubble2Recharge_Tick(object sender, EventArgs e)
        {
            lblBubbletime2.Text = "Recharging Bubbles";
            bubbletime2--;
            lblBubbletime2.Text = bubbletime2.ToString();

            if (bubbletime2 == 0)
            {
                tmrBubble2Recharge.Stop();
                bubblenumber2 = 10;
                lblBubbleCount2.Text = bubblenumber2.ToString();
                bubbletime2 = 3;
                lblBubbletime2.Text = "";
            }
        }

        private void tmrBubble2Use_Tick(object sender, EventArgs e)
        {
            if (bubbleuse2 == 0)
            {
                tmrBubble2Use.Stop();
                bubbleuse2 = 1;
            }
        }

        private void txtName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrBubbleRecharge_Tick(object sender, EventArgs e)
        {
            lblBubbletime.Text = "Recharging Bubbles";
            bubbletime--;
            lblBubbletime.Text = bubbletime.ToString();

            if (bubbletime == 0)
            {
                tmrBubbleRecharge.Stop();
                bubblenumber = 10;
                lblBubbleCount.Text = bubblenumber.ToString();
                bubbletime = 3;
                lblBubbletime.Text = "";
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
                eggs.Add(new Egg(t.enemyRec));
            }

              
            
            

            }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tmrJf2_Tick(object sender, EventArgs e)
        {
            if (right2)
            {
                move2 = "right2";
                jf2.moveJf2(move2);
                

            }
            if (left2)
            {
                move2 = "left2";
                jf2.moveJf2(move2);
            }
            if (up2)
            {
                move2 = "up2";
                jf2.moveJf2(move2);
            }
            if (down2)
            {
                move2 = "down2";
                jf2.moveJf2(move2);
            }
        }

        private void tmrBubble2_Tick(object sender, EventArgs e)
        {
           
        }

        private void FrmPlanetJamiro_KeyUp(object sender, KeyEventArgs e)
        {
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
            if (right)
            {
                move1 = "right";
                jf1.moveJf1(move1);
                stars.moveStar(move1);

            }
            if (left)
            {
                move1 = "left";
                jf1.moveJf1(move1);
                stars.moveStar(move1);
            }
            if (up)
            {
                move1 = "up";
                jf1.moveJf1(move1);
                stars.moveStar(move1);
            }
            if (down)
            {
                move1 = "down";
                jf1.moveJf1(move1);
                stars.moveStar(move1);
            }

            foreach (Egg s in eggs)
            {
                if (jf1.jf1Rec.IntersectsWith(s.eggRec))
                {
                    eggs.Remove(s);
                    lives1 -= 1;
                    txtLives1.Text = lives1.ToString();
                    checkLives();

                    //s.x = 0;

                    break;
                }
                if (jf2.jf2Rec.IntersectsWith(s.eggRec))
                {
                    eggs.Remove(s);
                    lives2 -= 1;
                    txtLives2.Text = lives2.ToString();
                    checkLives();

                    // s.x = 0;

                    break;
                }

                if ((s.x > 985))
                {
                    eggs.Remove(s);
                    break;
                }
            }
            }

        private void TmrEnemy_Tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 7; i++)
            {
                enemy[i].moveEnemy();

                if (jf1.jf1Rec.IntersectsWith(enemy[i].enemyRec))
                {
                    //reset planet[i] back to top of panel
                    enemy[i].y = 30; // set  y value of planetRec
                    lives1 -= 1;// lose a life
                    txtLives1.Text = lives1.ToString();// display number of lives
                    checkLives();
                }
                if (jf2.jf2Rec.IntersectsWith(enemy[i].enemyRec))
                {
                    //reset planet[i] back to top of panel
                    enemy[i].y = 30; // set  y value of planetRec
                    lives2 -= 1;// lose a life
                    txtLives2.Text = lives2.ToString();// display number of lives
                    checkLives();
                }

                foreach (Enemy n in enemy)
                {
                    if (n.y > 444)
                    {
                        score1 += 1;
                        lblScore1.Text = score1.ToString();
                        score2 += 1;
                        lblScore2.Text = score2.ToString();
                        n.y = 20;
                    }
                }
               
            //    score1 += enemy[i].score1;// get score from Planet class (in movePlanet method)
            //    lblScore1.Text = score1.ToString();

           //     score2 += enemy[i].score2;// get score from Planet class (in movePlanet method)
              //  lblScore2.Text = score2.ToString();

            }

            for (int i = 0; i < 7; i++)
            {
                turtle[i].moveEnemy();

                if (jf1.jf1Rec.IntersectsWith(turtle[i].enemyRec))
                {
                    //reset planet[i] back to top of panel
                    turtle[i].x = 10; // set  y value of planetRec
                    lives1 -= 1;// lose a life
                    txtLives1.Text = lives1.ToString();// display number of lives
                    checkLives();
                }
                if (jf2.jf2Rec.IntersectsWith(turtle[i].enemyRec))
                {
                    //reset planet[i] back to top of panel
                    turtle[i].x = 10; // set  y value of planetRec
                    lives2 -= 1;// lose a life
                    txtLives2.Text = lives2.ToString();// display number of lives
                    checkLives();
                }

            //    score1 += turtle[i].score1;// get score from Planet class (in movePlanet method)
            //    lblScore1.Text = score1.ToString();

           //    score2 += turtle[i].score2;// get score from Planet class (in movePlanet method)
            //    lblScore2.Text = score2.ToString();

            }

            pnlBG.Invalidate();
        }

        private void checkLives()
        {
            if (lives1 <= 0)
            {
                lives1 = 0;
                tmrJf1.Enabled = false;
                tmrBubble.Enabled = false;
                tmrBubbleRecharge.Enabled = false;
                tmrBubbleUse.Enabled = false;
                txtLives1.Text = lives1.ToString();
            }

            if (lives2 <= 0)
            {
                lives2 = 0;
                txtLives2.Text = lives2.ToString();
                tmrJf2.Enabled = false;
                tmrBubble2.Enabled = false;
                tmrBubble2Recharge.Enabled = false;
                tmrBubble2Use.Enabled = false;
            }


            if (lives1 == 0 && lives2 == 0)
            {
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
                MessageBox.Show("Game Over");

            }

        }

    }
}
