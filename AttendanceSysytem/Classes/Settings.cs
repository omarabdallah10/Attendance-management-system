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
    internal class Settings
    {
        //*****************************************  Font Data  *****************************************

        public static Font MyFont = new Font("Times New Roman", 10f);
        // Method to change font recursively for all controls
        public static void ChangeFont(Control control, Font font, bool changeChildren)
        {
            control.Font = font;
            if (changeChildren)
            {
                foreach (Control childControl in control.Controls)
                {
                    ChangeFont(childControl, font, changeChildren);
                }
            }
        }

        // You can call this method whenever you need to change the font
        public static void ChangeFontForAllPages(Font font)
        {
            MyFont = font;
            foreach (Form form in Application.OpenForms)
            {
                // Change font for each form
                ChangeFont(form, font, true);
            }
        }
    }
}
