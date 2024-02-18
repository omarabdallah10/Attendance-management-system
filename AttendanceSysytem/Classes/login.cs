using AttendanceSysytem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace AttendanceSysytem.Classes
{
    internal class login
    {
        static XmlDocument doc = new XmlDocument();
        static string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        static string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\xml\ProjectXml.xml");
        static string sFilePath = Path.GetFullPath(sFile);


            public static string isAdmin(string email, string password)
        {
            doc.Load(sFilePath);
            XmlNodeList adminNodes = doc.SelectNodes("//Users/Admin");
            foreach (XmlNode adminNode in adminNodes)
            {
                XmlNode EmailNode = adminNode.SelectSingleNode("Email");
                XmlNode PasswordNode = adminNode.SelectSingleNode("Password");
                XmlNode IDNode = adminNode.SelectSingleNode("UserID");

                if (email == EmailNode.InnerText && password == PasswordNode.InnerText) 
                {
                    Console.WriteLine($"Email: {email}");
                    Console.WriteLine($"password: {password}");
                    return IDNode.InnerText ;
                }

            }
            return isStudent(email,password) ;
        }
        public static string isStudent(string email, string password)
        {
            doc.Load(sFilePath);
            XmlNodeList adminNodes = doc.SelectNodes("//Users/Student");
            foreach (XmlNode adminNode in adminNodes)
            {
                XmlNode EmailNode = adminNode.SelectSingleNode("Email");
                XmlNode PasswordNode = adminNode.SelectSingleNode("Password");
                XmlNode IDNode = adminNode.SelectSingleNode("UserID");

                if (email == EmailNode.InnerText && password == PasswordNode.InnerText)
                {
                    Console.WriteLine($"Email: {email}");
                    Console.WriteLine($"password: {password}");
                    return IDNode.InnerText ;
                }

            }
            return isTeacher(email,password) ;
        }
        public static string isTeacher(string email, string password)
        {
            doc.Load(sFilePath);
            XmlNodeList adminNodes = doc.SelectNodes("//Users/Teacher");
            foreach (XmlNode adminNode in adminNodes)
            {
                XmlNode EmailNode = adminNode.SelectSingleNode("Email");
                XmlNode PasswordNode = adminNode.SelectSingleNode("Password");
                XmlNode IDNode = adminNode.SelectSingleNode("UserID");

                if (email == EmailNode.InnerText && password == PasswordNode.InnerText)
                {
                    Console.WriteLine($"Email: {email}");
                    Console.WriteLine($"password: {password}");
                    return IDNode.InnerText ;
                }

            }
            return null;
        }
        public static void auth(string email, string password)
        {
            
        }
    }
}
