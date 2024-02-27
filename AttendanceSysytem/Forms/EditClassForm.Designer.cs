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
            this.go_back_btn = new System.Windows.Forms.Button();
            this.add_teachers_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.class_name_label = new System.Windows.Forms.Label();
            this.supervisor_label = new System.Windows.Forms.Label();
            this.class_name_txt = new System.Windows.Forms.TextBox();
            this.SupervisorComboBox = new System.Windows.Forms.ComboBox();
            this.add_students_btn = new System.Windows.Forms.Button();
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
            // add_teachers_btn
            // 
            resources.ApplyResources(this.add_teachers_btn, "add_teachers_btn");
            this.add_teachers_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_teachers_btn.Name = "add_teachers_btn";
            this.add_teachers_btn.UseVisualStyleBackColor = true;
            this.add_teachers_btn.Click += new System.EventHandler(this.add_teachers_btn_Click);
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
            // add_students_btn
            // 
            resources.ApplyResources(this.add_students_btn, "add_students_btn");
            this.add_students_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_students_btn.Name = "add_students_btn";
            this.add_students_btn.UseVisualStyleBackColor = true;
            this.add_students_btn.Click += new System.EventHandler(this.add_students_btn_Click);
            // 
            // EditClassForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.go_back_btn;
            this.Controls.Add(this.add_students_btn);
            this.Controls.Add(this.SupervisorComboBox);
            this.Controls.Add(this.class_name_txt);
            this.Controls.Add(this.supervisor_label);
            this.Controls.Add(this.class_name_label);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.add_teachers_btn);
            this.Controls.Add(this.go_back_btn);
            this.Name = "EditClassForm";
            this.Load += new System.EventHandler(this.EditClassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private Button go_back_btn;
            private Button add_teachers_btn;
            private Button save_btn;
            private Label class_name_label;
            private Label supervisor_label;
            private TextBox class_name_txt;
        private ComboBox SupervisorComboBox;
        private Button add_students_btn;
    }
    }
