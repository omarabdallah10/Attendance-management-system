namespace AttendanceSysytem.Forms
{
    partial class AddTeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddTeacher = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.Classes = new System.Windows.Forms.Label();
            this.TeacherFName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.TeacherLName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddTeacher
            // 
            this.AddTeacher.AutoSize = true;
            this.AddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeacher.Location = new System.Drawing.Point(347, 29);

            this.AddTeacher.Name = "AddTeacher";
            this.AddTeacher.Size = new System.Drawing.Size(137, 25);
            this.AddTeacher.TabIndex = 11;
            this.AddTeacher.Text = "Add Teacher";
            // 
            // btnCancel
            // 
<<<<<<< HEAD
            this.btnCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(433, 366);
=======
            this.btnCancel.Location = new System.Drawing.Point(618, 388);
>>>>>>> main
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(220, 45);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
<<<<<<< HEAD
            this.btnCancel.UseVisualStyleBackColor = false;
=======
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
>>>>>>> main
            // 
            // txtFName
            // 
<<<<<<< HEAD
            this.txtClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasses.Location = new System.Drawing.Point(382, 297);
            this.txtClasses.Name = "txtClasses";
            this.txtClasses.Size = new System.Drawing.Size(271, 30);
            this.txtClasses.TabIndex = 19;
            this.txtClasses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(382, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 30);
            this.txtName.TabIndex = 13;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
=======
            this.txtFName.Location = new System.Drawing.Point(347, 80);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(189, 22);
            this.txtFName.TabIndex = 13;
>>>>>>> main
            // 
            // Classes
            // 
            this.Classes.AutoSize = true;
            this.Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classes.Location = new System.Drawing.Point(187, 300);
            this.Classes.Name = "Classes";
<<<<<<< HEAD
            this.Classes.Size = new System.Drawing.Size(90, 25);
            this.Classes.TabIndex = 18;
=======
            this.Classes.Size = new System.Drawing.Size(56, 16);
            this.Classes.TabIndex = 19;
>>>>>>> main
            this.Classes.Text = "Classes";
            // 
            // TeacherFName
            // 
<<<<<<< HEAD
            this.TeacherName.AutoSize = true;
            this.TeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherName.Location = new System.Drawing.Point(187, 105);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(68, 25);
            this.TeacherName.TabIndex = 12;
            this.TeacherName.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(184, 366);
=======
            this.TeacherFName.AutoSize = true;
            this.TeacherFName.Location = new System.Drawing.Point(230, 83);
            this.TeacherFName.Name = "TeacherFName";
            this.TeacherFName.Size = new System.Drawing.Size(72, 16);
            this.TeacherFName.TabIndex = 12;
            this.TeacherFName.Text = "First Name";
            this.TeacherFName.Click += new System.EventHandler(this.TeacherName_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(405, 388);
>>>>>>> main
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 45);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
<<<<<<< HEAD
            this.btnSave.UseVisualStyleBackColor = false;
=======
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
>>>>>>> main
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(382, 230);
            this.txtPassword.Name = "txtPassword";
<<<<<<< HEAD
            this.txtPassword.Size = new System.Drawing.Size(271, 30);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
=======
            this.txtPassword.Size = new System.Drawing.Size(189, 22);
            this.txtPassword.TabIndex = 18;
>>>>>>> main
            // 
            // txtEmail
            // 
<<<<<<< HEAD
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(382, 165);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(271, 30);
            this.txtUserName.TabIndex = 15;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
=======
            this.txtEmail.Location = new System.Drawing.Point(347, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 22);
            this.txtEmail.TabIndex = 16;
>>>>>>> main
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(187, 233);
            this.Password.Name = "Password";
<<<<<<< HEAD
            this.Password.Size = new System.Drawing.Size(106, 25);
            this.Password.TabIndex = 16;
=======
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 17;
>>>>>>> main
            this.Password.Text = "Password";
            // 
            // Email
            // 
<<<<<<< HEAD
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(187, 168);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(110, 25);
            this.Username.TabIndex = 14;
            this.Username.Text = "Username";
=======
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(230, 170);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 15;
            this.Email.Text = "Email";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(347, 266);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(189, 106);
            this.checkedListBox1.TabIndex = 22;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(347, 121);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(189, 22);
            this.txtLName.TabIndex = 15;
            this.txtLName.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // TeacherLName
            // 
            this.TeacherLName.AutoSize = true;
            this.TeacherLName.Location = new System.Drawing.Point(230, 127);
            this.TeacherLName.Name = "TeacherLName";
            this.TeacherLName.Size = new System.Drawing.Size(72, 16);
            this.TeacherLName.TabIndex = 14;
            this.TeacherLName.Text = "Last Name";
>>>>>>> main
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.TeacherLName);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.AddTeacher);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.Classes);
            this.Controls.Add(this.TeacherFName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Name = "AddTeacherForm";
            this.Text = "AddTeacherForm";
            this.Load += new System.EventHandler(this.AddTeacherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddTeacher;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label Classes;
        private System.Windows.Forms.Label TeacherFName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label TeacherLName;
    }
}