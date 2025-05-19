namespace SpaceShooter
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spaceship = new System.Windows.Forms.PictureBox();
            this.comet1 = new System.Windows.Forms.PictureBox();
            this.comet2 = new System.Windows.Forms.PictureBox();
            this.comet3 = new System.Windows.Forms.PictureBox();
            this.comet4 = new System.Windows.Forms.PictureBox();
            this.comet5 = new System.Windows.Forms.PictureBox();
            this.comet6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelLose = new System.Windows.Forms.Label();
            this.bRestart = new System.Windows.Forms.Button();
            this.bullet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 628);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // spaceship
            // 
            this.spaceship.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spaceship.BackgroundImage")));
            this.spaceship.Image = ((System.Drawing.Image)(resources.GetObject("spaceship.Image")));
            this.spaceship.Location = new System.Drawing.Point(439, 427);
            this.spaceship.Margin = new System.Windows.Forms.Padding(4);
            this.spaceship.Name = "spaceship";
            this.spaceship.Size = new System.Drawing.Size(174, 179);
            this.spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spaceship.TabIndex = 1;
            this.spaceship.TabStop = false;
            // 
            // comet1
            // 
            this.comet1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comet1.BackgroundImage")));
            this.comet1.Image = ((System.Drawing.Image)(resources.GetObject("comet1.Image")));
            this.comet1.Location = new System.Drawing.Point(67, -130);
            this.comet1.Margin = new System.Windows.Forms.Padding(4);
            this.comet1.Name = "comet1";
            this.comet1.Size = new System.Drawing.Size(57, 57);
            this.comet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comet1.TabIndex = 2;
            this.comet1.TabStop = false;
            // 
            // comet2
            // 
            this.comet2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comet2.BackgroundImage")));
            this.comet2.Image = ((System.Drawing.Image)(resources.GetObject("comet2.Image")));
            this.comet2.Location = new System.Drawing.Point(151, -98);
            this.comet2.Margin = new System.Windows.Forms.Padding(4);
            this.comet2.Name = "comet2";
            this.comet2.Size = new System.Drawing.Size(51, 57);
            this.comet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comet2.TabIndex = 3;
            this.comet2.TabStop = false;
            // 
            // comet3
            // 
            this.comet3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comet3.BackgroundImage")));
            this.comet3.Image = ((System.Drawing.Image)(resources.GetObject("comet3.Image")));
            this.comet3.Location = new System.Drawing.Point(325, -148);
            this.comet3.Margin = new System.Windows.Forms.Padding(4);
            this.comet3.Name = "comet3";
            this.comet3.Size = new System.Drawing.Size(51, 57);
            this.comet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comet3.TabIndex = 4;
            this.comet3.TabStop = false;
            // 
            // comet4
            // 
            this.comet4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comet4.BackgroundImage")));
            this.comet4.Image = ((System.Drawing.Image)(resources.GetObject("comet4.Image")));
            this.comet4.Location = new System.Drawing.Point(516, -500);
            this.comet4.Margin = new System.Windows.Forms.Padding(4);
            this.comet4.Name = "comet4";
            this.comet4.Size = new System.Drawing.Size(51, 57);
            this.comet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comet4.TabIndex = 5;
            this.comet4.TabStop = false;
            // 
            // comet5
            // 
            this.comet5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comet5.BackgroundImage")));
            this.comet5.Image = ((System.Drawing.Image)(resources.GetObject("comet5.Image")));
            this.comet5.Location = new System.Drawing.Point(620, -246);
            this.comet5.Margin = new System.Windows.Forms.Padding(4);
            this.comet5.Name = "comet5";
            this.comet5.Size = new System.Drawing.Size(51, 57);
            this.comet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comet5.TabIndex = 6;
            this.comet5.TabStop = false;
            // 
            // comet6
            // 
            this.comet6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comet6.BackgroundImage")));
            this.comet6.Image = ((System.Drawing.Image)(resources.GetObject("comet6.Image")));
            this.comet6.Location = new System.Drawing.Point(712, -795);
            this.comet6.Margin = new System.Windows.Forms.Padding(4);
            this.comet6.Name = "comet6";
            this.comet6.Size = new System.Drawing.Size(51, 57);
            this.comet6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comet6.TabIndex = 7;
            this.comet6.TabStop = false;
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
            this.labelLose.Location = new System.Drawing.Point(381, 87);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(274, 55);
            this.labelLose.TabIndex = 8;
            this.labelLose.Text = "YOU LOST";
            // 
            // bRestart
            // 
            this.bRestart.BackColor = System.Drawing.Color.LightGreen;
            this.bRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRestart.Location = new System.Drawing.Point(448, 174);
            this.bRestart.Name = "bRestart";
            this.bRestart.Size = new System.Drawing.Size(196, 70);
            this.bRestart.TabIndex = 9;
            this.bRestart.Text = "RESTART";
            this.bRestart.UseVisualStyleBackColor = false;
            this.bRestart.Click += new System.EventHandler(this.bRestart_Click);
            // 
            // bullet
            // 
            this.bullet.Image = ((System.Drawing.Image)(resources.GetObject("bullet.Image")));
            this.bullet.Location = new System.Drawing.Point(511, 485);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(16, 47);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 10;
            this.bullet.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 619);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox spaceship;
        private System.Windows.Forms.PictureBox comet1;
        private System.Windows.Forms.PictureBox comet2;
        private System.Windows.Forms.PictureBox comet3;
        private System.Windows.Forms.PictureBox comet4;
        private System.Windows.Forms.PictureBox comet5;
        private System.Windows.Forms.PictureBox comet6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button bRestart;
        private System.Windows.Forms.PictureBox bullet;
    }
}

