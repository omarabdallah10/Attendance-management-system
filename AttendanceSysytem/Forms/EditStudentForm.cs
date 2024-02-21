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
    public partial class EditStudentForm : Form
    {
        public EditStudentForm()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Show();
            Hide();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
