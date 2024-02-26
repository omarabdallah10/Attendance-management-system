using AttendanceSysytem.Classes;
using AttendanceSysytem.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AttendanceSysytem.Users
{
    public class Teacher : User
    {
        string TeacherClasses;
        string SupervisedClass;
        XmlDocument xmlDoc = DataManagement.xmlDoc();
        public Teacher(string name, string email, string password, string userID) : base(name, email, password, userID)
        {
            TeacherClasses = getClassesFromXML();
            SupervisedClass = getSupervisedClassesFromXML();
        }

        // Get Teaching Classes
        public string getClassesFromXML()
        {
            string TeacherClassesXml = "";
            int First = 1;
            XmlNodeList Classes = xmlDoc.SelectNodes("//Class");
            foreach (XmlNode classrecord in Classes)
            {
                XmlNode TeachersInClass = classrecord.SelectSingleNode($"Teachers[UserID = '{UserID}']");
                if (TeachersInClass == null) continue;
                if (First == 1)
                {
                    TeacherClassesXml += TeachersInClass.ParentNode.FirstChild.InnerText;
                    First = 0;
                }
                else
                    TeacherClassesXml += ", " + TeachersInClass.ParentNode.FirstChild.InnerText;
            }


            return TeacherClassesXml;
        }


        // Get Supervised Classes if Found
        public string getSupervisedClassesFromXML()
        {
            string TeacherSupervisedClassesXml = "----";
            XmlDocument xmlDoc = DataManagement.xmlDoc();

            XmlNodeList Teachers = xmlDoc.SelectNodes("//Users/Teacher");
            foreach (XmlElement TeacherRecord in Teachers)
            {
                if (TeacherRecord.GetAttribute("Supervisor").ToLower() == "true")
                {
                    XmlNodeList Classes = xmlDoc.SelectNodes("//Class");
                    foreach (XmlNode classrecord in Classes)
                    {
                        XmlNode SupervisedTeacher = classrecord.SelectSingleNode("Supervisor/UserID");
                        if (SupervisedTeacher.InnerText == UserID)
                            TeacherSupervisedClassesXml = SupervisedTeacher.ParentNode.ParentNode.FirstChild.InnerText;
                        if (TeacherSupervisedClassesXml != "----") break;

                    }
                    if (TeacherSupervisedClassesXml != "----") break;
                }
            }
            return TeacherSupervisedClassesXml;
        }



        public void ShowTeacherData(TeachersForm MyForm)
        {
            // Load the XML file
            XmlDocument xmlDoc = DataManagement.xmlDoc();
            MyForm.AddRow(UserID, Name, TeacherClasses, SupervisedClass);
        }
    }
}
