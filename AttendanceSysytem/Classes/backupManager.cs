using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Timers;


namespace AttendanceSysytem.Classes
{
    internal class backupManager
    {

        //set interval for backup == 24 hours
        //make a copy of xml file and save it in backup folder
        //if backup folder does not exist, create it
        //if backup file already exists, add new backup file to the folder
        //display a message or log that the backup was successful
        //handle exceptions (log or display an error message)

        /*private const string DatabaseFilePath = "attendance_data.xml";*/

        //get the xml file path using the funcyion in data management class
        private static string DatabaseFilePath = DataManagement.xmlPath();
        private const string BackupFolderPath = "backup";
        private static System.Windows.Forms.Timer backupTimer;
        private static EventHandler BackupTimer_Tick;

        static backupManager()
        {
            InitializeBackupTimer();
        }

        public static void InitializeBackupTimer()
        {
            // Create a timer with a 24-hour interval (adjust as needed).
            backupTimer = new System.Windows.Forms.Timer();
            //backupTimer.Interval = 24 * 60 * 60 * 1000; // 24 hours in milliseconds
            //set interval for backup == every 1 minutes
            backupTimer.Interval = 1 * 60 * 1000; // 1 minutes in milliseconds
            backupTimer.Tick += BackupTimer_Tick;
            backupTimer.Start();

        }

        private static void BackupTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Perform the automatic backup when the timer elapses.
            PerformBackup();
        }

        private static void PerformBackup()
        {
            try
            {
                // Create a backup folder if it doesn't exist.
                
                if (!Directory.Exists(BackupFolderPath))
                {
                    Directory.CreateDirectory(BackupFolderPath);
                }

                // Generate a unique backup file name using a timestamp.
                string backupFileName = $"attendance_backup_{DateTime.Now:yyyyMMdd_HHmmss}.xml";
                string backupFilePath = Path.Combine(BackupFolderPath, backupFileName);

                // Copy the current database file to the backup file.
                File.Copy(DatabaseFilePath, backupFilePath, true);

                // Display a message or log that the backup was successful.
                Console.WriteLine("backup complete successfully");

                MessageBox.Show("Attendance data backup successful.", "Backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or display an error message).
                MessageBox.Show($"Error during backup: {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






       /* private const string DatabaseFilePath = "attendance_data.xml";
        private const string BackupFolderPath = "backup";
        private static System.Windows.Forms.Timer backupTimer;
        private static EventHandler BackupTimer_Tick;

        static backupManager()
        {
            InitializeBackupTimer();
        }

        private static void InitializeBackupTimer()
        {
            // Create a timer with a 24-hour interval (adjust as needed).
            backupTimer = new System.Windows.Forms.Timer();
            backupTimer.Interval = 24 * 60 * 60 * 1000; // 24 hours in milliseconds
            backupTimer.Tick += BackupTimer_Tick;
            backupTimer.Start();

        }

        private static void BackupTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Perform the automatic backup when the timer elapses.
            PerformBackup();
        }

        private static void PerformBackup()
        {
            try
            {
                // Create a backup folder if it doesn't exist.
                if (!Directory.Exists(BackupFolderPath))
                {
                    Directory.CreateDirectory(BackupFolderPath);
                }

                // Generate a unique backup file name using a timestamp.
                string backupFileName = $"attendance_backup_{DateTime.Now:yyyyMMdd_HHmmss}.xml";
                string backupFilePath = Path.Combine(BackupFolderPath, backupFileName);

                // Copy the current database file to the backup file.
                File.Copy(DatabaseFilePath, backupFilePath, true);

                // Display a message or log that the backup was successful.
                MessageBox.Show("Attendance data backup successful.", "Backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or display an error message).
                MessageBox.Show($"Error during backup: {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
*/    
}
}
