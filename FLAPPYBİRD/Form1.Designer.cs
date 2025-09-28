namespace FLAPPYBİRD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flappyBird = new PictureBox();
            BoruUst = new PictureBox();
            BoruAlt = new PictureBox();
            Zemin = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoruUst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).BeginInit();
            SuspendLayout();
            // 
            // flappyBird
            // 
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(47, 241);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(90, 62);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            flappyBird.Click += pictureBox1_Click;
            // 
            // BoruUst
            // 
            BoruUst.Image = (Image)resources.GetObject("BoruUst.Image");
            BoruUst.Location = new Point(548, -2);
            BoruUst.Name = "BoruUst";
            BoruUst.Size = new Size(115, 196);
            BoruUst.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruUst.TabIndex = 1;
            BoruUst.TabStop = false;
            // 
            // BoruAlt
            // 
            BoruAlt.Image = (Image)resources.GetObject("BoruAlt.Image");
            BoruAlt.Location = new Point(398, 380);
            BoruAlt.Name = "BoruAlt";
            BoruAlt.Size = new Size(114, 197);
            BoruAlt.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruAlt.TabIndex = 2;
            BoruAlt.TabStop = false;
            // 
            // Zemin
            // 
            Zemin.Image = (Image)resources.GetObject("Zemin.Image");
            Zemin.Location = new Point(0, 564);
            Zemin.Name = "Zemin";
            Zemin.Size = new Size(802, 62);
            Zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            Zemin.TabIndex = 3;
            Zemin.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            scoreText.Location = new Point(0, 629);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(137, 46);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score:0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(800, 668);
            Controls.Add(flappyBird);
            Controls.Add(scoreText);
            Controls.Add(Zemin);
            Controls.Add(BoruAlt);
            Controls.Add(BoruUst);
            Name = "Form1";
            Text = "Flappy Bird Game";
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoruUst).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).EndInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox BoruUst;
        private PictureBox BoruAlt;
        private PictureBox Zemin;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
