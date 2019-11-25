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
            this.EnergyLabeI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FeedButton
            // 
            this.FeedButton.Location = new System.Drawing.Point(338, 326);
            this.FeedButton.Name = "FeedButton";
            this.FeedButton.Size = new System.Drawing.Size(75, 53);
            this.FeedButton.TabIndex = 0;
            this.FeedButton.Text = "Feed";
            this.FeedButton.UseVisualStyleBackColor = true;
            this.FeedButton.Click += new System.EventHandler(this.FeedButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(193, 326);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 53);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SleepButton
            // 
            this.SleepButton.Location = new System.Drawing.Point(470, 326);
            this.SleepButton.Name = "SleepButton";
            this.SleepButton.Size = new System.Drawing.Size(76, 53);
            this.SleepButton.TabIndex = 2;
            this.SleepButton.Text = "Sleep";
            this.SleepButton.UseVisualStyleBackColor = true;
            this.SleepButton.Click += new System.EventHandler(this.SleepButton_Click);
            // 
            // HungerLabel
            // 
            this.HungerLabel.AutoSize = true;
            this.HungerLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HungerLabel.Location = new System.Drawing.Point(109, 80);
            this.HungerLabel.Name = "HungerLabel";
            this.HungerLabel.Size = new System.Drawing.Size(113, 39);
            this.HungerLabel.TabIndex = 3;
            this.HungerLabel.Text = "Food: 0";
            // 
            // HappyLabel
            // 
            this.HappyLabel.AutoSize = true;
            this.HappyLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HappyLabel.Location = new System.Drawing.Point(298, 80);
            this.HappyLabel.Name = "HappyLabel";
            this.HappyLabel.Size = new System.Drawing.Size(181, 39);
            this.HappyLabel.TabIndex = 4;
            this.HappyLabel.Text = "Happiness: 0";
            // 
            // EnergyLabel
            // 
            this.EnergyLabel.AutoSize = true;
            this.EnergyLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnergyLabel.Location = new System.Drawing.Point(532, 80);
            this.EnergyLabel.Name = "EnergyLabel";
            this.EnergyLabel.Size = new System.Drawing.Size(141, 39);
            this.EnergyLabel.TabIndex = 5;
            this.EnergyLabel.Text = "Energy: 0";
            this.EnergyLabel.Click += new System.EventHandler(this.EnergyLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(305, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // EnergyLabeI
            // 
            this.EnergyLabeI.AutoSize = true;
            this.EnergyLabeI.ForeColor = System.Drawing.SystemColors.Control;
            this.EnergyLabeI.Location = new System.Drawing.Point(-30, -30);
            this.EnergyLabeI.Name = "EnergyLabeI";
            this.EnergyLabeI.Size = new System.Drawing.Size(149, 17);
            this.EnergyLabeI.TabIndex = 7;
            this.EnergyLabeI.Text = "Gjord av Leo och Teo!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnergyLabeI);
            this.Controls.Add(this.EnergyLabel);
            this.Controls.Add(this.HappyLabel);
            this.Controls.Add(this.HungerLabel);
            this.Controls.Add(this.SleepButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.FeedButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Tamagotchi (Leo & Teo exemplar version)";
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
        private System.Windows.Forms.Label EnergyLabeI;
    }
}

