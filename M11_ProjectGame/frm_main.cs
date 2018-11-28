using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace M11_ProjectGame
{
    enum SHOOTDIR { LEFT, RIGHT }

    public partial class frm_main : Form
    {
        bool p1_MovingR, p1_MovingL, p1_Jump, p1_ActiveBullet, p1_Collide, p2_MovingR, p2_MovingL, p2_Jump, p2_ActiveBullet, p2_Collide;
        int p1_Gravity = 25, p1_HP = 100, p2_Gravity = 25, p2_HP = 100;
        int p1_Score = 0, p2_Score = 0;
        SHOOTDIR p1_DIR, p2_DIR;

        List<PictureBox> AllObj = new List<PictureBox>();

        public frm_main()
        {
            InitializeComponent();
        }

        private void tick_game_Tick(object sender, EventArgs e)
        {
            lbl_fps.Text = "FPS: " + CalculateFrameRate().ToString();

            p1_Head.Location = new Point(p1.Location.X + (p1_Head.Width / 2), p1.Location.Y - p1_Head.Height);
            p2_Head.Location = new Point(p2.Location.X + (p2_Head.Width / 2), p2.Location.Y - p2_Head.Height);

            if (p1_HP <= 0 || p2_HP <= 0)
            {
                tick_game.Enabled = false;
                string str_MessageGO = "";

                if (p1_HP <= 0 && p2_HP <= 0)
                {
                    str_MessageGO = "Tie!";
                }
                else
                {
                    if (p1_HP <= 0)
                    {
                        str_MessageGO = "Player 2 WINS!";
                        p2_Score++;
                        lbl_p2score.Text = "Score: " + p2_Score.ToString();
                    }
                    else if (p2_HP <= 0)
                    {
                        str_MessageGO = "Player 1 WINS!";
                        p1_Score++;
                        lbl_p1score.Text = "Score: " + p1_Score.ToString();
                    }
                }

                frm_winner Winner = new frm_winner(str_MessageGO);
                DialogResult DR_WINNER = Winner.ShowDialog();
                if (DR_WINNER == DialogResult.Retry)
                {
                    Retry();
                }
                else if (DR_WINNER == DialogResult.Cancel)
                {
                    frm_mainmenu frm_mainmenu = new frm_mainmenu();
                    frm_mainmenu.Show();
                    Close();
                }
            }

            MoveP1();
            MoveP2();
        }

        private void frm_main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                frm_mainmenu frm_mainmenu = new frm_mainmenu();
                frm_mainmenu.Show();
                Close();
            }

            if (e.KeyCode == Keys.A)
            {
                p1_MovingL = true;

                if (p1_ActiveBullet == false)
                {
                    p1_DIR = SHOOTDIR.LEFT;
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                p1_MovingR = true;

                if (p1_ActiveBullet == false)
                {
                    p1_DIR = SHOOTDIR.RIGHT;
                }
            }
            else if (e.KeyCode == Keys.W)
            {
                p1_Jump = true;
                p1_Collide = false;
            }
            else if (e.KeyCode == Keys.G && p1_ActiveBullet == false)
            {
                if (p1_DIR == SHOOTDIR.LEFT)
                {
                    p1_Bullet.Location = new Point(p1.Location.X - p1_Bullet.Width, p1.Location.Y + (p1.Height / 2));
                }else if (p1_DIR == SHOOTDIR.RIGHT)
                {
                    p1_Bullet.Location = new Point(p1.Location.X + p1.Width, p1.Location.Y + (p1.Height / 2));
                }

                p1_ActiveBullet = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                p2_MovingL = true;

                if (p2_ActiveBullet == false)
                {
                    p2_DIR = SHOOTDIR.LEFT;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                p2_MovingR = true;

                if (p2_ActiveBullet == false)
                {
                    p2_DIR = SHOOTDIR.RIGHT;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                p2_Jump = true;
                p2_Collide = false;
            }
            else if (e.KeyCode == Keys.P && p2_ActiveBullet == false)
            {
                if (p2_DIR == SHOOTDIR.LEFT)
                {
                    p2_Bullet.Location = new Point(p2.Location.X - p2_Bullet.Width, p2.Location.Y + (p2.Height / 2));
                }
                else if (p2_DIR == SHOOTDIR.RIGHT)
                {
                    p2_Bullet.Location = new Point(p2.Location.X + p2.Width, p2.Location.Y + (p2.Height / 2));
                }

                p2_ActiveBullet = true;
            }
        }

        private void frm_main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                p1_MovingL = false;
            }else if(e.KeyCode == Keys.D)
            {
                p1_MovingR = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                p2_MovingL = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                p2_MovingR = false;
            }
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;

            tick_game.Enabled = true;
            tick_game.Interval = 1;

            p1_Bullet.Location = new Point(-50, -50);
            p2_Bullet.Location = new Point(pnl_Screen.Width + 50, pnl_Screen.Width - 50);

            p1_DIR = SHOOTDIR.RIGHT; p2_DIR = SHOOTDIR.LEFT;

            foreach (Control item in pnl_Screen.Controls)
            {
                if (item.Tag == "obj")
                {
                    AllObj.Add((PictureBox)item);
                }
            }
        }

        private void MoveP1()
        {
            if (p1_MovingL == true)
            {
                if (p1.Location.X > 0)
                {
                    p1.Left -= 10;
                }
            }
            else if (p1_MovingR == true)
            {
                if (p1.Location.X + p1.Width < pnl_Screen.Width)
                {
                    p1.Left += 10;
                }
            }

            if (p1_Jump == true)
            {
                p1.Top -= p1_Gravity;
                p1_Gravity -= 1;
            }

            if (p1.Location.Y + p1.Height >= pnl_Screen.Height || p1_Collide == true)
            {
                p1_Jump = false;
                p1_Gravity = 25;

                if (p1.Location.Y + p1.Height > pnl_Screen.Height)
                {
                    p1.Location = new Point(p1.Location.X, pnl_Screen.Height - p1.Height);
                }
            }
            else
            {
                p1.Top += 6;
            }

            if (p1_ActiveBullet == true)
            {
                if (p1_DIR == SHOOTDIR.RIGHT)
                {
                    if (p1_Bullet.Location.X > pnl_Screen.Width)
                    {
                        p1_ActiveBullet = false;
                    }
                    else
                    {
                        p1_Bullet.Left += 25;
                    }
                }else if (p1_DIR == SHOOTDIR.LEFT)
                {
                    if (p1_Bullet.Location.X + p1_Bullet.Width < 0)
                    {
                        p1_ActiveBullet = false;
                    }
                    else
                    {
                        p1_Bullet.Left -= 25;
                    }
                }

                for (int i = 0; i < AllObj.Count; i++)
                {
                    if (p1_Bullet.Bounds.IntersectsWith(AllObj[i].Bounds))
                    {
                        p1_ActiveBullet = false;
                        p1_Bullet.Location = new Point(-50, -50);
                    }
                }

                if (p1_Bullet.Bounds.IntersectsWith(p2.Bounds))
                {
                    p1_ActiveBullet = false;
                    p1_Bullet.Location = new Point(-50, -50);

                    p2_HP -= 25;
                    pb_p2HP.Value = p2_HP;
                }

                if (p1_Bullet.Bounds.IntersectsWith(p2_Head.Bounds))
                {
                    p1_ActiveBullet = false;
                    p1_Bullet.Location = new Point(-50, -50);

                    p2_HP -= 50;

                    if (p2_HP <= 0)
                    {
                        pb_p2HP.Value = 0;
                    }
                    else
                    {
                        pb_p2HP.Value = p2_HP;
                    }
                }
            }

            for (int i = 0; i < AllObj.Count; i++)
            {
                if (GroundCollision(p1, AllObj[i]) == true)
                {
                    p1_Collide = true;
                    break;
                }
                else
                {
                    p1_Collide = false;
                }
            }
        }

        private void MoveP2()
        {
            if (p2_MovingL == true)
            {
                if (p2.Location.X > 0)
                {
                    p2.Left -= 10;
                }
            }
            else if (p2_MovingR == true)
            {
                if (p2.Location.X + p2.Width < pnl_Screen.Width)
                {
                    p2.Left += 10;
                }
            }

            if (p2_Jump == true)
            {
                p2.Top -= p2_Gravity;
                p2_Gravity -= 1;
            }

            if (p2.Location.Y + p2.Height >= pnl_Screen.Height || p2_Collide == true)
            {
                p2_Jump = false;
                p2_Gravity = 25;

                if (p2.Location.Y + p2.Height > pnl_Screen.Height)
                {
                    p2.Location = new Point(p2.Location.X, pnl_Screen.Height - p2.Height);
                }
            }
            else
            {
                p2.Top += 6;
            }

            if (p2_ActiveBullet == true)
            {
                if (p2_DIR == SHOOTDIR.RIGHT)
                {
                    if (p2_Bullet.Location.X > pnl_Screen.Width)
                    {
                        p2_ActiveBullet = false;
                    }
                    else
                    {
                        p2_Bullet.Left += 25;
                    }
                }
                else if (p2_DIR == SHOOTDIR.LEFT)
                {
                    if (p2_Bullet.Location.X + p2_Bullet.Width < 0)
                    {
                        p2_ActiveBullet = false;
                    }
                    else
                    {
                        p2_Bullet.Left -= 25;
                    }
                }

                for (int i = 0; i < AllObj.Count; i++)
                {
                    if (p2_Bullet.Bounds.IntersectsWith(AllObj[i].Bounds))
                    {
                        p2_ActiveBullet = false;
                        p2_Bullet.Location = new Point(pnl_Screen.Width + 50, pnl_Screen.Width - 50);
                    }
                }

                if (p2_Bullet.Bounds.IntersectsWith(p1.Bounds))
                {
                    p2_ActiveBullet = false;
                    p2_Bullet.Location = new Point(pnl_Screen.Width + 50, pnl_Screen.Width - 50);

                    p1_HP -= 25;
                    pb_p1HP.Value = p1_HP;
                }

                if (p2_Bullet.Bounds.IntersectsWith(p1_Head.Bounds))
                {
                    p2_ActiveBullet = false;
                    p2_Bullet.Location = new Point(pnl_Screen.Width + 50, pnl_Screen.Width - 50);

                    p1_HP -= 50;

                    if (p1_HP <= 0)
                    {
                        pb_p1HP.Value = 0;
                    }
                    else
                    {
                        pb_p1HP.Value = p1_HP;
                    }
                }
            }

            for (int i = 0; i < AllObj.Count; i++)
            {
                if (GroundCollision(p2, AllObj[i]) == true)
                {
                    p2_Collide = true;
                    break;
                }
                else
                {
                    p2_Collide = false;
                }
            }
        }

        private bool GroundCollision(PictureBox Player, PictureBox Ground)
        {
            if (Player.Bounds.IntersectsWith(Ground.Bounds))
            {
                if (Player.Location.Y + Player.Height > Ground.Location.Y && Player.Location.Y + Player.Height < Ground.Location.Y + Ground.Height)
                {
                    Player.Location = new Point(Player.Location.X, Ground.Location.Y - Player.Height);

                    return true;
                }else if(Player.Location.Y > Ground.Location.Y)
                {
                    if (Player.Tag.ToString() == "p1")
                    {
                        p1_Jump = false;
                    }else if (Player.Tag.ToString() == "p2")
                    {
                        p2_Jump = false;
                    }

                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void Retry()
        {
            p1_HP = 100;
            p2_HP = 100;

            pb_p1HP.Value = p1_HP;
            pb_p2HP.Value = p2_HP;

            p1_MovingL = false; p1_MovingR = false;
            p2_MovingL = false; p2_MovingR = false;
            p1_ActiveBullet = false; p2_ActiveBullet = false;
            p1_DIR = SHOOTDIR.RIGHT; p2_DIR = SHOOTDIR.LEFT;

            p1.Location = new Point(11, 705);
            p2.Location = new Point(962, 706);
            p1_Bullet.Location = new Point(-50, -50);
            p2_Bullet.Location = new Point(pnl_Screen.Width + 50, pnl_Screen.Width - 50);

            tick_game.Enabled = true;
        }

        #region Basic Frame Counter

        private static int lastTick;
        private static int lastFrameRate;
        private static int frameRate;

        public static int CalculateFrameRate()
        {
            if (Environment.TickCount - lastTick >= 1000)
            {
                lastFrameRate = frameRate;
                frameRate = 0;
                lastTick = Environment.TickCount;
            }
            frameRate++;
            return lastFrameRate;
        }
        #endregion
    }
}
