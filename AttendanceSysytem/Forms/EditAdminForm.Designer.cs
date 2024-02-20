using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AttendanceSysytem.Forms
{
        partial class EditAdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.students_btn = new System.Windows.Forms.Button();
            this.teachers_btn = new System.Windows.Forms.Button();
            this.classes_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // go_back_btn
            // 
            this.go_back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.go_back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.go_back_btn.Location = new System.Drawing.Point(12, 10);
            this.go_back_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_back_btn.Name = "go_back_btn";
            this.go_back_btn.Size = new System.Drawing.Size(200, 40);
            this.go_back_btn.TabIndex = 0;
            this.go_back_btn.Text = "Go back";
            this.go_back_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Who would you like to (edit \\ delete)?";
            // 
            // students_btn
            // 
            this.students_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.students_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.students_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.students_btn.ForeColor = System.Drawing.Color.Black;
            this.students_btn.Location = new System.Drawing.Point(271, 241);
            this.students_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.students_btn.Name = "students_btn";
            this.students_btn.Size = new System.Drawing.Size(245, 45);
            this.students_btn.TabIndex = 2;
            this.students_btn.Text = "Students";
            this.students_btn.UseVisualStyleBackColor = false;
            this.students_btn.Click += new System.EventHandler(this.students_btn_Click);
            // 
            // teachers_btn
            // 
            this.teachers_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.teachers_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teachers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachers_btn.ForeColor = System.Drawing.Color.Black;
            this.teachers_btn.Location = new System.Drawing.Point(271, 290);
            this.teachers_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teachers_btn.Name = "teachers_btn";
            this.teachers_btn.Size = new System.Drawing.Size(245, 45);
            this.teachers_btn.TabIndex = 3;
            this.teachers_btn.Text = "Teachers";
            this.teachers_btn.UseVisualStyleBackColor = false;
            this.teachers_btn.Click += new System.EventHandler(this.teachers_btn_Click);
            // 
            // classes_btn
            // 
            this.classes_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.classes_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classes_btn.ForeColor = System.Drawing.Color.Black;
            this.classes_btn.Location = new System.Drawing.Point(271, 339);
            this.classes_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classes_btn.Name = "classes_btn";
            this.classes_btn.Size = new System.Drawing.Size(245, 45);
            this.classes_btn.TabIndex = 4;
            this.classes_btn.Text = "Classes";
            this.classes_btn.UseVisualStyleBackColor = false;
            // 
            // EditAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.classes_btn);
            this.Controls.Add(this.teachers_btn);
            this.Controls.Add(this.students_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.go_back_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditAdminForm";
            this.Text = "Admin Edit View";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private Button go_back_btn;
            private Label label1;
            private Button students_btn;
            private Button teachers_btn;
            private Button classes_btn;
        }
    }
