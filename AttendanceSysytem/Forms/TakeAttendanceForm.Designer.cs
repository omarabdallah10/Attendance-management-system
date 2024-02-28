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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeAttendanceForm));
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.dataGridViewTakeAttendance = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakeAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassComboBox
            // 
            resources.ApplyResources(this.ClassComboBox, "ClassComboBox");
            this.ClassComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Items.AddRange(new object[] {
            resources.GetString("ClassComboBox.Items"),
            resources.GetString("ClassComboBox.Items1"),
            resources.GetString("ClassComboBox.Items2")});
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnGoBack
            // 
            resources.ApplyResources(this.btnGoBack, "btnGoBack");
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTakeAttendance
            // 
            resources.ApplyResources(this.dataGridViewTakeAttendance, "dataGridViewTakeAttendance");
            this.dataGridViewTakeAttendance.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewTakeAttendance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTakeAttendance.Name = "dataGridViewTakeAttendance";
            this.dataGridViewTakeAttendance.RowTemplate.Height = 24;
            this.dataGridViewTakeAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTakeAttendance_CellClick);
            // 
            // btnSave
            // 

            this.btnSave.Location = new System.Drawing.Point(468, 385);

            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAs.Location = new System.Drawing.Point(87, 385);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(200, 40);
            this.btnSaveAs.TabIndex = 17;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = false;
            // 
            // TakeAttendanceForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveAs);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.dataGridViewTakeAttendance);
            this.Name = "TakeAttendanceForm";
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
        private System.Windows.Forms.Button btnSaveAs;
    }
}