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
        Form oldform = null;
        public StudentsForm(Form oldform)
        {
            InitializeComponent();
            this.oldform = oldform;
            Settings.ChangeFont(this, Settings.MyFont, true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==3)
            {
                EditStudentForm form = new EditStudentForm(this);
                MessageBox.Show(StudentsTable.Rows.SharedRow(e.RowIndex).Cells[0].Value.ToString());
                form.Recived = StudentsTable.Rows.SharedRow(e.RowIndex).Cells[0].Value.ToString();
                Console.WriteLine(form.Recived);
                form.Show();
                Hide();
            }
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = DataManagement.xmlDoc();
            XmlNodeList Students = xmlDoc.SelectNodes("//Users/Student");

            // Clear existing rows in the DataGridView
            this.resetDataTable();
            List<Student> StudentsList = new List<Student>();
            StudentsTable.AlternatingRowsDefaultCellStyle.Font = StudentsTable.RowsDefaultCellStyle.Font;
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
            oldform.Show();
        }
    }
}
