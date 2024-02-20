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

namespace AttendanceSysytem.Forms
{
    public partial class EditTeacherForm : Form
    {
        public string recived { get; set; }
        public EditTeacherForm()
        {
            InitializeComponent();           
        }


        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Hide();
            TeachersForm teachersForm = new TeachersForm();
            teachersForm.Show();
        }

        private void EditTeacherForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(recived);
        }
    }
}
