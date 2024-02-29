namespace AttendanceSysytem.Forms
{
    partial class view_attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_attendance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.classCompoBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.StudentAttendanceTable = new System.Windows.Forms.DataGridView();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to_label = new System.Windows.Forms.Label();
            this.showFrom_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DayFormatComboBox = new System.Windows.Forms.ComboBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentAttendanceTable)).BeginInit();
            this.SuspendLayout();
            // 
            // classCompoBox
            // 
            this.classCompoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.classCompoBox, "classCompoBox");
            this.classCompoBox.FormattingEnabled = true;
            this.classCompoBox.Name = "classCompoBox";
            this.classCompoBox.SelectedIndexChanged += new System.EventHandler(this.classCompoBox_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
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
            // ToDate
            // 
            resources.ApplyResources(this.ToDate, "ToDate");
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.MinDate = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            this.ToDate.Name = "ToDate";
            this.ToDate.Value = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            this.ToDate.ValueChanged += new System.EventHandler(this.ToDate_ValueChanged);
            // 
            // StudentAttendanceTable
            // 
            this.StudentAttendanceTable.AllowUserToAddRows = false;
            this.StudentAttendanceTable.AllowUserToDeleteRows = false;
            this.StudentAttendanceTable.AllowUserToOrderColumns = true;
            this.StudentAttendanceTable.AllowUserToResizeColumns = false;
            this.StudentAttendanceTable.AllowUserToResizeRows = false;
            resources.ApplyResources(this.StudentAttendanceTable, "StudentAttendanceTable");
            this.StudentAttendanceTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentAttendanceTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentAttendanceTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentAttendanceTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentAttendanceTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentAttendanceTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentAttendanceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentAttendanceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATE,
            this.STATUS,
            this.UserID});
            this.StudentAttendanceTable.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StudentAttendanceTable.Name = "StudentAttendanceTable";
            this.StudentAttendanceTable.ReadOnly = true;
            this.StudentAttendanceTable.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StudentAttendanceTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
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
            // UserID
            // 
            resources.ApplyResources(this.UserID, "UserID");
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // to_label
            // 
            resources.ApplyResources(this.to_label, "to_label");
            this.to_label.Name = "to_label";
            // 
            // showFrom_label
            // 
            resources.ApplyResources(this.showFrom_label, "showFrom_label");
            this.showFrom_label.Name = "showFrom_label";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
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
            this.DayFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.DayFormatComboBox_SelectedIndexChanged);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnGoBack, "btnGoBack");
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // view_attendance
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DayFormatComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.StudentAttendanceTable);
            this.Controls.Add(this.to_label);
            this.Controls.Add(this.showFrom_label);
            this.Controls.Add(this.classCompoBox);
            this.Controls.Add(this.label1);
            this.Name = "view_attendance";
            this.Load += new System.EventHandler(this.view_attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentAttendanceTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classCompoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.DataGridView StudentAttendanceTable;
        private System.Windows.Forms.Label to_label;
        private System.Windows.Forms.Label showFrom_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DayFormatComboBox;
        private System.Windows.Forms.Button btnGoBack;
    }
}