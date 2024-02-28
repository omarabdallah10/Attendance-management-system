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
    public partial class EditStudentForm : Form
    {
        public string Recived { get; set; }
        public XmlElement StudentElement { get; set; }
        public XmlDocument Doc { get; set; }
        UserControls.Edit ParentController = null;
        public EditStudentForm(UserControls.Edit _parentController)
        {
            InitializeComponent();
            Settings.ChangeFont(this, Settings.MyFont, true);
            ParentController = _parentController;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            XmlNode name = StudentElement.SelectSingleNode("Name");
            name.InnerText = FnameTxt.Text + " " + LnameTxt.Text;
            XmlNode email = StudentElement.SelectSingleNode("Email");
            email.InnerText = email_box.Text;
            XmlNode password = StudentElement.SelectSingleNode("Password");
            password.InnerText = password_box.Text;
            XmlNode className = StudentElement.SelectSingleNode("ClassName");
            className.InnerText = classes_list.Text;
            if (Valid.ValidUserInput(name.InnerText, email.InnerText, password.InnerText))
            {
                MessageBox.Show("Data has been updated");
                DataManagement.SaveXml(Doc);
                Close();
            }
        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            Doc = DataManagement.xmlDoc();

            StudentElement = DataManagement.GetElementById(Doc, Recived, "Student");
            XmlNode name = StudentElement.SelectSingleNode("Name");
            XmlNode email = StudentElement.SelectSingleNode("Email");
            XmlNode password = StudentElement.SelectSingleNode("Password");
            string fname = name.InnerText.Split(' ')[0];
            string lname = name.InnerText.Split(' ')[1];
            FnameTxt.Text = fname;
            LnameTxt.Text = lname;
            email_box.Text = email.InnerText;
            password_box.Text = password.InnerText;


            XmlNodeList ClassNodes = Doc.SelectNodes("//Class");
            int index = -1;
            foreach (XmlNode ClassNode in ClassNodes)
            {
                index++;
                string className = ClassNode.SelectSingleNode("Name").InnerText;
                classes_list.Items.Add(className);
                if (className == StudentElement.SelectSingleNode("ClassName").InnerText)
                {
                    classes_list.SelectedIndex = index;
                    Console.WriteLine(className);
                }
            }
            classes_list.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void delete_student_btn_Click(object sender, EventArgs e)
        {
            XmlNode student = (XmlNode)StudentElement;
            DataManagement.deleteUser(Doc, student);
            MessageBox.Show("Student has been deleted");
            DataManagement.SaveXml(Doc);
            Close();
        }

        private void EditStudentForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Printed student table");
            ParentController.printStudentsTable();
        }
    }
}
