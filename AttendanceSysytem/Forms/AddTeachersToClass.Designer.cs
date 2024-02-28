namespace AttendanceSysytem.Forms
{
    partial class AddTeachersToClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeachersToClass));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TeachersTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teachers_label = new System.Windows.Forms.Label();
            this.go_back_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TeachersTable
            // 
            this.TeachersTable.AllowUserToAddRows = false;
            this.TeachersTable.AllowUserToDeleteRows = false;
            this.TeachersTable.AllowUserToResizeColumns = false;
            this.TeachersTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.TeachersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.TeachersTable, "TeachersTable");
            this.TeachersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeachersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TeachersTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TeachersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeachersTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeachersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TeachersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TeacherName,
            this.Classes,
            this.checkCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeachersTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.TeachersTable.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TeachersTable.Name = "TeachersTable";
            this.TeachersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeachersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TeachersTable.RowHeadersVisible = false;
            this.TeachersTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TeachersTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TeachersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            // 
            // TeacherName
            // 
            this.TeacherName.FillWeight = 84.78261F;
            resources.ApplyResources(this.TeacherName, "TeacherName");
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Classes
            // 
            this.Classes.FillWeight = 84.78261F;
            resources.ApplyResources(this.Classes, "Classes");
            this.Classes.Name = "Classes";
            this.Classes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Classes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // checkCol
            // 
            this.checkCol.FillWeight = 60F;
            resources.ApplyResources(this.checkCol, "checkCol");
            this.checkCol.Name = "checkCol";
            this.checkCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // teachers_label
            // 
            resources.ApplyResources(this.teachers_label, "teachers_label");
            this.teachers_label.Name = "teachers_label";
            // 
            // go_back_btn
            // 
            this.go_back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.go_back_btn, "go_back_btn");
            this.go_back_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.go_back_btn.Name = "go_back_btn";
            this.go_back_btn.UseVisualStyleBackColor = false;
            this.go_back_btn.Click += new System.EventHandler(this.go_back_btn_Click);
            // 
            // Save_btn
            // 
            resources.ApplyResources(this.Save_btn, "Save_btn");
            this.Save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Save_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // AddTeachersToClass
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.go_back_btn);
            this.Controls.Add(this.TeachersTable);
            this.Controls.Add(this.teachers_label);
            this.Name = "AddTeachersToClass";
            this.Load += new System.EventHandler(this.AddTeachersToClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TeachersTable;
        private System.Windows.Forms.Label teachers_label;
        private System.Windows.Forms.Button go_back_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkCol;
        private System.Windows.Forms.Button Save_btn;
    }
}