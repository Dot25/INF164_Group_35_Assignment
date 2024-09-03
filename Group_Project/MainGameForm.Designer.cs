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
            this.iml = new System.Windows.Forms.ImageList(this.components);
            this.lblWord = new System.Windows.Forms.Label();
            this.btnMine = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.pbxOre = new System.Windows.Forms.PictureBox();
            this.pbxAxe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAxe)).BeginInit();
            this.SuspendLayout();
            // 
            // iml
            // 
            this.iml.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iml.ImageSize = new System.Drawing.Size(16, 16);
            this.iml.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblWord
            // 
            this.lblWord.BackColor = System.Drawing.Color.White;
            this.lblWord.Location = new System.Drawing.Point(276, 213);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(205, 50);
            this.lblWord.TabIndex = 0;
            // 
            // btnMine
            // 
            this.btnMine.Location = new System.Drawing.Point(312, 354);
            this.btnMine.Name = "btnMine";
            this.btnMine.Size = new System.Drawing.Size(127, 60);
            this.btnMine.TabIndex = 1;
            this.btnMine.Text = "Mine";
            this.btnMine.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(279, 297);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(193, 22);
            this.txtInput.TabIndex = 2;
            // 
            // pbxOre
            // 
            this.pbxOre.Location = new System.Drawing.Point(259, 36);
            this.pbxOre.Name = "pbxOre";
            this.pbxOre.Size = new System.Drawing.Size(232, 147);
            this.pbxOre.TabIndex = 3;
            this.pbxOre.TabStop = false;
            // 
            // pbxAxe
            // 
            this.pbxAxe.Location = new System.Drawing.Point(614, 56);
            this.pbxAxe.Name = "pbxAxe";
            this.pbxAxe.Size = new System.Drawing.Size(112, 108);
            this.pbxAxe.TabIndex = 4;
            this.pbxAxe.TabStop = false;
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxAxe);
            this.Controls.Add(this.pbxOre);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnMine);
            this.Controls.Add(this.lblWord);
            this.Name = "MainGameForm";
            this.Text = "MainGameForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxOre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAxe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList iml;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnMine;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.PictureBox pbxOre;
        private System.Windows.Forms.PictureBox pbxAxe;
    }
}