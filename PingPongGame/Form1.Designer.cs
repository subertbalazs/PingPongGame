namespace PingPongGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.points_lbl = new System.Windows.Forms.Label();
            this.playground = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.holy_lbl = new System.Windows.Forms.Label();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.insane_lbl = new System.Windows.Forms.Label();
            this.hard_lbl = new System.Windows.Forms.Label();
            this.advanced_lbl = new System.Windows.Forms.Label();
            this.basic_lbl = new System.Windows.Forms.Label();
            this.pause_lbl = new System.Windows.Forms.Label();
            this.action_lbl = new System.Windows.Forms.Label();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.racket = new System.Windows.Forms.PictureBox();
            this.asztal = new System.Windows.Forms.PictureBox();
            this.ball = new OvalPictureBox();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asztal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(197, 54);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score:";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.points_lbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.points_lbl.Location = new System.Drawing.Point(186, 9);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(52, 54);
            this.points_lbl.TabIndex = 5;
            this.points_lbl.Text = "0";
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.playground.Controls.Add(this.progressBar1);
            this.playground.Controls.Add(this.holy_lbl);
            this.playground.Controls.Add(this.star4);
            this.playground.Controls.Add(this.star3);
            this.playground.Controls.Add(this.star2);
            this.playground.Controls.Add(this.star1);
            this.playground.Controls.Add(this.insane_lbl);
            this.playground.Controls.Add(this.hard_lbl);
            this.playground.Controls.Add(this.advanced_lbl);
            this.playground.Controls.Add(this.basic_lbl);
            this.playground.Controls.Add(this.pause_lbl);
            this.playground.Controls.Add(this.action_lbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.gameover_lbl);
            this.playground.Controls.Add(this.points_lbl);
            this.playground.Controls.Add(this.Score);
            this.playground.Controls.Add(this.racket);
            this.playground.Controls.Add(this.asztal);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Margin = new System.Windows.Forms.Padding(5);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1354, 733);
            this.playground.TabIndex = 2;
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.playground_Paint);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar1.Location = new System.Drawing.Point(21, 131);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(159, 23);
            this.progressBar1.Step = 5;
            this.progressBar1.TabIndex = 21;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // holy_lbl
            // 
            this.holy_lbl.AutoSize = true;
            this.holy_lbl.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.holy_lbl.Location = new System.Drawing.Point(27, 63);
            this.holy_lbl.Name = "holy_lbl";
            this.holy_lbl.Size = new System.Drawing.Size(166, 23);
            this.holy_lbl.TabIndex = 20;
            this.holy_lbl.Text = "Holy Sh*t!!!";
            // 
            // star4
            // 
            this.star4.Image = global::PingPongGame.Properties.Resources.star;
            this.star4.Location = new System.Drawing.Point(145, 89);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(35, 35);
            this.star4.TabIndex = 18;
            this.star4.TabStop = false;
            // 
            // star3
            // 
            this.star3.Image = global::PingPongGame.Properties.Resources.star;
            this.star3.Location = new System.Drawing.Point(103, 89);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(35, 35);
            this.star3.TabIndex = 17;
            this.star3.TabStop = false;
            // 
            // star2
            // 
            this.star2.Image = global::PingPongGame.Properties.Resources.star;
            this.star2.Location = new System.Drawing.Point(62, 89);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(35, 35);
            this.star2.TabIndex = 16;
            this.star2.TabStop = false;
            // 
            // star1
            // 
            this.star1.Image = global::PingPongGame.Properties.Resources.star;
            this.star1.Location = new System.Drawing.Point(21, 89);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(35, 35);
            this.star1.TabIndex = 15;
            this.star1.TabStop = false;
            this.star1.Click += new System.EventHandler(this.star1_Click);
            // 
            // insane_lbl
            // 
            this.insane_lbl.AutoSize = true;
            this.insane_lbl.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.insane_lbl.Location = new System.Drawing.Point(17, 63);
            this.insane_lbl.Name = "insane_lbl";
            this.insane_lbl.Size = new System.Drawing.Size(166, 23);
            this.insane_lbl.TabIndex = 14;
            this.insane_lbl.Text = "Insane Level";
            // 
            // hard_lbl
            // 
            this.hard_lbl.AutoSize = true;
            this.hard_lbl.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hard_lbl.Location = new System.Drawing.Point(27, 63);
            this.hard_lbl.Name = "hard_lbl";
            this.hard_lbl.Size = new System.Drawing.Size(140, 23);
            this.hard_lbl.TabIndex = 13;
            this.hard_lbl.Text = "Hard level";
            // 
            // advanced_lbl
            // 
            this.advanced_lbl.AutoSize = true;
            this.advanced_lbl.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.advanced_lbl.Location = new System.Drawing.Point(27, 63);
            this.advanced_lbl.Name = "advanced_lbl";
            this.advanced_lbl.Size = new System.Drawing.Size(192, 23);
            this.advanced_lbl.TabIndex = 12;
            this.advanced_lbl.Text = "Advanced level";
            // 
            // basic_lbl
            // 
            this.basic_lbl.AutoSize = true;
            this.basic_lbl.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.basic_lbl.Location = new System.Drawing.Point(27, 63);
            this.basic_lbl.Name = "basic_lbl";
            this.basic_lbl.Size = new System.Drawing.Size(153, 23);
            this.basic_lbl.TabIndex = 11;
            this.basic_lbl.Text = "Basic level";
            // 
            // pause_lbl
            // 
            this.pause_lbl.AutoSize = true;
            this.pause_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pause_lbl.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pause_lbl.ForeColor = System.Drawing.Color.Green;
            this.pause_lbl.Location = new System.Drawing.Point(546, 250);
            this.pause_lbl.Name = "pause_lbl";
            this.pause_lbl.Size = new System.Drawing.Size(199, 56);
            this.pause_lbl.TabIndex = 10;
            this.pause_lbl.Text = "Paused";
            // 
            // action_lbl
            // 
            this.action_lbl.AutoSize = true;
            this.action_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.action_lbl.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.action_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.action_lbl.Location = new System.Drawing.Point(560, 523);
            this.action_lbl.Name = "action_lbl";
            this.action_lbl.Size = new System.Drawing.Size(460, 84);
            this.action_lbl.TabIndex = 9;
            this.action_lbl.Text = "Press Enter to retry\r\nPress Esc to Quit";
            this.action_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.BackColor = System.Drawing.Color.White;
            this.gameover_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameover_lbl.Font = new System.Drawing.Font("Courier New", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameover_lbl.ForeColor = System.Drawing.Color.Red;
            this.gameover_lbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gameover_lbl.Location = new System.Drawing.Point(653, 454);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(571, 112);
            this.gameover_lbl.TabIndex = 6;
            this.gameover_lbl.Text = "Game Over";
            this.gameover_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameover_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racket.Image = global::PingPongGame.Properties.Resources.uto2;
            this.racket.Location = new System.Drawing.Point(107, 288);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(297, 97);
            this.racket.TabIndex = 2;
            this.racket.TabStop = false;
            // 
            // asztal
            // 
            this.asztal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.asztal.Image = global::PingPongGame.Properties.Resources.tablepingpong011;
            this.asztal.Location = new System.Drawing.Point(-51, -383);
            this.asztal.Name = "asztal";
            this.asztal.Size = new System.Drawing.Size(1320, 1024);
            this.asztal.TabIndex = 7;
            this.asztal.TabStop = false;
            // 
            // ball
            // 
            this.ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = global::PingPongGame.Properties.Resources.labda1;
            this.ball.Location = new System.Drawing.Point(542, 306);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(26, 29);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ball.TabIndex = 8;
            this.ball.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asztal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label gameover_lbl;
        private System.Windows.Forms.PictureBox asztal;
        private OvalPictureBox ball;
        private System.Windows.Forms.Label action_lbl;
        private System.Windows.Forms.Label pause_lbl;
        private System.Windows.Forms.Label basic_lbl;
        private System.Windows.Forms.Label advanced_lbl;
        private System.Windows.Forms.Label hard_lbl;
        private System.Windows.Forms.Label insane_lbl;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox star4;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.Label holy_lbl;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

