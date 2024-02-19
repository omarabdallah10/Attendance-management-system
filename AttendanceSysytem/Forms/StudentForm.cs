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

namespace AttendanceSysytem.Forms
{
    public partial class StudentForm : Form
    {
        public Student recived {  get; set; }
        public StudentForm()
        {
            InitializeComponent();
        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
               ShowStudentAttendance("S002", FromDate.Value, ToDate.Value);
        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {
            ShowStudentAttendance("S002", FromDate.Value, ToDate.Value);

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // Clear existing rows in the DataGridView
            StudentAttendanceTable.Rows.Clear();
            // initialize max date
            ToDate.MaxDate = System.DateTime.Today;
            FromDate.MaxDate = System.DateTime.Today;
            // set student Name and class
            StudentNametxt.Text = "Abdelhameed Osama";
            StudentClasstxt.Text = "PD";
        }

        private void StudentAttendanceTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
