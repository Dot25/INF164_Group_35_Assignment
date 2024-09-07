namespace Group_Project
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
            this.lblDurability = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
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
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWord.Location = new System.Drawing.Point(276, 213);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(205, 50);
            this.lblWord.TabIndex = 0;
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMine
            // 
            this.btnMine.Location = new System.Drawing.Point(315, 354);
            this.btnMine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMine.Name = "btnMine";
            this.btnMine.Size = new System.Drawing.Size(127, 60);
            this.btnMine.TabIndex = 1;
            this.btnMine.Text = "Mine";
            this.btnMine.UseVisualStyleBackColor = true;
            this.btnMine.Click += new System.EventHandler(this.btnMine_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(282, 297);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(193, 22);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // pbxOre
            // 
            this.pbxOre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxOre.BackgroundImage")));
            this.pbxOre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxOre.Image = ((System.Drawing.Image)(resources.GetObject("pbxOre.Image")));
            this.pbxOre.Location = new System.Drawing.Point(291, 14);
            this.pbxOre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxOre.Name = "pbxOre";
            this.pbxOre.Size = new System.Drawing.Size(175, 175);
            this.pbxOre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOre.TabIndex = 3;
            this.pbxOre.TabStop = false;
            // 
            // pbxAxe
            // 
            this.pbxAxe.BackColor = System.Drawing.Color.Transparent;
            this.pbxAxe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxAxe.BackgroundImage")));
            this.pbxAxe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxAxe.Location = new System.Drawing.Point(544, 14);
            this.pbxAxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxAxe.Name = "pbxAxe";
            this.pbxAxe.Size = new System.Drawing.Size(112, 103);
            this.pbxAxe.TabIndex = 4;
            this.pbxAxe.TabStop = false;
            // 
            // imageListBlocks
            // 
            this.imageListBlocks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBlocks.ImageStream")));
            this.imageListBlocks.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBlocks.Images.SetKeyName(0, "sand.jpg");
            this.imageListBlocks.Images.SetKeyName(1, "dirt.jpg");
            this.imageListBlocks.Images.SetKeyName(2, "stone.jpg");
            this.imageListBlocks.Images.SetKeyName(3, "coal.jpg");
            this.imageListBlocks.Images.SetKeyName(4, "copper.jpg");
            this.imageListBlocks.Images.SetKeyName(5, "iron.jpg");
            this.imageListBlocks.Images.SetKeyName(6, "gold.jpg");
            this.imageListBlocks.Images.SetKeyName(7, "diamond.png");
            this.imageListBlocks.Images.SetKeyName(8, "emerald.jpg");
            this.imageListBlocks.Images.SetKeyName(9, "obsidian.jpg");
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // lblDurability
            // 
            this.lblDurability.AutoSize = true;
            this.lblDurability.BackColor = System.Drawing.Color.Transparent;
            this.lblDurability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurability.Location = new System.Drawing.Point(529, 134);
            this.lblDurability.Name = "lblDurability";
            this.lblDurability.Size = new System.Drawing.Size(146, 25);
            this.lblDurability.TabIndex = 5;
            this.lblDurability.Text = "Durability: 5/5";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.BackColor = System.Drawing.Color.Transparent;
            this.lblExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExp.Location = new System.Drawing.Point(68, 134);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(143, 25);
            this.lblExp.TabIndex = 6;
            this.lblExp.Text = "EXP Gained: \r\n";
            this.lblExp.Click += new System.EventHandler(this.lblExp_Click);
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemaining.Location = new System.Drawing.Point(260, 416);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(235, 25);
            this.lblTimeRemaining.TabIndex = 7;
            this.lblTimeRemaining.Text = "Time Remaining: 00:00";
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblDurability);
            this.Controls.Add(this.pbxAxe);
            this.Controls.Add(this.pbxOre);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnMine);
            this.Controls.Add(this.lblWord);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblDurability;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblTimeRemaining;
    }
}