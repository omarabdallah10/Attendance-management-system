using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using System.IO;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;



namespace AttendanceSysytem.Classes
{
    internal class DataManagement
    {

        /*
        1-Sava as PDF file or excel file
        2-Save Data to XML
        3-Load Data from XML
        */
        public static XmlDocument xmlDoc()
        {
            XmlDocument doc = new XmlDocument();
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\xml\ProjectXml.xml");
            string sFilePath = Path.GetFullPath(sFile);
            doc.Load(sFilePath);
            return doc;
        }
        public static string xmlPath()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\xml\ProjectXml.xml");
            string sFilePath = Path.GetFullPath(sFile);
            return sFilePath;
        }
        public static void SaveXml(XmlDocument doc)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\xml\ProjectXml.xml");
            string sFilePath = Path.GetFullPath(sFile);
            doc.Save(sFilePath);
        }
        public static XmlElement GetElementById(XmlDocument doc, string id)
        {
            XmlNodeList TeachereNodes=doc.SelectNodes("//Users/Teacher");
            foreach (XmlNode TeacherNode in TeachereNodes)
            {
                XmlNode userID = TeacherNode.SelectSingleNode("UserID");
                if (id == userID.InnerText)
                {
                    return (XmlElement)TeacherNode;
                }
            }
            return null;
        }

        public static void addTeacherToClass(XmlDocument doc,string id,string className)
        {
            XmlNodeList ClassNodes = doc.SelectNodes("//Class");

                foreach (XmlNode ClassNode in ClassNodes)
                {
                    XmlNode NameNode = ClassNode.SelectSingleNode("Name");
                    if (className == NameNode.InnerText)
                    {
                    XmlElement user = doc.CreateElement("UserID");
                        user.InnerText=id;
                        XmlNode classTeachers = ClassNode.SelectSingleNode("Teachers");
                        classTeachers.AppendChild(user);
                    }
                }
            
        }
        public static void removeTeacherFromClass(XmlDocument doc, string id, string className)
        {
            XmlNodeList ClassNodes = doc.SelectNodes("//Class");

            foreach (XmlNode ClassNode in ClassNodes)
            {
                XmlNode NameNode = ClassNode.SelectSingleNode("Name");
                if (className == NameNode.InnerText)
                {
                    XmlNode classTeachers = ClassNode.SelectSingleNode("Teachers");
                    XmlNodeList teachernodes = classTeachers.SelectNodes("UserID");
                    foreach (XmlNode teacherId in teachernodes)
                    {
                        if(teacherId.InnerText == id)
                        {
                            classTeachers.RemoveChild(teacherId);
                        }
                    }   
                }
            }

        }
        public static User getUserById(string id)
        {
            XmlDocument doc = xmlDoc();
            // Get All the nodes similar to the user type
            XmlNode UserTypeNodes = doc.SelectSingleNode("//Users/Admin[UserID = '" + id + "']"); ;
            if (id[0] == 'S')
                UserTypeNodes = doc.SelectSingleNode("//Users/Student[UserID = '"+id+"']");
            else if (id[0] == 'T')
            {
                UserTypeNodes = doc.SelectSingleNode("//Users/Teacher[UserID = '" + id + "']");
            }
            //
            string _name = UserTypeNodes.SelectSingleNode("Name").InnerText;
            string _Email = UserTypeNodes.SelectSingleNode("Email").InnerText;
            string _Password= UserTypeNodes.SelectSingleNode("Password").InnerText;
            User s = new User(_name,_Email,_Password,id);
            return s;
        }
    }
}
