using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AttendanceSysytem.Forms
{
    partial class EditClassForm
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClassForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.go_back_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.class_name_label = new System.Windows.Forms.Label();
            this.supervisor_label = new System.Windows.Forms.Label();
            this.class_name_txt = new System.Windows.Forms.TextBox();
            this.SupervisorComboBox = new System.Windows.Forms.ComboBox();
            this.StudentsTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.students_label = new System.Windows.Forms.Label();
            this.TeachersTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teachers_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // go_back_btn
            // 
            this.go_back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.go_back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_back_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.go_back_btn, "go_back_btn");
            this.go_back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.go_back_btn.Name = "go_back_btn";
            this.go_back_btn.UseVisualStyleBackColor = false;
            // 
            // save_btn
            // 
            resources.ApplyResources(this.save_btn, "save_btn");
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_btn.Name = "save_btn";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // class_name_label
            // 
            resources.ApplyResources(this.class_name_label, "class_name_label");
            this.class_name_label.Name = "class_name_label";
            // 
            // supervisor_label
            // 
            resources.ApplyResources(this.supervisor_label, "supervisor_label");
            this.supervisor_label.Name = "supervisor_label";
            // 
            // class_name_txt
            // 
            resources.ApplyResources(this.class_name_txt, "class_name_txt");
            this.class_name_txt.Name = "class_name_txt";
            // 
            // SupervisorComboBox
            // 
            resources.ApplyResources(this.SupervisorComboBox, "SupervisorComboBox");
            this.SupervisorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupervisorComboBox.FormattingEnabled = true;
            this.SupervisorComboBox.Name = "SupervisorComboBox";
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
            resources.ApplyResources(this.StudentsTable, "StudentsTable");
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
            // InClass
            // 
            resources.ApplyResources(this.InClass, "InClass");
            this.InClass.Name = "InClass";
            this.InClass.ReadOnly = true;
            // 
            // checkCol
            // 
            this.checkCol.FillWeight = 60F;
            resources.ApplyResources(this.checkCol, "checkCol");
            this.checkCol.Name = "checkCol";
            this.checkCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // students_label
            // 
            resources.ApplyResources(this.students_label, "students_label");
            this.students_label.Name = "students_label";
            // 
            // TeachersTable
            // 
            this.TeachersTable.AllowUserToAddRows = false;
            this.TeachersTable.AllowUserToDeleteRows = false;
            this.TeachersTable.AllowUserToResizeColumns = false;
            this.TeachersTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.TeachersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.TeachersTable, "TeachersTable");
            this.TeachersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeachersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TeachersTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TeachersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeachersTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeachersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TeachersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Classes,
            this.dataGridViewCheckBoxColumn1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeachersTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.TeachersTable.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TeachersTable.Name = "TeachersTable";
            this.TeachersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeachersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.TeachersTable.RowHeadersVisible = false;
            this.TeachersTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TeachersTable.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.TeachersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 84.78261F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Classes
            // 
            this.Classes.FillWeight = 84.78261F;
            resources.ApplyResources(this.Classes, "Classes");
            this.Classes.Name = "Classes";
            this.Classes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Classes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FillWeight = 60F;
            resources.ApplyResources(this.dataGridViewCheckBoxColumn1, "dataGridViewCheckBoxColumn1");
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // teachers_label
            // 
            resources.ApplyResources(this.teachers_label, "teachers_label");
            this.teachers_label.Name = "teachers_label";
            // 
            // EditClassForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.go_back_btn;
            this.Controls.Add(this.TeachersTable);
            this.Controls.Add(this.teachers_label);
            this.Controls.Add(this.StudentsTable);
            this.Controls.Add(this.students_label);
            this.Controls.Add(this.SupervisorComboBox);
            this.Controls.Add(this.class_name_txt);
            this.Controls.Add(this.supervisor_label);
            this.Controls.Add(this.class_name_label);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.go_back_btn);
            this.Name = "EditClassForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditClassForm_FormClosed);
            this.Load += new System.EventHandler(this.EditClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button go_back_btn;
        private Button save_btn;
        private Label class_name_label;
        private Label supervisor_label;
        private TextBox class_name_txt;
        private ComboBox SupervisorComboBox;
        private DataGridView StudentsTable;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TeacherName;
        private DataGridViewTextBoxColumn InClass;
        private DataGridViewCheckBoxColumn checkCol;
        private Label students_label;
        private DataGridView TeachersTable;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Classes;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Label teachers_label;
    }
}
