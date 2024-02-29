using AttendanceSysytem.Classes;
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
using System.Xml;

namespace AttendanceSysytem
{ 
    public partial class teacherFunctionalitiesForm : Form
    {
        public Teacher recived { get; set; }
        public XmlDocument xmlDoc { get; set; }
        public teacherFunctionalitiesForm()
        {
            InitializeComponent();
            Settings.ChangeFont(this, Settings.MyFont, true);
        }


        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            TeacherViewAttendanceForm form = new TeacherViewAttendanceForm();
            form.Show();
            Hide();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Recived = recived;
            settingsForm.Show();
            Hide();
        }

        private void teacherFunctionalitiesForm_Load(object sender, EventArgs e)
        {
            xmlDoc = DataManagement.xmlDoc();
            XmlNode teacher = xmlDoc.SelectSingleNode("//Users/Teacher[UserID='" + recived.UserID + "']");
            Console.WriteLine(teacher.InnerText);
        }

        private void btnTakeAttendance_Click(object sender, EventArgs e)
        {
            TakeAttendanceForm form = new TakeAttendanceForm();
            form.Show();
            Hide();
        }

    }
}
