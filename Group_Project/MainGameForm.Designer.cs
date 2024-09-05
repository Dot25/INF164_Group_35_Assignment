﻿namespace Group_Project
{
    partial class MainGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameForm));
            this.imageListBackground = new System.Windows.Forms.ImageList(this.components);
            this.lblWord = new System.Windows.Forms.Label();
            this.btnMine = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.pbxOre = new System.Windows.Forms.PictureBox();
            this.pbxAxe = new System.Windows.Forms.PictureBox();
            this.imageListBlocks = new System.Windows.Forms.ImageList(this.components);
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxOre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAxe)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListBackground
            // 
            this.imageListBackground.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBackground.ImageStream")));
            this.imageListBackground.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBackground.Images.SetKeyName(0, "background_1.jpg");
            this.imageListBackground.Images.SetKeyName(1, "background_2.jpg");
            this.imageListBackground.Images.SetKeyName(2, "background_3.jpg");
            this.imageListBackground.Images.SetKeyName(3, "background_4.png");
            this.imageListBackground.Images.SetKeyName(4, "background_5.jpg");
            // 
            // lblWord
            // 
            this.lblWord.BackColor = System.Drawing.Color.White;
            this.lblWord.Location = new System.Drawing.Point(207, 173);
            this.lblWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(154, 41);
            this.lblWord.TabIndex = 0;
            // 
            // btnMine
            // 
            this.btnMine.Location = new System.Drawing.Point(237, 288);
            this.btnMine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMine.Name = "btnMine";
            this.btnMine.Size = new System.Drawing.Size(95, 49);
            this.btnMine.TabIndex = 1;
            this.btnMine.Text = "Mine";
            this.btnMine.UseVisualStyleBackColor = true;
            this.btnMine.Click += new System.EventHandler(this.btnMine_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(211, 241);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(146, 20);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // pbxOre
            // 
            this.pbxOre.Location = new System.Drawing.Point(209, 11);
            this.pbxOre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxOre.Name = "pbxOre";
            this.pbxOre.Size = new System.Drawing.Size(150, 150);
            this.pbxOre.TabIndex = 3;
            this.pbxOre.TabStop = false;
            // 
            // pbxAxe
            // 
            this.pbxAxe.BackColor = System.Drawing.Color.Transparent;
            this.pbxAxe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxAxe.BackgroundImage")));
            this.pbxAxe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxAxe.Location = new System.Drawing.Point(403, 50);
            this.pbxAxe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxAxe.Name = "pbxAxe";
            this.pbxAxe.Size = new System.Drawing.Size(84, 84);
            this.pbxAxe.TabIndex = 4;
            this.pbxAxe.TabStop = false;
            // 
            // imageListBlocks
            // 
            this.imageListBlocks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBlocks.ImageStream")));
            this.imageListBlocks.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBlocks.Images.SetKeyName(0, "dirt_750x750.jpeg");
            this.imageListBlocks.Images.SetKeyName(1, "sand_750x750.jpeg");
            this.imageListBlocks.Images.SetKeyName(2, "stone_750x750.jpeg");
            this.imageListBlocks.Images.SetKeyName(3, "coal_750_750.jpeg");
            this.imageListBlocks.Images.SetKeyName(4, "copper_750x750.jpg");
            this.imageListBlocks.Images.SetKeyName(5, "iron_750x750.jpeg");
            this.imageListBlocks.Images.SetKeyName(6, "gold_750x750.jpg");
            this.imageListBlocks.Images.SetKeyName(7, "emerald_750_750.jpg");
            this.imageListBlocks.Images.SetKeyName(8, "diamond_750x750.png");
            this.imageListBlocks.Images.SetKeyName(9, "obsidian_750x750.jpg");
            this.imageListBlocks.Images.SetKeyName(10, "bedrock 750x750.png");
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pbxAxe);
            this.Controls.Add(this.pbxOre);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnMine);
            this.Controls.Add(this.lblWord);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainGameForm";
            this.Text = "MainGameForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxOre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAxe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListBackground;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnMine;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.PictureBox pbxOre;
        private System.Windows.Forms.PictureBox pbxAxe;
        private System.Windows.Forms.ImageList imageListBlocks;
        private System.Windows.Forms.Timer tmrCountdown;
    }
}