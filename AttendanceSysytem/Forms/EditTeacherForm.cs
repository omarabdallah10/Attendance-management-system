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
    public partial class EditTeacherForm : Form
    {
        public EditTeacherForm()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void EditTeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void edit_teacher_label_Click(object sender, EventArgs e)
        {

=======
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Hide();
            TeachersForm teachersForm = new TeachersForm();
            teachersForm.Show();
>>>>>>> main
        }
    }
}
