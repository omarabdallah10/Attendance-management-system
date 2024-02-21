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
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==3)
            {
                Hide();
                EditStudentForm form = new EditStudentForm();
                form.ShowDialog();
            }
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = DataManagement.xmlDoc();
            XmlNodeList Students = xmlDoc.SelectNodes("//Users/Student");

            // Clear existing rows in the DataGridView
            this.resetDataTable();
            List<Student> StudentsList = new List<Student>();

            foreach (XmlElement StudentRecord in Students)
            {
                string StudentID = StudentRecord.SelectSingleNode("UserID").InnerText;
                string StudentName = StudentRecord.SelectSingleNode("Name").InnerText;
                string StudentEmail = StudentRecord.SelectSingleNode("Email").InnerText;
                string StudentPassword = StudentRecord.SelectSingleNode("Password").InnerText;
                string ClassName = StudentRecord.SelectSingleNode("ClassName").InnerText;
                Student std = new Student(StudentName,StudentEmail,StudentPassword,StudentID, ClassName);
                std.ShowStudentData(this);
                StudentsList.Add(std);
            }

        }

        private void go_back_btn_Click(object sender, EventArgs e)
        {
            Hide();
            EditAdminForm form = new EditAdminForm();
            form.Show();
        }
    }
}
