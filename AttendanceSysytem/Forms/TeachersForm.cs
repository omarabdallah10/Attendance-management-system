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
            Settings.ChangeFont(this, Settings.MyFont, true);

        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = DataManagement.xmlDoc();
            
        }

        private void TeachersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                MessageBox.Show(this.TeachersTable.Rows.SharedRow(e.RowIndex).Cells[0].Value.ToString());
                Hide();
                //EditTeacherForm form = new EditTeacherForm();
                //form.recived = TeachersTable.Rows.SharedRow(e.RowIndex).Cells[0].Value.ToString();
                //Console.WriteLine(form.recived);
                //form.Show();
            }
        }

        private void go_back_btn_Click(object sender, EventArgs e)
        {
            Hide();
            oldform.Show();
        }
    }
}
