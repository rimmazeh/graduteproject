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
    public partial class CreateNotes : Form
    {
        public CreateNotes()
        {
            InitializeComponent();
        }
        // public String str_constring = @"Data Source=(local);Initial Catalog=TasksTrack;Integrated Security=True";
        SqlConnection c = new SqlConnection(@"Data Source=(local);Initial Catalog=TasksTrack;Integrated Security=True");
        SqlConnection c1 = new SqlConnection(@"Data Source=(local);Initial Catalog=TasksTrack;Integrated Security=True");

        private void ProjectLbl_Click(object sender, EventArgs e)
        {

        }

       

        private void ViewNotes_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //enregistre le contenu dans database
            //SqlConnection c = new SqlConnection(str_constring);
            try
            {
                c.Open();
                string q = "select count(*) from EmployeeNotes where Title='" + NoteTitleTxt.Text + "'";

                SqlCommand cmd = new SqlCommand(q, c);

                cmd.CommandType = CommandType.Text;  

                int x = (int)cmd.ExecuteScalar();
                c.Close();
                if (x == 0)
                {

                    string text;

                    text = "insert into EmployeeNotes values(" + EmpcomboBox1.SelectedValue + "," + TaskCbx.SelectedValue + ",'" + dateTimePicker1.Value + "','" + NoteTitleTxt.Text + "','" + DescTxt.Text + "' )";
                    c.Close();
                    // SqlConnection c1 = new SqlConnection(str_constring);

                    SqlCommand cmd1 = new SqlCommand(text, c1);

                    c1.Open();
                    cmd1.ExecuteNonQuery();

                    c1.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("seccsss");
            }
        }

        
    

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateNotes_Load(object sender, EventArgs e)
        {
           // SqlConnection c = new SqlConnection(str_constring);
            c.Open();

            SqlCommand cmd = new SqlCommand("select * from Task", c);


            cmd.CommandType = CommandType.Text;

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);

            TaskCbx.DataSource = dt;
            TaskCbx.DisplayMember = "Title";
            TaskCbx.ValueMember = "T_Id";

            SqlCommand cmd1 = new SqlCommand("select * from Employee", c);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr1);
            EmpcomboBox1.DataSource = dt2;
            EmpcomboBox1.DisplayMember = "FirstName";
            EmpcomboBox1.ValueMember = "E_Id";

            c.Close();

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DescTxt.Clear();
            NoteTitleTxt.Clear();
            
        }

        private void editPIC_Click(object sender, EventArgs e)
        {
           // SqlConnection c = new SqlConnection(str_constring);

            String query;
            query = "UPDATE [TasksTrack].[dbo].[EmployeeNotes] SET[EmployeeId] = '" + EmpcomboBox1.SelectedValue + "',TaskId='" + TaskCbx.SelectedValue + "',NDate='" + Convert.ToDateTime(dateTimePicker1.Value) + "',Title='" + NoteTitleTxt.Text + "' Where Title ='" + NoteTitleTxt.Text + "';";

            SqlCommand cmd = new SqlCommand(query, c);
            cmd.CommandType = CommandType.Text;
            c.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            c.Close();

            //SqlConnection c1 = new SqlConnection(str_constring);
            c1.Open();

            String display;
            display = "select * From EmployeeNotes";

            SqlCommand cmd2 = new SqlCommand(display, c1);
            cmd2.CommandType = CommandType.Text;


            SqlDataReader dr1;
            dr1 = cmd2.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr1);
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
            dataGridView.DataSource = dt;
            c1.Close();
        }

        private void DeletePIc_Click(object sender, EventArgs e)
        {
           // SqlConnection c = new SqlConnection(str_constring);

            String query;
            query = "Delete from [TasksTrack].[dbo].[EmployeeNotes] Where Title ='" + NoteTitleTxt.Text + "';";

            SqlCommand cmd = new SqlCommand(query, c);
            cmd.CommandType = CommandType.Text;
            c.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            c.Close();

            //SqlConnection c1 = new SqlConnection(str_constring);

            c1.Open();
      

            String display;
            display = "select * From EmployeeNotes";

            SqlCommand cmd2 = new SqlCommand(display, c1);
            cmd2.CommandType = CommandType.Text;


            SqlDataReader dr1;
            dr1 = cmd2.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr1);
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
            dataGridView.DataSource = dt;
            c1.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            tabControl1.BackColor = Color.FromArgb(255, 192, 192);

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            //display everything
            // SqlConnection c = new SqlConnection(str_constring);

            String query;
            query = "select * from EmployeeNotes";
             //   "select Employee.EmployeeId,Task1.Title,Employee.NDate,Employee.Title,Employee.Description" +
               // " from EmployeeNotes Employee inner join Task Task1 on   Employee.TasksId=Task1.T_Id  ";


            SqlCommand cmd = new SqlCommand(query, c);
            cmd.CommandType = CommandType.Text;
            c.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
            dataGridView.DataSource = dt;
            dataGridView.Update();


            c.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // SqlConnection c = new SqlConnection(str_constring);

            String query;
            query = "select * from EmployeeNotes Where Title '" + SearchTxt.Text+ "'; ";
            //   "select Employee.EmployeeId,Task1.Title,Employee.NDate,Employee.Title,Employee.Description" +
            // " from EmployeeNotes Employee inner join Task Task1 on   Employee.TasksId=Task1.T_Id  ";


            SqlCommand cmd = new SqlCommand(query, c);
            cmd.CommandType = CommandType.Text;
            c.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
            dataGridView.DataSource = dt;
            dataGridView.Update();


            c.Close();
        }
    }
}
