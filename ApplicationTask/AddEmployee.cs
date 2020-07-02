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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

       

        public String str_constring = @"Data Source=(local);Initial Catalog=TasksTrack;Integrated Security=True";

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DashboardMainForm f = new DashboardMainForm();
            f.Show();
            this.Hide();
        }

        

        private void FNTxt_TextChanged(object sender, EventArgs e)
        {
            if (FNTxt.Text == String.Empty)
            {
                Firstnameabel.Show();
            }
            else
                Firstnameabel.Hide();
        }

       

        private void LNTxt_TextChanged(object sender, EventArgs e)
        {
            if (LNTxt.Text == String.Empty)
            {
                LastNameLbl.Show();
            }
            else
                LastNameLbl.Hide();
        }

        

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
            if (EmailTxt.Text == String.Empty)
            {
                Emaillabel.Show();
            }
            else
                Emaillabel.Hide();
        }

        private void PhoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (PhoneTxt.Text == String.Empty)
            {
                Phonelabel.Show();
            }
            else
                Phonelabel.Hide();
        }

        
        private void CityTxt_TextChanged(object sender, EventArgs e)
        {
            if (CityTxt.Text == String.Empty)
            {
                addresslbl.Show();
            }
            else
                addresslbl.Hide();
        }

       

        private void closePBX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FNTxt.Text = String.Empty;
            LNTxt.Text= String.Empty;
            EmailTxt.Text= String.Empty;
            PhoneTxt.Text= String.Empty;
            CityTxt.Text= String.Empty;
           
        }

       

        private void jobpositionTxt_TextChanged(object sender, EventArgs e)
        {
            if (jobpositionTxt.Text == String.Empty)
            {
                jobLbl.Show();
            }
            else
                jobLbl.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizedbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        

        private void MiddleNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (MiddleNameTxt.Text == String.Empty)
            {
                MiddleNameLbl.Show();
            }
            else
                MiddleNameLbl.Hide();
        }

        private void PersonalGbx_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
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
