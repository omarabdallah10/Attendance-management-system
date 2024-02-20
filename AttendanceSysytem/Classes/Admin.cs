using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSysytem.Users
{
    public class Admin : User
    {
        public Admin(string name, string email, string password, string userID) : base(name, email, password, userID)
        {

        }

    }
}
