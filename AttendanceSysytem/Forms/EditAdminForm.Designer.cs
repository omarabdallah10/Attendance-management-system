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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAdminForm));
            this.go_back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.students_btn = new System.Windows.Forms.Button();
            this.teachers_btn = new System.Windows.Forms.Button();
            this.classes_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // go_back_btn
            // 
            resources.ApplyResources(this.go_back_btn, "go_back_btn");
            this.go_back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.go_back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_back_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.go_back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.go_back_btn.Name = "go_back_btn";
            this.go_back_btn.UseVisualStyleBackColor = false;
            this.go_back_btn.Click += new System.EventHandler(this.go_back_btn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Who would you like to (edit \\ delete)?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // students_btn
            // 
            resources.ApplyResources(this.students_btn, "students_btn");
            this.students_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.students_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.students_btn.ForeColor = System.Drawing.Color.Black;
            this.students_btn.Name = "students_btn";
            this.students_btn.UseVisualStyleBackColor = false;
            this.students_btn.Click += new System.EventHandler(this.students_btn_Click);
            // 
            // teachers_btn
            // 
            resources.ApplyResources(this.teachers_btn, "teachers_btn");
            this.teachers_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.teachers_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teachers_btn.ForeColor = System.Drawing.Color.Black;
            this.teachers_btn.Name = "teachers_btn";
            this.teachers_btn.UseVisualStyleBackColor = false;
            this.teachers_btn.Click += new System.EventHandler(this.teachers_btn_Click);
            // 
            // classes_btn
            // 
            resources.ApplyResources(this.classes_btn, "classes_btn");
            this.classes_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.classes_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classes_btn.ForeColor = System.Drawing.Color.Black;
            this.classes_btn.Name = "classes_btn";
            this.classes_btn.UseVisualStyleBackColor = false;
            this.classes_btn.Click += new System.EventHandler(this.classes_btn_Click);
            // 
            // EditAdminForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.go_back_btn;
            this.Controls.Add(this.classes_btn);
            this.Controls.Add(this.teachers_btn);
            this.Controls.Add(this.students_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.go_back_btn);
            this.Name = "EditAdminForm";
            this.Load += new System.EventHandler(this.EditAdminForm_Load);
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
