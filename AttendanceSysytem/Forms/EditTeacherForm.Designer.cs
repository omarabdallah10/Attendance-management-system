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
            this.cancel_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(738, 464);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(200, 40);
            this.cancel_btn.TabIndex = 23;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(501, 464);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(200, 40);
            this.save_btn.TabIndex = 22;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // delete_teacher_btn
            // 
            this.delete_teacher_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delete_teacher_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_teacher_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_teacher_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_teacher_btn.Location = new System.Drawing.Point(93, 464);
            this.delete_teacher_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_teacher_btn.Name = "delete_teacher_btn";
            this.delete_teacher_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.delete_teacher_btn.Size = new System.Drawing.Size(200, 40);
            this.delete_teacher_btn.TabIndex = 21;
            this.delete_teacher_btn.Text = "Delete Teacher";
            this.delete_teacher_btn.UseVisualStyleBackColor = false;
            this.delete_teacher_btn.Click += new System.EventHandler(this.delete_teacher_btn_Click);
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box.Location = new System.Drawing.Point(366, 267);
            this.password_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(335, 30);
            this.password_box.TabIndex = 19;
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.Location = new System.Drawing.Point(366, 208);
            this.email_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(335, 30);
            this.email_box.TabIndex = 18;
            // 
            // FnameTxt
            // 
            this.FnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameTxt.Location = new System.Drawing.Point(366, 105);
            this.FnameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FnameTxt.Name = "FnameTxt";
            this.FnameTxt.Size = new System.Drawing.Size(335, 30);
            this.FnameTxt.TabIndex = 17;
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Enabled = false;
            this.class_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.class_label.Location = new System.Drawing.Point(223, 332);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(90, 25);
            this.class_label.TabIndex = 16;
            this.class_label.Text = "Classes";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Enabled = false;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password_label.Location = new System.Drawing.Point(223, 270);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(106, 25);
            this.password_label.TabIndex = 15;
            this.password_label.Text = "Password";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Enabled = false;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email_label.Location = new System.Drawing.Point(223, 211);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(73, 25);
            this.email_label.TabIndex = 14;
            this.email_label.Text = "E-mail";
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Enabled = false;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fname.Location = new System.Drawing.Point(223, 110);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(116, 25);
            this.Fname.TabIndex = 13;
            this.Fname.Text = "First Name";
            // 
            // edit_teacher_label
            // 
            this.edit_teacher_label.AutoSize = true;
            this.edit_teacher_label.Enabled = false;
            this.edit_teacher_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_teacher_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edit_teacher_label.Location = new System.Drawing.Point(394, 39);
            this.edit_teacher_label.Name = "edit_teacher_label";
            this.edit_teacher_label.Size = new System.Drawing.Size(135, 25);
            this.edit_teacher_label.TabIndex = 12;
            this.edit_teacher_label.Text = "Edit Teacher";
            // 
            // LnameTxt
            // 
            this.LnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameTxt.Location = new System.Drawing.Point(366, 158);
            this.LnameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LnameTxt.Name = "LnameTxt";
            this.LnameTxt.Size = new System.Drawing.Size(335, 30);
            this.LnameTxt.TabIndex = 25;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Enabled = false;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LName.Location = new System.Drawing.Point(223, 163);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(115, 25);
            this.LName.TabIndex = 26;
            this.LName.Text = "Last Name";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(366, 332);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(335, 89);
            this.checkedListBox1.TabIndex = 27;
            // 
            // EditTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 553);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditTeacherForm";
            this.Text = "Form1";
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
