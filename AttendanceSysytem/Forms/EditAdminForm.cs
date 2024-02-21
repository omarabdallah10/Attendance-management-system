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
        public EditAdminForm()
        {
            InitializeComponent();
        }


        private void students_btn_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Show();
            Hide();
        }

        private void teachers_btn_Click(object sender, EventArgs e)
        {
            TeachersForm teachersForm = new TeachersForm();
            teachersForm.Show();
            Hide();
        }

        private void classes_btn_Click(object sender, EventArgs e)
        {
            Hide();
            ClassesForm classesForm = new ClassesForm();
            classesForm.Show();
        }
    }
}
