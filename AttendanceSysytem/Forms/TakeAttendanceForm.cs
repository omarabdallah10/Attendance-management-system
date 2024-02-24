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
            DataManagement.ChangeFont(this, DataManagement.MyFont, true);
        }


        
        private void TakeAttendanceForm_Load(object sender, EventArgs e)
        {
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
                checkColumn.Width = 100;
                checkColumn.ReadOnly = false;
                
                /*checkColumn.TrueValue = true;
                checkColumn.FalseValue = false;*/
                dataGridViewTakeAttendance.Columns.Add(checkColumn);

                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!! please try again later");
            }


        }
    }
}