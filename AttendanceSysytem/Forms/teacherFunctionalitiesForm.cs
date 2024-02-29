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
            Console.WriteLine(recived);
            Settings.ChangeFont(this, Settings.MyFont, true);
            xmlDoc = DataManagement.xmlDoc();
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
            //read the UserID for the teacher who logged in
            string UserID = recived.UserID;

            //check if he is a supervisor from 'Supervisor' properity in 'Techer' node in the xml file
            XmlNodeList Teacher = xmlDoc.SelectNodes("//Users/Teacher");
            foreach (XmlElement TeacherRecord in Teacher)
            {
                if (TeacherRecord.SelectSingleNode("UserID").InnerText == UserID)
                {
                    if (TeacherRecord.GetAttribute("Supervisor") == "true")
                    {
                        //make the button disabled
                        btnTakeAttendance.Enabled = true;
                    }
                    else
                    {
                        btnTakeAttendance.Enabled = false;
                    }
                }
            }
        }

        private void btnTakeAttendance_Click(object sender, EventArgs e)
        {
            TakeAttendanceForm form = new TakeAttendanceForm();
            form.Show();
            Hide();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Hide();
            loginForm login = new loginForm();
            login.Show();
            recived = null;
        }

        
    }
}
