namespace AttendanceSysytem.Forms
{
    partial class AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.DateandTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBack.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.btnSettings);
            this.panel4.Controls.Add(this.btnViewAttendance);
            this.panel4.Controls.Add(this.btnEditUsers);
            this.panel4.Controls.Add(this.btnAddClass);
            this.panel4.Controls.Add(this.btnAddTeacher);
            this.panel4.Controls.Add(this.btnAddStudent);
            this.panel4.Controls.Add(this.panelSide);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::AttendanceSysytem.Properties.Resources.settings1;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnViewAttendance
            // 
            this.btnViewAttendance.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnViewAttendance, "btnViewAttendance");
            this.btnViewAttendance.ForeColor = System.Drawing.Color.White;
            this.btnViewAttendance.Image = global::AttendanceSysytem.Properties.Resources.att;
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.UseVisualStyleBackColor = true;
            this.btnViewAttendance.Click += new System.EventHandler(this.btnViewAttendance_Click);
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnEditUsers, "btnEditUsers");
            this.btnEditUsers.ForeColor = System.Drawing.Color.White;
            this.btnEditUsers.Image = global::AttendanceSysytem.Properties.Resources.addStudent;
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.UseVisualStyleBackColor = true;
            this.btnEditUsers.Click += new System.EventHandler(this.btnEditUsers_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAddClass, "btnAddClass");
            this.btnAddClass.ForeColor = System.Drawing.Color.White;
            this.btnAddClass.Image = global::AttendanceSysytem.Properties.Resources._class;
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAddTeacher, "btnAddTeacher");
            this.btnAddTeacher.ForeColor = System.Drawing.Color.White;
            this.btnAddTeacher.Image = global::AttendanceSysytem.Properties.Resources.addStudent;
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAddStudent, "btnAddStudent");
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Image = global::AttendanceSysytem.Properties.Resources.addStudent;
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panelSide, "panelSide");
            this.panelSide.Name = "panelSide";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AttendanceSysytem.Properties.Resources.attendanceLogo_removebg_preview;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            resources.ApplyResources(this.panelBack, "panelBack");
            this.panelBack.Controls.Add(this.panelTop);
            this.panelBack.Controls.Add(this.btnLogout);
            this.panelBack.Controls.Add(this.DateandTime);
            this.panelBack.Name = "panelBack";
            // 
            // panelTop
            // 
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelTop.Controls.Add(this.labelRole);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.labelUsername);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Name = "panelTop";
            // 
            // labelRole
            // 
            resources.ApplyResources(this.labelRole, "labelRole");
            this.labelRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Name = "labelRole";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // labelUsername
            // 
            resources.ApplyResources(this.labelUsername, "labelUsername");
            this.labelUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Name = "labelUsername";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // DateandTime
            // 
            this.DateandTime.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.DateandTime, "DateandTime");
            this.DateandTime.ForeColor = System.Drawing.Color.OrangeRed;
            this.DateandTime.Name = "DateandTime";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // AdminDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnViewAttendance;
        private System.Windows.Forms.Button btnEditUsers;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label DateandTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
    }
}