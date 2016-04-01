using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Form1 : Form
    {
        public int speed_left = 1;
        public int speed_top = 4;
        public int points = 0;
        public bool isPasused = false;



        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            racket.Top = playground.Bottom - (playground.Bottom / 7);
            gameover_lbl.Left = (playground.Width / 2) - (gameover_lbl.Width / 2);
            gameover_lbl.Top = (playground.Height / 3) - (gameover_lbl.Height / 3);
            action_lbl.Left = (playground.Width / 2) - (action_lbl.Width / 2);
            action_lbl.Top = (playground.Height /2) - (action_lbl.Height / 2);
            pause_lbl.Left = (playground.Width / 2) - (pause_lbl.Width / 2);
            pause_lbl.Top = (playground.Height / 3) - (pause_lbl.Height / 3);
            gameover_lbl.Visible = false;
            action_lbl.Visible = false;
            pause_lbl.Visible = false;
            advanced_lbl.Visible = false;
            hard_lbl.Visible = false;
            insane_lbl.Visible = false;
            holy_lbl.Visible = false;
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            star4.Visible = false;
            progressBar1.Maximum = 5;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
           
        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += speed_left;
            ball.Top += speed_top;

            if(ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                IncrementProgressBar();
                points_lbl.Text = points.ToString();
                if(points >= 5 && points < 10)
                {
                    basic_lbl.Visible = false;
                    advanced_lbl.Visible = true;
                    star1.Visible = true;
                }

                if(points >= 10 && points < 15)
                {
                    advanced_lbl.Visible = false;
                    hard_lbl.Visible = true;
                    star2.Visible = true;
                }
                if(points >= 15 && points < 20)
                {
                    hard_lbl.Visible = false;
                    insane_lbl.Visible = true;
                    star3.Visible = true;
                }
                if(points >= 20)
                {
                    insane_lbl.Visible = false;
                    holy_lbl.Visible = true;
                    star4.Visible = true;
                    progressBar1.Visible = false;
                }
            }

            if(ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if(ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if(ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                gameover_lbl.Visible = true;
                action_lbl.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) { this.Close(); }
            if(e.KeyCode == Keys.Enter)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                points_lbl.Text = "0";
                timer1.Enabled = true;
                gameover_lbl.Visible = false;
                action_lbl.Visible = false;
                pause_lbl.Visible = false;
                basic_lbl.Visible = true;
                advanced_lbl.Visible = false;
                hard_lbl.Visible = false;
                insane_lbl.Visible = false;
                holy_lbl.Visible = false;
                star1.Visible = false;
                star2.Visible = false;
                star3.Visible = false;
                star4.Visible = false;


            }
            if(e.KeyCode == Keys.Space)
            {
                if(isPasused)
                {
                    timer1.Enabled = true;
                    pause_lbl.Visible = false;
                    isPasused = false;
                }
                else
                {
                isPasused = true;
                timer1.Enabled = false;
                pause_lbl.Visible = true;
                }
            }
        }

        private void IncrementProgressBar()
        {
            progressBar1.Value += 1;
            if(progressBar1.Value == 5)
            {
                progressBar1.Value = 0;
            }
        }

        private void playground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void star1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
