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
        //Declaring the SoundPlayer object to play the music
        SoundPlayer audio = new SoundPlayer(Group_Project.Properties.Resources.fellowship);
        public pnlWelcomeForm()
        {
            InitializeComponent();

        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Loops the audio when the form loads
            audio.PlayLooping();
            btnMusicOff.BackColor = Color.Red;
            btnMusic.BackColor = Color.Green;
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Hides this form and shows the MainGameForm
            this.Hide();
            MainGameForm newMainGameForm = new MainGameForm();
            newMainGameForm.ShowDialog();

        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            //Plays the audio on loop when the button is clicked and hides btnMusic and shows btnMusicOff
            audio.PlayLooping();
            btnMusic.Hide();
            btnMusicOff.Show();
            
            
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //Opens the instructions form
            InstructionsForm newInstructionsForm = new InstructionsForm();
            newInstructionsForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the program          
            this.Close();
            audio.Stop();
        }

        private void btnMusicOff_Click(object sender, EventArgs e)
        {
            //Plays the audio on loop when the button is clicked and hides btnMusic and shows btnMusicOff
            audio.Stop();
            btnMusicOff.Hide();
            btnMusic.Show();
        }
    }
}
