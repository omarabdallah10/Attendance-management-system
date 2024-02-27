using AttendanceSysytem.Classes;
using AttendanceSysytem.Users;
using Microsoft.Office.Interop.Excel;
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

namespace AttendanceSysytem.Forms
{
    public partial class AddTeachersToClass : Form
    {
        XmlDocument xmlDoc = DataManagement.xmlDoc();
        public Classes.Track recivedTrack { get; set; }
        public AddTeachersToClass()
        {
            DataManagement.ChangeFont(this, DataManagement.MyFont, true);
            InitializeComponent();
        }

        private void AddTeachersToClass_Load(object sender, EventArgs e)
        {
            printTable();

        }
        private void printTable()
        {
            XmlNodeList Teachers = xmlDoc.SelectNodes("//Users/Teacher");
            if (recivedTrack.Name == null) { recivedTrack.Name = ""; }
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
                this.TeachersTable.Rows.Add(TeacherID, TeacherName, _teacher.getClassesFromXML(), teacherClasses.Any(c => c.Trim() == recivedTrack.Name));

            }
        }

        private void go_back_btn_Click(object sender, EventArgs e)
        {
            EditClassForm editClassForm = new EditClassForm();
            editClassForm.recived = recivedTrack;
            editClassForm.StartPosition = FormStartPosition.CenterScreen;
            editClassForm.Show();
            Hide();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            XmlNode Teachers = xmlDoc.SelectSingleNode($"//Class[Name = '{recivedTrack.Name}' ]/Teachers");
            Teachers.RemoveAll();
            DataManagement.SaveXml(xmlDoc);
            for (int i = 0; i < this.TeachersTable.RowCount; i++)
            {
                //Console.WriteLine(this.TeachersTable.Rows[i].Cells[3].Value.ToString());
                if (this.TeachersTable.Rows[i].Cells[3].Value.ToString() == "True")
                {
                    string id = this.TeachersTable.Rows[i].Cells[0].Value.ToString();
                    Adding.addTeacherToClass(id, recivedTrack.Name);
                }
            }
            MessageBox.Show($"Teachers Added successfully to class {recivedTrack.Name}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.go_back_btn_Click(sender, e);
        }
    }
}
