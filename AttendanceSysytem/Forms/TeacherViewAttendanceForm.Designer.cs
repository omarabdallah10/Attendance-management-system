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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherViewAttendanceForm));
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackCompoBox = new System.Windows.Forms.ComboBox();
            this.DateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAttendance
            // 
            resources.ApplyResources(this.dataGridViewAttendance, "dataGridViewAttendance");
            this.dataGridViewAttendance.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.RowTemplate.Height = 24;
            // 
            // btnGoBack
            // 
            resources.ApplyResources(this.btnGoBack, "btnGoBack");
            this.btnGoBack.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
            // 
            // TrackCompoBox
            // 
            resources.ApplyResources(this.TrackCompoBox, "TrackCompoBox");
            this.TrackCompoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrackCompoBox.FormattingEnabled = true;
            this.TrackCompoBox.Items.AddRange(new object[] {
            resources.GetString("TrackCompoBox.Items"),
            resources.GetString("TrackCompoBox.Items1"),
            resources.GetString("TrackCompoBox.Items2")});
            this.TrackCompoBox.Name = "TrackCompoBox";
            // 
            // DateComboBox
            // 
            resources.ApplyResources(this.DateComboBox, "DateComboBox");
            this.DateComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateComboBox.FormattingEnabled = true;
            this.DateComboBox.Items.AddRange(new object[] {
            resources.GetString("DateComboBox.Items")});
            this.DateComboBox.Name = "DateComboBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Name = "label2";
            // 
            // btnViewAttendance
            // 
            resources.ApplyResources(this.btnViewAttendance, "btnViewAttendance");
            this.btnViewAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAttendance.ForeColor = System.Drawing.Color.White;
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.UseVisualStyleBackColor = false;
            this.btnViewAttendance.Click += new System.EventHandler(this.btnViewAttendance_Click);
            // 
            // btnSaveAs
            // 
            resources.ApplyResources(this.btnSaveAs, "btnSaveAs");
            this.btnSaveAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAs.ForeColor = System.Drawing.Color.White;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // TeacherViewAttendanceForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnViewAttendance);
            this.Controls.Add(this.DateComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrackCompoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.dataGridViewAttendance);
            this.Name = "TeacherViewAttendanceForm";
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
        private System.Windows.Forms.Button btnSaveAs;
    }
}