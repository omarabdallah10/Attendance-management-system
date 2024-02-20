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
            this.name_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.class_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.delete_student_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.classes_list = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // edit_student_label
            // 
            this.edit_student_label.AutoSize = true;
            this.edit_student_label.Enabled = false;
            this.edit_student_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_student_label.Location = new System.Drawing.Point(337, 48);
            this.edit_student_label.Name = "edit_student_label";
            this.edit_student_label.Size = new System.Drawing.Size(130, 25);
            this.edit_student_label.TabIndex = 0;
            this.edit_student_label.Text = "Edit Student";
            this.edit_student_label.Click += new System.EventHandler(this.edit_student_label_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Enabled = false;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(119, 132);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(68, 25);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Enabled = false;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(116, 184);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(73, 25);
            this.email_label.TabIndex = 2;
            this.email_label.Text = "E-mail";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Enabled = false;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(116, 232);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(106, 25);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password";
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Enabled = false;
            this.class_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_label.Location = new System.Drawing.Point(119, 284);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(67, 25);
            this.class_label.TabIndex = 4;
            this.class_label.Text = "Class";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(262, 129);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 30);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(262, 181);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(335, 30);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(262, 229);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(335, 30);
            this.textBox3.TabIndex = 7;
            // 
            // delete_student_btn
            // 
            this.delete_student_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delete_student_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_student_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_student_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_student_btn.Location = new System.Drawing.Point(70, 380);
            this.delete_student_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_student_btn.Name = "delete_student_btn";
            this.delete_student_btn.Size = new System.Drawing.Size(200, 40);
            this.delete_student_btn.TabIndex = 9;
            this.delete_student_btn.Text = "Delete Student";
            this.delete_student_btn.UseVisualStyleBackColor = false;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(397, 380);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(200, 40);
            this.save_btn.TabIndex = 10;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(603, 380);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(200, 40);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "Cancel";
<<<<<<< HEAD
            this.cancel_btn.UseVisualStyleBackColor = false;
=======
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
>>>>>>> main
            // 
            // classes_list
            // 
            this.classes_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classes_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classes_list.FormattingEnabled = true;
            this.classes_list.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.classes_list.Location = new System.Drawing.Point(262, 281);
            this.classes_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classes_list.Name = "classes_list";
            this.classes_list.Size = new System.Drawing.Size(335, 33);
            this.classes_list.TabIndex = 25;
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.classes_list);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.delete_student_btn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.class_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.edit_student_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditStudentForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label edit_student_label;
        private Label name_label;
        private Label email_label;
        private Label password_label;
        private Label class_label;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button delete_student_btn;
        private Button save_btn;
        private Button cancel_btn;
        private ComboBox classes_list;
    }
}