namespace Group_Project
{
    partial class pnlWelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlWelcomeForm));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnMusicOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(304, 174);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(181, 41);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(304, 238);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(181, 41);
            this.btnInstructions.TabIndex = 1;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.Location = new System.Drawing.Point(304, 307);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(181, 41);
            this.btnMusic.TabIndex = 2;
            this.btnMusic.Text = "Music On";
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(304, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 41);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(61, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(666, 168);
            this.pbxLogo.TabIndex = 4;
            this.pbxLogo.TabStop = false;
            // 
            // btnMusicOff
            // 
            this.btnMusicOff.Location = new System.Drawing.Point(304, 307);
            this.btnMusicOff.Name = "btnMusicOff";
            this.btnMusicOff.Size = new System.Drawing.Size(181, 41);
            this.btnMusicOff.TabIndex = 5;
            this.btnMusicOff.Text = "Music Off";
            this.btnMusicOff.UseVisualStyleBackColor = true;
            this.btnMusicOff.Click += new System.EventHandler(this.btnMusicOff_Click);
            // 
            // pnlWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMusicOff);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnPlay);
            this.Name = "pnlWelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnMusicOff;
    }
}

