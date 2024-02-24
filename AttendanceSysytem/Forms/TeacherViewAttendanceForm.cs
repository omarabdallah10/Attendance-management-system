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
    public partial class TeacherViewAttendanceForm : Form
    {
        public TeacherViewAttendanceForm()
        {
            InitializeComponent();
        }

        //load Data on form load
        private void TeacherViewAttendanceForm_Load(object sender, EventArgs e)
        {

            dataGridViewAttendance.AllowUserToAddRows = false;


            //load dates into DateComboBox from xml file
            XmlDataDocument xmlData = new XmlDataDocument();
            string xmlPath = DataManagement.xmlPath();
            xmlData.DataSet.ReadXml(xmlPath);

            DataView dv = new DataView(xmlData.DataSet.Tables["AttendanceRecord"]);
            DataTable dt = dv.ToTable(true, "Date");
            DateComboBox.DataSource = dt;
            DateComboBox.DisplayMember = "Date";

            

            
            // -- PD Track is selected by default
            TrackCompoBox.SelectedIndex = 0;
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
                dv.RowFilter = "Date = '" + DateComboBox.Text + "' AND ClassName = '" + TrackCompoBox.Text + "'";
                dataGridViewAttendance.DataSource = dv;

                //MessageBox.Show("Data Loaded Successfully!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(Text = ex.Message);
                MessageBox.Show("Sorry Something go wrong! \nPlease ry again later.");

            }

        }

       
    }
}
