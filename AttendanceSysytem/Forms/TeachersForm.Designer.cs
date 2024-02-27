using System.Drawing;
using System.Windows.Forms;

namespace AttendanceSysytem.Forms
{
    partial class TeachersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachersForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.go_back_btn = new System.Windows.Forms.Button();
            this.teachers_label = new System.Windows.Forms.Label();
            this.TeachersTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supervised_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // go_back_btn
            // 
            resources.ApplyResources(this.go_back_btn, "go_back_btn");
            this.go_back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.go_back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.go_back_btn.Name = "go_back_btn";
            this.go_back_btn.UseVisualStyleBackColor = false;
            this.go_back_btn.Click += new System.EventHandler(this.go_back_btn_Click);
            // 
            // teachers_label
            // 
            resources.ApplyResources(this.teachers_label, "teachers_label");
            this.teachers_label.Name = "teachers_label";
            // 
            // TeachersTable
            // 
            resources.ApplyResources(this.TeachersTable, "TeachersTable");
            this.TeachersTable.AllowUserToAddRows = false;
            this.TeachersTable.AllowUserToDeleteRows = false;
            this.TeachersTable.AllowUserToResizeColumns = false;
            this.TeachersTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.TeachersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.TeachersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeachersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TeachersTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TeachersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeachersTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeachersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.TeachersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TeacherName,
            this.Classes,
            this.Supervised_Class,
            this.dataGridViewButtonColumn1});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeachersTable.DefaultCellStyle = dataGridViewCellStyle13;
            this.TeachersTable.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TeachersTable.Name = "TeachersTable";
            this.TeachersTable.ReadOnly = true;
            this.TeachersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeachersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.TeachersTable.RowHeadersVisible = false;
            this.TeachersTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TeachersTable.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.TeachersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TeachersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeachersTable_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TeacherName
            // 
            this.TeacherName.FillWeight = 84.78261F;
            resources.ApplyResources(this.TeacherName, "TeacherName");
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            this.TeacherName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Classes
            // 
            this.Classes.FillWeight = 84.78261F;
            resources.ApplyResources(this.Classes, "Classes");
            this.Classes.Name = "Classes";
            this.Classes.ReadOnly = true;
            this.Classes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Classes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Supervised_Class
            // 
            resources.ApplyResources(this.Supervised_Class, "Supervised_Class");
            this.Supervised_Class.Name = "Supervised_Class";
            this.Supervised_Class.ReadOnly = true;
            this.Supervised_Class.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.FillWeight = 60F;
            resources.ApplyResources(this.dataGridViewButtonColumn1, "dataGridViewButtonColumn1");
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn1.Text = "Edit";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // TeachersForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeachersTable);
            this.Controls.Add(this.go_back_btn);
            this.Controls.Add(this.teachers_label);
            this.Name = "TeachersForm";
            this.Load += new System.EventHandler(this.TeachersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridViewTextBoxColumn NameColumn;
        private Button go_back_btn;
        private Label teachers_label;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn _Name;
        private DataGridViewTextBoxColumn Name1;
        private DataGridView TeachersTable;
        public void AddRow(string _UserID, string _Name, string _classes, string super_classes) { TeachersTable.Rows.Add(_UserID, _Name, _classes, super_classes); }

        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TeacherName;
        private DataGridViewTextBoxColumn Classes;
        private DataGridViewTextBoxColumn Supervised_Class;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}
