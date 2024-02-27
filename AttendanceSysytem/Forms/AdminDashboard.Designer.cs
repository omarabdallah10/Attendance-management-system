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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 673);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSettings);
            this.panel4.Controls.Add(this.btnViewAttendance);
            this.panel4.Controls.Add(this.btnEditUsers);
            this.panel4.Controls.Add(this.btnAddClass);
            this.panel4.Controls.Add(this.btnAddTeacher);
            this.panel4.Controls.Add(this.btnAddStudent);
            this.panel4.Controls.Add(this.panelSide);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 493);
            this.panel4.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::AttendanceSysytem.Properties.Resources.settings1;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 235);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(258, 47);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "              Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnViewAttendance
            // 
            this.btnViewAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewAttendance.FlatAppearance.BorderSize = 0;
            this.btnViewAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAttendance.ForeColor = System.Drawing.Color.White;
            this.btnViewAttendance.Image = global::AttendanceSysytem.Properties.Resources.att;
            this.btnViewAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAttendance.Location = new System.Drawing.Point(0, 188);
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.Size = new System.Drawing.Size(258, 47);
            this.btnViewAttendance.TabIndex = 0;
            this.btnViewAttendance.Text = "              View Attendance";
            this.btnViewAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewAttendance.UseVisualStyleBackColor = true;
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditUsers.FlatAppearance.BorderSize = 0;
            this.btnEditUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUsers.ForeColor = System.Drawing.Color.White;
            this.btnEditUsers.Image = global::AttendanceSysytem.Properties.Resources.addStudent;
            this.btnEditUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUsers.Location = new System.Drawing.Point(0, 141);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(258, 47);
            this.btnEditUsers.TabIndex = 0;
            this.btnEditUsers.Text = "              Edit Users";
            this.btnEditUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditUsers.UseVisualStyleBackColor = true;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddClass.FlatAppearance.BorderSize = 0;
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.ForeColor = System.Drawing.Color.White;
            this.btnAddClass.Image = global::AttendanceSysytem.Properties.Resources._class;
            this.btnAddClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClass.Location = new System.Drawing.Point(0, 94);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(258, 47);
            this.btnAddClass.TabIndex = 0;
            this.btnAddClass.Text = "              Add Class";
            this.btnAddClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddClass.UseVisualStyleBackColor = true;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTeacher.FlatAppearance.BorderSize = 0;
            this.btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeacher.ForeColor = System.Drawing.Color.White;
            this.btnAddTeacher.Image = global::AttendanceSysytem.Properties.Resources.addStudent;
            this.btnAddTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTeacher.Location = new System.Drawing.Point(0, 47);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(258, 47);
            this.btnAddTeacher.TabIndex = 0;
            this.btnAddTeacher.Text = "              Add Teacher";
            this.btnAddTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Image = global::AttendanceSysytem.Properties.Resources.addStudent;
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(0, 0);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(258, 47);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "              Add Student";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStudent.UseVisualStyleBackColor = true;

            
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(8, 47);
            this.panelSide.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 180);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AttendanceSysytem.Properties.Resources.dashboardIcon;
            this.pictureBox1.Location = new System.Drawing.Point(81, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.btnLogout);
            this.panelBack.Controls.Add(this.panelTop);
            this.panelBack.Location = new System.Drawing.Point(258, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(942, 165);
            this.panelBack.TabIndex = 0;
            // 

            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panelTop.Controls.Add(this.labelRole);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.labelUsername);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTop.Location = new System.Drawing.Point(0, 65);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(942, 100);
            this.panelTop.TabIndex = 0;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(154, 57);
            this.labelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(40, 25);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "(?)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Role:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(154, 22);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(40, 25);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "(?)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.btnLogout.Location = new System.Drawing.Point(779, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 48);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}