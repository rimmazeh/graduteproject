using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;



namespace TaskSystem.NewFolder1
{
    public partial class CreateTask : Form
    {
        public CreateTask()
        {
            InitializeComponent();
        }
        public String str_constring = @"Data Source=(local);Initial Catalog=TasksTrack;Integrated Security=True";
        
        

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void CreateTask_Load(object sender, EventArgs e)
        {


            SqlConnection c = new SqlConnection(str_constring);
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from Projects", c);
            cmd.CommandType = CommandType.Text;


            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            ProjectCbx.DataSource = dt;
            ProjectCbx.DisplayMember = "Title";   //la maniere dont il s'ffiche dans la forme
            ProjectCbx.ValueMember = "P_Id";

            //display all tasks in data grid on load
            String query;
            query = "select *  from Task ";

            SqlCommand cmd1 = new SqlCommand(query, c);
            cmd1.CommandType = CommandType.Text;


            SqlDataReader dr1 = cmd1.ExecuteReader();

            DataTable dt1 = new DataTable();
            dt1.Load(dr1);
            dataGridView1.DataSource = dt1;
            dataGridView1.Update();

            c.Close();

            PrioritycomboBox.Items.Add("Priority 1");
            PrioritycomboBox.Items.Add("Priority 2");
            PrioritycomboBox.Items.Add("Priority 3");

         //   PrioritycomboBox.Items.Insert(0, imageList1.Images[1]);
          //  PrioritycomboBox.Items.Insert(1, imageList1.Images[2]);

            



        }

       

        private void label4_Click(object sender, EventArgs e)
        {            //display everything
            SqlConnection c = new SqlConnection(str_constring);

            String query;
            query = "select *  from Task ";

            SqlCommand cmd = new SqlCommand(query, c);
            cmd.CommandType = CommandType.Text;
            c.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            c.Close();


        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(str_constring);

            String query;
            query = "select *  from Task ";

            SqlCommand cmd = new SqlCommand(query, c);
            cmd.CommandType = CommandType.Text;
            c.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            c.Close();
        }

        private void editPIC_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(str_constring);

            String query;
            query = "UPDATE [TasksTrack].[dbo].[Task] SET [ProjectId]=" + ProjectCbx.SelectedValue + ", [Title]   = '" + TaskTxt.Text + "',[Description]='" + DescTxt.Text + "',StartingDate='"+Convert.ToDateTime(StartdateTimePicker.Value)+ "',EndingDate='" + Convert.ToDateTime(EndingdateTimePicker.Value) + "' Where Title = '" + TaskTxt.Text + "' ;";

            SqlCommand cmd = new SqlCommand(query, c);
            cmd.CommandType = CommandType.Text;
            c.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            c.Close();
            SqlConnection c1 = new SqlConnection(str_constring);
            c1.Open();

            String display;
            display = "select * From [Task]";

            SqlCommand cmd2 = new SqlCommand(display, c1);
            cmd2.CommandType = CommandType.Text;


            SqlDataReader dr1;
            dr1 = cmd2.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr1);
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
            //dataGridView.DataSource = dt;
            c1.Close();
        }

        private void DeletePIc_Click(object sender, EventArgs e)
        {

            SqlConnection c = new SqlConnection(str_constring);

            String query;
            query = "Delete from [TasksTrack].[dbo].[Task] Where Title ='" + TaskTxt.Text + "';";

            SqlCommand cmd = new SqlCommand(query, c);
            cmd.CommandType = CommandType.Text;
            c.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            c.Close();
            SqlConnection c1 = new SqlConnection(str_constring);
            c1.Open();

            String display;
            display = "select * From [Task]";

            SqlCommand cmd2 = new SqlCommand(display, c1);
            cmd2.CommandType = CommandType.Text;


            SqlDataReader dr1;
            dr1 = cmd2.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr1);
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
            //dataGridView.DataSource = dt;
            c1.Close();
        }

        private void ClearPic_Click(object sender, EventArgs e)
        {
            ProjectCbx.SelectedIndex = -1;
            TaskTxt.Clear();
            DescTxt.Clear();
        }

        private void ProjectCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TaskTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roundedButtom2_Click(object sender, EventArgs e)
        {

            SqlConnection c = new SqlConnection(str_constring);
            c.Open();
            string q = "select count(*) from Task where Title='" + TaskTxt.Text + "'";

            SqlCommand cmd = new SqlCommand(q, c);

            cmd.CommandType = CommandType.Text;  //mas5araa

            int x = (int)cmd.ExecuteScalar();

            if (x == 0)
            {

                string text;

                text = "insert into Task values(" + ProjectCbx.SelectedValue + ",'" + TaskTxt.Text + "','" + DescTxt.Text + "','" + StartdateTimePicker.Value + "','" + EndingdateTimePicker.Value + "' )";


                SqlConnection c1 = new SqlConnection(str_constring);

                SqlCommand cmd1 = new SqlCommand(text, c1);

                c1.Open();
                cmd1.ExecuteNonQuery();
                c1.Close();

            }
            else
            {
                MessageBox.Show("cette etask existe deja");

            }
        }

        private void roundedButtom1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
