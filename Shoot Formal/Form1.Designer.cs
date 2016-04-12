namespace WindowsFormsApplication1
{
    partial class Pong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.paddle1 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.paddle2 = new System.Windows.Forms.PictureBox();
            this.one2 = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            this.one = new System.Windows.Forms.PictureBox();
            this.two2 = new System.Windows.Forms.PictureBox();
            this.two = new System.Windows.Forms.PictureBox();
            this.three2 = new System.Windows.Forms.PictureBox();
            this.three = new System.Windows.Forms.PictureBox();
            this.four2 = new System.Windows.Forms.PictureBox();
            this.four = new System.Windows.Forms.PictureBox();
            this.five2 = new System.Windows.Forms.PictureBox();
            this.five = new System.Windows.Forms.PictureBox();
            this.onePlayer = new System.Windows.Forms.PictureBox();
            this.twoPlayer = new System.Windows.Forms.PictureBox();
            this.playAgain = new System.Windows.Forms.PictureBox();
            this.winner1 = new System.Windows.Forms.PictureBox();
            this.winner2 = new System.Windows.Forms.PictureBox();
            this.easy = new System.Windows.Forms.PictureBox();
            this.medium = new System.Windows.Forms.PictureBox();
            this.hard = new System.Windows.Forms.PictureBox();
            this.time1 = new System.Windows.Forms.PictureBox();
            this.time2 = new System.Windows.Forms.PictureBox();
            this.time3 = new System.Windows.Forms.PictureBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.quit = new System.Windows.Forms.PictureBox();
            this.pause1 = new System.Windows.Forms.PictureBox();
            this.win = new System.Windows.Forms.PictureBox();
            this.lose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.one2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.two2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.three2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.three)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.four2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.four)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.five2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.five)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winner2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lose)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // paddle1
            // 
            this.paddle1.BackColor = System.Drawing.Color.White;
            this.paddle1.Location = new System.Drawing.Point(1631, 452);
            this.paddle1.Name = "paddle1";
            this.paddle1.Size = new System.Drawing.Size(21, 109);
            this.paddle1.TabIndex = 0;
            this.paddle1.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(674, 360);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(18, 18);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // paddle2
            // 
            this.paddle2.BackColor = System.Drawing.Color.White;
            this.paddle2.Location = new System.Drawing.Point(12, 322);
            this.paddle2.Name = "paddle2";
            this.paddle2.Size = new System.Drawing.Size(21, 109);
            this.paddle2.TabIndex = 3;
            this.paddle2.TabStop = false;
            // 
            // one2
            // 
            this.one2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("one2.BackgroundImage")));
            this.one2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.one2.Location = new System.Drawing.Point(330, 66);
            this.one2.Name = "one2";
            this.one2.Size = new System.Drawing.Size(57, 103);
            this.one2.TabIndex = 4;
            this.one2.TabStop = false;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line.BackgroundImage")));
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.line.Location = new System.Drawing.Point(624, -55);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(122, 1048);
            this.line.TabIndex = 5;
            this.line.TabStop = false;
            // 
            // one
            // 
            this.one.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("one.BackgroundImage")));
            this.one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.one.Location = new System.Drawing.Point(999, 66);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(53, 103);
            this.one.TabIndex = 6;
            this.one.TabStop = false;
            // 
            // two2
            // 
            this.two2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("two2.BackgroundImage")));
            this.two2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.two2.Location = new System.Drawing.Point(330, 66);
            this.two2.Name = "two2";
            this.two2.Size = new System.Drawing.Size(67, 103);
            this.two2.TabIndex = 7;
            this.two2.TabStop = false;
            // 
            // two
            // 
            this.two.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("two.BackgroundImage")));
            this.two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.two.Location = new System.Drawing.Point(999, 66);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(67, 103);
            this.two.TabIndex = 8;
            this.two.TabStop = false;
            // 
            // three2
            // 
            this.three2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("three2.BackgroundImage")));
            this.three2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.three2.Location = new System.Drawing.Point(330, 66);
            this.three2.Name = "three2";
            this.three2.Size = new System.Drawing.Size(63, 103);
            this.three2.TabIndex = 9;
            this.three2.TabStop = false;
            // 
            // three
            // 
            this.three.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("three.BackgroundImage")));
            this.three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.three.Location = new System.Drawing.Point(999, 66);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(63, 103);
            this.three.TabIndex = 10;
            this.three.TabStop = false;
            // 
            // four2
            // 
            this.four2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("four2.BackgroundImage")));
            this.four2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.four2.Location = new System.Drawing.Point(330, 66);
            this.four2.Name = "four2";
            this.four2.Size = new System.Drawing.Size(63, 103);
            this.four2.TabIndex = 11;
            this.four2.TabStop = false;
            // 
            // four
            // 
            this.four.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("four.BackgroundImage")));
            this.four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.four.Location = new System.Drawing.Point(999, 66);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(63, 103);
            this.four.TabIndex = 12;
            this.four.TabStop = false;
            // 
            // five2
            // 
            this.five2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("five2.BackgroundImage")));
            this.five2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.five2.Location = new System.Drawing.Point(330, 66);
            this.five2.Name = "five2";
            this.five2.Size = new System.Drawing.Size(63, 103);
            this.five2.TabIndex = 13;
            this.five2.TabStop = false;
            // 
            // five
            // 
            this.five.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("five.BackgroundImage")));
            this.five.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.five.Location = new System.Drawing.Point(999, 66);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(63, 103);
            this.five.TabIndex = 14;
            this.five.TabStop = false;
            // 
            // onePlayer
            // 
            this.onePlayer.BackColor = System.Drawing.Color.Transparent;
            this.onePlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("onePlayer.BackgroundImage")));
            this.onePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.onePlayer.Location = new System.Drawing.Point(807, 328);
            this.onePlayer.Name = "onePlayer";
            this.onePlayer.Size = new System.Drawing.Size(404, 103);
            this.onePlayer.TabIndex = 15;
            this.onePlayer.TabStop = false;
            // 
            // twoPlayer
            // 
            this.twoPlayer.BackColor = System.Drawing.Color.Transparent;
            this.twoPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("twoPlayer.BackgroundImage")));
            this.twoPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.twoPlayer.Location = new System.Drawing.Point(175, 328);
            this.twoPlayer.Name = "twoPlayer";
            this.twoPlayer.Size = new System.Drawing.Size(404, 103);
            this.twoPlayer.TabIndex = 16;
            this.twoPlayer.TabStop = false;
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.Color.Transparent;
            this.playAgain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playAgain.BackgroundImage")));
            this.playAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playAgain.Location = new System.Drawing.Point(508, 246);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(348, 385);
            this.playAgain.TabIndex = 17;
            this.playAgain.TabStop = false;
            // 
            // winner1
            // 
            this.winner1.BackColor = System.Drawing.Color.Transparent;
            this.winner1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("winner1.BackgroundImage")));
            this.winner1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.winner1.Location = new System.Drawing.Point(848, 276);
            this.winner1.Name = "winner1";
            this.winner1.Size = new System.Drawing.Size(395, 155);
            this.winner1.TabIndex = 18;
            this.winner1.TabStop = false;
            // 
            // winner2
            // 
            this.winner2.BackColor = System.Drawing.Color.Transparent;
            this.winner2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("winner2.BackgroundImage")));
            this.winner2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.winner2.Location = new System.Drawing.Point(157, 276);
            this.winner2.Name = "winner2";
            this.winner2.Size = new System.Drawing.Size(395, 155);
            this.winner2.TabIndex = 19;
            this.winner2.TabStop = false;
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.Transparent;
            this.easy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("easy.BackgroundImage")));
            this.easy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.easy.Location = new System.Drawing.Point(558, 235);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(269, 87);
            this.easy.TabIndex = 20;
            this.easy.TabStop = false;
            // 
            // medium
            // 
            this.medium.BackColor = System.Drawing.Color.Transparent;
            this.medium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("medium.BackgroundImage")));
            this.medium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.medium.Location = new System.Drawing.Point(470, 328);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(395, 89);
            this.medium.TabIndex = 21;
            this.medium.TabStop = false;
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Transparent;
            this.hard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hard.BackgroundImage")));
            this.hard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hard.Location = new System.Drawing.Point(534, 423);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(293, 96);
            this.hard.TabIndex = 22;
            this.hard.TabStop = false;
            // 
            // time1
            // 
            this.time1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("time1.BackgroundImage")));
            this.time1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.time1.Location = new System.Drawing.Point(651, 315);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(53, 103);
            this.time1.TabIndex = 23;
            this.time1.TabStop = false;
            // 
            // time2
            // 
            this.time2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("time2.BackgroundImage")));
            this.time2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.time2.Location = new System.Drawing.Point(644, 315);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(67, 103);
            this.time2.TabIndex = 24;
            this.time2.TabStop = false;
            // 
            // time3
            // 
            this.time3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("time3.BackgroundImage")));
            this.time3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.time3.Location = new System.Drawing.Point(646, 315);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(63, 103);
            this.time3.TabIndex = 25;
            this.time3.TabStop = false;
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.Transparent;
            this.quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quit.BackgroundImage")));
            this.quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.quit.Location = new System.Drawing.Point(600, 637);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(155, 56);
            this.quit.TabIndex = 26;
            this.quit.TabStop = false;
            // 
            // pause1
            // 
            this.pause1.BackColor = System.Drawing.Color.Transparent;
            this.pause1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pause1.BackgroundImage")));
            this.pause1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pause1.Location = new System.Drawing.Point(531, 318);
            this.pause1.Name = "pause1";
            this.pause1.Size = new System.Drawing.Size(293, 96);
            this.pause1.TabIndex = 27;
            this.pause1.TabStop = false;
            // 
            // win
            // 
            this.win.BackColor = System.Drawing.Color.Transparent;
            this.win.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("win.BackgroundImage")));
            this.win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.win.Location = new System.Drawing.Point(397, 345);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(404, 103);
            this.win.TabIndex = 28;
            this.win.TabStop = false;
            // 
            // lose
            // 
            this.lose.BackColor = System.Drawing.Color.Transparent;
            this.lose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lose.BackgroundImage")));
            this.lose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lose.Location = new System.Drawing.Point(452, 384);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(404, 103);
            this.lose.TabIndex = 29;
            this.lose.TabStop = false;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 770);
            this.Controls.Add(this.lose);
            this.Controls.Add(this.win);
            this.Controls.Add(this.pause1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.time3);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.twoPlayer);
            this.Controls.Add(this.five);
            this.Controls.Add(this.five2);
            this.Controls.Add(this.four);
            this.Controls.Add(this.four2);
            this.Controls.Add(this.three);
            this.Controls.Add(this.three2);
            this.Controls.Add(this.two);
            this.Controls.Add(this.two2);
            this.Controls.Add(this.one);
            this.Controls.Add(this.paddle2);
            this.Controls.Add(this.paddle1);
            this.Controls.Add(this.one2);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.onePlayer);
            this.Controls.Add(this.winner1);
            this.Controls.Add(this.winner2);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.line);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.one2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.one)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.two2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.three2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.three)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.four2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.four)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.five2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.five)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winner2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox paddle1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox paddle2;
        private System.Windows.Forms.PictureBox one2;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.PictureBox one;
        private System.Windows.Forms.PictureBox two2;
        private System.Windows.Forms.PictureBox two;
        private System.Windows.Forms.PictureBox three2;
        private System.Windows.Forms.PictureBox three;
        private System.Windows.Forms.PictureBox four2;
        private System.Windows.Forms.PictureBox four;
        private System.Windows.Forms.PictureBox five2;
        private System.Windows.Forms.PictureBox five;
        private System.Windows.Forms.PictureBox onePlayer;
        private System.Windows.Forms.PictureBox twoPlayer;
        private System.Windows.Forms.PictureBox playAgain;
        private System.Windows.Forms.PictureBox winner1;
        private System.Windows.Forms.PictureBox winner2;
        private System.Windows.Forms.PictureBox easy;
        private System.Windows.Forms.PictureBox medium;
        private System.Windows.Forms.PictureBox hard;
        private System.Windows.Forms.PictureBox time1;
        private System.Windows.Forms.PictureBox time2;
        private System.Windows.Forms.PictureBox time3;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PictureBox quit;
        private System.Windows.Forms.PictureBox pause1;
        private System.Windows.Forms.PictureBox win;
        private System.Windows.Forms.PictureBox lose;
    }
}

