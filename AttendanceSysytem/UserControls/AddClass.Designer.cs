namespace AttendanceSysytem.UserControls
{
    partial class AddClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClass));
            this.txtSupervisor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ClassName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.Supervisor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSupervisor
            // 
            resources.ApplyResources(this.txtSupervisor, "txtSupervisor");
            this.txtSupervisor.FormattingEnabled = true;
            this.txtSupervisor.Name = "txtSupervisor";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Name = "label1";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // ClassName
            // 
            resources.ApplyResources(this.ClassName, "ClassName");
            this.ClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClassName.Name = "ClassName";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Supervisor
            // 
            resources.ApplyResources(this.Supervisor, "Supervisor");
            this.Supervisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Supervisor.Name = "Supervisor";
            // 
            // AddClass
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.txtSupervisor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ClassName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Supervisor);
            this.Name = "AddClass";
            this.Load += new System.EventHandler(this.AddClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtSupervisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label ClassName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Supervisor;
    }
}
