﻿namespace SpaceShooter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelLose = new System.Windows.Forms.Label();
            this.bRestart = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.spaceship = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.comet6 = new System.Windows.Forms.PictureBox();
            this.comet5 = new System.Windows.Forms.PictureBox();
            this.comet4 = new System.Windows.Forms.PictureBox();
            this.comet3 = new System.Windows.Forms.PictureBox();
            this.comet2 = new System.Windows.Forms.PictureBox();
            this.comet1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.Black;
            this.labelLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLose.ForeColor = System.Drawing.Color.Red;
            this.labelLose.Location = new System.Drawing.Point(119, 89);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(334, 69);
            this.labelLose.TabIndex = 8;
            this.labelLose.Text = "Game over";
            // 
            // bRestart
            // 
            this.bRestart.BackColor = System.Drawing.Color.LightGreen;
            this.bRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRestart.Location = new System.Drawing.Point(439, 204);
            this.bRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRestart.Name = "bRestart";
            this.bRestart.Size = new System.Drawing.Size(196, 70);
            this.bRestart.TabIndex = 9;
            this.bRestart.Text = "RESTART";
            this.bRestart.UseVisualStyleBackColor = false;
            this.bRestart.Click += new System.EventHandler(this.bRestart_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Black;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelScore.Location = new System.Drawing.Point(911, 53);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(102, 29);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "Score: 0";
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Black;
            this.heart1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart1.BackgroundImage")));
            this.heart1.Image = global::SpaceShooter.Properties.Resources.heart;
            this.heart1.Location = new System.Drawing.Point(915, 21);
            this.heart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(36, 30);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 14;
            this.heart1.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Black;
            this.heart2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart2.BackgroundImage")));
            this.heart2.Image = global::SpaceShooter.Properties.Resources.heart;
            this.heart2.Location = new System.Drawing.Point(957, 21);
            this.heart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(36, 30);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 13;
            this.heart2.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Black;
            this.heart3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart3.BackgroundImage")));
            this.heart3.Image = global::SpaceShooter.Properties.Resources.heart;
            this.heart3.Location = new System.Drawing.Point(999, 21);
            this.heart3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(36, 30);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart3.TabIndex = 12;
            this.heart3.TabStop = false;
            // 
            // spaceship
            // 
            this.spaceship.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spaceship.BackgroundImage")));
            this.spaceship.Image = global::SpaceShooter.Properties.Resources.spaceship_Photoroom;
            this.spaceship.Location = new System.Drawing.Point(439, 449);
            this.spaceship.Margin = new System.Windows.Forms.Padding(4);
            this.spaceship.Name = "spaceship";
            this.spaceship.Size = new System.Drawing.Size(153, 156);
            this.spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spaceship.TabIndex = 1;
            this.spaceship.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Image = global::SpaceShooter.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(511, 485);
            this.bullet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(16, 47);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 10;
            this.bullet.TabStop = false;
            // 
            // comet6
            // 
            this.comet6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comet6.BackgroundImage")));
            this.comet6.Image = global::SpaceShooter.Properties.Resources.comet;
            this.comet6.Location = new System.Drawing.Point(712, -795);
            this.comet6.Margin = new System.Windows.Forms.Padding(4);
            this.comet6.Name = "comet6";
            this.comet6.Size = new System.Drawing.Size(51, 57);
            this.comet6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comet6.TabIndex = 7;
            this.comet6.TabStop = false;
            // 
            // comet5
            // 
            this.comet5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comet5.BackgroundImage")));
            this.comet5.Image = global::SpaceShooter.Properties.Resources.comet;
            this.comet5.Location = new System.Drawing.Point(620, -246);
            this.comet5.Margin = new System.Windows.Forms.Padding(4);
            this.comet5.Name = "comet5";
            this.comet5.Size = new System.Drawing.Size(51, 57);
            this.comet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comet5.TabIndex = 6;
            this.comet5.TabStop = false;
            // 
            // comet4
            // 
            this.comet4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comet4.BackgroundImage")));
            this.comet4.Image = global::SpaceShooter.Properties.Resources.comet;
            this.comet4.Location = new System.Drawing.Point(516, -500);
            this.comet4.Margin = new System.Windows.Forms.Padding(4);
            this.comet4.Name = "comet4";
            this.comet4.Size = new System.Drawing.Size(51, 57);
            this.comet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comet4.TabIndex = 5;
            this.comet4.TabStop = false;
            // 
            // comet3
            // 
            this.comet3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comet3.BackgroundImage")));
            this.comet3.Image = global::SpaceShooter.Properties.Resources.comet;
            this.comet3.Location = new System.Drawing.Point(325, -148);
            this.comet3.Margin = new System.Windows.Forms.Padding(4);
            this.comet3.Name = "comet3";
            this.comet3.Size = new System.Drawing.Size(51, 57);
            this.comet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comet3.TabIndex = 4;
            this.comet3.TabStop = false;
            // 
            // comet2
            // 
            this.comet2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comet2.BackgroundImage")));
            this.comet2.Image = global::SpaceShooter.Properties.Resources.comet;
            this.comet2.Location = new System.Drawing.Point(151, -98);
            this.comet2.Margin = new System.Windows.Forms.Padding(4);
            this.comet2.Name = "comet2";
            this.comet2.Size = new System.Drawing.Size(51, 57);
            this.comet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comet2.TabIndex = 3;
            this.comet2.TabStop = false;
            // 
            // comet1
            // 
            this.comet1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comet1.BackgroundImage")));
            this.comet1.Image = global::SpaceShooter.Properties.Resources.comet;
            this.comet1.Location = new System.Drawing.Point(67, -130);
            this.comet1.Margin = new System.Windows.Forms.Padding(4);
            this.comet1.Name = "comet1";
            this.comet1.Size = new System.Drawing.Size(57, 57);
            this.comet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comet1.TabIndex = 2;
            this.comet1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpaceShooter.Properties.Resources.space;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 628);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 619);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.spaceship);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.bRestart);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.comet6);
            this.Controls.Add(this.comet5);
            this.Controls.Add(this.comet4);
            this.Controls.Add(this.comet3);
            this.Controls.Add(this.comet2);
            this.Controls.Add(this.comet1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox spaceship;
        public System.Windows.Forms.PictureBox comet1;
        public System.Windows.Forms.PictureBox comet2;
        public System.Windows.Forms.PictureBox comet3;
        public System.Windows.Forms.PictureBox comet4;
        public System.Windows.Forms.PictureBox comet5;
        public System.Windows.Forms.PictureBox comet6;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label labelLose;
        public System.Windows.Forms.Button bRestart;
        public System.Windows.Forms.PictureBox bullet;
        public System.Windows.Forms.Label labelScore;
        public System.Windows.Forms.PictureBox heart3;
        public System.Windows.Forms.PictureBox heart2;
        public System.Windows.Forms.PictureBox heart1;
    }
}

