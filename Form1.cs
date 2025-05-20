using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceShooter
{
    public partial class Form1 : Form
    {
        //ПЕРЕМЕННЫЕ ДЛЯ УПРАВЛЕНИЯ ИГРОЙ
        private bool lose = false; // true — игра проиграна
        private bool bulletActive = false; 
        private int bulletSpeed = 20;
        private int score = 0; 
        private int lives = 3;
        private bool isInvincible = false; // Защита от повторного столкновения

        public Form1()
        {
            InitializeComponent();

            // Настройка начального состояния игры (надпись гейм овер, кнопка, пуля скрыты)
            labelLose.Visible = false; 
            bRestart.Visible = false; 
            bullet.Visible = false; 
            KeyPreview = true;

            UpdateScoreLabel();
            UpdateHearts(); 
        }

        private void UpdateScoreLabel()
        {
            labelScore.Text = $"Score: {score}";
        }

        private void UpdateHearts()
        {
            heart1.Visible = lives >= 1; 
            heart2.Visible = lives >= 2; 
            heart3.Visible = lives >= 3;
        }

        //Esc для выхода
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) 
                this.Close(); 
        }

        // Обработка движения корабля и выстрела
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose || isInvincible) return;

            int speed = 30;

            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && spaceship.Left > -30)
                spaceship.Left -= speed;

            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && spaceship.Right < 800)
                spaceship.Left += speed;

            else if (e.KeyCode == Keys.Space && !bulletActive)
            {
                ShootBullet();
            }
        }

        // пуля
        private void ShootBullet()
        {
            bulletActive = true; 
            bullet.Visible = true;

            bullet.Top = spaceship.Top - bullet.Height;
            bullet.Left = spaceship.Left + (spaceship.Width / 2) - (bullet.Width / 2);
        }

        // Главный игровой цикл 
        private void timer1_Tick(object sender, EventArgs e)
        {
            int cometspeed = 20;

            comet1.Top += cometspeed;
            comet2.Top += cometspeed;
            comet3.Top += cometspeed;
            comet4.Top += cometspeed;
            comet5.Top += cometspeed;
            comet6.Top += cometspeed;

            // выстрел пули 
            if (bulletActive)
            {
                bullet.Top -= bulletSpeed;

                if (bullet.Top < 0)
                {
                    bulletActive = false;
                    bullet.Visible = false;
                }

                // Попадание в комету 
                CheckBulletCollisions();
            }

            if (comet1.Top >= 600) ResetComet(comet1, -50, 10, 100);
            if (comet2.Top >= 600) ResetComet(comet2, -100, 100, 200);
            if (comet3.Top >= 600) ResetComet(comet3, -150, 200, 300);
            if (comet4.Top >= 600) ResetComet(comet4, -200, 300, 400);
            if (comet5.Top >= 600) ResetComet(comet5, -250, 500, 600);
            if (comet6.Top >= 600) ResetComet(comet6, -300, 600, 700);

            // Проверка столкновения корабля с кометами (если игрок не неуязвим)
            if (!isInvincible && (spaceship.Bounds.IntersectsWith(comet1.Bounds) ||
                spaceship.Bounds.IntersectsWith(comet2.Bounds) ||
                spaceship.Bounds.IntersectsWith(comet3.Bounds) ||
                spaceship.Bounds.IntersectsWith(comet4.Bounds) ||
                spaceship.Bounds.IntersectsWith(comet5.Bounds) ||
                spaceship.Bounds.IntersectsWith(comet6.Bounds)))
            {
                HandleSpaceshipHit();
            }
        }

        // Сбрасывает комету в случайную позицию вверху экрана
        private void ResetComet(PictureBox comet, int topOffset, int leftMin, int leftMax)
        {
            Random rand = new Random();
            comet.Top = topOffset;
            comet.Left = rand.Next(leftMin, leftMax); // Случайная позиция по X
        }

        // Столкновения корабля с кометой
        private void HandleSpaceshipHit()
        {
            lives--; 
            UpdateHearts();

            ResetAllComets(); // Сбрасываем все кометы вверх

            // Включаем неуязвимость на 1 секунду 
            isInvincible = true;
            Timer invincibilityTimer = new Timer();
            invincibilityTimer.Interval = 1000; // 1 секунда
            invincibilityTimer.Tick += (s, e) =>
            {
                isInvincible = false; // Выключаем неуязвимость
                invincibilityTimer.Stop(); 
                invincibilityTimer.Dispose();
            };
            invincibilityTimer.Start();

            if (lives <= 0)
            {
                GameOver();
            }
        }

        // кометы в начальное положение
        private void ResetAllComets()
        {
            ResetComet(comet1, -50, 10, 100);
            ResetComet(comet2, -700, 100, 200);
            ResetComet(comet3, -250, 200, 300);
            ResetComet(comet4, -320, 300, 400);
            ResetComet(comet5, -250, 500, 600);
            ResetComet(comet6, -540, 600, 700);
        }

        private void GameOver()
        {
            timer1.Enabled = false;
            lose = true;
            labelLose.Text = $"Game Over! Final Score: {score}"; 
            labelLose.Visible = true; 
            bRestart.Visible = true;
        }

        // Попала ли пуля в комету
        private void CheckBulletCollisions()
        {
            if (bullet.Bounds.IntersectsWith(comet1.Bounds))
            {
                HandleBulletHit(comet1);
            }
            else if (bullet.Bounds.IntersectsWith(comet2.Bounds))
            {
                HandleBulletHit(comet2);
            }
            else if (bullet.Bounds.IntersectsWith(comet3.Bounds))
            {
                HandleBulletHit(comet3);
            }
            else if (bullet.Bounds.IntersectsWith(comet4.Bounds))
            {
                HandleBulletHit(comet4);
            }
            else if (bullet.Bounds.IntersectsWith(comet5.Bounds))
            {
                HandleBulletHit(comet5);
            }
            else if (bullet.Bounds.IntersectsWith(comet6.Bounds))
            {
                HandleBulletHit(comet6);
            }
        }

        private void HandleBulletHit(PictureBox comet)
        {
            bulletActive = false; 
            bullet.Visible = false;

            // Перемещаем комету в случайное место вверху экрана
            Random rand = new Random();
            comet.Top = -rand.Next(50, 300);
            comet.Left = rand.Next(10, 700);

            score += 10; 
            UpdateScoreLabel(); 
        }

        // Рестарт игры
        private void bRestart_Click(object sender, EventArgs e)
        {
            lose = false; 
            labelLose.Visible = false; 
            bRestart.Visible = false;
            bulletActive = false; 
            bullet.Visible = false;
            timer1.Enabled = true; 
            isInvincible = false; 

            lives = 3; 
            UpdateHearts();

            score = 0;
            UpdateScoreLabel();

            spaceship.Left = this.ClientSize.Width / 2 - spaceship.Width / 2;

            // Сбрасываем все кометы
            ResetAllComets();
        }
    }
}