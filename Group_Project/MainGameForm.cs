using Group_Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class MainGameForm : Form
    {

        ImageList.ImageCollection ImagesBlocks;
        GameClass obj = new GameClass();
        public MainGameForm()
        {
            InitializeComponent();
            obj.LoadWordsFromFile();
            lblWord.Text = obj.GetRandomWord();
            pbxOre.Image = imageListBlocks.Images[obj.getRandomBlock()];
            pbxOre.SizeMode = PictureBoxSizeMode.StretchImage;
            tmrCountdown.Start();
        }
        
        
        int timeElapsed = 0;
        
        private void btnMine_Click(object sender, EventArgs e)
        {
            //Call getRandomBlock and getRandomWord
            if(obj.equal(txtInput.Text) == true)
            {
                obj.addExp();
                lblExp.Text = "EXP Gained: " + obj.getExp().ToString();
                lblWord.Text = obj.GetRandomWord();
                pbxOre.Image = imageListBlocks.Images[obj.getRandomBlock()];
            }
            else
            {
                //MessageBox.Show("0");
                obj.removeDurability();
                lblWord.Text = obj.GetRandomWord();
                lblDurability.Text = "Durability: " + obj.getDurability().ToString() + "/5";
                pbxOre.Image = imageListBlocks.Images[obj.getRandomBlock()];
                if(obj.getDurability() == 0)
                {
                    this.Hide();
                    HighScoreForm newHighScoreForm = new HighScoreForm();
                    newHighScoreForm.ShowDialog();
                }
            }
            txtInput.Clear();
            //obj.getRandomBlock();
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
           ++timeElapsed;
           lblTimeRemaining.Text = "Time Remaining: " + (60 - timeElapsed).ToString();
           if(timeElapsed == 60)
           {
                this.Hide();
                HighScoreForm newHighScoreForm = new HighScoreForm();
                newHighScoreForm.ShowDialog();
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblExp_Click(object sender, EventArgs e)
        {

        }
    }
}
