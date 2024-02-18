using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AttendanceSysytem.Forms
{
        partial class ClassEditForm
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
            this.go_back_btn = new System.Windows.Forms.Button();
            this.add_teacher_btn = new System.Windows.Forms.Button();
            this.add_student_btn = new System.Windows.Forms.Button();
            this.add_class_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.class_name_label = new System.Windows.Forms.Label();
            this.supervisor_label = new System.Windows.Forms.Label();
            this.class_name_txt = new System.Windows.Forms.TextBox();
            this.supervisor_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // go_back_btn
            // 
            this.go_back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.go_back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_back_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.go_back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.go_back_btn.Location = new System.Drawing.Point(38, 30);
            this.go_back_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_back_btn.Name = "go_back_btn";
            this.go_back_btn.Size = new System.Drawing.Size(124, 42);
            this.go_back_btn.TabIndex = 0;
            this.go_back_btn.Text = "Go Back";
            this.go_back_btn.UseVisualStyleBackColor = false;
            // 
            // add_teacher_btn
            // 
            this.add_teacher_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_teacher_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.add_teacher_btn.Location = new System.Drawing.Point(95, 263);
            this.add_teacher_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_teacher_btn.Name = "add_teacher_btn";
            this.add_teacher_btn.Size = new System.Drawing.Size(143, 42);
            this.add_teacher_btn.TabIndex = 1;
            this.add_teacher_btn.Text = "Add Teacher";
            this.add_teacher_btn.UseVisualStyleBackColor = true;
            // 
            // add_student_btn
            // 
            this.add_student_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_student_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.add_student_btn.Location = new System.Drawing.Point(344, 263);
            this.add_student_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_student_btn.Name = "add_student_btn";
            this.add_student_btn.Size = new System.Drawing.Size(143, 42);
            this.add_student_btn.TabIndex = 2;
            this.add_student_btn.Text = "Add Student";
            this.add_student_btn.UseVisualStyleBackColor = true;
            // 
            // add_class_btn
            // 
            this.add_class_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_class_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.add_class_btn.Location = new System.Drawing.Point(580, 263);
            this.add_class_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_class_btn.Name = "add_class_btn";
            this.add_class_btn.Size = new System.Drawing.Size(143, 42);
            this.add_class_btn.TabIndex = 3;
            this.add_class_btn.Text = "Add Class";
            this.add_class_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_btn.Location = new System.Drawing.Point(604, 342);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(134, 41);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            // 
            // class_name_label
            // 
            this.class_name_label.AutoSize = true;
            this.class_name_label.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.class_name_label.Location = new System.Drawing.Point(89, 131);
            this.class_name_label.Name = "class_name_label";
            this.class_name_label.Size = new System.Drawing.Size(138, 32);
            this.class_name_label.TabIndex = 6;
            this.class_name_label.Text = "Class Name";
            // 
            // supervisor_label
            // 
            this.supervisor_label.AutoSize = true;
            this.supervisor_label.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.supervisor_label.Location = new System.Drawing.Point(89, 183);
            this.supervisor_label.Name = "supervisor_label";
            this.supervisor_label.Size = new System.Drawing.Size(126, 32);
            this.supervisor_label.TabIndex = 7;
            this.supervisor_label.Text = "Supervisor";
            // 
            // class_name_txt
            // 
            this.class_name_txt.Enabled = false;
            this.class_name_txt.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.class_name_txt.Location = new System.Drawing.Point(246, 128);
            this.class_name_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.class_name_txt.Name = "class_name_txt";
            this.class_name_txt.Size = new System.Drawing.Size(277, 39);
            this.class_name_txt.TabIndex = 8;
            // 
            // supervisor_txt
            // 
            this.supervisor_txt.Enabled = false;
            this.supervisor_txt.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.supervisor_txt.Location = new System.Drawing.Point(246, 180);
            this.supervisor_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supervisor_txt.Name = "supervisor_txt";
            this.supervisor_txt.Size = new System.Drawing.Size(277, 39);
            this.supervisor_txt.TabIndex = 9;
            // 
            // ClassEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 422);
            this.Controls.Add(this.supervisor_txt);
            this.Controls.Add(this.class_name_txt);
            this.Controls.Add(this.supervisor_label);
            this.Controls.Add(this.class_name_label);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.add_class_btn);
            this.Controls.Add(this.add_student_btn);
            this.Controls.Add(this.add_teacher_btn);
            this.Controls.Add(this.go_back_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClassEditForm";
            this.Text = "Edit Class";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private Button go_back_btn;
            private Button add_teacher_btn;
            private Button add_student_btn;
            private Button add_class_btn;
            private Button save_btn;
            private Label class_name_label;
            private Label supervisor_label;
            private TextBox class_name_txt;
            private TextBox supervisor_txt;
        }
    }
