using System.Drawing;
using System.Windows.Forms;

namespace AttendanceSysytem.Forms
{
    partial class EditTeacherForm
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.delete_teacher_btn = new System.Windows.Forms.Button();
            this.password_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.class_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.edit_teacher_label = new System.Windows.Forms.Label();
            this.classes_list = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cancel_btn.Location = new System.Drawing.Point(693, 408);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(104, 41);
            this.cancel_btn.TabIndex = 23;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.save_btn.Location = new System.Drawing.Point(557, 408);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(104, 41);
            this.save_btn.TabIndex = 22;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // delete_teacher_btn
            // 
            this.delete_teacher_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delete_teacher_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_teacher_btn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.delete_teacher_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_teacher_btn.Location = new System.Drawing.Point(42, 408);
            this.delete_teacher_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_teacher_btn.Name = "delete_teacher_btn";
            this.delete_teacher_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.delete_teacher_btn.Size = new System.Drawing.Size(231, 40);
            this.delete_teacher_btn.TabIndex = 21;
            this.delete_teacher_btn.Text = "Delete Teacher";
            this.delete_teacher_btn.UseVisualStyleBackColor = false;
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.password_box.Location = new System.Drawing.Point(243, 222);
            this.password_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(335, 39);
            this.password_box.TabIndex = 19;
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.email_box.Location = new System.Drawing.Point(243, 179);
            this.email_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(335, 39);
            this.email_box.TabIndex = 18;
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.name_box.Location = new System.Drawing.Point(243, 136);
            this.name_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(335, 39);
            this.name_box.TabIndex = 17;
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Enabled = false;
            this.class_label.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.class_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.class_label.Location = new System.Drawing.Point(100, 267);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(90, 32);
            this.class_label.TabIndex = 16;
            this.class_label.Text = "Classes";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Enabled = false;
            this.password_label.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.password_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password_label.Location = new System.Drawing.Point(100, 224);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(111, 32);
            this.password_label.TabIndex = 15;
            this.password_label.Text = "Password";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Enabled = false;
            this.email_label.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.email_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email_label.Location = new System.Drawing.Point(100, 181);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(81, 32);
            this.email_label.TabIndex = 14;
            this.email_label.Text = "E-mail";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Enabled = false;
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.name_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_label.Location = new System.Drawing.Point(100, 138);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(78, 32);
            this.name_label.TabIndex = 13;
            this.name_label.Text = "Name";
            // 
            // edit_teacher_label
            // 
            this.edit_teacher_label.AutoSize = true;
            this.edit_teacher_label.Enabled = false;
            this.edit_teacher_label.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.edit_teacher_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edit_teacher_label.Location = new System.Drawing.Point(329, 38);
            this.edit_teacher_label.Name = "edit_teacher_label";
            this.edit_teacher_label.Size = new System.Drawing.Size(201, 46);
            this.edit_teacher_label.TabIndex = 12;
            this.edit_teacher_label.Text = "Edit Teacher";
            // 
            // classes_list
            // 
            this.classes_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.classes_list.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.classes_list.FormattingEnabled = true;
            this.classes_list.Location = new System.Drawing.Point(243, 265);
            this.classes_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classes_list.Name = "classes_list";
            this.classes_list.Size = new System.Drawing.Size(335, 40);
            this.classes_list.TabIndex = 24;
            // 
            // EditTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.classes_list);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.delete_teacher_btn);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.class_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.edit_teacher_label);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditTeacherForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancel_btn;
        private Button save_btn;
        private Button delete_teacher_btn;
        private TextBox password_box;
        private TextBox email_box;
        private TextBox name_box;
        private Label class_label;
        private Label password_label;
        private Label email_label;
        private Label name_label;
        private Label edit_teacher_label;
        private ComboBox classes_list;
    }
}
