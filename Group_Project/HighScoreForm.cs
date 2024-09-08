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
        BindingList<Record> recordsList = new BindingList<Record>();
        
        
        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            GameClass obj = new GameClass();
            recordsList = obj.ReadFromFile("Records");
            dgvHighScores.DataSource = recordsList;

        }
    }
}
