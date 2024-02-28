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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentForm));
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
            resources.ApplyResources(this.edit_student_label, "edit_student_label");
            this.edit_student_label.Name = "edit_student_label";
            // 
            // delete_student_btn
            // 
            this.delete_student_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delete_student_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.delete_student_btn, "delete_student_btn");
            this.delete_student_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_student_btn.Name = "delete_student_btn";
            this.delete_student_btn.UseVisualStyleBackColor = false;
            this.delete_student_btn.Click += new System.EventHandler(this.delete_student_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.save_btn, "save_btn");
            this.save_btn.Name = "save_btn";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.cancel_btn, "cancel_btn");
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // classes_list
            // 
            this.classes_list.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.classes_list, "classes_list");
            this.classes_list.FormattingEnabled = true;
            this.classes_list.Name = "classes_list";
            // 
            // LName
            // 
            resources.ApplyResources(this.LName, "LName");
            this.LName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LName.Name = "LName";
            // 
            // LnameTxt
            // 
            resources.ApplyResources(this.LnameTxt, "LnameTxt");
            this.LnameTxt.Name = "LnameTxt";
            // 
            // password_box
            // 
            resources.ApplyResources(this.password_box, "password_box");
            this.password_box.Name = "password_box";
            // 
            // email_box
            // 
            resources.ApplyResources(this.email_box, "email_box");
            this.email_box.Name = "email_box";
            // 
            // FnameTxt
            // 
            resources.ApplyResources(this.FnameTxt, "FnameTxt");
            this.FnameTxt.Name = "FnameTxt";
            // 
            // class_label
            // 
            resources.ApplyResources(this.class_label, "class_label");
            this.class_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.class_label.Name = "class_label";
            // 
            // password_label
            // 
            resources.ApplyResources(this.password_label, "password_label");
            this.password_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password_label.Name = "password_label";
            // 
            // email_label
            // 
            resources.ApplyResources(this.email_label, "email_label");
            this.email_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email_label.Name = "email_label";
            // 
            // Fname
            // 
            resources.ApplyResources(this.Fname, "Fname");
            this.Fname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fname.Name = "Fname";
            // 
            // EditStudentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "EditStudentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditStudentForm_FormClosed_1);
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