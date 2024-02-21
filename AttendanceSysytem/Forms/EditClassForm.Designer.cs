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
            this.go_back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.go_back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.go_back_btn.Location = new System.Drawing.Point(12, 11);
            this.go_back_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_back_btn.Name = "go_back_btn";
            this.go_back_btn.Size = new System.Drawing.Size(200, 40);
            this.go_back_btn.TabIndex = 0;
            this.go_back_btn.Text = "Go Back";
            this.go_back_btn.UseVisualStyleBackColor = false;
            // 
            // add_teachers_btn
            // 
            this.add_teachers_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_teachers_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_teachers_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.add_teachers_btn.Location = new System.Drawing.Point(195, 272);
            this.add_teachers_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_teachers_btn.Name = "add_teachers_btn";
            this.add_teachers_btn.Size = new System.Drawing.Size(371, 42);
            this.add_teachers_btn.TabIndex = 2;
            this.add_teachers_btn.Text = "Add Teachers";
            this.add_teachers_btn.UseVisualStyleBackColor = true;
            this.add_teachers_btn.Click += new System.EventHandler(this.add_teachers_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_btn.Location = new System.Drawing.Point(559, 526);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.MaximumSize = new System.Drawing.Size(150, 50);
            this.save_btn.MinimumSize = new System.Drawing.Size(150, 50);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(150, 50);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            // 
            // class_name_label
            // 
            this.class_name_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class_name_label.AutoSize = true;
            this.class_name_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_name_label.Location = new System.Drawing.Point(191, 171);
            this.class_name_label.Name = "class_name_label";
            this.class_name_label.Size = new System.Drawing.Size(114, 24);
            this.class_name_label.TabIndex = 6;
            this.class_name_label.Text = "Class Name";
            // 
            // supervisor_label
            // 
            this.supervisor_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supervisor_label.AutoSize = true;
            this.supervisor_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisor_label.Location = new System.Drawing.Point(191, 226);
            this.supervisor_label.Name = "supervisor_label";
            this.supervisor_label.Size = new System.Drawing.Size(103, 24);
            this.supervisor_label.TabIndex = 7;
            this.supervisor_label.Text = "Supervisor";
            // 
            // class_name_txt
            // 
            this.class_name_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class_name_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_name_txt.Location = new System.Drawing.Point(323, 168);
            this.class_name_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.class_name_txt.Name = "class_name_txt";
            this.class_name_txt.Size = new System.Drawing.Size(243, 32);
            this.class_name_txt.TabIndex = 8;
            // 
            // SupervisorComboBox
            // 
            this.SupervisorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SupervisorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupervisorComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupervisorComboBox.FormattingEnabled = true;
            this.SupervisorComboBox.Location = new System.Drawing.Point(323, 220);
            this.SupervisorComboBox.Name = "SupervisorComboBox";
            this.SupervisorComboBox.Size = new System.Drawing.Size(243, 32);
            this.SupervisorComboBox.TabIndex = 10;
            // 
            // add_students_btn
            // 
            this.add_students_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_students_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_students_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.add_students_btn.Location = new System.Drawing.Point(195, 335);
            this.add_students_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_students_btn.Name = "add_students_btn";
            this.add_students_btn.Size = new System.Drawing.Size(371, 42);
            this.add_students_btn.TabIndex = 15;
            this.add_students_btn.Text = "Add Students";
            this.add_students_btn.UseVisualStyleBackColor = true;
            // 
            // EditClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(746, 604);
            this.Controls.Add(this.add_students_btn);
            this.Controls.Add(this.SupervisorComboBox);
            this.Controls.Add(this.class_name_txt);
            this.Controls.Add(this.supervisor_label);
            this.Controls.Add(this.class_name_label);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.add_teachers_btn);
            this.Controls.Add(this.go_back_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditClassForm";
            this.Text = "Edit Class";
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
