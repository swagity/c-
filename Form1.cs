using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pingpeng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

            PictureBox[] Score_Player = new PictureBox[5];
            PictureBox[] Score_Enemy = new PictureBox[5];
            Color ScoreColor = Color.Silver;                
            Random rng = new Random();                      
            Boolean Player_Up, Player_Down = false;         
            Boolean BallGoingLeft = true;                   
            Boolean GameOn = false;

            int Speed_Player;
            int Speed_Enemy;
            int Ball_Speed;
            int Ball_Force;
        public Boolean Collision_Left(PictureBox obj)
        {
            if (obj.Location.X <= 0)    
            {
                return true;
            }
            return false;
        }

        public Boolean Collision_Right(PictureBox obj)
        {
            if (obj.Location.X + obj.Width >= WorldFrame.Width) 
            {
                return true;
            }
            return false;
        } 
        public Boolean Collision_Up(PictureBox obj)
        {
                if (obj.Location.Y <= 0)    //gdy obiekt Y znajduje się poniżej ekranu
                {
                    return true;
                }
                return false;
        }

        public Boolean Collision_Down(PictureBox obj)
        {
            if (obj.Location.Y + obj.Height >= WorldFrame.Height)   //gdy znajduje sie powyżej ekranu
            {
                return true;
            }
            return false;
        }
        public Boolean Collision_Enemy(PictureBox tar)
        {
            PictureBox temp1 = new PictureBox();   
            temp1.Bounds = pb_Enemy.Bounds;         
                                                    
            temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))    
            {                                               
                Ball_Force = 3;                              
                return true;
            }
            temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 5, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))    
            {
                Ball_Force = 2;                              
                return true;
            }
            temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))    
            {
                Ball_Force = 1;
                return true;
            }
            temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))
            {
                Ball_Force = 0;
                return true;
            }
            temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))
            {
                Ball_Force = -1;
                return true;
            }
            temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))
            {
                Ball_Force = -2;
                return true;
            }
            temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))
            {
                Ball_Force = -3;
                return true;
            }
            return false;
        }
        public Boolean Collision_Player(PictureBox tar)
        {
            if (tar.Bounds.IntersectsWith(pb_Player.Bounds))    
            {
                PictureBox temp1 = new PictureBox();
                temp1.Bounds = pb_Player.Bounds;
                temp1.SetBounds(temp1.Location.X + temp1.Width, temp1.Location.Y, 1, 10);
                
                if (tar.Bounds.IntersectsWith(temp1.Bounds))    
                {
                    Ball_Force = 3;
                    return true;
                }
                temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 5, 1, 10);

                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    Ball_Force = 2;
                    return true;
                }
                temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
               
                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    Ball_Force = 1;
                    return true;
                }
                temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
              
                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    Ball_Force = 0;
                    return true;
                }
                temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
                
                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    Ball_Force = -1;
                    return true;
                }
                temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
        
                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    Ball_Force = -2;
                    return true;
                }
                temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
          
                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    Ball_Force = -3;
                    return true;
                }
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pb_ball_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Pb_rocket_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
         private void Form1_KeyDown(object sender, KeyEventArgs e)  //eventholder  z intrukcją switch dla wcisniecia klawisza 
        {                                                           // zmienia booleany Player_Up i Player_Down w przypadku wcisniecia klawisza
            switch (e.KeyCode)                                      
            {
                case Keys.W:
                case Keys.Up:
                    Player_Down = false;
                    Player_Up = true;
                    break;
                case Keys.S:
                case Keys.Down:
                    Player_Up = false;
                    Player_Down = true;
                    break;
                case Keys.Space:    //wciśniecie spacji startuje gre
                    GameOn = true;
                    LosowyStart(BallGoingLeft);
                    label_start.Visible = false;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) // instrukcja switch dla niewciśniętego klawisza
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    Player_Up = false;
                    break;
                case Keys.S:
                case Keys.Down:
                    Player_Down = false;
                    break;
            }
        }
        public void LosowyStart(Boolean x)
        {
            for (int i = 0; i < rng.Next(5, 10); i++) 
            {   
                if (x)
                {
                    x = false;
                }
                else
                {
                    x = true;
                }
            }
        }
        public int odbicie(int x, Boolean Force = false, Boolean Negative = false)
        {
            if (Force)  //Kinda overdid this, not sure why but here's how it works
            {
                if (Negative)   //If the Negative boolean is on, it's always returns a negative number
                {
                    if (x > 0)  //So if X is above 0 it changes it
                    {
                        x = ~x + 1; //Not sure how this worked, ask the guy behind you.
                    }
                }
                else
                {   //Simple math, negatives a positive number
                    x = x - (x * 2);
                }
            }
            else
            {
                if (x > 0)
                {
                    x = x - (x * 2);
                }
                else
                {
                    x = ~x + 1;
                }
            }
            return x;
        }
        public void AddScore(PictureBox[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {   //Goes through the entire array, checks where the first "non black" box is
                if (Arr[i].BackColor == ScoreColor)
                {   //And then changes it to black
                    Arr[i].BackColor = Color.Black;
                    break;
                }
            }

        }
        private void timer_MoveBall_Tick(object sender, EventArgs e)
        {
            

            if (GameOn)         
            {
                if (Player_Up && !Collision_Up(pb_Player)) //gdy gracz ma isc w góre i nie zderza sie ze scianą 
                {               
                    pb_Player.Top -= Speed_Player;    //przesuwa gracza w góre
                }
                if (Player_Down && !Collision_Down(pb_Player))
                {               // Same here but going down instead, collision at the bottom check
                    pb_Player.Top += Speed_Player;
                }

                if (Ball_Force > 0)
                {   //If BallForce is positive, it moves the ball up #ballforce pixels
                    pb_ball.Top -= Ball_Force;
                }
                if (Ball_Force < 0)
                {   //Same as above but negative
                    pb_ball.Top -= Ball_Force;
                }

                if (pb_ball.Location.Y <= 1) //gdy piłka zderzy sie ze górną scianą odibja ją z taka samą siłą
                {   
                    Ball_Force = odbicie(Ball_Force, true, true);
                }
                //gdy piłka uderzy w podłoge odbija ją
                if (pb_ball.Location.Y + pb_ball.Height >= WorldFrame.Height - 1)
                {
                    Ball_Force = odbicie(Ball_Force, true, false);
                }

                if (BallGoingLeft)  //gdy piłka leci w lewo
                {
                    if (Collision_Left(pb_ball))    //i zderzy się ze scianą 
                    {
                        AddScore(Score_Player);     //dodaje punkt dla gracza
                        pb_ball.Location = new Point(206, 67);
                        LosowyStart(BallGoingLeft);
                        Ball_Force = 0;
                    }
                    if (!Collision_Player(pb_ball)) // piłka leci dopóki sie nie zderzy ze scianą lub graczem
                    {                              
                        pb_ball.Left -= Ball_Speed;
                    }
                    else
                    {                              
                        BallGoingLeft = false;
                    }
                }
                else
                {
                    if (Collision_Right(pb_ball))  //to samo dla przeciwnika 
                    {
                        AddScore(Score_Enemy);
                        pb_ball.Location = new Point(206, 67);
                        LosowyStart(BallGoingLeft);
                        Ball_Force = 0;
                    }
                    if (!Collision_Enemy(pb_ball))
                    {
                        pb_ball.Left += Ball_Speed;
                    }
                    else
                    {
                        BallGoingLeft = true;
                    }
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
