using AttendanceSysytem.Classes;
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
    public partial class AddTeacherForm : Form
    {
        public AddTeacherForm()
        {
            InitializeComponent();
            XmlDocument doc = DataManagement.xmlDoc();
            XmlNodeList ClassNodes = doc.SelectNodes("//Class");
            foreach (XmlNode ClassNode in ClassNodes)
            {
                checkedListBox1.Items.Add(ClassNode.SelectSingleNode("Name").InnerText);
            }
            
        }

        private void AddTeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlDocument doc = DataManagement.xmlDoc();
            string username = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;


            XmlElement newTeacher= Adding.addUser("Teacher", doc, username, email,password);
           newTeacher.SetAttribute("Supervisor", "false");


            XmlNode UsersNode = doc.SelectSingleNode("//Users");
            XmlNode oldTeacher = doc.SelectSingleNode("//Users/Teacher");

            Console.WriteLine(newTeacher.InnerText);
            UsersNode.AppendChild(newTeacher);
            UsersNode.InsertBefore(newTeacher, oldTeacher);

            // Save the document

            XmlNodeList ClassNodes = doc.SelectNodes("//Class");
            
            foreach (object checkedItem in checkedListBox1.CheckedItems)
            {
                foreach (XmlNode ClassNode in ClassNodes)
                {
                    XmlNode NameNode = ClassNode.SelectSingleNode("Name");
                    if (checkedItem.ToString() == NameNode.InnerText)
                    {
                        XmlNode user = newTeacher.SelectSingleNode("UserID").CloneNode(true);
                        XmlNode classTeachers = ClassNode.SelectSingleNode("Teachers");

                        classTeachers.AppendChild(user);
                    }
                }
            }
            DataManagement.SaveXml(doc);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
