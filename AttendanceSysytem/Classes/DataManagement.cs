using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;
using System.Threading;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using AttendanceSysytem.Forms;



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
        public static XmlElement GetElementById(XmlDocument doc, string id, string type)
        {
            XmlNodeList UserNodes = doc.SelectNodes($"//Users/{type}");
            foreach (XmlNode UserNode in UserNodes)
            {
                XmlNode userID = UserNode.SelectSingleNode("UserID");
                if (id == userID.InnerText)
                {
                    return (XmlElement)UserNode;
                }
            }
            return null;
        }

        public static void addTeacherToClass(XmlDocument doc, string id, string className)
        {
            XmlNodeList ClassNodes = doc.SelectNodes("//Class");

            foreach (XmlNode ClassNode in ClassNodes)
            {
                XmlNode NameNode = ClassNode.SelectSingleNode("Name");
                if (className == NameNode.InnerText)
                {
                    XmlElement user = doc.CreateElement("UserID");
                    user.InnerText = id;
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
                        if (teacherId.InnerText == id)
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
                UserTypeNodes = doc.SelectSingleNode("//Users/Student[UserID = '" + id + "']");
            else if (id[0] == 'T')
            {
                UserTypeNodes = doc.SelectSingleNode("//Users/Teacher[UserID = '" + id + "']");
            }
            //
            string _name = UserTypeNodes.SelectSingleNode("Name").InnerText;
            string _Email = UserTypeNodes.SelectSingleNode("Email").InnerText;
            string _Password = UserTypeNodes.SelectSingleNode("Password").InnerText;
            User s = new User(_name, _Email, _Password, id);
            return s;
        }
        public static void deleteUser(XmlDocument doc, XmlNode user)
        {
            XmlNode Users = doc.SelectSingleNode("//Users");
            string id = user.SelectSingleNode("UserID").InnerText;
            if (id[0] == 'S')
            {
                string classname = user.SelectSingleNode("ClassName").InnerText;
                Console.WriteLine(classname);
                XmlNodeList ClassNodes = doc.SelectNodes("//Class");
                foreach (XmlNode ClassNode in ClassNodes)
                {
                    if (ClassNode.SelectSingleNode("Name").InnerText == classname)
                    {
                        Console.WriteLine(classname + "2");
                        XmlNode studentsnode = ClassNode.SelectSingleNode("Students");
                        XmlNodeList userIdnodes = studentsnode.SelectNodes("UserID");
                        foreach (XmlNode userIdnode in userIdnodes)
                        {
                            if (userIdnode.InnerText == id)
                            {
                                studentsnode.RemoveChild(userIdnode);
                                Console.WriteLine(id);
                            }
                        }
                    }
                }
            }
            else if (id[0] == 'T')
            {
                XmlNodeList ClassNodes = doc.SelectNodes("//Class");
                foreach (XmlNode ClassNode in ClassNodes)
                {
                    XmlNode TeacherNode = ClassNode.SelectSingleNode("Teachers");
                    XmlNodeList TeachersNodes = TeacherNode.SelectNodes("UserID");
                    foreach (XmlNode teacherNode in TeachersNodes)
                    {
                        if (id == teacherNode.InnerText)
                        {
                            TeacherNode.RemoveChild(teacherNode);
                            Console.WriteLine(id);
                        }
                    }
                }
                if (user.Attributes[0].InnerText == "true")
                {
                    XmlNode classname = doc.SelectSingleNode("//Class/Supervisor[UserID='" + id + "']");
                    //Console.WriteLine(classname.ParentNode.FirstChild.InnerText);
                    Track t1 = new Track(classname.ParentNode.FirstChild.InnerText, id);
                    //EditClassForm editClassForm = new EditClassForm();
                    MessageBox.Show($"This teacher is a supervisor for class{t1.Name}, please change its supervisor first");

                    return;
                }

            }
            Users.RemoveChild(user);

        }

        public static void changeStdClassName(XmlDocument doc, string oldClassName, string newClassName)
        {
            XmlNodeList studentnodes = doc.SelectNodes("//Users/Student");
            foreach (XmlNode studentnode in studentnodes)
            {
                if (studentnode.SelectSingleNode("ClassName").InnerText == oldClassName)
                {
                    studentnode.SelectSingleNode("ClassName").InnerText = newClassName;
                    Console.WriteLine(studentnode.SelectSingleNode("Name").InnerText);
                }
            }
        }

       
    }
}
