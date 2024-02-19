using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSysytem.Users
{
    internal class Student : User
    {
        public string ClassName { get; set; }
        public Student(string name, string email, string password, string userID,string className) : base(name, email, password, userID)
        {
            ClassName = className;
        }
        public override string ToString()
        {
            return $"name : {Name}\nEmail : {Email}\nPassword : {Password}\nUserID : {UserID}\nClassName : {ClassName}";

        }
    }
}
