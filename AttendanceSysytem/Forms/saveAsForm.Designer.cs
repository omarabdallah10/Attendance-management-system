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
            this.btnSaveAsPDF = new System.Windows.Forms.Button();
            this.RichTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnSaveAsExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveAsPDF
            // 
            this.btnSaveAsPDF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveAsPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsPDF.Location = new System.Drawing.Point(187, 333);
            this.btnSaveAsPDF.Name = "btnSaveAsPDF";
            this.btnSaveAsPDF.Size = new System.Drawing.Size(220, 45);
            this.btnSaveAsPDF.TabIndex = 0;
            this.btnSaveAsPDF.Text = "Save As PDF";
            this.btnSaveAsPDF.UseVisualStyleBackColor = false;
            this.btnSaveAsPDF.Click += new System.EventHandler(this.btnSaveAsPDF_Click);
            // 
            // RichTxtBox
            // 
            this.RichTxtBox.Location = new System.Drawing.Point(187, 90);
            this.RichTxtBox.Name = "RichTxtBox";
            this.RichTxtBox.Size = new System.Drawing.Size(460, 205);
            this.RichTxtBox.TabIndex = 1;
            this.RichTxtBox.Text = "";
            // 
            // btnSaveAsExcel
            // 
            this.btnSaveAsExcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveAsExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsExcel.Location = new System.Drawing.Point(427, 333);
            this.btnSaveAsExcel.Name = "btnSaveAsExcel";
            this.btnSaveAsExcel.Size = new System.Drawing.Size(220, 45);
            this.btnSaveAsExcel.TabIndex = 2;
            this.btnSaveAsExcel.Text = "Save As EXCEL";
            this.btnSaveAsExcel.UseVisualStyleBackColor = false;
            this.btnSaveAsExcel.Click += new System.EventHandler(this.btnSaveAsExcel_Click);
            // 
            // saveAsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.btnSaveAsExcel);
            this.Controls.Add(this.RichTxtBox);
            this.Controls.Add(this.btnSaveAsPDF);
            this.Name = "saveAsForm";
            this.Text = "saveAsForm";
            this.Load += new System.EventHandler(this.saveAsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveAsPDF;
        private System.Windows.Forms.RichTextBox RichTxtBox;
        private System.Windows.Forms.Button btnSaveAsExcel;
    }
}