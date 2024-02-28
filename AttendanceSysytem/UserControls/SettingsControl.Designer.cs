namespace AttendanceSysytem.UserControls
{
    partial class SettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            this.Languages = new System.Windows.Forms.ComboBox();
            this.font = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Languages
            // 
            this.Languages.DisplayMember = "English";
            resources.ApplyResources(this.Languages, "Languages");
            this.Languages.FormattingEnabled = true;
            this.Languages.Items.AddRange(new object[] {
            resources.GetString("Languages.Items"),
            resources.GetString("Languages.Items1")});
            this.Languages.Name = "Languages";
            this.Languages.ValueMember = "English";
            this.Languages.SelectedIndexChanged += new System.EventHandler(this.Languages_SelectedIndexChanged_1);
            // 
            // font
            // 
            resources.ApplyResources(this.font, "font");
            this.font.Cursor = System.Windows.Forms.Cursors.Hand;
            this.font.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.font.Name = "font";
            this.font.UseVisualStyleBackColor = true;
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // Settings
            // 
            resources.ApplyResources(this.Settings, "Settings");
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Settings.Name = "Settings";
            // 
            // password_box
            // 
            resources.ApplyResources(this.password_box, "password_box");
            this.password_box.Name = "password_box";
            // 
            // password_label
            // 
            resources.ApplyResources(this.password_label, "password_label");
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.password_label.Name = "password_label";
            // 
            // save_btn
            // 
            resources.ApplyResources(this.save_btn, "save_btn");
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Name = "save_btn";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
            // 
            // SettingsControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Languages);
            this.Controls.Add(this.font);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.save_btn);
            this.Name = "SettingsControl";
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Languages;
        private System.Windows.Forms.Button font;
        private System.Windows.Forms.Label Settings;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label1;
    }
}
