using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AttendanceSysytem.Classes
{
    public class Adding
    {
        static public int RandomID()
        {
           Random random = new Random();
            return random.Next(100, 1000);
        }
        static public XmlElement addUser (string type, XmlDocument doc, string name,string email, string password)
        {
            XmlElement newUser = doc.CreateElement(type);

            string userId = type[0] + RandomID().ToString();
            XmlElement newId = doc.CreateElement("UserID");
            newId.InnerText = userId; // Set the student ID

            XmlElement newName = doc.CreateElement("Name");
            newName.InnerText = name; // Set the student name

            XmlElement newEmail = doc.CreateElement("Email");
            newEmail.InnerText = email; // Set the student email

            XmlElement newPassword = doc.CreateElement("Password");
            newPassword.InnerText = password; // Set the student password

            newUser.AppendChild(newId);
            newUser.AppendChild(newName);
            newUser.AppendChild(newEmail);
            newUser.AppendChild(newPassword);

            return newUser ;
        }
    }
}
