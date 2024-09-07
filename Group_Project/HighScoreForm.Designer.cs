namespace Group_Project
{
    partial class HighScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScoreForm));
            this.dgvHighScores = new System.Windows.Forms.DataGridView();
            this.btnBestPlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHighScores
            // 
            this.dgvHighScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHighScores.Location = new System.Drawing.Point(185, 65);
            this.dgvHighScores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHighScores.Name = "dgvHighScores";
            this.dgvHighScores.RowHeadersWidth = 51;
            this.dgvHighScores.RowTemplate.Height = 24;
            this.dgvHighScores.Size = new System.Drawing.Size(411, 233);
            this.dgvHighScores.TabIndex = 0;
            this.dgvHighScores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHighScores_CellContentClick);
            // 
            // btnBestPlayer
            // 
            this.btnBestPlayer.Location = new System.Drawing.Point(227, 332);
            this.btnBestPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBestPlayer.Name = "btnBestPlayer";
            this.btnBestPlayer.Size = new System.Drawing.Size(349, 82);
            this.btnBestPlayer.TabIndex = 1;
            this.btnBestPlayer.Text = "Search for the best player";
            this.btnBestPlayer.UseVisualStyleBackColor = true;
            // 
            // HighScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBestPlayer);
            this.Controls.Add(this.dgvHighScores);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HighScoreForm";
            this.Text = "HighScoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHighScores;
        private System.Windows.Forms.Button btnBestPlayer;
    }
}