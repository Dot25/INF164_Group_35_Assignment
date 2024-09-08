using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class InstructionsForm : Form
    {
        public InstructionsForm()
        {
            InitializeComponent();
            LoadInstructions();
        }

        private void LoadInstructions()
        {

            try
            {
                
                {
                    string fileContent = Properties.Resources.Instructions;

                    // Displays the instructions in the RichTextBox
                    rtbInstructions.Text = fileContent;
                }
            }
            catch (Exception ex)
            {
                // Exception Handling
                MessageBox.Show($"An error occurred while loading the instructions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Returns to the welcome form
            this.Hide();
            
        }
    }
}
