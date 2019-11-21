namespace Tamagotchi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FeedButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SleepButton = new System.Windows.Forms.Button();
            this.HungerLabel = new System.Windows.Forms.Label();
            this.HappyLabel = new System.Windows.Forms.Label();
            this.EnergyLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FeedButton
            // 
            this.FeedButton.Location = new System.Drawing.Point(507, 509);
            this.FeedButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FeedButton.Name = "FeedButton";
            this.FeedButton.Size = new System.Drawing.Size(112, 83);
            this.FeedButton.TabIndex = 0;
            this.FeedButton.Text = "Feed";
            this.FeedButton.UseVisualStyleBackColor = true;
            this.FeedButton.Click += new System.EventHandler(this.FeedButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(290, 509);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(112, 83);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SleepButton
            // 
            this.SleepButton.Location = new System.Drawing.Point(705, 509);
            this.SleepButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SleepButton.Name = "SleepButton";
            this.SleepButton.Size = new System.Drawing.Size(114, 83);
            this.SleepButton.TabIndex = 2;
            this.SleepButton.Text = "Sleep";
            this.SleepButton.UseVisualStyleBackColor = true;
            this.SleepButton.Click += new System.EventHandler(this.SleepButton_Click);
            // 
            // HungerLabel
            // 
            this.HungerLabel.AutoSize = true;
            this.HungerLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HungerLabel.Location = new System.Drawing.Point(164, 125);
            this.HungerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HungerLabel.Name = "HungerLabel";
            this.HungerLabel.Size = new System.Drawing.Size(179, 61);
            this.HungerLabel.TabIndex = 3;
            this.HungerLabel.Text = "Food: 0";
            // 
            // HappyLabel
            // 
            this.HappyLabel.AutoSize = true;
            this.HappyLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HappyLabel.Location = new System.Drawing.Point(447, 125);
            this.HappyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HappyLabel.Name = "HappyLabel";
            this.HappyLabel.Size = new System.Drawing.Size(286, 61);
            this.HappyLabel.TabIndex = 4;
            this.HappyLabel.Text = "Happiness: 0";
            // 
            // EnergyLabel
            // 
            this.EnergyLabel.AutoSize = true;
            this.EnergyLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnergyLabel.Location = new System.Drawing.Point(798, 125);
            this.EnergyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnergyLabel.Name = "EnergyLabel";
            this.EnergyLabel.Size = new System.Drawing.Size(222, 61);
            this.EnergyLabel.TabIndex = 5;
            this.EnergyLabel.Text = "Energy: 0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(458, 212);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.EnergyLabel);
            this.Controls.Add(this.HappyLabel);
            this.Controls.Add(this.HungerLabel);
            this.Controls.Add(this.SleepButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.FeedButton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Tamagotchi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button FeedButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button SleepButton;
        private System.Windows.Forms.Label HungerLabel;
        private System.Windows.Forms.Label HappyLabel;
        private System.Windows.Forms.Label EnergyLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
    }
}

