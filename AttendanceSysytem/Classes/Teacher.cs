using AttendanceSysytem.Classes;
using AttendanceSysytem.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AttendanceSysytem.Users
{
    public class Teacher : User
    {
        public Teacher(string name, string email, string password, string userID):base(name, email, password, userID)
        {

        }
        public void ShowTeacherData(StudentsForm MyForm)
        {
            // Load the XML file
            XmlDocument xmlDoc = DataManagement.XmlPath();
            MyForm.AddRow(UserID, Name, ClassName);

        }
    }
}
