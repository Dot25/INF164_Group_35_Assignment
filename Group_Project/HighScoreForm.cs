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
    public partial class HighScoreForm : Form
    {
        public HighScoreForm()
        {
            InitializeComponent();
        }

  

        private void dgvHighScores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Declaration of BindingList
        BindingList<Record> recordsList = new BindingList<Record>();
        
        
        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            //dgvHighScores uses the binding list as the data source
            GameClass obj = new GameClass();
            obj.ReadFromFile("Records", recordsList);
            
            dgvHighScores.DataSource = recordsList;
            
        }

        private void btnBestPlayer_Click(object sender, EventArgs e)
        {
            //Finds the best score and displays it
            string bestPlayer = recordsList[0].Name;
            int bestScore = recordsList[0].TotalExp;
           for(int i = 0; i < recordsList.Count; ++i)
           {
                if (recordsList[i].TotalExp > bestScore) 
                {
                    bestScore = recordsList[i].TotalExp;
                    bestPlayer = recordsList[i].Name;
                }
           }
            MessageBox.Show("The best player is (" + bestPlayer + ") with a top Exp of : " + bestScore);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Returns to the welcome form
            this.Hide();
            pnlWelcomeForm Form1 = new pnlWelcomeForm();
            Form1.ShowDialog();
        }
    }
}
