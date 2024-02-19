using AttendanceSysytem.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSysytem.Forms
{
    public partial class StudentForm : Form
    {
        public Student recived { get; set; }
        public StudentForm()
        {
            InitializeComponent();
        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
            recived.ShowStudentAttendance(FromDate.Value, ToDate.Value, this);
        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {
            recived.ShowStudentAttendance(FromDate.Value, ToDate.Value, this);

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            if (recived != null && recived.UserID[0].ToString() == "S")
            {
                // initialize max date
                ToDate.MaxDate = System.DateTime.Today;
                FromDate.MaxDate = System.DateTime.Today;
                // set student Name and class
                StudentNametxt.Text = recived.Name;
                StudentClasstxt.Text = recived.ClassName;
                recived.ShowStudentAttendance(FromDate.Value, ToDate.Value, this);
            }
            else
            {
                MessageBox.Show("Not Authorized", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void StudentAttendanceTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
