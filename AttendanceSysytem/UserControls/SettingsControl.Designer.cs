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
            this.Languages = new System.Windows.Forms.ComboBox();
            this.font = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Languages
            // 
            this.Languages.DisplayMember = "English";
            this.Languages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Languages.FormattingEnabled = true;
            this.Languages.ItemHeight = 20;
            this.Languages.Items.AddRange(new object[] {
            "العربية",
            "English"});
            this.Languages.Location = new System.Drawing.Point(272, 281);
            this.Languages.Name = "Languages";
            this.Languages.Size = new System.Drawing.Size(358, 28);
            this.Languages.TabIndex = 50;
            this.Languages.ValueMember = "English";
            // 
            // font
            // 
            this.font.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.font.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.font.Cursor = System.Windows.Forms.Cursors.Hand;
            this.font.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.font.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.font.Location = new System.Drawing.Point(380, 346);
            this.font.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(234, 40);
            this.font.TabIndex = 49;
            this.font.Text = "Font";
            this.font.UseVisualStyleBackColor = true;
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // Settings
            // 
            this.Settings.AutoSize = true;
            this.Settings.Enabled = false;
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.Settings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Settings.Location = new System.Drawing.Point(372, 83);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(141, 46);
            this.Settings.TabIndex = 48;
            this.Settings.Text = "Settings";
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password_box.Location = new System.Drawing.Point(316, 188);
            this.password_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(314, 30);
            this.password_box.TabIndex = 47;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Enabled = false;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.password_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.password_label.Location = new System.Drawing.Point(176, 191);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(106, 25);
            this.password_label.TabIndex = 46;
            this.password_label.Text = "Password";
            // 
            // save_btn
            // 
            this.save_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.save_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.save_btn.Location = new System.Drawing.Point(380, 403);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(234, 40);
            this.save_btn.TabIndex = 44;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Languages);
            this.Controls.Add(this.font);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.save_btn);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(879, 621);
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
    }
}
