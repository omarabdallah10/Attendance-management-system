using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceSysytem.Classes;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace AttendanceSysytem.Forms
{
    public partial class saveAsForm : Form
    {
        public saveAsForm()
        {
            InitializeComponent();
            Settings.ChangeFont(this, Settings.MyFont, true);
            // System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        private void btnSaveAsPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.DefaultExt = "pdf";
            sfd.AddExtension = true;
            sfd.FileName = "Attendance Report";
            sfd.OverwritePrompt = true;

                
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    //create a new pdf document
                    
                        PdfDocument pdf = new PdfDocument();
                        pdf.Info.Title = "Created Attendance Report";
                        PdfPage pdfPage = pdf.AddPage();
                        XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                        XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
                        graph.DrawString("Attendance Report \n"+ RichTxtBox.Text, font, XBrushes.Black,
                            new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);
                        pdf.Save(sfd.FileName);
                }
            
        }

        private void btnSaveAsExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";
            sfd.DefaultExt = "xlsx";
            sfd.AddExtension = true;
            sfd.FileName = "Attendance Report";
            sfd.OverwritePrompt = true;

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                //create a new excel document
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Workbooks.Add();
                Microsoft.Office.Interop.Excel._Worksheet workSheet = excel.ActiveSheet;
                workSheet.Cells[1, "A"] = RichTxtBox.Text;
                workSheet.SaveAs(sfd.FileName); 
            }

        }

        private void saveAsForm_Load(object sender, EventArgs e)
        {
        }
    }
}

