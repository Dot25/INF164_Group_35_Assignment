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
        SoundPlayer music;
        public pnlWelcomeForm()
        {
            InitializeComponent();

            //music = new SoundPlayer(@"Resources/fellowship.wav");
            //string exePath = Path.GetDirectoryName(Application.ExecutablePath);

            // Combine it with the relative path to the Resources folder and the .wav file
            
            

            



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
            string wavFilePath = Path.Combine("Resources", "fellowship.wav");
            if (File.Exists(wavFilePath))
            {
                music = new SoundPlayer(wavFilePath);
                MessageBox.Show("File found!");
            }
            else
            {
                MessageBox.Show("WAV file not found!");
            }
            //music.PlayLooping();

            //music.PlayLooping(); // Plays the sound once
            // player.PlayLooping(); // Uncomment this line to loop the sound

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
