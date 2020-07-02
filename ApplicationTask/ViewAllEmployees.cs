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
    public partial class ViewAllEmployees : Form
    {
        public ViewAllEmployees()
        {
            InitializeComponent();
        }

     
        public String str_constring = @"Data Source=(local);Initial Catalog=TasksTrack;Integrated Security=True";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {
            // automativly all employees details are in the data grid

            SqlConnection c = new SqlConnection(str_constring);
            c.Open();

            string q = "select* from  Employee";

            SqlCommand cmd = new SqlCommand(q, c);
            cmd.CommandType = CommandType.Text;

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            datagrid1.DataSource = dt;
            c.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DashboardMainForm f = new DashboardMainForm();
            f.Show();
            this.Hide();
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
            CloseBtn.BackColor = Color.FromArgb(0, 106, 134);
        }
    }
}
