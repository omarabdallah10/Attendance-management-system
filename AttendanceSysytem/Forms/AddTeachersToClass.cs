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
    public partial class AddTeachersToClass : Form
    {
        public AddTeachersToClass()
        {
            InitializeComponent();
        }

        private void AddTeachersToClass_Load(object sender, EventArgs e)
        {
            printTable();
            
        }
        private void printTable()
        {
            XmlDocument xmlDoc = DataManagement.xmlDoc();
            XmlNodeList Teachers = xmlDoc.SelectNodes("//Users/Teacher");

            // Clear existing rows in the DataGridView
            this.TeachersTable.Rows.Clear();
            foreach (XmlElement TeacherRecord in Teachers)
            {
                string TeacherID = TeacherRecord.SelectSingleNode("UserID").InnerText;
                string TeacherName = TeacherRecord.SelectSingleNode("Name").InnerText;
                string TeacherEmail = TeacherRecord.SelectSingleNode("Email").InnerText;
                string TeacherPassword = TeacherRecord.SelectSingleNode("Password").InnerText;
                Teacher _teacher = new Teacher(TeacherName, TeacherEmail, TeacherPassword, TeacherID);
                string[] teacherClasses = _teacher.getClassesFromXML().Split(',');
                if (!teacherClasses.Contains("PD"))
                    this.TeachersTable.Rows.Add(TeacherID, TeacherName, _teacher.getClassesFromXML());
            }
        }
    }
}
