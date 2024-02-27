﻿using AttendanceSysytem.Classes;
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
        Form adminform = new AdminFunctionalitiesForm();
        public AddTeacherForm(Form oldform)
        {
            Settings.ChangeFont(this, Settings.MyFont, true);
            adminform = oldform;
            InitializeComponent();
           // XmlDocument doc = DataManagement.xmlDoc();
           XmlDataDocument doc = new XmlDataDocument();
            XmlNodeList ClassNodes = doc.SelectNodes("//Class");
            foreach (XmlNode ClassNode in ClassNodes)
            {
                checkedListBox1.Items.Add(ClassNode.SelectSingleNode("Name").InnerText);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlDocument doc = DataManagement.xmlDoc();
            string userFname = txtFName.Text;
            string userLname = txtLName.Text;

            string email = txtEmail.Text;
            string password = txtPassword.Text;


            XmlElement newTeacher = Adding.addUser("Teacher", doc, userFname, userLname, email, password);
            if (newTeacher != null)
            {
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
                MessageBox.Show("Teacher Added successfully");
                foreach (Control control in Controls)
                {
                    if (control is System.Windows.Forms.TextBox)
                    {
                        ((System.Windows.Forms.TextBox)control).Clear();
                    }
                    else if (control is System.Windows.Forms.CheckedListBox)
                    {
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            checkedListBox1.SetItemChecked(i, false);
                            Console.WriteLine(checkedListBox1.GetItemCheckState(i));
                        }
                    }
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            adminform.Show();
            Hide();
        }

        private void AddTeacherForm_Load(object sender, EventArgs e)
        {
            Settings.ChangeFont(this, Settings.MyFont, true);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            adminform.Show();
            Hide();
        }
    }
}
