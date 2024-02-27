using AttendanceSysytem.Classes;
using AttendanceSysytem.Users;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AttendanceSysytem.Forms
{
    public partial class AddStudentsToClass : Form
    {
        XmlDocument xmlDoc = DataManagement.xmlDoc();
        public Classes.Track recivedTrack { get; set; }
        public AddStudentsToClass()
        {
            Settings.ChangeFont(this, Settings.MyFont, true);
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.StudentsTable.RowCount; i++)
            {
                //Console.WriteLine(this.TeachersTable.Rows[i].Cells[3].Value.ToString());
                if (this.StudentsTable.Rows[i].Cells[3].Value.ToString() == "True")
                {
                    string id = this.StudentsTable.Rows[i].Cells[0].Value.ToString();
                    string oldClassName = this.StudentsTable.Rows[i].Cells[2].Value.ToString();
                    Adding.addStudentToClass(id, oldClassName, recivedTrack.Name);
                }
            }
            MessageBox.Show($"Students Added successfully to class {recivedTrack.Name}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.go_back_btn_Click(sender, e);
        }

        private void AddStudentsToClass_Load(object sender, EventArgs e)
        {
            printTable();
            StudentsTable.AlternatingRowsDefaultCellStyle.Font = StudentsTable.RowsDefaultCellStyle.Font;
        }
        private void printTable()
        {
            XmlNodeList Students = xmlDoc.SelectNodes($"//Users/Student[ClassName != '{recivedTrack.Name}']");
            //Console.WriteLine(Students.Count+"AAAAAAAAAa");
            if (recivedTrack.Name == null) { recivedTrack.Name = ""; }
            // Clear existing rows in the DataGridView
            this.StudentsTable.Rows.Clear();
            foreach (XmlElement StudentsRecord in Students)
            {
                string StudentID = StudentsRecord.SelectSingleNode("UserID").InnerText;
                string StudentName = StudentsRecord.SelectSingleNode("Name").InnerText;
                string StudentEmail = StudentsRecord.SelectSingleNode("Email").InnerText;
                string StudentPassword = StudentsRecord.SelectSingleNode("Password").InnerText;
                string StudentClass = StudentsRecord.SelectSingleNode("ClassName").InnerText;

                this.StudentsTable.Rows.Add(StudentID, StudentName,StudentClass,false);

            }
        }

        private void go_back_btn_Click(object sender, EventArgs e)
        {
            EditClassForm editClassForm = new EditClassForm();
            editClassForm.recived = recivedTrack;
            editClassForm.StartPosition = FormStartPosition.CenterScreen;
            editClassForm.Show();
            Close();
        }
    }
}
