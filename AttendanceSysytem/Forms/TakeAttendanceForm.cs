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

namespace AttendanceSysytem.Forms
{
    public partial class TakeAttendanceForm : Form
    {
        public TakeAttendanceForm()
        {
            InitializeComponent();
        }


        
        private void TakeAttendanceForm_Load(object sender, EventArgs e)
        {
            //'select track' is displayed by default
            ClassComboBox.Text = "Select Class";

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
                checkColumn.Width = 100;
                checkColumn.ReadOnly = false;




                //add event on checkbox cell click



                /*checkColumn.TrueValue = true;
                checkColumn.FalseValue = false;

                //print the state of the checkbox
                Console.WriteLine(checkColumn.TrueValue);
                Console.WriteLine(checkColumn.FalseValue);*/


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

            //make the width of the whole gridview bigger



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //save the attendance status of the students in the xml file into the attendance table with the current date

            /*try
            {
                XmlDataDocument xmlData = new XmlDataDocument();
                string xmlPath = DataManagement.xmlPath();
                xmlData.DataSet.ReadXml(xmlPath);

                //get the current date
                string date = DateTime.Now.ToString("dd/MM/yyyy");

                //get the class name from the index of the classComboBox and set the class in the xml file to the class name in the combobox to the attenedace from in XML
                if (ClassComboBox.SelectedIndex != 0)
                {
                    xmlData.DataSet.Tables["Attendance"].Rows[0]["Class"] = ClassComboBox.Text;
                    xmlData.DataSet.WriteXml(xmlPath);
                }
                else
                {
                    MessageBox.Show("Please select a class");
                    return;
                }
            }*/
                

               /* //get the attendance id
                string attendanceID = DataManagement.getAttendanceID();

                //get the students' attendance status
                for (int i = 0; i < dataGridViewTakeAttendance.Rows.Count; i++)
                {
                    string studentID = dataGridViewTakeAttendance.Rows[i].Cells[0].Value.ToString();
                    string status = dataGridViewTakeAttendance.Rows[i].Cells[2].Value.ToString();

                    //add the attendance status of the students to the attendance table
                    DataManagement.addAttendance(attendanceID, studentID, status, date, classID);
                }

                MessageBox.Show("Attendance has been saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!! please try again later");
            }*/
        }
    }
}

/*//save the attendance status of the students in the xml file into the attendance table with the current date
            //as the structure of attendance record in XML (userID, Name, Class, Date, Status)
            //the status is the attendance status of the student (true or false) represented as (present or absent) respectively
            try
            {
                XmlDataDocument xmlData = new XmlDataDocument();
                string xmlPath = DataManagement.xmlPath();
                xmlData.DataSet.ReadXml(xmlPath);

                //get the current date
                string date = DateTime.Now.ToString("dd/MM/yyyy");

                //get the students of the selected class
                DataView dv = new DataView(xmlData.DataSet.Tables["Student"]);
                dv.RowFilter = "ClassName = '" + ClassComboBox.Text + "'";
                DataTable dc = dv.ToTable(true, "UserID", "Name");

                //get the attendance table
                DataTable dt = xmlData.DataSet.Tables["Attendance"];
                Console.WriteLine(dt);

                //add the attendance status of the students to the attendance table
                foreach (DataRow row in dc.Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["UserID"] = row["UserID"];
                    dr["Name"] = row["Name"];
                    dr["Class"] = ClassComboBox.Text;
                    dr["Date"] = date;
                    dr["Status"] = dataGridViewTakeAttendance.Rows[dc.Rows.IndexOf(row)].Cells[2].Value;
                    dt.Rows.Add(dr);
                }

                //save the changes to the xml file
                xmlData.DataSet.WriteXml(xmlPath);
                MessageBox.Show("Attendance has been saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!! please try again later");
            }*/