﻿namespace pingpeng
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_rocket2 = new System.Windows.Forms.PictureBox();
            this.WorldFrame = new System.Windows.Forms.Panel();
            this.pb_ball = new System.Windows.Forms.PictureBox();
            this.pb_rocket = new System.Windows.Forms.PictureBox();
            this.player_4 = new System.Windows.Forms.PictureBox();
            this.player_3 = new System.Windows.Forms.PictureBox();
            this.player_2 = new System.Windows.Forms.PictureBox();
            this.player_1 = new System.Windows.Forms.PictureBox();
            this.enemy_1 = new System.Windows.Forms.PictureBox();
            this.enemy_2 = new System.Windows.Forms.PictureBox();
            this.enemy_3 = new System.Windows.Forms.PictureBox();
            this.enemy_4 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timerMoveBall = new System.Windows.Forms.Timer(this.components);
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_rocket2)).BeginInit();
            this.WorldFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_4)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_rocket2
            // 
            this.pb_rocket2.BackColor = System.Drawing.Color.Red;
            this.pb_rocket2.Location = new System.Drawing.Point(778, 140);
            this.pb_rocket2.Name = "pb_rocket2";
            this.pb_rocket2.Size = new System.Drawing.Size(23, 129);
            this.pb_rocket2.TabIndex = 0;
            this.pb_rocket2.TabStop = false;
            this.pb_rocket2.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // WorldFrame
            // 
            this.WorldFrame.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.WorldFrame.Controls.Add(this.pb_ball);
            this.WorldFrame.Controls.Add(this.pb_rocket);
            this.WorldFrame.Controls.Add(this.pb_rocket2);
            this.WorldFrame.Location = new System.Drawing.Point(-1, 0);
            this.WorldFrame.Name = "WorldFrame";
            this.WorldFrame.Size = new System.Drawing.Size(806, 397);
            this.WorldFrame.TabIndex = 1;
            this.WorldFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pb_ball
            // 
            this.pb_ball.BackColor = System.Drawing.Color.Black;
            this.pb_ball.Location = new System.Drawing.Point(395, 199);
            this.pb_ball.Name = "pb_ball";
            this.pb_ball.Size = new System.Drawing.Size(16, 16);
            this.pb_ball.TabIndex = 2;
            this.pb_ball.TabStop = false;
            this.pb_ball.Click += new System.EventHandler(this.Pb_ball_Click);
            // 
            // pb_rocket
            // 
            this.pb_rocket.BackColor = System.Drawing.Color.Blue;
            this.pb_rocket.Location = new System.Drawing.Point(3, 140);
            this.pb_rocket.Name = "pb_rocket";
            this.pb_rocket.Size = new System.Drawing.Size(23, 129);
            this.pb_rocket.TabIndex = 1;
            this.pb_rocket.TabStop = false;
            // 
            // player_4
            // 
            this.player_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player_4.Location = new System.Drawing.Point(258, 417);
            this.player_4.Name = "player_4";
            this.player_4.Size = new System.Drawing.Size(22, 21);
            this.player_4.TabIndex = 2;
            this.player_4.TabStop = false;
            this.player_4.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // player_3
            // 
            this.player_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player_3.Location = new System.Drawing.Point(230, 417);
            this.player_3.Name = "player_3";
            this.player_3.Size = new System.Drawing.Size(22, 21);
            this.player_3.TabIndex = 3;
            this.player_3.TabStop = false;
            // 
            // player_2
            // 
            this.player_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player_2.Location = new System.Drawing.Point(202, 417);
            this.player_2.Name = "player_2";
            this.player_2.Size = new System.Drawing.Size(22, 21);
            this.player_2.TabIndex = 3;
            this.player_2.TabStop = false;
            // 
            // player_1
            // 
            this.player_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player_1.Location = new System.Drawing.Point(174, 417);
            this.player_1.Name = "player_1";
            this.player_1.Size = new System.Drawing.Size(22, 21);
            this.player_1.TabIndex = 3;
            this.player_1.TabStop = false;
            // 
            // enemy_1
            // 
            this.enemy_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemy_1.Location = new System.Drawing.Point(500, 417);
            this.enemy_1.Name = "enemy_1";
            this.enemy_1.Size = new System.Drawing.Size(22, 21);
            this.enemy_1.TabIndex = 3;
            this.enemy_1.TabStop = false;
            // 
            // enemy_2
            // 
            this.enemy_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemy_2.Location = new System.Drawing.Point(528, 417);
            this.enemy_2.Name = "enemy_2";
            this.enemy_2.Size = new System.Drawing.Size(22, 21);
            this.enemy_2.TabIndex = 4;
            this.enemy_2.TabStop = false;
            this.enemy_2.Click += new System.EventHandler(this.PictureBox6_Click);
            // 
            // enemy_3
            // 
            this.enemy_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemy_3.Location = new System.Drawing.Point(556, 417);
            this.enemy_3.Name = "enemy_3";
            this.enemy_3.Size = new System.Drawing.Size(22, 21);
            this.enemy_3.TabIndex = 3;
            this.enemy_3.TabStop = false;
            // 
            // enemy_4
            // 
            this.enemy_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemy_4.Location = new System.Drawing.Point(584, 417);
            this.enemy_4.Name = "enemy_4";
            this.enemy_4.Size = new System.Drawing.Size(22, 21);
            this.enemy_4.TabIndex = 3;
            this.enemy_4.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(68, 417);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "PLAYER1";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(394, 417);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "PLAYER2";
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // timerMoveBall
            // 
            this.timerMoveBall.Enabled = true;
            this.timerMoveBall.Interval = 1;
            // 
            // timerEnemy
            // 
            this.timerEnemy.Enabled = true;
            this.timerEnemy.Interval = 10;
            this.timerEnemy.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enemy_4);
            this.Controls.Add(this.enemy_3);
            this.Controls.Add(this.enemy_2);
            this.Controls.Add(this.enemy_1);
            this.Controls.Add(this.player_1);
            this.Controls.Add(this.player_2);
            this.Controls.Add(this.player_3);
            this.Controls.Add(this.player_4);
            this.Controls.Add(this.WorldFrame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_rocket2)).EndInit();
            this.WorldFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_rocket2;
        private System.Windows.Forms.Panel WorldFrame;
        private System.Windows.Forms.PictureBox pb_rocket;
        private System.Windows.Forms.PictureBox pb_ball;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox player_4;
        private System.Windows.Forms.PictureBox player_3;
        private System.Windows.Forms.PictureBox player_2;
        private System.Windows.Forms.PictureBox player_1;
        private System.Windows.Forms.PictureBox enemy_1;
        private System.Windows.Forms.PictureBox enemy_2;
        private System.Windows.Forms.PictureBox enemy_3;
        private System.Windows.Forms.PictureBox enemy_4;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timerMoveBall;
        private System.Windows.Forms.Timer timerEnemy;
    }
}

