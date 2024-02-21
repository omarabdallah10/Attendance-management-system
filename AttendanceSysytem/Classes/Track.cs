using AttendanceSysytem.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AttendanceSysytem.Classes
{
    public class Track
    {
        public Track(string _name, string _SuperVisorID)
        {
            Name = _name;
            Supervisor = _SuperVisorID;
        }
        public string Name { get; set; }
        public string Supervisor { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }

        public void addTeacher(Teacher TeacherToAdd)
        {
            Teachers.Add(TeacherToAdd);
            XmlDocument doc = DataManagement.xmlDoc();
            XmlNode MyClassTeachers = doc.SelectSingleNode("//Class[Name = '" + Name + "']/Teachers");
            XmlNode newTeacher = doc.CreateElement("UserID");
            newTeacher.InnerText = TeacherToAdd.UserID;
            MyClassTeachers.AppendChild(newTeacher);
        }
        public void addStudent(Student StudentToAdd)
        {
            Students.Add(StudentToAdd);
            XmlDocument doc = DataManagement.xmlDoc();
            XmlNode MyClassTeachers = doc.SelectSingleNode("//Class[Name = '" + Name + "']/Teachers");
            XmlNode newTeacher = doc.CreateElement("UserID");
            newTeacher.InnerText = StudentToAdd.UserID;
            MyClassTeachers.AppendChild(newTeacher);
        }
        public static User[] getClassTeachers(string ClassName)
        {
            XmlDocument doc = DataManagement.xmlDoc();
            // Get Class Node
            XmlNode ClassNode = doc.SelectSingleNode("//Class[Name= '" + ClassName + "']");
            XmlNodeList ClassTeachersIDs = ClassNode.SelectNodes("/Teachers/UserID");
            User[] Teachers = new User[ClassTeachersIDs.Count];
            int i = 0;
            foreach (XmlNode ClassTeacher in ClassTeachersIDs)
            {
                Teachers[i] = DataManagement.getUserById(ClassTeacher.InnerText);
                i++;
            }
            return Teachers;
        }

    }
}
