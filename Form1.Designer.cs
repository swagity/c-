namespace pingpeng
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
            this.pb_Enemy = new System.Windows.Forms.PictureBox();
            this.WorldFrame = new System.Windows.Forms.Panel();
            this.pb_ball = new System.Windows.Forms.PictureBox();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.player_4 = new System.Windows.Forms.PictureBox();
            this.player_3 = new System.Windows.Forms.PictureBox();
            this.player_2 = new System.Windows.Forms.PictureBox();
            this.player_1 = new System.Windows.Forms.PictureBox();
            this.enemy_1 = new System.Windows.Forms.PictureBox();
            this.enemy_2 = new System.Windows.Forms.PictureBox();
            this.enemy_3 = new System.Windows.Forms.PictureBox();
            this.enemy_4 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer_MoveBall = new System.Windows.Forms.Timer(this.components);
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            this.label_start = new System.Windows.Forms.Label();
            this.timer_Sec = new System.Windows.Forms.Timer(this.components);
            this.label_Time = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Enemy)).BeginInit();
            this.WorldFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_4)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Enemy
            // 
            this.pb_Enemy.BackColor = System.Drawing.Color.Red;
            this.pb_Enemy.Location = new System.Drawing.Point(778, 140);
            this.pb_Enemy.Name = "pb_Enemy";
            this.pb_Enemy.Size = new System.Drawing.Size(23, 129);
            this.pb_Enemy.TabIndex = 0;
            this.pb_Enemy.TabStop = false;
            this.pb_Enemy.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // WorldFrame
            // 
            this.WorldFrame.BackColor = System.Drawing.SystemColors.Highlight;
            this.WorldFrame.Controls.Add(this.pb_ball);
            this.WorldFrame.Controls.Add(this.pb_Player);
            this.WorldFrame.Controls.Add(this.pb_Enemy);
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
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Blue;
            this.pb_Player.Location = new System.Drawing.Point(3, 140);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(23, 129);
            this.pb_Player.TabIndex = 1;
            this.pb_Player.TabStop = false;
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
            // timer_MoveBall
            // 
            this.timer_MoveBall.Enabled = true;
            this.timer_MoveBall.Interval = 1;
            this.timer_MoveBall.Tick += new System.EventHandler(this.timer_MoveBall_Tick);
            // 
            // timerEnemy
            // 
            this.timerEnemy.Enabled = true;
            this.timerEnemy.Interval = 10;
            this.timerEnemy.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Location = new System.Drawing.Point(329, 416);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(27, 13);
            this.label_start.TabIndex = 5;
            this.label_start.Text = "start";
            this.label_start.Click += new System.EventHandler(this.Label1_Click);
            // 
            // timer_Sec
            // 
            this.timer_Sec.Tick += new System.EventHandler(this.Timer_Sec_Tick);
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(394, 416);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(35, 13);
            this.label_Time.TabIndex = 6;
            this.label_Time.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_start);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_Enemy)).EndInit();
            this.WorldFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_4)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Enemy;
        private System.Windows.Forms.Panel WorldFrame;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.PictureBox pb_ball;
        private System.Windows.Forms.PictureBox player_4;
        private System.Windows.Forms.PictureBox player_3;
        private System.Windows.Forms.PictureBox player_2;
        private System.Windows.Forms.PictureBox player_1;
        private System.Windows.Forms.PictureBox enemy_1;
        private System.Windows.Forms.PictureBox enemy_2;
        private System.Windows.Forms.PictureBox enemy_3;
        private System.Windows.Forms.PictureBox enemy_4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer_MoveBall;
        private System.Windows.Forms.Timer timerEnemy;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Timer timer_Sec;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

