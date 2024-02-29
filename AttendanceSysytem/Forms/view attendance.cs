using AttendanceSysytem.Classes;
using AttendanceSysytem.Users;
using PdfSharp.Drawing;
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
    public partial class view_attendance : Form
    {
        public Teacher recived { get; set; }
        public XmlDocument xmlDoc { get; set; }
        private string DateFormat = "dddd, dd MMMM yyyy";
        public view_attendance()
        {
            Settings.ChangeFont(this, Settings.MyFont, true);
            xmlDoc = DataManagement.xmlDoc();
            InitializeComponent();
        }
        private void view_attendance_Load(object sender, EventArgs e)
        {
            string UserID = recived.UserID;
            XmlDocument xmlDoc = DataManagement.xmlDoc();
            XmlNodeList ClassNodes = xmlDoc.SelectNodes("//Class");
            foreach (XmlNode ClassNode in ClassNodes)
            {
                XmlNode TeacherNode = ClassNode.SelectSingleNode("Teachers");
                XmlNodeList TeachersNodes = TeacherNode.SelectNodes("UserID");
                foreach (XmlNode teacherNode in TeachersNodes)
                {
                    if (UserID == teacherNode.InnerText)
                    {
                        string ClassName = ClassNode.SelectSingleNode("Name").InnerText;
                        classCompoBox.Items.Add(ClassName);
                    }
                }
            }
            classCompoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            classCompoBox.SelectedIndex = 0;
            DayFormatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DayFormatComboBox.SelectedIndex = 0;
        }

        private void classCompoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentAttendanceTable.AlternatingRowsDefaultCellStyle.Font = StudentAttendanceTable.RowsDefaultCellStyle.Font;
            printTable();
        }
        private void printTable()
        {
            // initialize max date
            ToDate.MaxDate = System.DateTime.Today;
            FromDate.MaxDate = System.DateTime.Today;

            // Clear existing rows in the DataGridView
            // Clear existing rows in the DataGridView
            this.StudentAttendanceTable.Rows.Clear();

            // Define a list to store attendance data
            List<Classes.Attendance> attendanceData = new List<Classes.Attendance>();

            // Get the selected class name from the ComboBox
            string selectedClassName = classCompoBox.Text;

            // Retrieve all attendance records for the selected class
            XmlNodeList attendanceRecords = xmlDoc.SelectNodes($"//AttendanceData/AttendanceRecord[ClassName='{classCompoBox.Text}']");
            foreach (XmlNode record in attendanceRecords)
            {
                string UserID = record.SelectSingleNode("UserID").InnerText;
                string AttendanceDateString = record.SelectSingleNode("Date").InnerText;
                DateTime attendanceDate = DateTime.Parse(AttendanceDateString);

                // Check if the attendance date is within the specified range
                // Compare the DateTime objects
                int result = DateTime.Compare(FromDate.Value, attendanceDate);
                if (result <= 0)
                {
                    result = DateTime.Compare(ToDate.Value, attendanceDate);
                    if (result >= 0)
                    {
                        string status = record.SelectSingleNode("Status").InnerText;
                        attendanceData.Add(new Attendance(UserID, attendanceDate.Date, status));
                    }
                }


            }

            // Populate the DataGridView with attendance data
            foreach (var data in attendanceData)
            {
                this.StudentAttendanceTable.Rows.Add(data.Status, data.AttendanceDate.ToString(DateFormat.ToString()), data.UserID);
            }
        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {
            printTable();
        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
            printTable();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DayFormatComboBox.SelectedIndex)
            {
                case 0:
                    DateFormat = "MM/dd/yyyy";

                    break;
                case 1:
                    DateFormat = "dddd, dd MMMM yyyy";
                    break;
                case 2:
                    DateFormat = "MMMM dd";
                    break;
                case 3:
                    DateFormat = "yyyy MMMM";
                    break;
            }
            Console.WriteLine(DateFormat);
            printTable();
        }

        private void DayFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DayFormatComboBox.SelectedIndex)
            {
                case 0:
                    DateFormat = "MM/dd/yyyy";
                    break;
                case 1:
                    DateFormat = "dddd, dd MMMM yyyy";
                    break;
                case 2:
                    DateFormat = "MMMM dd";
                    break;
                case 3:
                    DateFormat = "yyyy MMMM";
                    break;
            }
            printTable();
        }
    }
}
