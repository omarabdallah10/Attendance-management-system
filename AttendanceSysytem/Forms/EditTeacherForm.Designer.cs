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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTeacherForm));
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.delete_teacher_btn = new System.Windows.Forms.Button();
            this.password_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.FnameTxt = new System.Windows.Forms.TextBox();
            this.class_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.edit_teacher_label = new System.Windows.Forms.Label();
            this.LnameTxt = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            resources.ApplyResources(this.cancel_btn, "cancel_btn");
            this.cancel_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // save_btn
            // 
            resources.ApplyResources(this.save_btn, "save_btn");
            this.save_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.Name = "save_btn";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // delete_teacher_btn
            // 
            resources.ApplyResources(this.delete_teacher_btn, "delete_teacher_btn");
            this.delete_teacher_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delete_teacher_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_teacher_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_teacher_btn.Name = "delete_teacher_btn";
            this.delete_teacher_btn.UseVisualStyleBackColor = false;
            this.delete_teacher_btn.Click += new System.EventHandler(this.delete_teacher_btn_Click);
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
            // edit_teacher_label
            // 
            resources.ApplyResources(this.edit_teacher_label, "edit_teacher_label");
            this.edit_teacher_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edit_teacher_label.Name = "edit_teacher_label";
            // 
            // LnameTxt
            // 
            resources.ApplyResources(this.LnameTxt, "LnameTxt");
            this.LnameTxt.Name = "LnameTxt";
            // 
            // LName
            // 
            resources.ApplyResources(this.LName, "LName");
            this.LName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LName.Name = "LName";
            // 
            // checkedListBox1
            // 
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Name = "checkedListBox1";
            // 
            // EditTeacherForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.LnameTxt);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.delete_teacher_btn);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.FnameTxt);
            this.Controls.Add(this.class_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.edit_teacher_label);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "EditTeacherForm";
            this.Load += new System.EventHandler(this.EditTeacherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancel_btn;
        private Button save_btn;
        private Button delete_teacher_btn;
        private TextBox password_box;
        private TextBox email_box;
        private TextBox FnameTxt;
        private Label class_label;
        private Label password_label;
        private Label email_label;
        private Label Fname;
        private Label edit_teacher_label;
        private TextBox LnameTxt;
        private Label LName;
        private CheckedListBox checkedListBox1;
    }
}
