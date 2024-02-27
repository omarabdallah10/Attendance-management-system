using System.Drawing;
using System.Windows.Forms;

namespace AttendanceSysytem.Forms
{
    partial class EditStudentForm
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
            this.edit_student_label = new System.Windows.Forms.Label();
            this.delete_student_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.classes_list = new System.Windows.Forms.ComboBox();
            this.LName = new System.Windows.Forms.Label();
            this.LnameTxt = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.FnameTxt = new System.Windows.Forms.TextBox();
            this.class_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // edit_student_label
            // 
            this.edit_student_label.AutoSize = true;
            this.edit_student_label.Enabled = false;
            this.edit_student_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_student_label.Location = new System.Drawing.Point(372, 53);
            this.edit_student_label.Name = "edit_student_label";
            this.edit_student_label.Size = new System.Drawing.Size(130, 25);
            this.edit_student_label.TabIndex = 0;
            this.edit_student_label.Text = "Edit Student";
            // 
            // delete_student_btn
            // 
            this.delete_student_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delete_student_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_student_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_student_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_student_btn.Location = new System.Drawing.Point(41, 452);
            this.delete_student_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_student_btn.Name = "delete_student_btn";
            this.delete_student_btn.Size = new System.Drawing.Size(200, 40);
            this.delete_student_btn.TabIndex = 9;
            this.delete_student_btn.Text = "Delete Student";
            this.delete_student_btn.UseVisualStyleBackColor = false;
            this.delete_student_btn.Click += new System.EventHandler(this.delete_student_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(447, 452);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(200, 40);
            this.save_btn.TabIndex = 10;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(714, 452);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(200, 40);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // classes_list
            // 
            this.classes_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classes_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classes_list.FormattingEnabled = true;
            this.classes_list.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.classes_list.Location = new System.Drawing.Point(312, 361);
            this.classes_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classes_list.Name = "classes_list";
            this.classes_list.Size = new System.Drawing.Size(335, 33);
            this.classes_list.TabIndex = 25;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Enabled = false;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LName.Location = new System.Drawing.Point(169, 197);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(115, 25);
            this.LName.TabIndex = 35;
            this.LName.Text = "Last Name";
            // 
            // LnameTxt
            // 
            this.LnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameTxt.Location = new System.Drawing.Point(312, 192);
            this.LnameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LnameTxt.Name = "LnameTxt";
            this.LnameTxt.Size = new System.Drawing.Size(335, 30);
            this.LnameTxt.TabIndex = 34;
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box.Location = new System.Drawing.Point(312, 301);
            this.password_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(335, 30);
            this.password_box.TabIndex = 33;
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.Location = new System.Drawing.Point(312, 242);
            this.email_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(335, 30);
            this.email_box.TabIndex = 32;
            // 
            // FnameTxt
            // 
            this.FnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameTxt.Location = new System.Drawing.Point(312, 139);
            this.FnameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FnameTxt.Name = "FnameTxt";
            this.FnameTxt.Size = new System.Drawing.Size(335, 30);
            this.FnameTxt.TabIndex = 31;
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Enabled = false;
            this.class_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.class_label.Location = new System.Drawing.Point(169, 366);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(90, 25);
            this.class_label.TabIndex = 30;
            this.class_label.Text = "Classes";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Enabled = false;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password_label.Location = new System.Drawing.Point(169, 304);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(106, 25);
            this.password_label.TabIndex = 29;
            this.password_label.Text = "Password";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Enabled = false;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email_label.Location = new System.Drawing.Point(169, 245);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(73, 25);
            this.email_label.TabIndex = 28;
            this.email_label.Text = "E-mail";
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Enabled = false;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fname.Location = new System.Drawing.Point(169, 144);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(116, 25);
            this.Fname.TabIndex = 27;
            this.Fname.Text = "First Name";
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.LnameTxt);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.FnameTxt);
            this.Controls.Add(this.class_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.classes_list);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.delete_student_btn);
            this.Controls.Add(this.edit_student_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label edit_student_label;
        private Button delete_student_btn;
        private Button save_btn;
        private Button cancel_btn;
        private ComboBox classes_list;
        private Label LName;
        private TextBox LnameTxt;
        private TextBox password_box;
        private TextBox email_box;
        private TextBox FnameTxt;
        private Label class_label;
        private Label password_label;
        private Label email_label;
        private Label Fname;
    }
}