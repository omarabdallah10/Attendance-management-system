using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSysytem.Classes
{
    internal class Attendance
    {
        DateTime attendanceDate;
        public Attendance(string _UserID, DateTime _date, string _status)
        {
            UserID = _UserID;
            AttendanceDate = _date;
            Status = _status;
        }

        public DateTime AttendanceDate
        {
            get { return attendanceDate; }
            set
            {
                if (DateTime.Compare(DateTime.Today, value) != -1){ attendanceDate = value; }
            }
        }
        public string Status { get; set; }
        public string UserID { get; set; }
    }
}
