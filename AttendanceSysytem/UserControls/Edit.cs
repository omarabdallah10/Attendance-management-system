using AttendanceSysytem.Classes;
using AttendanceSysytem.Forms;
using AttendanceSysytem.Users;
using PdfSharp.Drawing;
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

namespace AttendanceSysytem.UserControls
{
    public partial class Edit : UserControl
    {
        XmlDocument xmlDoc = DataManagement.xmlDoc();
        public Edit()
        {
            InitializeComponent();
        }

        private void TeachersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                EditTeacherForm form = new EditTeacherForm(this);
                form.recived = TeachersTable.Rows.SharedRow(e.RowIndex).Cells[0].Value.ToString();
                Console.WriteLine(form.recived);
                form.ShowDialog();
            }
        }
        private void StudentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                EditStudentForm form = new EditStudentForm(this);
                //MessageBox.Show(StudentsTable.Rows.SharedRow(e.RowIndex).Cells[0].Value.ToString());
                form.Recived = StudentsTable.Rows.SharedRow(e.RowIndex).Cells[0].Value.ToString();
                Console.WriteLine(form.Recived);
                form.ShowDialog();
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void students_btn_Click(object sender, EventArgs e)
        {
            editStudent1.SelectedTab = tabPage2;
        }

        private void ClassesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tabPage3_Enter(object sender, EventArgs e)
        {

        }

        private void Edit_Load(object sender, EventArgs e)
        {

            // Teachers
            printTeachersTable();
            // Students
            printStudentTable();
        }
        public void printTeachersTable()
        {
            XmlNodeList Teachers = xmlDoc.SelectNodes("//Users/Teacher");
            TeachersTable.AlternatingRowsDefaultCellStyle.Font = TeachersTable.RowsDefaultCellStyle.Font;
            // Clear existing rows in the DataGridView
            this.TeachersTable.Rows.Clear();
            List<Teacher> TeachersList = new List<Teacher>();
            foreach (XmlElement TeacherRecord in Teachers)
            {
                string TeacherID = TeacherRecord.SelectSingleNode("UserID").InnerText;
                string TeacherName = TeacherRecord.SelectSingleNode("Name").InnerText;
                string TeacherEmail = TeacherRecord.SelectSingleNode("Email").InnerText;
                string TeacherPassword = TeacherRecord.SelectSingleNode("Password").InnerText;
                Teacher _teacher = new Teacher(TeacherName, TeacherEmail, TeacherPassword, TeacherID);
                TeachersList.Add(_teacher);
                this.TeachersTable.Rows.Add(_teacher.UserID, _teacher.Name, _teacher.getClassesFromXML(), _teacher.getSupervisedClassesFromXML());
            }
        }
        public void printStudentTable()
        {
            XmlNodeList Students = xmlDoc.SelectNodes("//Users/Student");
            this.StudentsTable.Rows.Clear();
            List<Student> StudentsList = new List<Student>();
            StudentsTable.AlternatingRowsDefaultCellStyle.Font = StudentsTable.RowsDefaultCellStyle.Font;
            foreach (XmlElement StudentRecord in Students)
            {
                string StudentID = StudentRecord.SelectSingleNode("UserID").InnerText;
                string StudentName = StudentRecord.SelectSingleNode("Name").InnerText;
                string StudentEmail = StudentRecord.SelectSingleNode("Email").InnerText;
                string StudentPassword = StudentRecord.SelectSingleNode("Password").InnerText;
                string ClassName = StudentRecord.SelectSingleNode("ClassName").InnerText;

                Student std = new Student(StudentName, StudentEmail, StudentPassword, StudentID, ClassName);
                StudentsTable.Rows.Add(std.UserID, std.Name, std.ClassName);
                StudentsList.Add(std);
            }
        }
    }
}
