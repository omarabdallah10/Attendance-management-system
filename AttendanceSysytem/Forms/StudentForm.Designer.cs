using AttendanceSysytem.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml;

namespace AttendanceSysytem.Forms
{
    partial class StudentForm
    {
        private string DateFormat = "dddd, dd MMMM yyyy";
        // Define a method to fetch and display attendance data for a specific student
        private void ShowStudentAttendance(string studentID, DateTime fromDate, DateTime toDate)
        {
            // Clear existing rows in the DataGridView
            StudentAttendanceTable.Rows.Clear();
            int absentDays = 0;
            if (DateTime.Compare(fromDate, toDate) == 1)
            {
                MessageBox.Show("Choose a correct range for date", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FromDate.Value = FromDate.MinDate;
            }
            // Load the XML file
            XmlDocument xmlDoc = DataManagement.xmlDoc();

            // Define a list to store attendance data
            List<Classes.Attendance> attendanceData = new List<Classes.Attendance>();

            // Select all AttendanceRecord nodes for the specific student within the specified date range and Date >= '" + fromDate.ToString("yyyy-MM-dd") + "' and Date <= '" + toDate.ToString("yyyy-MM-dd") + "']
            XmlNodeList attendanceRecords = xmlDoc.SelectNodes("//AttendanceData/AttendanceRecord[UserID='" + studentID + "']");

            // Iterate through the selected attendance records and extract relevant information
            foreach (XmlNode record in attendanceRecords)
            {
                string Userid = record.SelectSingleNode("UserID").InnerText;
                string AttendanceDateString = record.SelectSingleNode("Date").InnerText;
                DateTime attendanceDate = DateTime.Parse(AttendanceDateString);

                // Compare the DateTime objects
                int result = DateTime.Compare(fromDate, attendanceDate);
                if (result <= 0)
                {
                    result = DateTime.Compare(toDate, attendanceDate);
                    if (result >= 0)
                    {
                        string status = record.SelectSingleNode("Status").InnerText;
                        if (status == "Absent") absentDays++;
                        attendanceData.Add(new Attendance(Userid, attendanceDate.Date, status));
                    }
                }
            }

            AbsentDays.Text = absentDays.ToString();

            // Populate the DataGridView with attendance data
            foreach (var data in attendanceData)
            {
                StudentAttendanceTable.Rows.Add(data.AttendanceDate.DayOfWeek, data.AttendanceDate, data.Status);
            }
        }




        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StudentNametxt = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.class_label = new System.Windows.Forms.Label();
            this.StudentClasstxt = new System.Windows.Forms.TextBox();
            this.showFrom_label = new System.Windows.Forms.Label();
            this.to_label = new System.Windows.Forms.Label();
            this.StudentAttendanceTable = new System.Windows.Forms.DataGridView();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absentdays_label = new System.Windows.Forms.Label();
            this.AbsentDays = new System.Windows.Forms.TextBox();
            this.signOutBTN = new System.Windows.Forms.Button();
            this.saveAs_btn = new System.Windows.Forms.Button();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.settings = new System.Windows.Forms.Button();
            this.DayFormatComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentAttendanceTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentNametxt
            // 
            resources.ApplyResources(this.StudentNametxt, "StudentNametxt");
            this.StudentNametxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StudentNametxt.Name = "StudentNametxt";
            this.StudentNametxt.ReadOnly = true;
            // 
            // name_label
            // 
            resources.ApplyResources(this.name_label, "name_label");
            this.name_label.Name = "name_label";
            // 
            // class_label
            // 
            resources.ApplyResources(this.class_label, "class_label");
            this.class_label.Name = "class_label";
            // 
            // StudentClasstxt
            // 
            resources.ApplyResources(this.StudentClasstxt, "StudentClasstxt");
            this.StudentClasstxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StudentClasstxt.Name = "StudentClasstxt";
            this.StudentClasstxt.ReadOnly = true;
            // 
            // showFrom_label
            // 
            resources.ApplyResources(this.showFrom_label, "showFrom_label");
            this.showFrom_label.Name = "showFrom_label";
            // 
            // to_label
            // 
            resources.ApplyResources(this.to_label, "to_label");
            this.to_label.Name = "to_label";
            // 
            // StudentAttendanceTable
            // 
            resources.ApplyResources(this.StudentAttendanceTable, "StudentAttendanceTable");
            this.StudentAttendanceTable.AllowUserToAddRows = false;
            this.StudentAttendanceTable.AllowUserToDeleteRows = false;
            this.StudentAttendanceTable.AllowUserToOrderColumns = true;
            this.StudentAttendanceTable.AllowUserToResizeColumns = false;
            this.StudentAttendanceTable.AllowUserToResizeRows = false;
            this.StudentAttendanceTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentAttendanceTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentAttendanceTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentAttendanceTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentAttendanceTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentAttendanceTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.StudentAttendanceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentAttendanceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATE,
            this.STATUS});
            this.StudentAttendanceTable.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StudentAttendanceTable.Name = "StudentAttendanceTable";
            this.StudentAttendanceTable.ReadOnly = true;
            this.StudentAttendanceTable.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StudentAttendanceTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.StudentAttendanceTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentAttendanceTable_CellContentClick);
            // 
            // DATE
            // 
            resources.ApplyResources(this.DATE, "DATE");
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            // 
            // STATUS
            // 
            resources.ApplyResources(this.STATUS, "STATUS");
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // absentdays_label
            // 
            resources.ApplyResources(this.absentdays_label, "absentdays_label");
            this.absentdays_label.Name = "absentdays_label";
            // 
            // AbsentDays
            // 
            resources.ApplyResources(this.AbsentDays, "AbsentDays");
            this.AbsentDays.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AbsentDays.Name = "AbsentDays";
            this.AbsentDays.ReadOnly = true;
            // 
            // signOutBTN
            // 
            resources.ApplyResources(this.signOutBTN, "signOutBTN");
            this.signOutBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signOutBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signOutBTN.Name = "signOutBTN";
            this.signOutBTN.UseVisualStyleBackColor = false;
            this.signOutBTN.Click += new System.EventHandler(this.signOutBTN_Click);
            // 
            // saveAs_btn
            // 
            resources.ApplyResources(this.saveAs_btn, "saveAs_btn");
            this.saveAs_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveAs_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveAs_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveAs_btn.Name = "saveAs_btn";
            this.saveAs_btn.UseVisualStyleBackColor = false;
            // 
            // ToDate
            // 
            resources.ApplyResources(this.ToDate, "ToDate");
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.MinDate = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            this.ToDate.Name = "ToDate";
            this.ToDate.Value = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            this.ToDate.ValueChanged += new System.EventHandler(this.ToDate_ValueChanged);
            // 
            // FromDate
            // 
            resources.ApplyResources(this.FromDate, "FromDate");
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.MaxDate = new System.DateTime(2024, 2, 18, 0, 0, 0, 0);
            this.FromDate.MinDate = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            this.FromDate.Name = "FromDate";
            this.FromDate.Value = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            this.FromDate.ValueChanged += new System.EventHandler(this.FromDate_ValueChanged);
            // 
            // settings
            // 
            resources.ApplyResources(this.settings, "settings");
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settings.Name = "settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // DayFormatComboBox
            // 
            resources.ApplyResources(this.DayFormatComboBox, "DayFormatComboBox");
            this.DayFormatComboBox.DisplayMember = "day, dd Month YYYY";
            this.DayFormatComboBox.FormattingEnabled = true;
            this.DayFormatComboBox.Items.AddRange(new object[] {
            resources.GetString("DayFormatComboBox.Items"),
            resources.GetString("DayFormatComboBox.Items1"),
            resources.GetString("DayFormatComboBox.Items2"),
            resources.GetString("DayFormatComboBox.Items3")});
            this.DayFormatComboBox.Name = "DayFormatComboBox";
            this.DayFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // StudentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DayFormatComboBox);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.saveAs_btn);
            this.Controls.Add(this.signOutBTN);
            this.Controls.Add(this.absentdays_label);
            this.Controls.Add(this.AbsentDays);
            this.Controls.Add(this.StudentAttendanceTable);
            this.Controls.Add(this.to_label);
            this.Controls.Add(this.showFrom_label);
            this.Controls.Add(this.class_label);
            this.Controls.Add(this.StudentClasstxt);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.StudentNametxt);
            this.Name = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentAttendanceTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label name_label;
        private Label class_label;
        private Label showFrom_label;
        private Label to_label;
        private Label absentdays_label;
        private Button signOutBTN;
        private Button saveAs_btn;
        private TextBox StudentNametxt;
        private TextBox StudentClasstxt;
        private TextBox AbsentDays;
        private DateTimePicker ToDate;
        private DateTimePicker FromDate;
        private DataGridView StudentAttendanceTable;

        // Setters And Getters
        public void setAbsentDays(int number) { AbsentDays.Text = number.ToString(); }
        //public void setTable() { StudentAttendanceTable. }
        public void setFromDate() { FromDate.Value = FromDate.MinDate; }
        // Populate the DataGridView with attendance data

        public void setAttendanceRecord(DateTime _date, string _status)
        {
            StudentAttendanceTable.Rows.Add(_date.ToString(DateFormat), _status);

        }
        public void resetAttendanceTable() {  StudentAttendanceTable.Rows.Clear();}

        private Button settings;
        private ComboBox DayFormatComboBox;
        private DataGridViewTextBoxColumn DATE;
        private DataGridViewTextBoxColumn STATUS;
        private Label label1;
    }
}