using AttendanceSysytem.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace AttendanceSysytem.Forms
{
    partial class StudentForm
    {
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
            this.StudentNametxt = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.class_label = new System.Windows.Forms.Label();
            this.StudentClasstxt = new System.Windows.Forms.TextBox();
            this.showFrom_label = new System.Windows.Forms.Label();
            this.to_label = new System.Windows.Forms.Label();
            this.StudentAttendanceTable = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absentdays_label = new System.Windows.Forms.Label();
            this.AbsentDays = new System.Windows.Forms.TextBox();
            this.signOutBTN = new System.Windows.Forms.Button();
            this.saveAs_btn = new System.Windows.Forms.Button();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.StudentAttendanceTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentNametxt
            // 
            this.StudentNametxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StudentNametxt.Enabled = false;
            this.StudentNametxt.Location = new System.Drawing.Point(169, 31);
            this.StudentNametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentNametxt.Name = "StudentNametxt";
            this.StudentNametxt.ReadOnly = true;
            this.StudentNametxt.Size = new System.Drawing.Size(187, 22);
            this.StudentNametxt.TabIndex = 0;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(57, 31);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(44, 16);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name";
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Location = new System.Drawing.Point(57, 67);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(41, 16);
            this.class_label.TabIndex = 3;
            this.class_label.Text = "Class";
            // 
            // StudentClasstxt
            // 
            this.StudentClasstxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StudentClasstxt.Enabled = false;
            this.StudentClasstxt.Location = new System.Drawing.Point(169, 67);
            this.StudentClasstxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentClasstxt.Name = "StudentClasstxt";
            this.StudentClasstxt.ReadOnly = true;
            this.StudentClasstxt.Size = new System.Drawing.Size(187, 22);
            this.StudentClasstxt.TabIndex = 2;
            // 
            // showFrom_label
            // 
            this.showFrom_label.AutoSize = true;
            this.showFrom_label.Location = new System.Drawing.Point(57, 110);
            this.showFrom_label.Name = "showFrom_label";
            this.showFrom_label.Size = new System.Drawing.Size(74, 16);
            this.showFrom_label.TabIndex = 4;
            this.showFrom_label.Text = "Show From";
            // 
            // to_label
            // 
            this.to_label.AutoSize = true;
            this.to_label.Location = new System.Drawing.Point(372, 113);
            this.to_label.Name = "to_label";
            this.to_label.Size = new System.Drawing.Size(24, 16);
            this.to_label.TabIndex = 5;
            this.to_label.Text = "To";
            // 
            // StudentAttendanceTable
            // 
            this.StudentAttendanceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentAttendanceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.DATE,
            this.STATUS});
            this.StudentAttendanceTable.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StudentAttendanceTable.Location = new System.Drawing.Point(60, 184);
            this.StudentAttendanceTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentAttendanceTable.Name = "StudentAttendanceTable";
            this.StudentAttendanceTable.ReadOnly = true;
            this.StudentAttendanceTable.RowHeadersWidth = 51;
            this.StudentAttendanceTable.Size = new System.Drawing.Size(582, 150);
            this.StudentAttendanceTable.TabIndex = 10;
            this.StudentAttendanceTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentAttendanceTable_CellContentClick);
            // 
            // Day
            // 
            this.Day.HeaderText = "DAY";
            this.Day.MinimumWidth = 6;
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Width = 125;
            // 
            // DATE
            // 
            this.DATE.HeaderText = "DATE";
            this.DATE.MinimumWidth = 6;
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            this.DATE.Width = 125;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.MinimumWidth = 6;
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 125;
            // 
            // absentdays_label
            // 
            this.absentdays_label.AutoSize = true;
            this.absentdays_label.Location = new System.Drawing.Point(674, 110);
            this.absentdays_label.Name = "absentdays_label";
            this.absentdays_label.Size = new System.Drawing.Size(84, 16);
            this.absentdays_label.TabIndex = 12;
            this.absentdays_label.Text = "Absent Days";
            // 
            // AbsentDays
            // 
            this.AbsentDays.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AbsentDays.Enabled = false;
            this.AbsentDays.Location = new System.Drawing.Point(765, 107);
            this.AbsentDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AbsentDays.Name = "AbsentDays";
            this.AbsentDays.ReadOnly = true;
            this.AbsentDays.Size = new System.Drawing.Size(44, 22);
            this.AbsentDays.TabIndex = 11;
            // 
            // signOutBTN
            // 
            this.signOutBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signOutBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.signOutBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signOutBTN.Location = new System.Drawing.Point(765, 398);
            this.signOutBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signOutBTN.Name = "signOutBTN";
            this.signOutBTN.Size = new System.Drawing.Size(112, 42);
            this.signOutBTN.TabIndex = 13;
            this.signOutBTN.Text = "Sign out";
            this.signOutBTN.UseVisualStyleBackColor = false;
            // 
            // saveAs_btn
            // 
            this.saveAs_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveAs_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveAs_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveAs_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveAs_btn.Location = new System.Drawing.Point(629, 398);
            this.saveAs_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveAs_btn.Name = "saveAs_btn";
            this.saveAs_btn.Size = new System.Drawing.Size(124, 42);
            this.saveAs_btn.TabIndex = 14;
            this.saveAs_btn.Text = "Save As";
            this.saveAs_btn.UseVisualStyleBackColor = false;
            // 
            // ToDate
            // 
            this.ToDate.CustomFormat = "dd/MM/yyyy";
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(402, 108);
            this.ToDate.MinDate = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(200, 22);
            this.ToDate.TabIndex = 15;
            this.ToDate.Value = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            this.ToDate.ValueChanged += new System.EventHandler(this.ToDate_ValueChanged);
            // 
            // FromDate
            // 
            this.FromDate.CustomFormat = "dd/MM/yyyy";
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(169, 108);
            this.FromDate.MaxDate = new System.DateTime(2024, 2, 18, 0, 0, 0, 0);
            this.FromDate.MinDate = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(200, 22);
            this.FromDate.TabIndex = 16;
            this.FromDate.Value = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            this.FromDate.ValueChanged += new System.EventHandler(this.FromDate_ValueChanged);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 499);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentForm";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentAttendanceTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox StudentNametxt;
        private Label name_label;
        private Label class_label;
        private TextBox StudentClasstxt;
        private Label showFrom_label;
        private Label to_label;
        private DataGridView StudentAttendanceTable;
        private Label absentdays_label;
        private TextBox AbsentDays;
        private Button signOutBTN;
        private Button saveAs_btn;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn DATE;
        private DataGridViewTextBoxColumn STATUS;
        private DateTimePicker ToDate;
        private DateTimePicker FromDate;
    }
}