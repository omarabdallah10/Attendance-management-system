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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacherForm));
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
            resources.ApplyResources(this.AddTeacher, "AddTeacher");
            this.AddTeacher.Name = "AddTeacher";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // txtFName
            // 
            resources.ApplyResources(this.txtFName, "txtFName");
            this.txtFName.Name = "txtFName";
            // 
            // Classes
            // 
            resources.ApplyResources(this.Classes, "Classes");
            this.Classes.Name = "Classes";
            // 
            // TeacherFName
            // 
            resources.ApplyResources(this.TeacherFName, "TeacherFName");
            this.TeacherFName.Name = "TeacherFName";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // Password
            // 
            resources.ApplyResources(this.Password, "Password");
            this.Password.Name = "Password";
            // 
            // Email
            // 
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            // 
            // checkedListBox1
            // 
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Name = "checkedListBox1";
            // 
            // txtLName
            // 
            resources.ApplyResources(this.txtLName, "txtLName");
            this.txtLName.Name = "txtLName";
            // 
            // TeacherLName
            // 
            resources.ApplyResources(this.TeacherLName, "TeacherLName");
            this.TeacherLName.Name = "TeacherLName";
            // 
            // AddTeacherForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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