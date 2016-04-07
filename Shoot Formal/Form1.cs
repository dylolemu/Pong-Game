using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Pong : Form
    {

        public Pong()
        {
            InitializeComponent();
            TopMost = true;
            main = true;
            one.Hide();
            one2.Hide();
            two.Hide();
            two2.Hide();
            three.Hide();
            three2.Hide();
            four.Hide();
            four2.Hide();
            five.Hide();
            five2.Hide();
            easy.Hide();
            medium.Hide();
            hard.Hide();
            playAgain.Hide();
            pause1.Hide();
            winner1.Hide();
            winner2.Hide();
            time1.Hide();
            time2.Hide();
            time3.Hide();
            quit.Hide();
            quit.Location = new Point(this.Width / 2 - quit.Width / 2, this.Height - quit.Height * 3);
            pause1.Location = new Point(this.Width/2 - pause1.Width / 2, this.Height/2 - pause1.Height / 2);
            paddle1.Location = new Point(15, this.Height / 2 - paddle1.Height / 2);
            paddle2.Location = new Point(this.Width - paddle2.Width - 15, this.Height / 2 - paddle2.Height / 2);
            ball.Location = new Point(this.Width / 2 - ball.Width / 2, this.Height / 2 - ball.Height / 2);
            line.Location = new Point(this.Width / 2 - line.Width / 2 + 3, this.Height / 2 - line.Height / 2);
            twoPlayer.Location = new Point((this.Width / 4 * 3) - (twoPlayer.Width / 2), this.Height / 2 - twoPlayer.Height / 2);
            onePlayer.Location = new Point(this.Width / 4 - onePlayer.Width / 2, this.Height / 2 - onePlayer.Height / 2);
            easy.Location = new Point(this.Width / 2 - easy.Width / 2, this.Height * 1 / 3 - easy.Height / 2);
            medium.Location = new Point(this.Width / 2 - medium.Width / 2, this.Height / 2 - medium.Height / 2);
            hard.Location = new Point(this.Width / 2 - hard.Width / 2, this.Height * 2 / 3 - hard.Height / 2);
            time1.Location = new Point(this.Width / 2 - time1.Width / 2, this.Height / 2 - time1.Height / 2);
            time2.Location = new Point(this.Width / 2 - time2.Width / 2, this.Height / 2 - time2.Height / 2);
            time3.Location = new Point(this.Width / 2 - time3.Width / 2, this.Height / 2 - time3.Height / 2);
            winner1.Location = new Point(this.Width / 4 - winner1.Width / 2, this.Height / 2 - winner1.Height / 2);
            winner2.Location = new Point(this.Width / 4 * 3 - winner2.Width / 2, this.Height / 2 - winner2.Height / 2);
            one.Location = new Point((this.Width / 4 * 3) - (one.Width / 2), 66);
            two.Location = new Point((this.Width / 4 * 3) - (two.Width / 2), 66);
            three.Location = new Point((this.Width / 4 * 3) - (three.Width / 2), 66);
            four.Location = new Point((this.Width / 4 * 3) - (four.Width / 2), 66);
            five.Location = new Point((this.Width / 4 * 3) - (five.Width / 2), 66);
            one2.Location = new Point(this.Width / 4 - one2.Width / 2, 66);
            two2.Location = new Point(this.Width / 4 - two2.Width / 2, 66);
            three2.Location = new Point(this.Width / 4 - three2.Width / 2, 66);
            four2.Location = new Point(this.Width / 4 - four2.Width / 2, 66);
            five2.Location = new Point(this.Width / 4 - five2.Width / 2, 66);
        }
        bool main,levels,pause = false;
        bool upc, downc = false;
        bool upc2, downc2 = false;
        bool canUp, canDown, bcanUp, bcanDown = false;
        bool Stwo, Sone, Sthree, Sfour, Sfive = false;
        bool Stwo2, Sone2, Sthree2, Sfour2, Sfive2 = false;
        bool start = false;
        bool twoPlayers = false;
        bool easyLevel, mediumLevel, hardLevel = false;
        bool restart = false;
        int add;
        Random randNum = new Random();
        int angleX, angleY;
        int x, y;
        int x1, y1;
        int x2, y2;
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (main == true)
                {
                    this.Close();
                }
                else if (pause == false)
                {
                    pause1.Show();
                    pause = true;
                    quit.Show();
                }
                else
                {
                    quit.Hide();
                    pause1.Hide();
                    pause = false;
                }
            }
           
            if (e.KeyCode == Keys.Up)
            {
                upc = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                downc = true;
            }
            if (e.KeyCode == Keys.W)
            {
                upc2 = true;
            }
            if (e.KeyCode == Keys.S)
            {
                downc2 = true;
            }
            if (restart == true)
            {
                winner2.Location = new Point(2000, 1000);
                winner1.Location = new Point(2000, 1000);
                ball.Location = new Point(this.Width / 2 - ball.Width / 2 -6, this.Height / 2 - ball.Height / 2 +15);
                    paddle2.Location = new Point(this.Width - paddle2.Width - 15, this.Height / 2 - paddle2.Height / 2);
                    paddle1.Location = new Point(15, this.Height / 2 - paddle1.Height / 2);
                    Sfive = false;
                    Sfive2 = false;
                    Sfour = false;
                    Sfour2 = false;
                    Sthree = false;
                    Sthree2 = false;
                    Stwo = false;
                    Stwo2 = false;
                    Sone = false;
                    Sone2 = false;
                    onePlayer.Show();
                    twoPlayer.Show();
                    five.Hide();
                    five2.Hide();
                    one.Hide();
                    one2.Hide();
                    two.Hide();
                    two2.Hide();
                    three.Hide();
                    three2.Hide();
                    four.Hide();
                    four2.Hide();
                    winner1.Hide();
                    winner2.Hide();
                    winner1.Location = new Point(this.Width / 4 - winner1.Width / 2, this.Height / 2 - winner1.Height / 2);
                    winner2.Location = new Point(this.Width / 4 * 3 - winner2.Width / 2, this.Height / 2 - winner2.Height / 2);
                    restart = false;
                    start = false;
                    main = true;
            }
            if (pause == true)
            {
                //close game
                if (e.KeyCode == Keys.M)
                {
                    this.Close();
                }
            }
            if (main == true)//can only be clicked in main screen
            {
                //one player
                if (e.KeyCode == Keys.B)
                {
                    main = false;
                    twoPlayers = false;
                    onePlayer.Hide();
                    twoPlayer.Hide();
                    easy.Show();
                    medium.Show();
                    hard.Show();
                    levels = true;
                }
                //two player
                if (e.KeyCode == Keys.M)
                {
                    main = false;
                    twoPlayers = true;
                    onePlayer.Hide();
                    twoPlayer.Hide();
                    start = true;
                    easyLevel = false;
                    mediumLevel = false;
                    hardLevel = false;
                    levels = false;
                }
            }
                if(levels ==true)
            { 
                //easy mode
                if (e.KeyCode == Keys.N)
                {
                    twoPlayers = false;
                    start = true;
                    easyLevel = true;
                    easy.Hide();
                    medium.Hide();
                    hard.Hide();
                }
                //medium mode
                if (e.KeyCode == Keys.M)
                {
                    twoPlayers = false;
                    mediumLevel = true;
                    easy.Hide();
                    medium.Hide();
                    hard.Hide();
                    start = true;
                }
                //hard mode
                if (e.KeyCode == Keys.Space)
                {
                    twoPlayers = false;
                    hardLevel = true;
                    easy.Hide();
                    medium.Hide();
                    hard.Hide();
                    start = true;
                }
            }
            if (start == true)
            {
                add = 0;
                angleX = randNum.Next(10, 17);
                angleY = randNum.Next(10, 17);
                label1.Text = "";
                paddle2.Location = new Point(this.Width - paddle2.Width - 25, this.Height / 2 - paddle2.Height / 2);
                paddle1.Location = new Point(15, this.Height / 2 - paddle1.Height / 2);
                //countdown for game start
                for (int i = 1; i <= 4; i++)
                {
                    Refresh();
                    Thread.Sleep(800);
                    ball.Location = new Point(this.Width / 2 - ball.Width / 2, this.Height / 2 - ball.Height / 2);
                    if (i == 1)
                    {
                        time3.Show();
                    }
                    if (i == 2)
                    {
                        time2.Show();
                        time3.Hide();
                    }
                    if (i == 3)
                    {
                        time2.Hide();
                        time1.Show();
                    }
                    if (i == 4)
                    {
                        time1.Hide();
                    }
                }
                //Score
                if (Sone == true && Stwo != true && Sthree != true && Sfour != true)
                {
                    Stwo = true;
                }
                if (Sone2 == true && Stwo2 != true && Sthree2 != true && Sfour2 != true)
                {
                    Stwo2 = true;
                }
                if (Stwo == true && Sone != true)
                {
                    Sthree = true;
                }
                if (Stwo2 == true && Sone2 != true)
                {
                    Sthree2 = true;
                }
                if (Sthree == true && Stwo != true)
                {
                    Sfour = true;
                }
                if (Sthree2 == true && Stwo2 != true)
                {
                    Sfour2 = true;
                }
                if (Sfour == true && Sthree != true)
                {
                    Sfive = true;
                }
                if (Sfour2 == true && Sthree2 != true)
                {
                    Sfive2 = true;
                }
                if (angleX == 10 || angleX == 14)
                {
                    canUp = true;
                    canDown = false;
                    bcanUp = false;
                    bcanDown = false;
                }
                if (angleX == 11 || angleX == 15)
                {
                    canDown = true;
                    canUp = false;
                    bcanUp = false;
                    bcanDown = false;
                }
                if (angleX == 12 || angleX == 16)
                {
                    bcanUp = true;
                    canDown = false;
                    canUp = false;
                    bcanDown = false;
                }
                if (angleX == 13 || angleX == 17)
                {
                    bcanDown = true;
                    canDown = false;
                    bcanUp = false;
                    canUp = false;
                }
                start = false;
            }

        }


        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Up)
            {
                upc = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                downc = false;
            }
            if (e.KeyCode == Keys.W)
            {
                upc2 = false;
            }
            if (e.KeyCode == Keys.S)
            {
                downc2 = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = paddle1.Location.X;
            y = paddle1.Location.Y;
            x2 = paddle2.Location.X;
            y2 = paddle2.Location.Y;
            x1 = ball.Location.X;
            y1 = ball.Location.Y;
            if (pause == false)
            {
                //paddle movements
                if (upc == true)
                {
                    y -= 15;
                }
                if (downc == true)
                {
                    y += 15;
                }
                //second player movement
                if (twoPlayers == true)
                {
                    if (upc2 == true)
                    {
                        y2 -= 15;
                    }
                    if (downc2 == true)
                    {
                        y2 += 15;
                    }
                }
                //computer controlled
                else
                {
                    if (easyLevel == true)
                    {
                        if (y2 < y1 - 40)
                        {
                            y2 += 15;
                        }
                        if (y2 > y1 - 40)
                        {
                            y2 -= 15;
                        }
                    }
                    if (mediumLevel == true)
                    {
                        if (y2 < y1 - 40)
                        {
                            y2 += 22;
                        }
                        if (y2 > y1 - 40)
                        {
                            y2 -= 22;
                        }
                    }
                    if (hardLevel == true)
                    {
                        if (y2 < y1 - 40)
                        {
                            y2 += 33;
                        }
                        if (y2 > y1 - 40)
                        {
                            y2 -= 33;
                        }
                    }
                }
                //ball movements
                if (canUp == true)
                {
                    if (y1 > 0)
                    {
                        x1 += angleX + add;
                        y1 -= angleY + add;
                        if (y1 <= 0)
                        {
                            canUp = false;
                            canDown = true;
                            if (hardLevel == true)
                            {
                                angleX = randNum.Next(16, 20);
                                angleY = randNum.Next(16, 20);
                            }
                        }
                    }
                }
                if (canDown == true)
                {
                    if (y1 < this.Height - ball.Height)
                    {
                        x1 += angleX + add;
                        y1 += angleY + add;
                        if (y1 >= this.Height - ball.Height)
                        {
                            canDown = false;
                            canUp = true;
                            if (hardLevel == true)
                            {
                                angleX = randNum.Next(21, 25);
                                angleY = randNum.Next(21, 25);
                            }
                        }
                    }
                }
                if (bcanUp == true)
                {
                    if (y1 > 0)
                    {
                        x1 -= angleX + add;
                        y1 -= angleY + add;
                        if (y1 <= 0)
                        {
                            bcanUp = false;
                            bcanDown = true;
                            if (hardLevel == true)
                            {
                                angleX = randNum.Next(16, 20);
                                angleY = randNum.Next(16, 20);
                            }
                        }
                    }
                }
                if (bcanDown == true)
                {
                    if (y1 < this.Height - ball.Height)
                    {
                        x1 -= angleX + add;
                        y1 += angleY + add;
                        if (y1 >= this.Height - ball.Height)
                        {
                            bcanDown = false;
                            bcanUp = true;
                            if (hardLevel == true)
                            {
                                angleX = randNum.Next(21, 25);
                                angleY = randNum.Next(21, 25);
                            }
                        }
                    }
                }
                label1.Text = Convert.ToString(angleX);
                label1.Text += Convert.ToString(angleY);
                label1.Text += Convert.ToString(add);
                //making contact with paddle2
                if (x1 <= x2 + 20 && x1 >= x2 - 33 && y1 >= y2-2 && y1 <= y2 + 111)
                {
                    if (twoPlayers == true)
                    {
                        add += 3;
                    }
                    if (easyLevel == true)
                    {
                        add += 1;
                    }
                    if (mediumLevel == true)
                    {
                        add += 3;
                    }
                    if (hardLevel == true)
                    {
                        add += 4;
                    }
                    if (canUp == true)
                    {
                        label1.Text = "UP";
                        bcanUp = true;
                    }
                    if (canDown == true)
                    {
                        label1.Text = "DOWN";
                        bcanDown = true;
                    }
                    canDown = false;
                    canUp = false;
                }
                //making contact with paddle1
                if (x1 >= x - 20 && x1 <= x + 33 && y1 >= y-2 && y1 <= y + 111)
                {
                    if (twoPlayers == true)
                    {
                        add += 3;
                    }
                    if (easyLevel == true)
                    {
                        add += 1;
                    }
                    if (mediumLevel == true)
                    {
                        add += 3;
                    }
                    if (hardLevel == true)
                    {
                        add += 4;
                    }
                    if (bcanUp == true)
                    {
                        label1.Text = "UP";
                        canUp = true;
                    }
                    if (bcanDown == true)
                    {
                        label1.Text = "DOWN";
                        canDown = true;
                    }
                    bcanDown = false;
                    bcanUp = false;
                }
                //paddle1 borders
                if (y <= 0)
                {
                    y = 0;
                }
                if (y >= this.Height - paddle1.Height)
                {
                    y = this.Height - paddle1.Height;
                }
                //paddle2 borders
                if (y2 <= 0)
                {
                    y2 = 0;
                }
                if (y2 >= this.Height - paddle2.Height)
                {
                    y2 = this.Height - paddle2.Height;
                }
                //scoring
                if (x1 > this.Width)
                {
                    start = true;
                    one2.Show();
                    Sone = true;
                    canDown = false;
                    canUp = false;
                    bcanDown = false;
                    bcanUp = false;
                }
                if (x1 < -20)
                {
                    start = true;
                    one.Show();
                    Sone2 = true;
                    canDown = false;
                    canUp = false;
                    bcanDown = false;
                    bcanUp = false;
                }
                if (x1 > this.Width && Stwo == true)
                {
                    start = true;
                    two2.Show();
                    one2.Hide();
                    Sone = false;
                }
                if (x1 < -20 && Stwo2 == true)
                {
                    start = true;
                    two.Show();
                    one.Hide();
                    Sone2 = false;

                }
                if (x1 > this.Width && Sthree == true)
                {
                    start = true;
                    three2.Show();
                    two2.Hide();
                    one2.Hide();
                    Stwo = false;
                }
                if (x1 < -20 && Sthree2 == true)
                {
                    start = true;
                    three.Show();
                    two.Hide();
                    one.Hide();
                    Stwo2 = false;
                }
                if (x1 > this.Width && Sfour == true)
                {
                    start = true;
                    three2.Hide();
                    four2.Show();
                    one2.Hide();
                    Sthree = false;
                }
                if (x1 < -20 && Sfour2 == true)
                {
                    start = true;
                    four.Show();
                    three.Hide();
                    one.Hide();
                    Sthree2 = false;
                }
                if (x1 > this.Width && Sfive == true)
                {
                    start = false;
                    four2.Hide();
                    five2.Show();
                    one2.Hide();
                    Sfour = false;
                    winner1.Show();
                    Refresh();
                    Thread.Sleep(2000);
                    restart = true;
                }
                if (x1 < -20 && Sfive2 == true)
                {
                    start = false;
                    five.Show();
                    four.Hide();
                    one.Hide();
                    Sfour2 = false;
                    winner2.Show();
                    Refresh();
                    Thread.Sleep(2000);
                    restart = true;
                }
            }
            ball.Location = new Point(x1, y1);
            paddle1.Location = new Point(x, y);
            paddle2.Location = new Point(x2, y2);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            onePlayer.Hide();
            twoPlayer.Hide();
            easy.Show();
            medium.Show();
            hard.Show();
        }

        private void twoPlayer_Click(object sender, EventArgs e)
        {
            twoPlayers = true;
            onePlayer.Hide();
            twoPlayer.Hide();
            start = true;
            easyLevel = false;
            mediumLevel = false;
            hardLevel = false;
        }

        private void easy_Click(object sender, EventArgs e)
        {
            twoPlayers = false;
            start = true;
            easyLevel = true;
            easy.Hide();
            medium.Hide();
            hard.Hide();
        }

        private void medium_Click(object sender, EventArgs e)
        {
            twoPlayers = false;
            mediumLevel = true;
            easy.Hide();
            medium.Hide();
            hard.Hide();
            start = true;
        }

        private void hard_Click(object sender, EventArgs e)
        {
            twoPlayers = false;
            hardLevel = true;
            easy.Hide();
            medium.Hide();
            hard.Hide();
            start = true;
        }
    }
}

