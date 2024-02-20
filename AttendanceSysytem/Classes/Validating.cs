using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSysytem.Classes
{
    public class Valid
    {
        static public bool ValidName(string name)
        {
            string pattern = @"^[a-zA-Z]{2,}(?: [a-zA-Z]+){1,}$";
            return Regex.IsMatch(name, pattern);
 
        }
        static public bool ValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, emailPattern);

        }
        static public bool ValidPassword(string password)
        {
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*()-_+=])[A-Za-z\d!@#$%^&*()-_+=]{8,}$";

            return Regex.IsMatch(password, passwordPattern);

        }
        static public bool ValidUserInput(string name , string email , string password)
        {
            if (!ValidName(name))
            {
                MessageBox.Show("Invalid name formula please try again");
                return false;
            }else if (!ValidEmail(email))
            {
                MessageBox.Show("Invalid email formula please try again");
                return false;
            }else if (!ValidPassword(password))
            {
                MessageBox.Show("Invalid password formula please try again");
                return false;
            }
            return true;
        }
    }
}
