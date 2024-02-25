using AttendanceSysytem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttendanceSysytem
{
    public partial class AddStudentForm : Form
    {
        Form oldform = new AdminFunctionalitiesForm();
        public AddStudentForm(Form f1)
        {
            DataManagement.ChangeFont(this, DataManagement.MyFont, true);
            oldform = f1;
            InitializeComponent();
            XmlDocument doc = DataManagement.xmlDoc();
            XmlNodeList ClassNodes = doc.SelectNodes("//Class");
            foreach (XmlNode ClassNode in ClassNodes)
            {
                ClassList.Items.Add(ClassNode.SelectSingleNode("Name").InnerText);
            }
            ClassList.SelectedIndex = 0;
            ClassList.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlDocument doc = DataManagement.xmlDoc();
            string userFname = txtFName.Text;
            string userLname = txtLName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string className = ClassList.Text;
            XmlElement newStudent = Adding.addUser("Student", doc, userFname, userLname, email, password);
            if (newStudent != null)
            {
                XmlElement newClass = doc.CreateElement("ClassName");
                newClass.InnerText = className; // Set the class name
                newStudent.AppendChild(newClass);


                XmlNode UsersNode = doc.SelectSingleNode("//Users");
                XmlNode oldStudent = doc.SelectSingleNode("//Users/Student");

                Console.WriteLine(newStudent.InnerText);
                UsersNode.AppendChild(newStudent);
                UsersNode.InsertBefore(newStudent, oldStudent);

                // Save the document

                XmlNodeList ClassNodes = doc.SelectNodes("//Class");

                    foreach (XmlNode ClassNode in ClassNodes)
                    {
                        XmlNode NameNode = ClassNode.SelectSingleNode("Name");
                        if (className == NameNode.InnerText)
                        {
                            XmlNode user =  newStudent.SelectSingleNode("UserID").CloneNode(true);
                            XmlNode classStudents = ClassNode.SelectSingleNode("Students");

                        classStudents.AppendChild(user);
                        }
                    }
                
                DataManagement.SaveXml(doc);
                MessageBox.Show("Student Added successfully");
                foreach (Control control in Controls)
                {
                    if (control is System.Windows.Forms.TextBox)
                    {
                        ((System.Windows.Forms.TextBox)control).Clear();
                    }
                    else if (control is System.Windows.Forms.ComboBox)
                    {
                        ((System.Windows.Forms.ComboBox)control).SelectedIndex = -1;
                    }
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            oldform.Show();
            Hide();
        }
    }
}
