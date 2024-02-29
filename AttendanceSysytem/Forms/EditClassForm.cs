using AttendanceSysytem.Classes;
using AttendanceSysytem.UserControls;
using AttendanceSysytem.Users;
using Microsoft.Office.Interop.Excel;
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
    public partial class EditClassForm : Form
    {
        public Classes.Track recived { get; set; }
        public XmlDocument doc { get; set; }
        XmlDocument xmlDoc = DataManagement.xmlDoc();
        Edit ParentController = null;
        public EditClassForm(Edit _parentController)
        {
            InitializeComponent();
            Settings.ChangeFont(this, Settings.MyFont, true);
            ParentController = _parentController;
        }

        private void EditClassForm_Load(object sender, EventArgs e)
        {
            doc = DataManagement.xmlDoc();
            SupervisorComboBox.Font = this.Font;
            class_name_txt.Text = recived.Name;
            SupervisorComboBox.Items.Add(recived.Supervisor.Name);
            XmlNodeList TeacherNodes = doc.SelectNodes("//Users/Teacher");
            foreach (XmlNode TeacherNode in TeacherNodes)
            {
                if (TeacherNode.Attributes[0].Value == "false")
                {
                    SupervisorComboBox.Items.Add(TeacherNode.SelectSingleNode("Name").InnerText);
                }
            }
            SupervisorComboBox.SelectedIndex = 0;
            SupervisorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            // Print Teachers
            printTeachersTable();
            // Print Students outside class
            printStudentsTable();


        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            XmlNode classNode = doc.SelectSingleNode("//Class[Name='" + recived.Name + "']");
            XmlNode name = classNode.SelectSingleNode("Name");
            XmlNode newSuper = doc.SelectSingleNode("//Users/Teacher[Name='" + SupervisorComboBox.Text + "']");
            XmlNode oldSuper = doc.SelectSingleNode("//Users/Teacher[UserID='" + classNode.SelectSingleNode("Supervisor/UserID").InnerText + "']");
            XmlNodeList classnodes = doc.SelectNodes("//Class");
            int flag = 0;
            /*foreach (XmlNode classnode in classnodes)
            {
                if (classnode.SelectSingleNode("Name").InnerText == class_name_txt.Text && class_name_txt.Text != recived.Name)
                {
                    flag++;
                    break;
                }
            }
            Console.WriteLine(flag);
            if (newSuper != oldSuper && flag == 0)
            {
                newSuper.Attributes[0].InnerText = "true";
                oldSuper.Attributes[0].InnerText = "false";
                classNode.SelectSingleNode("Supervisor/UserID").InnerText = newSuper.SelectSingleNode("UserID").InnerText;
            }
            if (flag == 0 && (class_name_txt.Text != recived.Name || newSuper != oldSuper))
            {*/
            name.InnerText = class_name_txt.Text;
            DataManagement.changeStdClassName(doc, recived.Name, class_name_txt.Text);
            SaveTeachers();
            SaveStudents();
            MessageBox.Show("Your edits have been saved successfully");
            Close();
            /* }
             else
             {
                 MessageBox.Show("Class name already exists, please choose another one");
             }*/

        }

        private void printStudentsTable()
        {
            XmlDocument xmlDoc = DataManagement.xmlDoc();
            XmlNodeList Students = xmlDoc.SelectNodes($"//Users/Student[ClassName != '{recived.Name}']");
            //Console.WriteLine(Students.Count+"AAAAAAAAAa");
            if (recived.Name == null) { recived.Name = ""; }
            // Clear existing rows in the DataGridView
            this.StudentsTable.Rows.Clear();
            foreach (XmlElement StudentsRecord in Students)
            {
                string StudentID = StudentsRecord.SelectSingleNode("UserID").InnerText;
                string StudentName = StudentsRecord.SelectSingleNode("Name").InnerText;
                string StudentEmail = StudentsRecord.SelectSingleNode("Email").InnerText;
                string StudentPassword = StudentsRecord.SelectSingleNode("Password").InnerText;
                string StudentClass = StudentsRecord.SelectSingleNode("ClassName").InnerText;

                this.StudentsTable.Rows.Add(StudentID, StudentName, StudentClass, false);

            }
        }
        private void printTeachersTable()
        {
            XmlDocument xmlDoc = DataManagement.xmlDoc();
            XmlNodeList Teachers = xmlDoc.SelectNodes("//Users/Teacher");
            if (recived.Name == null) { recived.Name = ""; }
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
                this.TeachersTable.Rows.Add(TeacherID, TeacherName, _teacher.getClassesFromXML(), teacherClasses.Any(c => c.Trim() == recived.Name));

            }
        }
        private void SaveTeachers()
        {
            XmlNode Teachers = xmlDoc.SelectSingleNode($"//Class[Name = '{recived.Name}' ]/Teachers");
            Teachers.RemoveAll();
            DataManagement.SaveXml(xmlDoc);
            for (int i = 0; i < this.TeachersTable.RowCount; i++)
            {
                Console.WriteLine(this.TeachersTable.Rows[i].Cells[3].Value.ToString());
                if (this.TeachersTable.Rows[i].Cells[3].Value.ToString() == "True")
                {
                    string id = this.TeachersTable.Rows[i].Cells[0].Value.ToString();
                    Console.WriteLine(id + " :::: " + recived.Name);
                    Adding.addTeacherToClass(id, recived.Name);
                }
            }
            //MessageBox.Show($"Teachers Added successfully to class {recived.Name}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SaveStudents()
        {
            for (int i = 0; i < this.StudentsTable.RowCount; i++)
            {
                Console.WriteLine(this.StudentsTable.Rows[i].Cells[3].Value.ToString());
                if (this.StudentsTable.Rows[i].Cells[3].Value.ToString() == "True")
                {
                    string id = this.StudentsTable.Rows[i].Cells[0].Value.ToString();
                    string oldClassName = this.StudentsTable.Rows[i].Cells[2].Value.ToString();
                    Console.WriteLine("OLD Class: " + oldClassName + " NEW Class: " + recived.Name);
                    Adding.addStudentToClass(id, oldClassName, recived.Name);
                }
            }
            //MessageBox.Show($"Students Added successfully to class {recived.Name}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditClassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentController.printClassesTable();
        }
    }
}
