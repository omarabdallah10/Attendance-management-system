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
            this.DateComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
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
            this.classComboBox.Location = new System.Drawing.Point(230, 57);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(200, 24);
            this.classComboBox.TabIndex = 12;
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
            this.classes_label.Location = new System.Drawing.Point(87, 36);
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
            this.dataGridViewAttendance.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(73, 188);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.RowHeadersWidth = 51;
            this.dataGridViewAttendance.RowTemplate.Height = 24;
            this.dataGridViewAttendance.Size = new System.Drawing.Size(1080, 471);
            this.dataGridViewAttendance.TabIndex = 14;
            // 
            // DateComboBox
            // 
            this.DateComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DateComboBox.FormattingEnabled = true;
            this.DateComboBox.ItemHeight = 20;
            this.DateComboBox.Items.AddRange(new object[] {
            ""});
            this.DateComboBox.Location = new System.Drawing.Point(743, 57);
            this.DateComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateComboBox.Name = "DateComboBox";
            this.DateComboBox.Size = new System.Drawing.Size(200, 28);
            this.DateComboBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(600, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MaximumSize = new System.Drawing.Size(1800, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewAttendance
            // 
            this.btnViewAttendance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewAttendance.ForeColor = System.Drawing.Color.White;
            this.btnViewAttendance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnViewAttendance.Location = new System.Drawing.Point(230, 123);
            this.btnViewAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.Size = new System.Drawing.Size(234, 46);
            this.btnViewAttendance.TabIndex = 45;
            this.btnViewAttendance.Text = "View Attendance";
            this.btnViewAttendance.UseVisualStyleBackColor = false;
            this.btnViewAttendance.Click += new System.EventHandler(this.btnViewAttendance_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveAs.ForeColor = System.Drawing.Color.White;
            this.btnSaveAs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveAs.Location = new System.Drawing.Point(590, 123);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(234, 46);
            this.btnSaveAs.TabIndex = 46;
            this.btnSaveAs.Text = "Save AS";
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // ViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnViewAttendance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateComboBox);
            this.Controls.Add(this.dataGridViewAttendance);
            this.Controls.Add(this.classes_label);
            this.Controls.Add(this.classComboBox);
            this.Name = "ViewAttendance";
            this.Size = new System.Drawing.Size(1314, 766);
            this.Load += new System.EventHandler(this.ViewAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label classes_label;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.ComboBox DateComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAttendance;
        private System.Windows.Forms.Button btnSaveAs;
    }
}
