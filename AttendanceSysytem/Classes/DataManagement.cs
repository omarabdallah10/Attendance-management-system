using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AttendanceSysytem.Classes
{
    internal class DataManagement
    {
        /*
        1-Sava as PDF file or excel file
        2-Save Data to XML
        3-Load Data from XML
        */
        public static XmlDocument XmlPath()
        {
            XmlDocument doc = new XmlDocument();
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\xml\ProjectXml.xml");
            string sFilePath = Path.GetFullPath(sFile);
            doc.Load(sFilePath);
            return doc;
        }
    }
}
