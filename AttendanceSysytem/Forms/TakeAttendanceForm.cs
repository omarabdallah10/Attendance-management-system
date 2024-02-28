using AttendanceSysytem.Classes;
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
using System.IO;
using System.Xml.Linq;
using PdfSharp.Drawing;
using PdfSharp.Pdf;



namespace AttendanceSysytem.Forms
{
    public partial class TakeAttendanceForm : Form
    {
        public TakeAttendanceForm()
        {
            InitializeComponent();
            DataManagement.ChangeFont(this, DataManagement.MyFont, true);
        }


        
        private void TakeAttendanceForm_Load(object sender, EventArgs e)
        {
            //check if the user is logged in



            //'select track' is displayed by default
            ClassComboBox.Text = "Select Class";
            dataGridViewTakeAttendance.AlternatingRowsDefaultCellStyle.Font = dataGridViewTakeAttendance.RowsDefaultCellStyle.Font;
            dataGridViewTakeAttendance.AllowUserToAddRows = false;
            

        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear the datagridview
            dataGridViewTakeAttendance.Columns.Clear();

           


            //display the students of the selected class from the combobox in the datagridview
            try
            {
                XmlDataDocument xmlData = new XmlDataDocument();
                string xmlPath = DataManagement.xmlPath();
                xmlData.DataSet.ReadXml(xmlPath);

                //filtering the students of the selected class according to the class name
                DataView dv = new DataView(xmlData.DataSet.Tables["Student"]);
                dv.RowFilter = "ClassName = '" + ClassComboBox.Text + "'";

                //display the name of the user id and the name of the students in the datagridview
                DataTable dc = dv.ToTable(true, "UserID", "Name");
                dataGridViewTakeAttendance.DataSource = dc;

                // add a checkbox column to the datagridview
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "AttendanceStatusCheckBox";
                checkColumn.HeaderText = "Status";
                checkColumn.ReadOnly = false;

                //make the of three columns equal one third the width of the datagridview
                dataGridViewTakeAttendance.Columns[0].Width = dataGridViewTakeAttendance.Width / 3;
                dataGridViewTakeAttendance.Columns[1].Width = dataGridViewTakeAttendance.Width / 3;
                checkColumn.Width = dataGridViewTakeAttendance.Width / 3;

                dataGridViewTakeAttendance.Columns.Add(checkColumn);                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!! please try again later");
            }


        }

        private void dataGridViewTakeAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //change the state of the checkbox when clicked
            //change the apperance of the checkbox when clicked
            if (e.ColumnIndex == 2)
            {
                if (dataGridViewTakeAttendance.Rows[e.RowIndex].Cells[2].Value == null)
                {
                    dataGridViewTakeAttendance.Rows[e.RowIndex].Cells[2].Value = true;
                }
                else
                {
                    if ((bool)dataGridViewTakeAttendance.Rows[e.RowIndex].Cells[2].Value == true)
                    {
                        dataGridViewTakeAttendance.Rows[e.RowIndex].Cells[2].Value = false;
                    }
                    else
                    {
                        dataGridViewTakeAttendance.Rows[e.RowIndex].Cells[2].Value = true;
                    }
                }
            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //read the data fro dataGridView
            string todayDate = DateTime.Now.ToString("yyyy-MM-dd");
            string className = ClassComboBox.Text;
            for (int i = 0; i < dataGridViewTakeAttendance.Rows.Count; i++)
            {
                string userID = dataGridViewTakeAttendance.Rows[i].Cells[0].Value.ToString();
                string Studentname = dataGridViewTakeAttendance.Rows[i].Cells[1].Value.ToString();
                string status;
                if (dataGridViewTakeAttendance.Rows[i].Cells[2].Value == null)
                {
                    status = "Absent";
                }
                else
                {
                    if ((bool)dataGridViewTakeAttendance.Rows[i].Cells[2].Value == true)
                    {
                        status = "Present";
                    }
                    else
                    {
                        status = "Absent";
                    }
                }

                //build a new AttendanceRecord element
                XElement newAttendanceRecord = new XElement("AttendanceRecord",
                                           new XElement("UserID", userID),
                                           new XElement("Name", Studentname),
                                           new XElement("ClassName", className),
                                           new XElement("Date", todayDate),
                                           new XElement("Status", status)
                                           );


                //insert the record into the XML file
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    string xmlPath = DataManagement.xmlPath();
                    xmlDoc.Load(xmlPath);

                    /*XmlNode parentNode = xmlDoc.SelectSingleNode("School/AttendanceData");
                    parentNode.AppendChild(parentNode.OwnerDocument.ReadNode(newAttendanceRecord.CreateReader()));

                    xmlDoc.Save(xmlPath);*/

                    // check the date if it exists --> if it exists, update the status only -- if not, add a new record
                    XmlNodeList AttendanceRecords = xmlDoc.SelectNodes("//AttendanceRecord");
                    int recordExists = 0;
                    foreach (XmlNode record in AttendanceRecords)
                    {
                        if (record.SelectSingleNode("UserID").InnerText == userID && record.SelectSingleNode("Date").InnerText == todayDate)
                        {
                            record.SelectSingleNode("Status").InnerText = status;
                            recordExists = 1;
                            break;
                        }
                    }
                    if (recordExists == 0)
                    {
                        XmlNode parentNode = xmlDoc.SelectSingleNode("School/AttendanceData");
                        parentNode.AppendChild(parentNode.OwnerDocument.ReadNode(newAttendanceRecord.CreateReader()));
                    }
                    xmlDoc.Save(xmlPath);


                    if(i == dataGridViewTakeAttendance.Rows.Count - 1)
                    {
                        MessageBox.Show("Attendance has been saved successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong!! please try again later");
                }
            }

        }

      
    }
}

