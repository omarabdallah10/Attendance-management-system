using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

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
        public static void SaveXml(XmlDocument doc)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\xml\ProjectXml.xml");
            string sFilePath = Path.GetFullPath(sFile);
            doc.Save(sFilePath);
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
