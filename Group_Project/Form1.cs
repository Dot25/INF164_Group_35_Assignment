using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;


namespace Group_Project
{
    public partial class pnlWelcomeForm : Form
    {
        
        public pnlWelcomeForm()
        {
            InitializeComponent();

            
            
            

            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGameForm newMainGameForm = new MainGameForm();
            newMainGameForm.ShowDialog();

        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Group_Project.Properties.Resources.fellowship); 
            audio.PlayLooping();
            

        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          
            this.Close();
            
        }
    }
}
