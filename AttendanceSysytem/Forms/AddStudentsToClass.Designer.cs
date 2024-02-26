namespace AttendanceSysytem.Forms
{
    partial class AddStudentsToClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Save_btn = new System.Windows.Forms.Button();
            this.go_back_btn = new System.Windows.Forms.Button();
            this.StudentsTable = new System.Windows.Forms.DataGridView();
            this.students_label = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Save_btn.Location = new System.Drawing.Point(724, 436);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(122, 35);
            this.Save_btn.TabIndex = 16;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // go_back_btn
            // 
            this.go_back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.go_back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_back_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.go_back_btn.Location = new System.Drawing.Point(12, 12);
            this.go_back_btn.Name = "go_back_btn";
            this.go_back_btn.Size = new System.Drawing.Size(122, 35);
            this.go_back_btn.TabIndex = 15;
            this.go_back_btn.Text = "Go Back";
            this.go_back_btn.UseVisualStyleBackColor = false;
            this.go_back_btn.Click += new System.EventHandler(this.go_back_btn_Click);
            // 
            // StudentsTable
            // 
            this.StudentsTable.AllowUserToAddRows = false;
            this.StudentsTable.AllowUserToDeleteRows = false;
            this.StudentsTable.AllowUserToResizeColumns = false;
            this.StudentsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.StudentsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.StudentsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TeacherName,
            this.InClass,
            this.checkCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.StudentsTable.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.StudentsTable.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.StudentsTable.Location = new System.Drawing.Point(27, 97);
            this.StudentsTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentsTable.Name = "StudentsTable";
            this.StudentsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StudentsTable.RowHeadersVisible = false;
            this.StudentsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.StudentsTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StudentsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StudentsTable.Size = new System.Drawing.Size(803, 319);
            this.StudentsTable.TabIndex = 14;
            // 
            // students_label
            // 
            this.students_label.AutoSize = true;
            this.students_label.Enabled = false;
            this.students_label.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.students_label.Location = new System.Drawing.Point(327, 49);
            this.students_label.Name = "students_label";
            this.students_label.Size = new System.Drawing.Size(151, 46);
            this.students_label.TabIndex = 13;
            this.students_label.Text = "Students";
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // TeacherName
            // 
            this.TeacherName.FillWeight = 84.78261F;
            this.TeacherName.HeaderText = "Name";
            this.TeacherName.MinimumWidth = 6;
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // InClass
            // 
            this.InClass.HeaderText = "In Class";
            this.InClass.MinimumWidth = 6;
            this.InClass.Name = "InClass";
            this.InClass.ReadOnly = true;
            // 
            // checkCol
            // 
            this.checkCol.FillWeight = 60F;
            this.checkCol.HeaderText = "Add";
            this.checkCol.MinimumWidth = 6;
            this.checkCol.Name = "checkCol";
            this.checkCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AddStudentsToClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 483);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.go_back_btn);
            this.Controls.Add(this.StudentsTable);
            this.Controls.Add(this.students_label);
            this.Name = "AddStudentsToClass";
            this.Text = "AddStudentsToClass";
            this.Load += new System.EventHandler(this.AddStudentsToClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button go_back_btn;
        private System.Windows.Forms.DataGridView StudentsTable;
        private System.Windows.Forms.Label students_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InClass;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkCol;
    }
}