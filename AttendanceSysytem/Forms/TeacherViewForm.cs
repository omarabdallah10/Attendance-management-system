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
    public partial class TeacherViewForm : Form
    {
        public TeacherViewForm()
        {
            InitializeComponent();
        }

        private void btnShowAttendance_Click(object sender, EventArgs e)
        {
            try
            {

                XmlDataDocument xmlData = new XmlDataDocument();
                xmlData.DataSet.ReadXml("D:\\ITI-9 Month\\11-C#\\Repo\\Attendance-management-system\\xml\\ProjectSchema.xml");
                dataGridView1.DataSource = xmlData.DataSet;
                dataGridView1.DataMember = "AttendanceRecord";

                MessageBox.Show("Data Loaded Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text = ex.Message);
            }
        }
    }
}
