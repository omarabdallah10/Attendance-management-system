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
    public partial class teacherFunctionalitiesForm : Form
    {
        public Teacher recived { get; set; }
        public teacherFunctionalitiesForm()
        {
            InitializeComponent();
        }

        private void btnTakeAttendance_Click(object sender, EventArgs e)
        {

        }

        private void btnTakeAttendance_Click_1(object sender, EventArgs e)
        {

        }

        private void btnViewAttendance_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Recived = recived;
            settingsForm.Show();
        }
    }
}
