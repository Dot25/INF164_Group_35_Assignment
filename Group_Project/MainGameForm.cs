using Group_Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class MainGameForm : Form
    {

        ImageList.ImageCollection ImagesBlocks;
        GameClass obj = new GameClass();
        BindingList<Record> recordsList;

        public MainGameForm()
        {
            InitializeComponent();
            obj.LoadWordsFromFile();
            lblWord.Text = obj.GetRandomWord();
            pbxOre.Image = imageListBlocks.Images[obj.getRandomBlock()];
            pbxOre.SizeMode = PictureBoxSizeMode.StretchImage;
            recordsList = new BindingList<Record>();


        }


        int timeElapsed = 0;
        
        private void btnMine_Click(object sender, EventArgs e)
        {
            //Checks if the player input matches the correct word
            if(obj.equal(txtInput.Text) == true)
            {
                //Updates exp and blocksbroken
                obj.addExp();
                obj.setBlocksBroken();
                lblExp.Text = "EXP Gained: " + obj.getExp().ToString();
                lblWord.Text = obj.GetRandomWord();
                pbxOre.Image = imageListBlocks.Images[obj.getRandomBlock()];
            }
            else
            {
                //Removes durability (attempts)
                obj.removeDurability();

                //Sets a new word and updates the labels
                lblWord.Text = obj.GetRandomWord();
                lblDurability.Text = "Durability: " + obj.getDurability().ToString() + "/5";

                //Sets the new image
                pbxOre.Image = imageListBlocks.Images[obj.getRandomBlock()];

                //Checks if the players still has attempts left
                if(obj.getDurability() == 0)
                {
                    //Adds the details to the records list and serializes it
                    recordsList.Add(new Record(obj.getName(), obj.getExp(), obj.getBlocksBroken()));
                    obj.WriteToFile("Records", recordsList);

                    //Closes the form
                    this.Hide();
                    HighScoreForm newHighScoreForm = new HighScoreForm();
                    newHighScoreForm.ShowDialog();
                }
            }
            //Clears the input
            txtInput.Clear();
            
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
           ++timeElapsed;
           lblTimeRemaining.Text = "Time Remaining: " + (60 - timeElapsed).ToString();
           if(timeElapsed == 60)
           {
                //Adds the details to the records list and serializes it
                recordsList.Add(new Record(obj.getName(), obj.getExp(), obj.getBlocksBroken()));
                obj.WriteToFile("Records", recordsList);

                //Closes the form
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
        
        private void btnName_Click(object sender, EventArgs e)
        {
            //Switches the interface from get name to the games and starts the game timer
            tmrCountdown.Start();
            obj.setName(txtName.Text);
            lblExp.Visible = true;
            lblName.Visible = false;
            lblDurability.Visible = true;
            lblTimeRemaining.Visible = true;
            btnMine.Visible = true;
            btnName.Visible = false;
            txtInput.Visible = true;
            txtName.Visible = false;
            pbxAxe.Visible = true;
            pbxOre.Visible = true;
            lblWord.Visible = true;
            
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
