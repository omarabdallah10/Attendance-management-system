using AttendanceSysytem.Classes;
using AttendanceSysytem.Users;
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

namespace AttendanceSysytem.Forms
{
    public partial class TeachersForm : Form
    {
        Form oldform = null;
        public TeachersForm(Form f1)
        {
            InitializeComponent();
            oldform = f1;
            DataManagement.ChangeFont(this, DataManagement.MyFont, true);
        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = DataManagement.xmlDoc();
            XmlNodeList Teachers = xmlDoc.SelectNodes("//Users/Teacher");
            TeachersTable.AlternatingRowsDefaultCellStyle.Font = TeachersTable.RowsDefaultCellStyle.Font;
            // Clear existing rows in the DataGridView
            this.TeachersTable.Rows.Clear();
            List<Teacher> TeachersList = new List<Teacher>();

            foreach (XmlElement TeacherRecord in Teachers)
            {
                string TeacherID = TeacherRecord.SelectSingleNode("UserID").InnerText;
                string TeacherName = TeacherRecord.SelectSingleNode("Name").InnerText;
                string TeacherEmail = TeacherRecord.SelectSingleNode("Email").InnerText;
                string TeacherPassword = TeacherRecord.SelectSingleNode("Password").InnerText;
                Teacher _teacher = new Teacher(TeacherName, TeacherEmail, TeacherPassword, TeacherID);
                _teacher.ShowTeacherData(this);
                TeachersList.Add(_teacher);
            }
        }

        private void TeachersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                MessageBox.Show(this.TeachersTable.Rows.SharedRow(e.RowIndex).Cells[0].Value.ToString());
                Hide();
                EditTeacherForm form = new EditTeacherForm(this);
                form.recived = TeachersTable.Rows.SharedRow(e.RowIndex).Cells[0].Value.ToString();
                Console.WriteLine(form.recived);
                form.Show();
            }
        }

        private void go_back_btn_Click(object sender, EventArgs e)
        {
            Hide();
            oldform.Show();
        }
    }
}
