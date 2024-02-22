namespace AttendanceSysytem.Forms
{
    partial class SettingsForm
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
            this.password_box = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Label();
            this.font = new System.Windows.Forms.Button();
            this.Langauge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box.Location = new System.Drawing.Point(278, 164);
            this.password_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(314, 30);
            this.password_box.TabIndex = 39;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Enabled = false;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password_label.Location = new System.Drawing.Point(138, 167);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(106, 25);
            this.password_label.TabIndex = 37;
            this.password_label.Text = "Password";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(568, 379);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(200, 40);
            this.cancel_btn.TabIndex = 35;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(342, 379);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(200, 40);
            this.save_btn.TabIndex = 34;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Settings
            // 
            this.Settings.AutoSize = true;
            this.Settings.Enabled = false;
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.Settings.Location = new System.Drawing.Point(334, 59);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(141, 46);
            this.Settings.TabIndex = 40;
            this.Settings.Text = "Settings";
            // 
            // font
            // 
            this.font.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.font.Cursor = System.Windows.Forms.Cursors.Hand;
            this.font.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.font.Location = new System.Drawing.Point(234, 296);
            this.font.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(371, 42);
            this.font.TabIndex = 42;
            this.font.Text = "Font";
            this.font.UseVisualStyleBackColor = true;
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // Langauge
            // 
            this.Langauge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Langauge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Langauge.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Langauge.Location = new System.Drawing.Point(234, 237);
            this.Langauge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Langauge.Name = "Langauge";
            this.Langauge.Size = new System.Drawing.Size(371, 42);
            this.Langauge.TabIndex = 41;
            this.Langauge.Text = "Langauge";
            this.Langauge.UseVisualStyleBackColor = true;
            this.Langauge.Click += new System.EventHandler(this.Langauge_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.font);
            this.Controls.Add(this.Langauge);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label Settings;
        private System.Windows.Forms.Button font;
        private System.Windows.Forms.Button Langauge;
    }
}