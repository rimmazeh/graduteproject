using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace TaskSystem.NewFolder1
{
    public partial class ViewETasks : Form
    {
        public ViewETasks()
        {
            InitializeComponent();
        }
        public String str_constring = @"Data Source=(local);Initial Catalog=TasksTrack;Integrated Security=True";
        private void ViewETasks_Load(object sender, EventArgs e)
        {
       
                  }

        private void label1_Click(object sender, EventArgs e)
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
