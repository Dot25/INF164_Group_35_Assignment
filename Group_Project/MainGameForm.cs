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
        public MainGameForm()
        {
            InitializeComponent();
            pbxOre.Image = imageListBlocks.Images[0];
        }

        int timeElapsed = 0;

        private void btnMine_Click(object sender, EventArgs e)
        {
            
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            ++timeElapsed;
            if(timeElapsed == 10)
            {
                
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
