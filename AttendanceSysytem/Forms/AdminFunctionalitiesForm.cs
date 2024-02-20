using AttendanceSysytem.Forms;
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
    }
}
