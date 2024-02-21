using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        static public XmlElement addUser (string type, XmlDocument doc, string Fname,string Lname ,string email, string password)
        {
            XmlElement newUser = doc.CreateElement(type);
            string fullName=Fname.Trim()+" "+Lname.Trim();
            if(!Valid.ValidUserInput(fullName, email, password))
            {
                return null;
            }
            
            XmlElement newName = doc.CreateElement("Name");
            newName.InnerText = fullName; // Set the User name

            XmlElement newEmail = doc.CreateElement("Email");
            newEmail.InnerText = email; // Set the User email

            XmlElement newPassword = doc.CreateElement("Password");
            newPassword.InnerText = password; // Set the User password

            string userId = type[0] + RandomID().ToString();
            XmlElement newId = doc.CreateElement("UserID");
            newId.InnerText = userId; // Set the User ID

            newUser.AppendChild(newId);
            newUser.AppendChild(newName);
            newUser.AppendChild(newEmail);
            newUser.AppendChild(newPassword);

            return newUser ;
        }
       static public XmlElement AddClass(XmlDocument doc , string name , string supervisor)
        {
            name=name.Trim();
            if (name.Length<2)
            {
                return null;
            }
            XmlElement newClass = doc.CreateElement("Class");
            XmlElement newName = doc.CreateElement("Name");
            newName.InnerText = name; // Set the class name
            XmlElement newSupervisor = doc.CreateElement("Supervisor");
            XmlElement superId = doc.CreateElement("UserID");
            superId.InnerText = supervisor; // Set the Supervisor ID
            newSupervisor.AppendChild(superId);
            XmlNode newId = superId.CloneNode(true);
            XmlElement Teachers = doc.CreateElement("Teachers");
            newId.InnerText = supervisor;
            Teachers.AppendChild(newId);
            XmlElement Students = doc.CreateElement("Students");


            newClass.AppendChild(newName);
            newClass.AppendChild(newSupervisor);
            newClass.AppendChild(Teachers);
            newClass.AppendChild(Students);
            return newClass ;
        }
    }
}
