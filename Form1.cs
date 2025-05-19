using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter
{
    public partial class Form1 : Form
    {
        private bool lose = false;
        private bool bulletActive = false;
        private int bulletSpeed = 20;

        public Form1()
        {
            InitializeComponent();
            labelLose.Visible = false;
            bRestart.Visible = false;
            bullet.Visible = false; // Скрываем пулю в начале игры
            KeyPreview = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int speed = 30;
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;

            int speed = 30;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && spaceship.Left > -30)
                spaceship.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && spaceship.Right < 800)
                spaceship.Left += speed;
            else if (e.KeyCode == Keys.Space && !bulletActive) // Стрельба пробелом
            {
                ShootBullet();
            }
        }

        private void ShootBullet()
        {
            bulletActive = true;
            bullet.Visible = true;
            bullet.Top = spaceship.Top - bullet.Height;
            bullet.Left = spaceship.Left + (spaceship.Width / 2) - (bullet.Width / 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int cometspeed = 20;

            // Движение комет
            comet1.Top += cometspeed;
            comet2.Top += cometspeed;
            comet3.Top += cometspeed;
            comet4.Top += cometspeed;
            comet5.Top += cometspeed;
            comet6.Top += cometspeed;

            // Движение пули
            if (bulletActive)
            {
                bullet.Top -= bulletSpeed;

                // Проверка выхода пули за границы экрана
                if (bullet.Top < 0)
                {
                    bulletActive = false;
                    bullet.Visible = false;
                }

                // Проверка столкновений пули с кометами
                CheckBulletCollisions();
            }

            // Перемещение комет при выходе за границы
            if (comet1.Top >= 600)
            {
                comet1.Top = -50;
                Random rand = new Random();
                comet1.Left = rand.Next(10, 100);
            }
            if (comet2.Top >= 600)
            {
                comet2.Top = -100;
                Random rand = new Random();
                comet2.Left = rand.Next(100, 200);
            }
            if (comet3.Top >= 600)
            {
                comet3.Top = -150;
                Random rand = new Random();
                comet3.Left = rand.Next(200, 300);
            }
            if (comet4.Top >= 600)
            {
                comet4.Top = -200;
                Random rand = new Random();
                comet4.Left = rand.Next(300, 400);
            }
            if (comet5.Top >= 600)
            {
                comet5.Top = -250;
                Random rand = new Random();
                comet5.Left = rand.Next(500, 600);
            }
            if (comet6.Top >= 600)
            {
                comet6.Top = -300;
                Random rand = new Random();
                comet6.Left = rand.Next(600, 700);
            }

            // Проверка столкновений корабля с кометами
            if (spaceship.Bounds.IntersectsWith(comet1.Bounds) ||
                spaceship.Bounds.IntersectsWith(comet2.Bounds) ||
                spaceship.Bounds.IntersectsWith(comet3.Bounds) ||
                spaceship.Bounds.IntersectsWith(comet4.Bounds) ||
                spaceship.Bounds.IntersectsWith(comet5.Bounds) ||
                spaceship.Bounds.IntersectsWith(comet6.Bounds))
            {
                timer1.Enabled = false;
                labelLose.Visible = true;
                bRestart.Visible = true;
                lose = true;
            }
        }

        private void CheckBulletCollisions()
        {
            // Проверка столкновений пули с каждой кометой
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
            // Деактивируем пулю
            bulletActive = false;
            bullet.Visible = false;

            // Перемещаем комету вверх экрана
            Random rand = new Random();
            comet.Top = -rand.Next(50, 300);
            comet.Left = rand.Next(10, 700);

            // Здесь можно добавить очки или другие эффекты
        }

        private void bRestart_Click(object sender, EventArgs e)
        {
            lose = false;
            labelLose.Visible = false;
            bRestart.Visible = false;
            bulletActive = false;
            bullet.Visible = false;
            timer1.Enabled = true;

            comet1.Top = -100;
            comet2.Top = -500;
            comet3.Top = -430;
            comet4.Top = -230;
            comet5.Top = -180;
            comet6.Top = -720;
        }
    }
}