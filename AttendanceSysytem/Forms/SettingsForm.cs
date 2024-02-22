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
    public partial class SettingsForm : Form
    {
        public User Recived { get; set; }
        public XmlDocument Document { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Document = DataManagement.xmlDoc();

            /*StudentElement = DataManagement.GetElementById(Document, Recived, "Student");
            XmlNode name = StudentElement.SelectSingleNode("Name");
            XmlNode email = StudentElement.SelectSingleNode("Email");
            XmlNode password = StudentElement.SelectSingleNode("Password");
            string fname = name.InnerText.Split(' ')[0];
            string lname = name.InnerText.Split(' ')[1];
            FnameTxt.Text = fname;
            LnameTxt.Text = lname;
            email_box.Text = email.InnerText;
            password_box.Text = password.InnerText;*/
        }

        private void password_label_Click(object sender, EventArgs e)
        {

        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void font_Click(object sender, EventArgs e)
        {

        }

        private void Langauge_Click(object sender, EventArgs e)
        {

        }
    }
}
