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





        }
        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Show the attendance of the selected track and date
            try
            {

                XmlDataDocument xmlData = new XmlDataDocument();
                string xmlPath = DataManagement.xmlPath();
                xmlData.DataSet.ReadXml(xmlPath);

                //view the matched track only
                DataView dv = new DataView(xmlData.DataSet.Tables["AttendanceRecord"]);
                dv.RowFilter = "ClassName = '" + classComboBox.Text + "'";
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
