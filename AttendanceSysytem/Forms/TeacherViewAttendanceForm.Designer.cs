namespace AttendanceSysytem.Forms
{
    partial class TeacherViewAttendanceForm
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
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackCompoBox = new System.Windows.Forms.ComboBox();
            this.DateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(26, 186);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.RowHeadersWidth = 51;
            this.dataGridViewAttendance.RowTemplate.Height = 24;
            this.dataGridViewAttendance.Size = new System.Drawing.Size(777, 242);
            this.dataGridViewAttendance.TabIndex = 6;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(41, 23);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(200, 40);
            this.btnGoBack.TabIndex = 5;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Track Name: ";
            // 
            // TrackCompoBox
            // 
            this.TrackCompoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrackCompoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackCompoBox.FormattingEnabled = true;
            this.TrackCompoBox.Items.AddRange(new object[] {
            "PD",
            "OS",
            "AI"});
            this.TrackCompoBox.Location = new System.Drawing.Point(546, 35);
            this.TrackCompoBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrackCompoBox.Name = "TrackCompoBox";
            this.TrackCompoBox.Size = new System.Drawing.Size(200, 28);
            this.TrackCompoBox.TabIndex = 1;
            // 
            // DateComboBox
            // 
            this.DateComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateComboBox.FormattingEnabled = true;
            this.DateComboBox.ItemHeight = 20;
            this.DateComboBox.Items.AddRange(new object[] {
            ""});
            this.DateComboBox.Location = new System.Drawing.Point(546, 79);
            this.DateComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateComboBox.Name = "DateComboBox";
            this.DateComboBox.Size = new System.Drawing.Size(200, 28);
            this.DateComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date: ";
            // 
            // btnViewAttendance
            // 
            this.btnViewAttendance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAttendance.Location = new System.Drawing.Point(428, 130);
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.Size = new System.Drawing.Size(280, 40);
            this.btnViewAttendance.TabIndex = 4;
            this.btnViewAttendance.Text = "View Attendance";
            this.btnViewAttendance.UseVisualStyleBackColor = false;
            this.btnViewAttendance.Click += new System.EventHandler(this.btnViewAttendance_Click);
            // 
            // TeacherViewAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.btnViewAttendance);
            this.Controls.Add(this.DateComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrackCompoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.dataGridViewAttendance);
            this.Name = "TeacherViewAttendanceForm";
            this.Text = "TeacherView";
            this.Load += new System.EventHandler(this.TeacherViewAttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TrackCompoBox;
        private System.Windows.Forms.ComboBox DateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnViewAttendance;
    }
}