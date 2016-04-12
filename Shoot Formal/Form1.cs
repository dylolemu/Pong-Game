//created by Dylon Lemus
//April 2016
// Description: Classic looking pong game that allows you to play multiplayer or single player. In single player you can play with different difficulties.

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
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Pong : Form
    {

        public Pong()
        {
            InitializeComponent();
            TopMost = true;
            main = true;
            //hides all images
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
            win.Hide();
            lose.Hide();
            //sets location of everything according to form size
            win.Location = new Point(this.Width / 2 - win.Width / 2, this.Height / 2 - win.Height / 2);
            lose.Location = new Point(this.Width / 2 - lose.Width / 2, this.Height / 2 - lose.Height / 2);
            quit.Location = new Point(this.Width / 2 - quit.Width / 2, this.Height - quit.Height * 3);
            pause1.Location = new Point(this.Width / 2 - pause1.Width / 2, this.Height / 2 - pause1.Height / 2);
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

            Form bg = new Form();
            bg.BackColor = Color.White;
            bg.FormBorderStyle = FormBorderStyle.None;
            bg.WindowState = FormWindowState.Maximized;

            bg.Show();
            this.BringToFront();
        }
        bool main, levels, pause = false;
        bool upc, downc = false;//paddle1 movements
        bool upc2, downc2 = false;//paddle 2 movements
        bool canUp, canDown, bcanUp, bcanDown = false;//ball movements
        bool Stwo, Sone, Sthree, Sfour, Sfive = false;//score for player 1
        bool Stwo2, Sone2, Sthree2, Sfour2, Sfive2 = false;//score for player 2
        bool twoPlayers = false;
        bool easyLevel, mediumLevel, hardLevel = false;
        bool restart, start, play = false;

        Random randNum = new Random();

        int angleX, angleY;//random angle for ball
        int add;
        //variables for location of paddles and ball
        int x, y;
        int x1, y1;
        int x2, y2;
        //sound used
        SoundPlayer score = new SoundPlayer(Properties.Resources.score);
        SoundPlayer wallHit = new SoundPlayer(Properties.Resources.wallHit);
        SoundPlayer paddleHit = new SoundPlayer(Properties.Resources.paddleHit);

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (main == true)//if on main screen esc closes game
                {
                    this.Close();
                }
                else if (pause == false)//if not on main screen it pauses the game
                {
                    pause1.Show();
                    pause = true;
                    quit.Show();
                }
                else//if already paused it unpauses game
                {
                    quit.Hide();
                    pause1.Hide();
                    pause = false;
                }
            }
            //key pressed for paddles
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
            //game restarts
            if (restart == true)
            {
                winner2.Location = new Point(2000, 1000);
                winner1.Location = new Point(2000, 1000);
                ball.Location = new Point(this.Width / 2 - ball.Width / 2, this.Height / 2 - ball.Height / 2);
                paddle2.Location = new Point(this.Width - paddle2.Width - 27, this.Height / 2 - paddle2.Height / 2);
                paddle1.Location = new Point(15, this.Height / 2 - paddle1.Height / 2);
                //score goes back to 0
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
                //lets you choose 2 or 1 player again
                onePlayer.Show();
                twoPlayer.Show();
                //hides all pictures so game can be restarted
                win.Hide();
                lose.Hide();
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
                //can't be restarted again
                restart = false;
                start = false;
                //esc key can be used to exit
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
            if (levels == true)
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
            if (pause == false)
            {
                if (start == true)
                {
                    //increase goes back to 0
                    add = 0;
                    //angles are randomized
                    angleX = randNum.Next(10, 17);
                    angleY = randNum.Next(10, 17);
                    //paddles are placed back to original spots
                    paddle2.Location = new Point(this.Width - paddle2.Width - 15, this.Height / 2 - paddle2.Height / 2);
                    paddle1.Location = new Point(15, this.Height / 2 - paddle1.Height / 2);
                    ball.Location = new Point(this.Width / 2 - ball.Width / 2, this.Height / 2 - ball.Height / 2);//ball is moved to the center
                    //countdown for game start
                    for (int i = 1; i <= 4; i++)
                    {
                        Refresh();
                        Thread.Sleep(800);//pauses in between each countdown
                        if (i == 1)
                        {
                            time3.Show();
                        }
                        if (i == 2)
                        {
                            time3.Hide();
                            time2.Show();
                        }
                        if (i == 3)
                        {
                            time1.Show();
                            time2.Hide();
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
                    //picks a random side for ball to go
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
                    //scoring sound can be heard again
                    play = true;
                }
            }
        }


        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            //key is released
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
            //variables for location of paddles and ball
            x = paddle1.Location.X;
            y = paddle1.Location.Y;
            x2 = paddle2.Location.X;
            y2 = paddle2.Location.Y;
            x1 = ball.Location.X;
            y1 = ball.Location.Y;
            if (pause == false)
            {
                //paddle1 movements
                if (upc == true)
                {
                    y -= 15;
                }
                if (downc == true)
                {
                    y += 15;
                }
                //paddle2 movements
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
                    if (easyLevel == true)//moves slower
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
                    if (hardLevel == true)//moves very fast
                    {
                        if (y2 < y1 - 40)
                        {
                            y2 += 35;
                        }
                        if (y2 > y1 - 40)
                        {
                            y2 -= 35;
                        }
                    }
                }
                //ball movements
                //wallhits
                if (canUp == true)
                {
                    if (y1 > 0)//ball moves up and right
                    {
                        x1 += angleX + add;//speed increases each time it hits side
                        y1 -= angleY + add;
                        if (y1 <= 0)//hits bottom wall
                        {
                            wallHit.Play();//sound
                            canUp = false;
                            canDown = true;
                            if (hardLevel == true)//angle changes each time it hits side
                            {
                                angleX = randNum.Next(16, 20);
                                angleY = randNum.Next(16, 20);
                            }
                        }
                    }
                }
                if (canDown == true)
                {
                    if (y1 < this.Height - ball.Height)//ball moves down and right
                    {
                        x1 += angleX + add;
                        y1 += angleY + add;
                        if (y1 >= this.Height - ball.Height)
                        {
                            wallHit.Play();//sound
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
                    if (y1 > 0)//ball moves up and left
                    {
                        x1 -= angleX + add;
                        y1 -= angleY + add;
                        if (y1 <= 0)
                        {
                            wallHit.Play();//sound
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
                    if (y1 < this.Height - ball.Height)//moves down and left
                    {
                        x1 -= angleX + add;
                        y1 += angleY + add;
                        if (y1 >= this.Height - ball.Height)
                        {
                            wallHit.Play();//sound
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
                //making contact with paddle2
                if (x1 <= x2 + 20 && x1 >= x2 - 33 && y1 >= y2 - 2 && y1 <= y2 + 111)
                {
                    paddleHit.Play();//sound
                    if (twoPlayers == true)
                    {
                        add += 3;//speed increases when it hits paddle
                    }
                    if (easyLevel == true)
                    {
                        add += 1;//small increase
                    }
                    if (mediumLevel == true)
                    {
                        add += 3;//medium increase
                    }
                    if (hardLevel == true)
                    {
                        add += 4;//high increase
                    }
                    //moves left
                    if (canUp == true)
                    {
                        bcanUp = true;
                    }
                    if (canDown == true)
                    {
                        bcanDown = true;
                    }
                    canDown = false;
                    canUp = false;
                }
                //making contact with paddle1
                if (x1 >= x - 20 && x1 <= x + 33 && y1 >= y - 2 && y1 <= y + 111)
                {
                    paddleHit.Play();//sound
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
                    //moves right
                    if (bcanUp == true)
                    {
                        canUp = true;
                    }
                    if (bcanDown == true)
                    {
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
                //play scoring sound
                if (play == true)
                {
                    if (x1 - 20 > this.Width)
                    {
                        score.PlaySync();
                        play = false;
                    }
                }
                if (play == true)
                {
                    if (x1 < -45)
                    {
                        score.PlaySync();
                        play = false;
                    }
                }
                //scoring
                if (x1 - 20 > this.Width)
                {
                    start = true;
                    one2.Show();//score 1
                    Sone = true;
                    canDown = false;
                    canUp = false;
                    bcanDown = false;
                    bcanUp = false;
                }
                if (x1 < -45)
                {
                    start = true;
                    one.Show();//score 1
                    Sone2 = true;
                    canDown = false;
                    canUp = false;
                    bcanDown = false;
                    bcanUp = false;
                }
                if (x1 - 20 > this.Width && Stwo == true)
                {
                    start = true;
                    two2.Show();//score 2
                    one2.Hide();
                    Sone = false;
                }
                if (x1 < -45 && Stwo2 == true)
                {
                    start = true;
                    two.Show();//score 2
                    one.Hide();
                    Sone2 = false;

                }
                if (x1 - 20 > this.Width && Sthree == true)
                {
                    start = true;
                    three2.Show();//score 3
                    two2.Hide();
                    one2.Hide();
                    Stwo = false;
                }
                if (x1 < -45 && Sthree2 == true)
                {
                    start = true;
                    three.Show();// score 3
                    two.Hide();
                    one.Hide();
                    Stwo2 = false;
                }
                if (x1 - 20 > this.Width && Sfour == true)
                {
                    start = true;
                    three2.Hide();//score 4
                    four2.Show();
                    one2.Hide();
                    Sthree = false;
                }
                if (x1 < -45 && Sfour2 == true)
                {
                    start = true;
                    four.Show();//score 4
                    three.Hide();
                    one.Hide();
                    Sthree2 = false;
                }
                if (x1 - 20 > this.Width && Sfive == true)
                {
                    start = false;
                    four2.Hide();
                    five2.Show();//score 5
                    one2.Hide();
                    Sfour = false;
                    if (twoPlayers == true)//if playing 2 player
                    {
                        winner1.Show();
                    }
                    else
                    {
                        win.Show();
                    }
                    Refresh();
                    Thread.Sleep(2000);
                    restart = true;//game can be restarted
                }
                if (x1 < -45 && Sfive2 == true)
                {
                    start = false;
                    five.Show();//score 5
                    four.Hide();
                    one.Hide();
                    if (twoPlayers == true)
                    {
                        winner2.Show();
                    }
                    else
                    {
                        lose.Show();
                    }
                    Sfour2 = false;
                    Refresh();
                    Thread.Sleep(2000);
                    restart = true;
                }
            }
            //location of paddles and ball using variables created
            ball.Location = new Point(x1, y1);
            paddle1.Location = new Point(x, y);
            paddle2.Location = new Point(x2, y2);
        }
    }
}

