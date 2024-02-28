namespace AttendanceSysytem.Forms
{
    partial class AddClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClassForm));
            this.AddClass = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ClassName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.Supervisor = new System.Windows.Forms.Label();
            this.txtSupervisor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddClass
            // 
            resources.ApplyResources(this.AddClass, "AddClass");
            this.AddClass.Name = "AddClass";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // ClassName
            // 
            resources.ApplyResources(this.ClassName, "ClassName");
            this.ClassName.Name = "ClassName";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Supervisor
            // 
            resources.ApplyResources(this.Supervisor, "Supervisor");
            this.Supervisor.Name = "Supervisor";
            // 
            // txtSupervisor
            // 
            resources.ApplyResources(this.txtSupervisor, "txtSupervisor");
            this.txtSupervisor.FormattingEnabled = true;
            this.txtSupervisor.Name = "txtSupervisor";
            // 
            // AddClassForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.txtSupervisor);
            this.Controls.Add(this.AddClass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ClassName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Supervisor);
            this.Name = "AddClassForm";
            this.Load += new System.EventHandler(this.AddClassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddClass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label ClassName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Supervisor;
        private System.Windows.Forms.ComboBox txtSupervisor;
    }
}