using AttendanceSysytem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using AttendanceSysytem.UserControls;
using AttendanceSysytem.Users;

namespace AttendanceSysytem.Forms
{

    public partial class AdminDashboard : Form
    {
        public User recived { get; set; }
        public AdminDashboard()
        {
            InitializeComponent();
            Settings.ChangeFont(this, Settings.MyFont, true);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateandTime.Text = DateTime.Now.ToString("f");
            timer1.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            AddStudent addStudentControl = new AddStudent();
            panel3.Controls.Add(addStudentControl);
        }
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            AddTeacher addTeacherControl = new AddTeacher();
            panel3.Controls.Add(addTeacherControl);
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            AddClass addTeacherControl = new AddClass();
            panel3.Controls.Add(addTeacherControl);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            labelUsername.Text = recived.Name;
            labelRole.Text = "Admin";
        }

        private void btnEditUsers_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Edit addTeacherControl = new Edit();
            panel3.Controls.Add(addTeacherControl);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Settings settings = new Settings();
            settings.Recived = recived;
            panel3.Controls.Add(settings);
        }
    }
}
