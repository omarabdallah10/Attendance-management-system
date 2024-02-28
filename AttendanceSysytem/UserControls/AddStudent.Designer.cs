namespace AttendanceSysytem.UserControls
{
    partial class AddStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            System.Windows.Forms.Label Lname;
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.ClassList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.Class = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            Lname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // email
            // 
            resources.ApplyResources(this.email, "email");
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.email.Name = "email";
            // 
            // ClassList
            // 
            resources.ApplyResources(this.ClassList, "ClassList");
            this.ClassList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClassList.FormattingEnabled = true;
            this.ClassList.Name = "ClassList";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
            // 
            // txtFName
            // 
            resources.ApplyResources(this.txtFName, "txtFName");
            this.txtFName.Name = "txtFName";
            // 
            // Class
            // 
            resources.ApplyResources(this.Class, "Class");
            this.Class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Class.Name = "Class";
            // 
            // FName
            // 
            resources.ApplyResources(this.FName, "FName");
            this.FName.BackColor = System.Drawing.Color.Transparent;
            this.FName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FName.Name = "FName";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLName
            // 
            resources.ApplyResources(this.txtLName, "txtLName");
            this.txtLName.Name = "txtLName";
            // 
            // Password
            // 
            resources.ApplyResources(this.Password, "Password");
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Password.Name = "Password";
            // 
            // Lname
            // 
            resources.ApplyResources(Lname, "Lname");
            Lname.BackColor = System.Drawing.Color.Transparent;
            Lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            Lname.Name = "Lname";
            // 
            // AddStudent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.ClassList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.Password);
            this.Controls.Add(Lname);
            this.Name = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.ComboBox ClassList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label Password;
    }
}
