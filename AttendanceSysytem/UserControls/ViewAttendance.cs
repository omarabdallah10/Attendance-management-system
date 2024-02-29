using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using AttendanceSysytem.Classes;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace AttendanceSysytem.UserControls
{
    public partial class ViewAttendance : UserControl
    {
        public ViewAttendance()
        {
            InitializeComponent();
        }


        private void ViewAttendance_Load(object sender, EventArgs e)
        {
            dataGridViewAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewAttendance.AllowUserToAddRows = false;

            dataGridViewAttendance.AlternatingRowsDefaultCellStyle.Font = dataGridViewAttendance.RowsDefaultCellStyle.Font;
            //load dates into DateComboBox from xml file
            XmlDataDocument xmlData = new XmlDataDocument();
            string xmlPath = DataManagement.xmlPath();
            xmlData.DataSet.ReadXml(xmlPath);

            DataView dv = new DataView(xmlData.DataSet.Tables["AttendanceRecord"]);
            DataTable dt = dv.ToTable(true, "Date");
            DateComboBox.DataSource = dt;
            DateComboBox.DisplayMember = "Date";




            // -- PD Track is selected by default
            classComboBox.SelectedIndex = 0;
            // -- last index of combobox is selected
            DateComboBox.SelectedIndex = DateComboBox.Items.Count - 1;




        }
        

        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            // Show the attendance of the selected track and date
            try
            {

                XmlDataDocument xmlData = new XmlDataDocument();
                string xmlPath = DataManagement.xmlPath();
                xmlData.DataSet.ReadXml(xmlPath);

                //view the matched date and track
                DataView dv = new DataView(xmlData.DataSet.Tables["AttendanceRecord"]);
                dv.RowFilter = "Date = '" + DateComboBox.Text + "' AND ClassName = '" + classComboBox.Text + "'";
                dataGridViewAttendance.DataSource = dv;

                //MessageBox.Show("Data Loaded Successfully!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(Text = ex.Message);
                MessageBox.Show("Sorry Something go wrong! \nPlease ry again later.");

            }
        }

        private void SaveAsPDF(string fileName, string data)
        {
            //make an instance of the pdf document as a table and add the data to it
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "Created Attendance Report";
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            // draw every row in a new line
            string[] rows = data.Split('\n');
            //make a table of the data
            for (int i = 0; i < rows.Length; i++)
            {
                string[] columns = rows[i].Split(' ');
                for (int j = 0; j < columns.Length; j++)
                {
                    graph.DrawString(columns[j], font, XBrushes.Black,
                                                              new XRect(j * 100, i * 20, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                }
            }

            pdf.Save(fileName);

        }

        private void SaveAsExcel(string fileName, string data)
        {
            // Create a new Excel document and devide the data into rows and columns
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel._Worksheet workSheet = excel.ActiveSheet;
            string[] rows = data.Split('\n');
            for (int i = 0; i < rows.Length; i++)
            {
                string[] columns = rows[i].Split(' ');
                for (int j = 0; j < columns.Length; j++)
                {
                    workSheet.Cells[i + 1, j + 1] = columns[j];
                }
            }
            workSheet.SaveAs(fileName);

        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            //if no data to save
            if (dataGridViewAttendance.Rows.Count == 0)
            {
                MessageBox.Show("No data to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //get the data from the datagridview Fro the excel file
            string data = "";
            for (int i = 0; i < dataGridViewAttendance.Rows.Count; i++)
            {
                //add the title for the first row
                if (i == 0)
                {
                    for (int j = 0; j < dataGridViewAttendance.Columns.Count; j++)
                    {
                        data = "UserID" + " " + "Fname" + " " + "Lname" + " " + "Class" + " " + "Date" + " " + "Status";
                    }
                    data += "\n";
                }

                for (int j = 0; j < dataGridViewAttendance.Columns.Count; j++)
                {
                    data += dataGridViewAttendance.Rows[i].Cells[j].Value.ToString() + " ";
                }
                data += "\n";

            }

            //save the data as pdf or excel
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf|Excel Files|*.xlsx";
            sfd.DefaultExt = "pdf";
            sfd.AddExtension = true;
            sfd.FileName = "Attendance Report";
            sfd.OverwritePrompt = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FilterIndex == 1) // PDF selected
                {
                    SaveAsPDF(sfd.FileName, data);
                }
                else if (sfd.FilterIndex == 2) // Excel selected
                {
                    SaveAsExcel(sfd.FileName, data);
                }
            }
        }
    }
}
