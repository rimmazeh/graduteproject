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
using TaskSystem.Application;

namespace TaskSystem.NewFolder1
{
    public partial class CreateProject : Form
    {
        public CreateProject()
        {
            InitializeComponent();
        }
        public String str_constring = @"Data Source=(local);Initial Catalog=TasksTrack;Integrated Security=True";
       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DashboardMainForm f = new DashboardMainForm();
            f.Show();
            this.Hide();
        }

       

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(str_constring);
            c.Open();
            string q = "select count(*) from Projects where Title='" + ProjectTxt.Text + "'";

            SqlCommand cmd = new SqlCommand(q, c);

            cmd.CommandType = CommandType.Text;  //mas5araa

            int x = (int)cmd.ExecuteScalar();

            if (x == 0)
            {

                string text;
                text = "insert into Projects values('" + ProjectTxt.Text + "', 1) ";


                SqlConnection c1 = new SqlConnection(str_constring);

                SqlCommand cmd1 = new SqlCommand(text, c1);

                c1.Open();
                cmd1.ExecuteNonQuery();
                c1.Close();


            }

            else
            {
                MessageBox.Show("this project already exists");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            //display everything
            SqlConnection c = new SqlConnection(str_constring);

            String query;
            query = "select *  from Projects ";

            SqlCommand cmd = new SqlCommand(query, c);
            cmd.CommandType = CommandType.Text;
            c.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView.DataSource = dt;
            dataGridView.Update();

            c.Close();

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            //display everything
            SqlConnection c = new SqlConnection(str_constring);

            String query;
            query = "select *  from Projects ";

            SqlCommand cmd = new SqlCommand(query, c);
            cmd.CommandType = CommandType.Text;
            c.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView.DataSource = dt;
            dataGridView.Update();

            c.Close();
        }

        private void editPIC_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(str_constring);

            String query;
            query = "UPDATE [TasksTrack].[dbo].[Projects] SET [Title]   = '" + ProjectTxt.Text + "', [IsDelivered]=1 Where Title = '" + ProjectTxt.Text + "' ;";

            SqlCommand cmd = new SqlCommand(query, c);
            cmd.CommandType = CommandType.Text;
            c.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            c.Close();
            SqlConnection c1 = new SqlConnection(str_constring);
            c1.Open();

            String display;
            display = "select * From Projects";

            SqlCommand cmd2 = new SqlCommand(display, c1);
            cmd2.CommandType = CommandType.Text;


            SqlDataReader dr1;
            dr1 = cmd2.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr1);
            dataGridView.DataSource = dt;
            dataGridView.Update();
            //dataGridView.DataSource = dt;
            c1.Close();
        }

        private void DeletePIc_Click(object sender, EventArgs e)
        {

            SqlConnection c = new SqlConnection(str_constring);

            String query;
            query = "Delete from [TasksTrack].[dbo].[Projects] Where Title = '" + ProjectTxt.Text + "' ;";

            SqlCommand cmd = new SqlCommand(query, c);
            cmd.CommandType = CommandType.Text;
            c.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            c.Close();
            SqlConnection c1 = new SqlConnection(str_constring);
            c1.Open();

            String display;
            display = "select * From Projects";

            SqlCommand cmd2 = new SqlCommand(display, c1);
            cmd2.CommandType = CommandType.Text;


            SqlDataReader dr1;
            dr1 = cmd2.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr1);
            dataGridView.DataSource = dt;
            dataGridView.Update();
            // dataGridView.DataSource = dt;
            c1.Close();
        }


        private void WorklineCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // e.handled=true

        }

        private void WorklineCbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateProject_Load(object sender, EventArgs e)
        {

        }

        private void ProjectLbl_Click(object sender, EventArgs e)
        {

        }

       

        private void roundedButtom1_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(str_constring);
            c.Open();
            string q = "select count(*) from Projects where Title='" + ProjectTxt.Text + "'";

            SqlCommand cmd = new SqlCommand(q, c);

            cmd.CommandType = CommandType.Text;  //mas5araa

            int x = (int)cmd.ExecuteScalar();

            if (x == 0)
            {

                string text;
                text = "insert into Projects values('" + ProjectTxt.Text + "', 1) ";


                SqlConnection c1 = new SqlConnection(str_constring);

                SqlCommand cmd1 = new SqlCommand(text, c1);

                c1.Open();
                cmd1.ExecuteNonQuery();
                c1.Close();


            }

            else
            {
                MessageBox.Show("this project already exists");
            }
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

