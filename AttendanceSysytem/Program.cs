using AttendanceSysytem.Classes;
using AttendanceSysytem.Forms;
using AttendanceSysytem.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;


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

            // initialize the backup manager
            backupManager.InitializeBackupTimer();

            Application.Run(new TeacherViewAttendanceForm());





            
            //isAdmin("Admin@admin.com", "123456789");
        }
    }
}
