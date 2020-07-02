using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskSystem.Application.Services;
using TaskSystem.NewFolder1;

namespace TaskSystem.Application
{
    public partial class DashboardMainForm : Form
    {
        Class1 c1 = new Class1();
        int panelW;
        //object for all forms
        ViewAllTeams vat = new ViewAllTeams();
        ViewAllEmployees ve = new ViewAllEmployees();
        PermissionControl pc = new PermissionControl();
        ViewETasks vet = new ViewETasks();
        CreateProject c = new CreateProject();
        AboutForm a = new AboutForm();
        SettingForm sf = new SettingForm();
        Report report = new Report();
        CreateTeam ct = new CreateTeam();
        ViewAllProjectsForm vapf = new ViewAllProjectsForm();
        AddEmployee ae = new AddEmployee();

        public DashboardMainForm()
        {
            InitializeComponent();
            customizeDesign();
            panelW = SideMenupanel.Width;
           }
        private void customizeDesign()
        {
            ProjectSideBar.Visible = false;
            EmployeeSideBar.Visible = false;
            TeamsSidepanel.Visible = false;
        }

        private void Hidesubmenu()
        {
            if (ProjectSideBar.Visible == true)
                ProjectSideBar.Visible = false;
            if (EmployeeSideBar.Visible == true)
                EmployeeSideBar.Visible = false;
            if (TeamsSidepanel.Visible == true)
                TeamsSidepanel.Visible = false;

        }
        private void SetBackGroundColorOfMDIForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if ((ctl) is MdiClient)

                // If the control is the correct type,
                // change the color.
                {
                    ctl.BackColor = System.Drawing.Color.WhiteSmoke;
                }
            }
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                Hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;

            }
        }
       
        private void ProjectsBtn_Click(object sender, EventArgs e)
        {
            

            if (SideMenupanel.Width == 56)
            {
                SideMenupanel.Width = 230;
                showSubMenu(ProjectSideBar);
            }
            else
                showSubMenu(ProjectSideBar);

        }

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
          if (SideMenupanel.Width == 56)
            {
                SideMenupanel.Width = 230;
                showSubMenu(EmployeeSideBar);
            }
            else
                showSubMenu(EmployeeSideBar);
        }

        private void teamsBtn_Click(object sender, EventArgs e)
        {
           
            if (SideMenupanel.Width == 56)
            {
                SideMenupanel.Width = 230;
                showSubMenu(TeamsSidepanel);
            }
            else
                showSubMenu(TeamsSidepanel);
        }

        private void ViewAllProject_Click(object sender, EventArgs e)
        {
            vapf.MdiParent = this;
            vapf.Show();
            Hidesubmenu();
            c1.HideDashboard(Dashpanel);
        }

        private void CreateANewProject_Click(object sender, EventArgs e)
        {
            c.MdiParent = this;
            c.Show();
            Hidesubmenu();
            c1.HideDashboard(Dashpanel);
        }

        private void ViewAllEBtn_Click(object sender, EventArgs e)
        {
           ve.MdiParent = this; 
           ve.Show();
           Hidesubmenu();
           c1.HideDashboard(Dashpanel);
        }

        private void ViewAllTeamsBtn_Click(object sender, EventArgs e)
        {
            vat.MdiParent = this;
            vat.Show();
            Hidesubmenu();
            c1.HideDashboard(Dashpanel);
        }

        private void CreateNewTeamsBtn_Click(object sender, EventArgs e)
        {
            ct.MdiParent = this;
            ct.Show();
            Hidesubmenu();
            c1.HideDashboard(Dashpanel);
        }

        private void MenuPic_Click(object sender, EventArgs e)
        {

            if (MenuPic.Visible == true)
            {
                MenuPic.Visible = false;
                MenuClose.Visible = true;
            }
            
            if (SideMenupanel.Width ==56)
            {
                SideMenupanel.Width = 230;
            }
            else
                SideMenupanel.Width = 56;


        }
        private void Menu2_Click_1(object sender, EventArgs e)
        {

          if (MenuClose.Visible == true)
            {
                MenuClose.Visible = false;
                MenuPic.Visible = true;
            }

            if (SideMenupanel.Width == 230)
            {
                SideMenupanel.Width = 56;
                Hidesubmenu();

            }
            else
                SideMenupanel.Width = 230;
              
        }
              
        private void AddEBtn_Click(object sender, EventArgs e)
        {
            ae.MdiParent = this;
            ae.Show();
            c1.HideDashboard(Dashpanel);
        }

        private void ViewETasksBtn_Click(object sender, EventArgs e)
        {
            vet.MdiParent = this;
            vet.Show();
            c1.HideDashboard(Dashpanel);
        }

        private void PermissionControlBtn_Click(object sender, EventArgs e)
        {
          pc.MdiParent = this;
          pc.Show();
          c1.HideDashboard(Dashpanel);
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            report.MdiParent = this;
            report.Show();
            c1.HideDashboard(Dashpanel);
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            a.MdiParent = this;
            a.Show();
            c1.HideDashboard(Dashpanel);
        }

        private void Settingsbutton_Click(object sender, EventArgs e)
        {
            sf.MdiParent = this;
            sf.Show();
            c1.HideDashboard(Dashpanel);
        }

        private void DashboardMainForm_Load(object sender, EventArgs e)
        {
            SetBackGroundColorOfMDIForm();
        }
    
    }
}
