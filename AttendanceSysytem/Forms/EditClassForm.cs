using AttendanceSysytem.Users;
using Microsoft.Office.Interop.Excel;
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
    public partial class EditClassForm : Form
    {
        public Classes.Track recived { get; set; }
        public EditClassForm()
        {
            InitializeComponent();
        }

        private void EditClassForm_Load(object sender, EventArgs e)
        {
            class_name_txt.Text = recived.Name;
            SupervisorComboBox.Items.Add(recived.Supervisor.Name);
            SupervisorComboBox.SelectedIndex=0;
        }

        private void add_teachers_btn_Click(object sender, EventArgs e)
        {
            AddTeachersToClass addteacherform = new AddTeachersToClass();
            addteacherform.Show();
            Hide();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
