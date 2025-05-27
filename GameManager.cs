using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceShooter
{
    public class GameManager
    {
        // Ссылка на главную форму
        private Form1 form;

        // Игровые переменные
        public bool Lose { get; private set; } = false;
        public bool BulletActive { get; private set; } = false;
        public int BulletSpeed { get; private set; } = 20;
        public int Score { get; private set; } = 0;
        public int Lives { get; private set; } = 3;

        // Конструктор
        public GameManager(Form1 mainForm)
        {
            form = mainForm;
            InitializeGame();
        }

        private void InitializeGame()
        {
            Lose = false;
            BulletActive = false;
            Score = 0;
            Lives = 3;

            form.labelLose.Visible = false;
            form.bRestart.Visible = false;
            form.bullet.Visible = false;

            UpdateScoreLabel();
            UpdateHearts();
        }

        public void UpdateScoreLabel()
        {
            form.labelScore.Text = $"Score: {Score}";
        }

        public void UpdateHearts()
        {
            form.heart1.Visible = Lives >= 1;
            form.heart2.Visible = Lives >= 2;
            form.heart3.Visible = Lives >= 3;
        }

        public void ShootBullet()
        {
            BulletActive = true;
            form.bullet.Visible = true;
            form.bullet.Top = form.spaceship.Top - form.bullet.Height;
            form.bullet.Left = form.spaceship.Left + (form.spaceship.Width / 2) - (form.bullet.Width / 2);
        }

        public void HandleGameTick()
        {
            int cometspeed = 20;

            form.comet1.Top += cometspeed;
            form.comet2.Top += cometspeed;
            form.comet3.Top += cometspeed;
            form.comet4.Top += cometspeed;
            form.comet5.Top += cometspeed;
            form.comet6.Top += cometspeed;

            if (BulletActive)
            {
                form.bullet.Top -= BulletSpeed;

                if (form.bullet.Top < 0)
                {
                    BulletActive = false;
                    form.bullet.Visible = false;
                }

                CheckBulletCollisions();
            }

            if (form.comet1.Top >= 600) ResetComet(form.comet1, -50, 10, 100);
            if (form.comet2.Top >= 600) ResetComet(form.comet2, -100, 100, 200);
            if (form.comet3.Top >= 600) ResetComet(form.comet3, -150, 200, 300);
            if (form.comet4.Top >= 600) ResetComet(form.comet4, -200, 300, 400);
            if (form.comet5.Top >= 600) ResetComet(form.comet5, -250, 500, 600);
            if (form.comet6.Top >= 600) ResetComet(form.comet6, -300, 600, 700);

            if (form.spaceship.Bounds.IntersectsWith(form.comet1.Bounds) ||
                form.spaceship.Bounds.IntersectsWith(form.comet2.Bounds) ||
                form.spaceship.Bounds.IntersectsWith(form.comet3.Bounds) ||
                form.spaceship.Bounds.IntersectsWith(form.comet4.Bounds) ||
                form.spaceship.Bounds.IntersectsWith(form.comet5.Bounds) ||
                form.spaceship.Bounds.IntersectsWith(form.comet6.Bounds))
            {
                HandleSpaceshipHit();
            }
        }

        private void ResetComet(PictureBox comet, int topOffset, int leftMin, int leftMax)
        {
            Random rand = new Random();
            comet.Top = topOffset;
            comet.Left = rand.Next(leftMin, leftMax);
        }

        private void HandleSpaceshipHit()
        {
            Lives--;
            UpdateHearts();
            ResetAllComets();

            if (Lives <= 0)
            {
                GameOver();
            }
        }

        private void ResetAllComets()
        {
            ResetComet(form.comet1, -50, 10, 100);
            ResetComet(form.comet2, -700, 100, 200);
            ResetComet(form.comet3, -250, 200, 300);
            ResetComet(form.comet4, -320, 300, 400);
            ResetComet(form.comet5, -250, 500, 600);
            ResetComet(form.comet6, -540, 600, 700);
        }

        private void GameOver()
        {
            form.timer1.Stop();
            Lose = true;
            form.labelLose.Text = $"Game Over! Final Score: {Score}";
            form.labelLose.Visible = true;
            form.bRestart.Visible = true;
        }

        private void CheckBulletCollisions()
        {
            if (form.bullet.Bounds.IntersectsWith(form.comet1.Bounds))
            {
                HandleBulletHit(form.comet1);
            }
            else if (form.bullet.Bounds.IntersectsWith(form.comet2.Bounds))
            {
                HandleBulletHit(form.comet2);
            }
            else if (form.bullet.Bounds.IntersectsWith(form.comet3.Bounds))
            {
                HandleBulletHit(form.comet3);
            }
            else if (form.bullet.Bounds.IntersectsWith(form.comet4.Bounds))
            {
                HandleBulletHit(form.comet4);
            }
            else if (form.bullet.Bounds.IntersectsWith(form.comet5.Bounds))
            {
                HandleBulletHit(form.comet5);
            }
            else if (form.bullet.Bounds.IntersectsWith(form.comet6.Bounds))
            {
                HandleBulletHit(form.comet6);
            }
        }

        private void HandleBulletHit(PictureBox comet)
        {
            BulletActive = false;
            form.bullet.Visible = false;

            Random rand = new Random();
            comet.Top = -rand.Next(50, 300);
            comet.Left = rand.Next(10, 700);

            Score += 10;
            UpdateScoreLabel();
        }

        public void RestartGame()
        {
            Lose = false;
            BulletActive = false;
            Score = 0;
            Lives = 3;

            form.spaceship.Left = (form.ClientSize.Width - form.spaceship.Width) / 2;
            form.bullet.Visible = false;

            ResetAllComets();

            UpdateScoreLabel();
            UpdateHearts();

            form.labelLose.Visible = false;
            form.bRestart.Visible = false;

            form.timer1.Start();
            form.Focus();
        }
    }
}