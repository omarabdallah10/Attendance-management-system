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
    public partial class ClassesForm : Form
    {
        public ClassesForm()
        {
            Settings.ChangeFont(this, Settings.MyFont, true);
            InitializeComponent();
        }

        private void StudentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow row = ClassesTable.Rows[e.RowIndex];
                string Classname = row.Cells["ClassName"].Value.ToString();
                string supervisor = row.Cells["Supervisor"].Value.ToString();
                string supervisorID= row.Cells["SupervisorID"].Value.ToString();

                //EditClassForm form = new EditClassForm();
                //form.recived = new Track(Classname.ToString(), supervisorID.ToString());
                //form.StartPosition = FormStartPosition.CenterScreen;
                //form.Show();

                this.Hide();
            }
        }

        private void ClassesForm_Load(object sender, EventArgs e)
        {
            ClassesTable.AlternatingRowsDefaultCellStyle.Font = ClassesTable.RowsDefaultCellStyle.Font;
            XmlDocument xmlDoc = DataManagement.xmlDoc();
            XmlNodeList MyClasses = xmlDoc.SelectNodes("//Class");
            foreach (XmlNode MyClass in MyClasses)
            {
                string _className = MyClass.SelectSingleNode("Name").InnerText; 
                string _supervisorID = MyClass.SelectSingleNode("Supervisor/UserID").InnerText; 
                string _supervisorName = DataManagement.getUserById(_supervisorID).Name;
                this.ClassesTable.Rows.Add(_className, _supervisorID, _supervisorName);
            }
        
        }

        private void go_back_btn_Click(object sender, EventArgs e)
        {
            AdminFunctionalitiesForm form = new AdminFunctionalitiesForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Hide();
        }
    }
}
