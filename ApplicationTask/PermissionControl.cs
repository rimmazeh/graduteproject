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

namespace TaskSystem.ApplicationTask
{
    public partial class PermissionControl : Form
    {
        public PermissionControl()
        {
            InitializeComponent();
        }
        public String str_constring = @"Data Source=(local);Initial Catalog=TasksTrack;Integrated Security=True";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

      
         
       
        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            DashboardMainForm f = new DashboardMainForm();
            f.Show();
            this.Hide();
        }
    }
}
