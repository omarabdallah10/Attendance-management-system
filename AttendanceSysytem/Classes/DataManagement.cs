﻿using System;
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
        public static XmlElement GetElementById(XmlDocument doc, string id,string type)
        {
            XmlNodeList UserNodes=doc.SelectNodes($"//Users/{type}");
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
        public static void deleteUser(XmlDocument doc,XmlNode user)
        {
            XmlNode Users = doc.SelectSingleNode("//Users");
            Users.RemoveChild(user);
        }
    }
}
