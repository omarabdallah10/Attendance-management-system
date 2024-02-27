namespace AttendanceSysytem.Forms
{
    partial class saveAsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saveAsForm));
            this.btnSaveAsPDF = new System.Windows.Forms.Button();
            this.RichTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnSaveAsExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveAsPDF
            // 
            resources.ApplyResources(this.btnSaveAsPDF, "btnSaveAsPDF");
            this.btnSaveAsPDF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveAsPDF.Name = "btnSaveAsPDF";
            this.btnSaveAsPDF.UseVisualStyleBackColor = false;
            this.btnSaveAsPDF.Click += new System.EventHandler(this.btnSaveAsPDF_Click);
            // 
            // RichTxtBox
            // 
            resources.ApplyResources(this.RichTxtBox, "RichTxtBox");
            this.RichTxtBox.Name = "RichTxtBox";
            // 
            // btnSaveAsExcel
            // 
            resources.ApplyResources(this.btnSaveAsExcel, "btnSaveAsExcel");
            this.btnSaveAsExcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveAsExcel.Name = "btnSaveAsExcel";
            this.btnSaveAsExcel.UseVisualStyleBackColor = false;
            this.btnSaveAsExcel.Click += new System.EventHandler(this.btnSaveAsExcel_Click);
            // 
            // saveAsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.btnSaveAsExcel);
            this.Controls.Add(this.RichTxtBox);
            this.Controls.Add(this.btnSaveAsPDF);
            this.Name = "saveAsForm";
            this.Load += new System.EventHandler(this.saveAsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveAsPDF;
        private System.Windows.Forms.RichTextBox RichTxtBox;
        private System.Windows.Forms.Button btnSaveAsExcel;
    }
}