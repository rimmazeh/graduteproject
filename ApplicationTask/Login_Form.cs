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
using System.Threading;
using TaskSystem.Application;

namespace TaskSystem.ApplicationTask
{
    public partial class Login_Form : Form
    {

        public Login_Form()
        {
           
            InitializeComponent();
      
       
         }
       
        public String str_constring = @"Data Source=(local);Initial Catalog=TasksTrack;Integrated Security=True";

        private void UserNameTxt_Click(object sender, EventArgs e)
        {

            UserNameTxt.Clear();
            panel1.BackColor = Color.FromArgb(32, 158, 187);
            UserNameTxt.ForeColor = Color.FromArgb(32, 158, 187);
            userpic.Hide();
            userblue.Visible = true;

        }

        private void PassWordTxt_Click(object sender, EventArgs e)
        {
            PassWordTxt.UseSystemPasswordChar = true;
            passwordlbl.Hide();

           // PassWordTxt.Text = "";
            //if (PassWordTxt.Text == String.Empty)
            //{
            //    PasswordLbl.Show();
            //}

            //else  PasswordLbl.Hide();

            panel5.BackColor = Color.FromArgb(32, 158, 187);
            PassWordTxt.ForeColor = Color.FromArgb(32, 158, 187);
            passwordpic.Hide();
            passblue.Visible = true;
        }

      
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //username:rimano
            //password:abc

            SqlConnection c = new SqlConnection(str_constring);
            c.Open();

            string q = "select count(*) from Admin1 where [Username]='" + UserNameTxt.Text + "'and [Password]='" + PassWordTxt.Text + "';";

            SqlCommand cmd1 = new SqlCommand(q, c);

            int n = (int)cmd1.ExecuteScalar();

            if (n == 0)
            {
                MessageBox.Show("incorrect, Try again", "warning  !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                DashboardMainForm f = new DashboardMainForm();
                f.Show();
                this.Hide();
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mask_MouseHover(object sender, EventArgs e)
        {
            if (PassWordTxt.UseSystemPasswordChar == true)
            {

                PassWordTxt.UseSystemPasswordChar = false;
            }
            //else
            //{
            //    PassWordTxt.UseSystemPasswordChar = true;
            //}
        }

        private void mask_MouseLeave(object sender, EventArgs e)
        {
            if (PassWordTxt.UseSystemPasswordChar == false)
            {
                PassWordTxt.UseSystemPasswordChar = true;
            }
            //else
            //{
            //    PassWordTxt.UseSystemPasswordChar = false;
            //}
        }

        private void roundedButtom2_Click(object sender, EventArgs e)
        {
            //username:rimano
            //password:abc

            SqlConnection c = new SqlConnection(str_constring);
            c.Open();

            string q = "select count(*) from Admin1 where [Username]='" + UserNameTxt.Text + "'and [Password]='" + PassWordTxt.Text + "';";

            SqlCommand cmd1 = new SqlCommand(q, c);

            int n = (int)cmd1.ExecuteScalar();

            if (n == 0)
            {
                MessageBox.Show("incorrect, Try again", "warning  !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                DashboardMainForm f = new DashboardMainForm();
                f.Show();
                this.Hide();
            }
        }

        private void UserNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
