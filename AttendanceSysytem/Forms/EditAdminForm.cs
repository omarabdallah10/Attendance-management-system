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

namespace AttendanceSysytem.Forms
{
    public partial class EditAdminForm : Form
    {
        Form adminform = new AdminFunctionalitiesForm();
        public EditAdminForm(Form oldform)
        {
            adminform = oldform;
            Settings.ChangeFont(this, Settings.MyFont, true);
            InitializeComponent();
        }


        private void students_btn_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm(this);
            studentsForm.Show();
            Hide();
        }

        private void teachers_btn_Click(object sender, EventArgs e)
        {
            TeachersForm teachersForm = new TeachersForm(this);
            teachersForm.Show();
            Hide();
        }

        private void classes_btn_Click(object sender, EventArgs e)
        {
            Hide();
            ClassesForm classesForm = new ClassesForm();
            classesForm.Show();
        }

        private void EditAdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void go_back_btn_Click(object sender, EventArgs e)
        {
            adminform.Show();
            Hide();
        }
    }
}
