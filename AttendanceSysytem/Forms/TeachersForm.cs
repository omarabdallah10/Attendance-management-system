using AttendanceSysytem.Classes;
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

namespace AttendanceSysytem.Forms
{
    public partial class TeachersForm : Form
    {
        public TeachersForm()
        {
            InitializeComponent();
        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = DataManagement.xmlDoc();
            XmlNodeList Teachers = xmlDoc.SelectNodes("//Users/Teacher");

            // Clear existing rows in the DataGridView
            this.TeachersTable.Rows.Clear();
            List<Teacher> TeachersList = new List<Teacher>();

            foreach (XmlElement TeacherRecord in Teachers)
            {
                string TeacherID = TeacherRecord.SelectSingleNode("UserID").InnerText;
                string TeacherName = TeacherRecord.SelectSingleNode("Name").InnerText;
                string TeacherEmail = TeacherRecord.SelectSingleNode("Email").InnerText;
                string TeacherPassword = TeacherRecord.SelectSingleNode("Password").InnerText;
                Teacher _teacher = new Teacher(TeacherName,TeacherEmail,TeacherPassword,TeacherID);
                _teacher.ShowTeacherData(this);
            }
        }
    }
}
