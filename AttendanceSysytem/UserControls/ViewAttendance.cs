using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using AttendanceSysytem.Classes;
using iTextSharp.text.pdf;
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
        private void ExportDataToPdf()
        {
            try
            {
                // Create a Document
                iTextSharp.text.Document doc = new iTextSharp.text.Document();
                string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\reports\report.pdf");
                string filePath = Path.GetFullPath(sFile);

                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                doc.Open();

                doc.Add(new iTextSharp.text.Paragraph("Attendance Report"));

                PdfPTable table = new PdfPTable(dataGridViewAttendance.Columns.Count);

                foreach (DataGridViewColumn column in dataGridViewAttendance.Columns)
                {
                    table.AddCell(new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText)));
                }

                foreach (DataGridViewRow row in dataGridViewAttendance.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(new PdfPCell(new iTextSharp.text.Phrase(cell.Value?.ToString() ?? "")));
                    }
                }

                doc.Add(table);
                doc.Close();

                MessageBox.Show("Data exported to PDF successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            sfd.Filter = "Excel Files|*.xlsx";
            sfd.DefaultExt = "xlsx";
            sfd.AddExtension = true;
            sfd.FileName = "Attendance Report";
            sfd.OverwritePrompt = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                
                    SaveAsExcel(sfd.FileName, data);
                
            }
        }

        private void btnPDf_Click(object sender, EventArgs e)
        {
            ExportDataToPdf();
        }
    }
}
