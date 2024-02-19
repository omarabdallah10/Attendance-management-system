﻿using AttendanceSysytem;
using AttendanceSysytem.Users;
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


            public static object isAdmin(string email, string password)
        {
            doc.Load(sFilePath);
            XmlNodeList adminNodes = doc.SelectNodes("//Users/Admin");
            foreach (XmlNode adminNode in adminNodes)
            {
                XmlNode EmailNode = adminNode.SelectSingleNode("Email");
                XmlNode PasswordNode = adminNode.SelectSingleNode("Password");
                XmlNode IDNode = adminNode.SelectSingleNode("UserID");
                XmlNode NameNode = adminNode.SelectSingleNode("Name");

                if (email == EmailNode.InnerText && password == PasswordNode.InnerText) 
                {
                    return new Admin(NameNode.InnerText, EmailNode.InnerText, PasswordNode.InnerText, IDNode.InnerText);
                }

            }
            return isStudent(email,password) ;
        }
        public static object isStudent(string email, string password)
        {
            doc.Load(sFilePath);
            XmlNodeList studentNodes = doc.SelectNodes("//Users/Student");
            foreach (XmlNode studentNode in studentNodes)
            {
                XmlNode EmailNode = studentNode.SelectSingleNode("Email");
                XmlNode PasswordNode = studentNode.SelectSingleNode("Password");
                XmlNode IDNode = studentNode.SelectSingleNode("UserID");
                XmlNode NameNode = studentNode.SelectSingleNode("Name");
                XmlNode ClassNode = studentNode.SelectSingleNode("ClassName");

                if (email == EmailNode.InnerText && password == PasswordNode.InnerText)
                {
                    return new Student(NameNode.InnerText, EmailNode.InnerText, PasswordNode.InnerText, IDNode.InnerText, ClassNode.InnerText);
                }

            }
            return isTeacher(email,password) ;
        }
        public static object isTeacher(string email, string password)
        {
            doc.Load(sFilePath);
            XmlNodeList teacherNodes = doc.SelectNodes("//Users/Teacher");
            foreach (XmlNode teacherNode in teacherNodes)
            {
                XmlNode EmailNode = teacherNode.SelectSingleNode("Email");
                XmlNode PasswordNode = teacherNode.SelectSingleNode("Password");
                XmlNode IDNode = teacherNode.SelectSingleNode("UserID");
                XmlNode NameNode = teacherNode.SelectSingleNode("Name");

                if (email == EmailNode.InnerText && password == PasswordNode.InnerText)
                {
                    return new Teacher(NameNode.InnerText, EmailNode.InnerText, PasswordNode.InnerText, IDNode.InnerText);
                }

            }
            return null;
        }
        public static object auth(string email, string password)
        {
            if (isAdmin(email, password) != null)
            {
                return isAdmin(email, password);
            }else
            {
                if(isTeacher(email, password) != null)
                {
                    return isTeacher(email, password);
                }
                else
                {
                    if(isStudent(email, password) != null)
                    {
                        return isStudent(email, password);
                    }
                }
            }return null;
        }
    }
}
