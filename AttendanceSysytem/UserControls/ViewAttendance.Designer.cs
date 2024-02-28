namespace AttendanceSysytem.UserControls
{
    partial class ViewAttendance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.classes_label = new System.Windows.Forms.Label();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "PD",
            "OS",
            "AI"});
            this.classComboBox.Location = new System.Drawing.Point(529, 58);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(184, 24);
            this.classComboBox.TabIndex = 12;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // classes_label
            // 
            this.classes_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classes_label.AutoSize = true;
            this.classes_label.Enabled = false;
            this.classes_label.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.classes_label.ForeColor = System.Drawing.Color.Coral;
            this.classes_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.classes_label.Location = new System.Drawing.Point(386, 37);
            this.classes_label.Margin = new System.Windows.Forms.Padding(0);
            this.classes_label.MaximumSize = new System.Drawing.Size(1800, 100);
            this.classes_label.Name = "classes_label";
            this.classes_label.Size = new System.Drawing.Size(101, 46);
            this.classes_label.TabIndex = 13;
            this.classes_label.Text = "Class:";
            this.classes_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(73, 110);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.RowHeadersWidth = 51;
            this.dataGridViewAttendance.RowTemplate.Height = 24;
            this.dataGridViewAttendance.Size = new System.Drawing.Size(993, 482);
            this.dataGridViewAttendance.TabIndex = 14;
            // 
            // ViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewAttendance);
            this.Controls.Add(this.classes_label);
            this.Controls.Add(this.classComboBox);
            this.Name = "ViewAttendance";
            this.Size = new System.Drawing.Size(1133, 653);
            this.Load += new System.EventHandler(this.ViewAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label classes_label;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
    }
}
