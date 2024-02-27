using AttendanceSysytem.Classes;
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
    public partial class AddClassForm : Form
    {
        Form adminform = new AdminFunctionalitiesForm();
        public AddClassForm(Form f1)
        {
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
            Settings.ChangeFont(this, Settings.MyFont, true);
            adminform = f1;
            InitializeComponent();
            XmlDocument doc = DataManagement.xmlDoc();
            XmlNodeList TeacherNodes = doc.SelectNodes("//Users/Teacher");
            foreach (XmlNode TeacherNode in TeacherNodes)
            {
                if (TeacherNode.Attributes[0].Value == "false")
                {
                    txtSupervisor.Items.Add(TeacherNode.SelectSingleNode("Name").InnerText);
                }
            }
            txtSupervisor.SelectedIndex = 0;
            txtSupervisor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlDocument doc = DataManagement.xmlDoc();
            string className = txtName.Text;
            string supervisor=txtSupervisor.Text;
            XmlNodeList TeacherNodes = doc.SelectNodes("//Users/Teacher");
            foreach (XmlNode TeacherNode in TeacherNodes)
            {
                XmlNode nameNode=TeacherNode.SelectSingleNode("Name");
                if (supervisor == nameNode.InnerText)
                {
                    XmlNode id= TeacherNode.SelectSingleNode("UserID");
                    supervisor = id.InnerText;
                    XmlElement teacher = (XmlElement)TeacherNode;
                    teacher.SetAttribute("Supervisor", "true");
                    break;
                }
            }
            XmlElement newClass=Adding.AddClass(doc, className, supervisor);
            Console.WriteLine(newClass);
            if (newClass != null )
            {
                XmlNode oldClass = doc.SelectSingleNode("//Class");
                XmlNode School = doc.SelectSingleNode("School");
                Console.WriteLine(newClass.InnerText);
                School.AppendChild(newClass);
                School.InsertBefore(newClass, oldClass);
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
            adminform.Show();
            Hide();
        }

        private void AddClassForm_Load(object sender, EventArgs e)
        {

        }
    }
}
