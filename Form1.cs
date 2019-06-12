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
            if (obj.Location.Y <= 0)    //If the objs Y coordinate is above the screen
            {
                return true;
            }
            return false;
        }

        public Boolean Collision_Down(PictureBox obj)
        {
            if (obj.Location.Y + obj.Height >= WorldFrame.Height)   //If the Obj is below the screen
            {
                return true;
            }
            return false;
        }
        public Boolean Collision_Player(PictureBox obj)
        {
            if ()
            {
            }
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
       
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
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
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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

        private void timer_MoveBall_Tick(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
