namespace AttendanceSysytem.Forms
{
    partial class TakeAttendanceForm
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
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.dataGridViewTakeAttendance = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakeAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.ItemHeight = 20;
            this.ClassComboBox.Items.AddRange(new object[] {
            "PD",
            "OS",
            "AI"});
            this.ClassComboBox.Location = new System.Drawing.Point(541, 35);
            this.ClassComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(200, 28);
            this.ClassComboBox.TabIndex = 15;
            this.ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Class:";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(27, 23);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(200, 40);
            this.btnGoBack.TabIndex = 13;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTakeAttendance
            // 
            this.dataGridViewTakeAttendance.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewTakeAttendance.ColumnHeadersHeight = 29;
            this.dataGridViewTakeAttendance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTakeAttendance.Location = new System.Drawing.Point(11, 106);
            this.dataGridViewTakeAttendance.Name = "dataGridViewTakeAttendance";
            this.dataGridViewTakeAttendance.RowHeadersWidth = 51;
            this.dataGridViewTakeAttendance.RowTemplate.Height = 24;
            this.dataGridViewTakeAttendance.Size = new System.Drawing.Size(777, 242);
            this.dataGridViewTakeAttendance.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(302, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 40);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // TakeAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.dataGridViewTakeAttendance);
            this.Name = "TakeAttendanceForm";
            this.Text = "TakeAttendanceForm";
            this.Load += new System.EventHandler(this.TakeAttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakeAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.DataGridView dataGridViewTakeAttendance;
        private System.Windows.Forms.Button btnSave;
    }
}