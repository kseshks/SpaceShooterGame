using System;
using System.Windows.Forms;

namespace SpaceShooter
{
    public partial class Form1 : Form
    {
        private GameManager gameManager;

        public Form1()
        {
            InitializeComponent();

            // Стандартные настройки кнопки
            bRestart.TabStop = true;
            bRestart.FlatStyle = FlatStyle.Standard;
            this.KeyPreview = true;
            this.Focus();

            gameManager = new GameManager(this);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 50;

            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && spaceship.Left > -30)
                spaceship.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && spaceship.Right < 800)
                spaceship.Left += speed;
            else if (e.KeyCode == Keys.Space && !gameManager.BulletActive)
            {
                gameManager.ShootBullet();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameManager.HandleGameTick();
        }

        private void bRestart_Click(object sender, EventArgs e)
        {
            if (gameManager.Lose)
            {
                gameManager.RestartGame();
            }
        }
    }
}