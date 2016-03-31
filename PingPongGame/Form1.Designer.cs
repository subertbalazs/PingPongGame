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
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.racket = new System.Windows.Forms.PictureBox();
            this.asztal = new System.Windows.Forms.PictureBox();
            this.action_lbl = new System.Windows.Forms.Label();
            this.pause_lbl = new System.Windows.Forms.Label();
            this.ball = new OvalPictureBox();
            this.playground.SuspendLayout();
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
            this.points_lbl.ForeColor = System.Drawing.Color.Red;
            this.points_lbl.Location = new System.Drawing.Point(186, 9);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(52, 54);
            this.points_lbl.TabIndex = 5;
            this.points_lbl.Text = "0";
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.playground.Size = new System.Drawing.Size(1362, 741);
            this.playground.TabIndex = 2;
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.playground_Paint);
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.BackColor = System.Drawing.Color.White;
            this.gameover_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameover_lbl.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameover_lbl.ForeColor = System.Drawing.Color.Red;
            this.gameover_lbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gameover_lbl.Location = new System.Drawing.Point(657, 462);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(286, 56);
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
            this.asztal.Location = new System.Drawing.Point(-47, -383);
            this.asztal.Name = "asztal";
            this.asztal.Size = new System.Drawing.Size(1320, 1024);
            this.asztal.TabIndex = 7;
            this.asztal.TabStop = false;
            // 
            // action_lbl
            // 
            this.action_lbl.AutoSize = true;
            this.action_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.action_lbl.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.action_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.action_lbl.Location = new System.Drawing.Point(560, 523);
            this.action_lbl.Name = "action_lbl";
            this.action_lbl.Size = new System.Drawing.Size(350, 84);
            this.action_lbl.TabIndex = 9;
            this.action_lbl.Text = "Enter - Restart\r\nEsc - Exit";
            // 
            // pause_lbl
            // 
            this.pause_lbl.AutoSize = true;
            this.pause_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pause_lbl.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pause_lbl.ForeColor = System.Drawing.Color.Green;
            this.pause_lbl.Location = new System.Drawing.Point(546, 250);
            this.pause_lbl.Name = "pause_lbl";
            this.pause_lbl.Size = new System.Drawing.Size(170, 56);
            this.pause_lbl.TabIndex = 10;
            this.pause_lbl.Text = "Pause";
            // 
            // ball
            // 
            this.ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = global::PingPongGame.Properties.Resources.labda1;
            this.ball.Location = new System.Drawing.Point(546, 310);
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
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
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
    }
}

