using AttendanceSysytem.Classes;
using AttendanceSysytem.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AttendanceSysytem.Users
{
    public class Student : User
    {
        public string ClassName { get; set; }
        public Student(string name, string email, string password, string userID, string className) : base(name, email, password, userID)
        {
            ClassName = className;
        }
        public override string ToString()
        {
            return $"name : {Name}\nEmail : {Email}\nPassword : {Password}\nUserID : {UserID}\nClassName : {ClassName}";

        }
        public void ShowStudentAttendance(DateTime fromDate, DateTime toDate,StudentForm MyForm)
        {
            // Clear existing rows in the DataGridView
            MyForm.resetAttendanceTable();
            int absentDays = 0;
            if (DateTime.Compare(fromDate, toDate) == 1)
            {
                MessageBox.Show("Choose a correct range for date", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MyForm.setFromDate();
            }
            // Load the XML file
            XmlDocument xmlDoc = DataManagement.XmlPath();

            // Define a list to store attendance data
            List<Classes.Attendance> attendanceData = new List<Classes.Attendance>();

            // Select all AttendanceRecord nodes for the specific student within the specified date range and Date >= '" + fromDate.ToString("yyyy-MM-dd") + "' and Date <= '" + toDate.ToString("yyyy-MM-dd") + "']
            XmlNodeList attendanceRecords = xmlDoc.SelectNodes("//AttendanceData/AttendanceRecord[UserID='" + UserID + "']");

            // Iterate through the selected attendance records and extract relevant information
            foreach (XmlNode record in attendanceRecords)
            {
                string Userid = record.SelectSingleNode("UserID").InnerText;
                string AttendanceDateString = record.SelectSingleNode("Date").InnerText;
                DateTime attendanceDate = DateTime.Parse(AttendanceDateString);

                // Compare the DateTime objects
                int result = DateTime.Compare(fromDate, attendanceDate);
                if (result <= 0)
                {
                    result = DateTime.Compare(toDate, attendanceDate);
                    if (result >= 0)
                    {
                        string status = record.SelectSingleNode("Status").InnerText;
                        if (status == "Absent") absentDays++;
                        attendanceData.Add(new Attendance(Userid, attendanceDate.Date, status));
                    }
                }
            }

            MyForm.setAbsentDays(absentDays);

            // Populate the DataGridView with attendance data
            foreach (var data in attendanceData)
            {
                MyForm.setAttendanceRecord(data.AttendanceDate, data.Status);
            }
        }
    }
}
