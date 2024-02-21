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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AttendanceSysytem.Forms
{
    public partial class EditClassForm : Form
    {
        public Classes.Track recived { get; set; }
        public XmlDocument doc{ get; set; }
        public EditClassForm()
        {
            InitializeComponent();
        }

        private void EditClassForm_Load(object sender, EventArgs e)
        {
            doc = DataManagement.xmlDoc();
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


        }

        private void add_teachers_btn_Click(object sender, EventArgs e)
        {
            AddTeachersToClass addteacherform = new AddTeachersToClass();
            addteacherform.Show();
            Hide();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            XmlNode classNode = doc.SelectSingleNode("//Class[Name='" + recived.Name + "']");
            classNode.SelectSingleNode("Name").InnerText = class_name_txt.Text;
            XmlNode newSuper = doc.SelectSingleNode("//Users/Teacher[Name='" + SupervisorComboBox.Text + "']");
            XmlNode oldSuper = doc.SelectSingleNode("//Users/Teacher[UserID='" + classNode.SelectSingleNode("Supervisor/UserID").InnerText + "']");
            classNode.SelectSingleNode("Supervisor/UserID").InnerText = newSuper.SelectSingleNode("UserID").InnerText;
            newSuper.Attributes[0].InnerText = "true";
            oldSuper.Attributes[0].InnerText = "false";
            DataManagement.SaveXml(doc);
            MessageBox.Show("Your edits have been saved successfully");
            ClassesForm classesForm = new ClassesForm();
            classesForm.Show();
            Hide();

        }

        private void go_back_btn_Click(object sender, EventArgs e)
        {
            ClassesForm classesForm = new ClassesForm();
            classesForm.Show();
            Hide();
        }
    }
}
