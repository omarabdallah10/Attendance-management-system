namespace AttendanceSysytem.UserControls
{
    partial class ViewAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAttendance));
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.classes_label = new System.Windows.Forms.Label();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.DateComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnPDf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // classComboBox
            // 
            resources.ApplyResources(this.classComboBox, "classComboBox");
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            resources.GetString("classComboBox.Items"),
            resources.GetString("classComboBox.Items1"),
            resources.GetString("classComboBox.Items2")});
            this.classComboBox.Name = "classComboBox";
            // 
            // classes_label
            // 
            resources.ApplyResources(this.classes_label, "classes_label");
            this.classes_label.ForeColor = System.Drawing.Color.Coral;
            this.classes_label.Name = "classes_label";
            // 
            // dataGridViewAttendance
            // 
            resources.ApplyResources(this.dataGridViewAttendance, "dataGridViewAttendance");
            this.dataGridViewAttendance.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.RowTemplate.Height = 24;
            // 
            // DateComboBox
            // 
            resources.ApplyResources(this.DateComboBox, "DateComboBox");
            this.DateComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateComboBox.FormattingEnabled = true;
            this.DateComboBox.Items.AddRange(new object[] {
            resources.GetString("DateComboBox.Items")});
            this.DateComboBox.Name = "DateComboBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Name = "label1";
            // 
            // btnViewAttendance
            // 
            resources.ApplyResources(this.btnViewAttendance, "btnViewAttendance");
            this.btnViewAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAttendance.ForeColor = System.Drawing.Color.White;
            this.btnViewAttendance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnViewAttendance.Location = new System.Drawing.Point(214, 126);
            this.btnViewAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.Size = new System.Drawing.Size(280, 40);
            this.btnViewAttendance.TabIndex = 45;
            this.btnViewAttendance.Text = "View Attendance";
            this.btnViewAttendance.UseVisualStyleBackColor = false;
            this.btnViewAttendance.Click += new System.EventHandler(this.btnViewAttendance_Click);
            // 
            // btnSaveAs
            // 
            resources.ApplyResources(this.btnSaveAs, "btnSaveAs");
            this.btnSaveAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAs.ForeColor = System.Drawing.Color.White;
            this.btnSaveAs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveAs.Location = new System.Drawing.Point(520, 126);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(280, 40);
            this.btnSaveAs.TabIndex = 46;
            this.btnSaveAs.Text = "Save AS Excel";
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnPDf
            // 
            this.btnPDf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPDf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPDf.ForeColor = System.Drawing.Color.White;
            this.btnPDf.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnPDf.Location = new System.Drawing.Point(820, 126);
            this.btnPDf.Name = "btnPDf";
            this.btnPDf.Size = new System.Drawing.Size(280, 40);
            this.btnPDf.TabIndex = 47;
            this.btnPDf.Text = "Save As PDF";
            this.btnPDf.UseVisualStyleBackColor = false;
            this.btnPDf.Click += new System.EventHandler(this.btnPDf_Click);
            // 
            // ViewAttendance
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPDf);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnViewAttendance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateComboBox);
            this.Controls.Add(this.dataGridViewAttendance);
            this.Controls.Add(this.classes_label);
            this.Controls.Add(this.classComboBox);
            this.Name = "ViewAttendance";
            this.Load += new System.EventHandler(this.ViewAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label classes_label;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.ComboBox DateComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAttendance;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnPDf;
    }
}
