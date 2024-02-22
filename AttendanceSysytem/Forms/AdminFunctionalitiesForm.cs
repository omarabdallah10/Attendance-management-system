using AttendanceSysytem.Forms;
using AttendanceSysytem.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSysytem
{
    public partial class AdminFunctionalitiesForm : Form
    {
        public Admin recived { get; set; }
        public AdminFunctionalitiesForm()
        {
            InitializeComponent();
        }

        private void AdminFunctionalitiesForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm();
            addTeacherForm.Show();
            Hide();
        }

        private void btnEditUsers_Click(object sender, EventArgs e)
        {
            Hide();
            EditAdminForm editAdminForm = new EditAdminForm();
            editAdminForm.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudent = new AddStudentForm();
            addStudent.Show();
            Hide();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            AddClassForm addClass = new AddClassForm();
            addClass.Show();
            Hide();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Hide();
            loginForm login = new loginForm();
            login.Show();
            recived = null;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Recived = recived;
            settingsForm.Show();

        }
    }
}
