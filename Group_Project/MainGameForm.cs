﻿using Group_Project.Class;
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
        
        public MainGameForm()
        {
            InitializeComponent();
            GameClass obj = new GameClass();
            pbxOre.Image = imageListBlocks.Images[obj.getRandomBlock()];
            pbxOre.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        
        
        int timeElapsed = 0;

        private void btnMine_Click(object sender, EventArgs e)
        {
            //Call getRandomBlock and getRandomWord
            GameClass obj = new GameClass();
            obj.getRandomBlock();
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
    }
}
