using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AttendanceSysytem.Forms
{
        partial class ClassesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.classes_label = new System.Windows.Forms.Label();
            this.go_back_btn = new System.Windows.Forms.Button();
            this.ClassesTable = new System.Windows.Forms.DataGridView();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuperVisorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClassesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // classes_label
            // 
            this.classes_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classes_label.AutoSize = true;
            this.classes_label.Enabled = false;
            this.classes_label.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.classes_label.Location = new System.Drawing.Point(342, 95);
            this.classes_label.Margin = new System.Windows.Forms.Padding(0);
            this.classes_label.MaximumSize = new System.Drawing.Size(1800, 100);
            this.classes_label.Name = "classes_label";
            this.classes_label.Size = new System.Drawing.Size(126, 46);
            this.classes_label.TabIndex = 0;
            this.classes_label.Text = "Classes";
            this.classes_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // go_back_btn
            // 
            this.go_back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.go_back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_back_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.go_back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.go_back_btn.Location = new System.Drawing.Point(12, 10);
            this.go_back_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_back_btn.Name = "go_back_btn";
            this.go_back_btn.Size = new System.Drawing.Size(134, 42);
            this.go_back_btn.TabIndex = 2;
            this.go_back_btn.Text = "Go Back";
            this.go_back_btn.UseVisualStyleBackColor = false;
            // 
            // ClassesTable
            // 
            this.ClassesTable.AllowUserToAddRows = false;
            this.ClassesTable.AllowUserToDeleteRows = false;
            this.ClassesTable.AllowUserToResizeColumns = false;
            this.ClassesTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ClassesTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClassesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ClassesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ClassesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassesTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClassesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassName,
            this.SuperVisorID,
            this.Supervisor,
            this.Edit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassesTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClassesTable.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClassesTable.Location = new System.Drawing.Point(111, 157);
            this.ClassesTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTable.Name = "ClassesTable";
            this.ClassesTable.ReadOnly = true;
            this.ClassesTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClassesTable.RowHeadersVisible = false;
            this.ClassesTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassesTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ClassesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ClassesTable.Size = new System.Drawing.Size(590, 268);
            this.ClassesTable.TabIndex = 8;
            this.ClassesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsTable_CellContentClick);
            // 
            // ClassName
            // 
            this.ClassName.FillWeight = 84.78261F;
            this.ClassName.HeaderText = "Name";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SuperVisorID
            // 
            this.SuperVisorID.FillWeight = 84.78261F;
            this.SuperVisorID.HeaderText = "SuperVisorID";
            this.SuperVisorID.MinimumWidth = 6;
            this.SuperVisorID.Name = "SuperVisorID";
            this.SuperVisorID.ReadOnly = true;
            this.SuperVisorID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SuperVisorID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Supervisor
            // 
            this.Supervisor.HeaderText = "Supervisor";
            this.Supervisor.MinimumWidth = 6;
            this.Supervisor.Name = "Supervisor";
            this.Supervisor.ReadOnly = true;
            this.Supervisor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 60F;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // ClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.ClassesTable);
            this.Controls.Add(this.go_back_btn);
            this.Controls.Add(this.classes_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClassesForm";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.ClassesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private Label classes_label;
            private Button go_back_btn;
        private DataGridView ClassesTable;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn SuperVisorID;
        private DataGridViewTextBoxColumn Supervisor;
        private DataGridViewButtonColumn Edit;
    }
    }
