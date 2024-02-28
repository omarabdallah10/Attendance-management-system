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
using AttendanceSysytem.UserControls;
using AttendanceSysytem.Users;

namespace AttendanceSysytem.Forms
{

    public partial class AdminDashboard : Form
    {
        public User recived { get; set; }
        public AdminDashboard()
        {
            InitializeComponent();
            Settings.ChangeFont(this, Settings.MyFont, true);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = recived.Name;
            labelRole.Text = "Admin";


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateandTime.Text = DateTime.Now.ToString("f");
            timer1.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            AddStudent addStudentControl = new AddStudent();
            panel3.Controls.Add(addStudentControl);
            panel3.BringToFront();

        }
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            AddTeacher addTeacherControl = new AddTeacher();
            panel3.Controls.Add(addTeacherControl);
            panel3.BringToFront();

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            AddClass addTeacherControl = new AddClass();
            panel3.Controls.Add(addTeacherControl);
            panel3.BringToFront();

        }

        private void btnEditUsers_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Edit addTeacherControl = new Edit();
            panel3.Controls.Add(addTeacherControl);
            panel3.BringToFront();
            Dock = DockStyle.Fill;

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            SettingsControl settingsControl = new SettingsControl();
            settingsControl.Recived = recived;
            panel3.Controls.Add(settingsControl);
            panel3.BringToFront();
            Dock = DockStyle.Fill;

        }

        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            ViewAttendance viewAttendanceControl = new ViewAttendance();
            panel3.Controls.Add(viewAttendanceControl);
            panel3.BringToFront();
            Dock = DockStyle.Fill;

            
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BringToFront();
        }

        
    }
}


/*
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
            TrackCompoBox.SelectedIndex = 0;
            // -- last index of combobox is selected
            DateComboBox.SelectedIndex = DateComboBox.Items.Count - 1;


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
 */