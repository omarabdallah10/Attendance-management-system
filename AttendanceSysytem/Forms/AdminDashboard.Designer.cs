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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 979);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.btnSettings);
            this.panel4.Controls.Add(this.btnViewAttendance);
            this.panel4.Controls.Add(this.btnEditUsers);
            this.panel4.Controls.Add(this.btnAddClass);
            this.panel4.Controls.Add(this.btnAddTeacher);
            this.panel4.Controls.Add(this.btnAddStudent);
            this.panel4.Controls.Add(this.panelSide);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 799);
            this.panel4.TabIndex = 0;
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::AttendanceSysytem.Properties.Resources.settings1;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnViewAttendance
            // 
            resources.ApplyResources(this.btnViewAttendance, "btnViewAttendance");
            this.btnViewAttendance.FlatAppearance.BorderSize = 0;
            this.btnViewAttendance.ForeColor = System.Drawing.Color.White;
            this.btnViewAttendance.Image = global::AttendanceSysytem.Properties.Resources.att;
            this.btnViewAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAttendance.Location = new System.Drawing.Point(0, 188);
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.UseVisualStyleBackColor = true;
            // 
            // btnEditUsers
            // 
            resources.ApplyResources(this.btnEditUsers, "btnEditUsers");
            this.btnEditUsers.FlatAppearance.BorderSize = 0;
            this.btnEditUsers.ForeColor = System.Drawing.Color.White;
            this.btnEditUsers.Image = global::AttendanceSysytem.Properties.Resources.addStudent;
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.UseVisualStyleBackColor = true;
            this.btnEditUsers.Click += new System.EventHandler(this.btnEditUsers_Click);
            // 
            // btnAddClass
            // 
            resources.ApplyResources(this.btnAddClass, "btnAddClass");
            this.btnAddClass.FlatAppearance.BorderSize = 0;
            this.btnAddClass.ForeColor = System.Drawing.Color.White;
            this.btnAddClass.Image = global::AttendanceSysytem.Properties.Resources._class;
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnAddTeacher
            // 
            resources.ApplyResources(this.btnAddTeacher, "btnAddTeacher");
            this.btnAddTeacher.FlatAppearance.BorderSize = 0;
            this.btnAddTeacher.ForeColor = System.Drawing.Color.White;
            this.btnAddTeacher.Image = global::AttendanceSysytem.Properties.Resources.addStudent;
            this.btnAddTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTeacher.Location = new System.Drawing.Point(0, 47);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnAddStudent
            // 
            resources.ApplyResources(this.btnAddStudent, "btnAddStudent");
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Image = global::AttendanceSysytem.Properties.Resources.addStudent;
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(0, 0);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // panelSide
            // 
            resources.ApplyResources(this.panelSide, "panelSide");
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Name = "panelSide";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Name = "panel2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::AttendanceSysytem.Properties.Resources.dashboardIcon;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.panelTop);
            this.panelBack.Controls.Add(this.btnLogout);
            this.panelBack.Controls.Add(this.DateandTime);
            this.panelBack.Location = new System.Drawing.Point(258, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1387, 165);
            this.panelBack.TabIndex = 0;
            // 
            // panelTop
            // 
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panelTop.Controls.Add(this.labelRole);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.labelUsername);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1387, 100);
            this.panelTop.TabIndex = 0;
            // 
            // labelRole
            // 
            resources.ApplyResources(this.labelRole, "labelRole");
            this.labelRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Name = "labelRole";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // labelUsername
            // 
            resources.ApplyResources(this.labelUsername, "labelUsername");
            this.labelUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Name = "labelUsername";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Welcome:";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.btnLogout.Image = global::AttendanceSysytem.Properties.Resources.logOut_icon;
            this.btnLogout.Location = new System.Drawing.Point(1109, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 48);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // DateandTime
            // 
            this.DateandTime.AutoSize = true;
            this.DateandTime.BackColor = System.Drawing.Color.White;
            this.DateandTime.ForeColor = System.Drawing.Color.IndianRed;
            this.DateandTime.Location = new System.Drawing.Point(29, 22);
            this.DateandTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateandTime.Name = "DateandTime";
            this.DateandTime.Size = new System.Drawing.Size(109, 25);
            this.DateandTime.TabIndex = 1;
            this.DateandTime.Text = "Welcome:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(258, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1387, 799);
            this.panel3.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1657, 979);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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