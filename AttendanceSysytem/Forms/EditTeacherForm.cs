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
    public partial class EditTeacherForm : Form
    {
        public string recived { get; set; }
        public XmlElement teacherElement { get; set; }
        public XmlDocument doc { get; set; }
        Form oldform=null;
        public EditTeacherForm(Form f1)
        {
            Settings.ChangeFont(this, Settings.MyFont, true);
            oldform = f1;
            InitializeComponent();           
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Hide();
            oldform.Show();
        }

        public void EditTeacherForm_Load(object sender, EventArgs e)
        {
            doc = DataManagement.xmlDoc();
            
            teacherElement = DataManagement.GetElementById(doc, recived,"Teacher");
            XmlNode name = teacherElement.SelectSingleNode("Name");
            XmlNode email = teacherElement.SelectSingleNode("Email");
            XmlNode password = teacherElement.SelectSingleNode("Password");
            string fname= name.InnerText.Split(' ')[0];
            string lname = name.InnerText.Split(' ')[1];
            FnameTxt.Text = fname;
            LnameTxt.Text = lname;
            email_box.Text= email.InnerText;
            password_box.Text= password.InnerText;
            //checkbox items creation 
            XmlNodeList ClassNodes = doc.SelectNodes("//Class");
            foreach (XmlNode ClassNode in ClassNodes)
            {
                checkedListBox1.Items.Add(ClassNode.SelectSingleNode("Name").InnerText);
                XmlNode TeacherNode = ClassNode.SelectSingleNode("Teachers");
                XmlNodeList TeachersNodes = TeacherNode.SelectNodes("UserID");
                foreach (XmlNode teacherNode in TeachersNodes)
                {
                    if (recived == teacherNode.InnerText)
                    {
                        int i = checkedListBox1.Items.Count-1;
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }
            }
            checkedListBox1.ItemCheck += CheckedListBox_ItemCheck;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            XmlNode name = teacherElement.SelectSingleNode("Name");
            name.InnerText = FnameTxt.Text + " " + LnameTxt.Text;
            XmlNode email = teacherElement.SelectSingleNode("Email");
            email.InnerText=email_box.Text;
            XmlNode password = teacherElement.SelectSingleNode("Password");
            password.InnerText=password_box.Text;
            if (Valid.ValidUserInput(name.InnerText,email.InnerText,password.InnerText))
            {
                MessageBox.Show("Data has been updated");
                DataManagement.SaveXml(doc);
                oldform.Show();
                Hide();
            }
           
        }


        //check box event
        private void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string itemName = checkedListBox1.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                Console.WriteLine($"{itemName} is about to be checked");
                DataManagement.addTeacherToClass(doc,recived, itemName);
                DataManagement.SaveXml(doc);
            }
            else
            {
                Console.WriteLine($"{itemName} is about to be unchecked");
                // Do something when the item is about to be unchecked
                DataManagement.removeTeacherFromClass(doc,recived, itemName);
                DataManagement.SaveXml(doc);
            }
        }

        private void delete_teacher_btn_Click(object sender, EventArgs e)
        {
            XmlNode teacher = (XmlNode)teacherElement;
            DataManagement.deleteUser(doc,teacher);
            MessageBox.Show("Teacher has been deleted");
            DataManagement.SaveXml(doc);
            oldform.Show();
            Hide();
        }
    }
}
