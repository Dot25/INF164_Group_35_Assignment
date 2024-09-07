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
        }
        
        
        int timeElapsed = 0;

        private void btnMine_Click(object sender, EventArgs e)
        {
            //Call getRandomBlock and getRandomWord
            if(obj.equal(txtInput.Text) == true)
            {
                obj.addExp();
                lblWord.Text = obj.GetRandomWord();
                //MessageBox.Show("1");
            }
            else
            {
                //MessageBox.Show("0");
                if (obj.removeDurability() == false)
                {
                    //End Game

                }
                else
                {
                    lblWord.Text = obj.GetRandomWord();
                }
            }
            
            //obj.getRandomBlock();
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
           ++timeElapsed;
           if(timeElapsed == 60)
           {
              //Get Exp method
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
