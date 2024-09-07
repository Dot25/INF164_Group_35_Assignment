namespace Group_Project
{
    partial class InstructionsForm
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
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.Location = new System.Drawing.Point(179, 66);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.Size = new System.Drawing.Size(409, 264);
            this.rtbInstructions.TabIndex = 0;
            this.rtbInstructions.Text = "";
            // 
            // InstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbInstructions);
            this.Name = "InstructionsForm";
            this.Text = "InstructionsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInstructions;
    }
}