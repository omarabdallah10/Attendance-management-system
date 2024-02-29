using AttendanceSysytem.Classes;
using AttendanceSysytem.Forms;
using AttendanceSysytem.Users;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AttendanceSysytem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Initialize the LanguageManager
            Settings.Initialize();

            // Subscribe to FormOpened event to track new forms
            Application.ApplicationExit += (sender, e) => Settings.FormOpened -= Settings.OnFormOpened;
            Settings.FormOpened += (form) => Settings.AddForm(form);
            Application.Run(new loginForm());


            //isAdmin("Admin@admin.com", "123456789");
        }
    }
}
