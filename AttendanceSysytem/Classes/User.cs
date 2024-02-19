using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSysytem
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserID { get; set; }
        public User(string name, string email, string password, string userID)
        {
            Name = name;
            Email = email;
            Password = password;
            UserID = userID;
        }
        public override string ToString()
        {
            return $"name : {Name}\nEmail : {Email}\nPassword : {Password}\nUserID : {UserID}";
        }
    }
}
