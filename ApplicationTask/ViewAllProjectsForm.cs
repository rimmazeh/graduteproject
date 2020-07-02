using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskSystem.NewFolder1
{
    public partial class ViewAllProjectsForm : Form
    {
        public ViewAllProjectsForm()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewAllProjectsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tasksTrackDataSet.Admin1' table. You can move, or remove it, as needed.
            this.admin1TableAdapter.Fill(this.tasksTrackDataSet.Admin1);

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
          
                   
           
        private void CloseBtn_MouseHover(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.FromArgb(0, 106, 134);
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.FromArgb(32, 158, 187);
        }
    }
}
