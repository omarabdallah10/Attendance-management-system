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
    public partial class ClassesForm : Form
    {
        public ClassesForm()
        {
            InitializeComponent();
        }

        private void StudentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow row = ClassesTable.Rows[e.RowIndex];
                
                // Now you can access cell values using column indexes or names

                string Classname = row.Cells["ClassName"].Value.ToString();
                string supervisor = row.Cells["Supervisor"].Value.ToString();
                string supervisorID= row.Cells["SupervisorID"].Value.ToString();
                MessageBox.Show(Classname + " " + supervisorID + " " + supervisor);
                Hide();
                EditClassForm form = new EditClassForm();
                form.Show();
            }
        }

        private void ClassesForm_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = DataManagement.xmlDoc();
            XmlNodeList MyClasses = xmlDoc.SelectNodes("//Class");
            foreach (XmlNode MyClass in MyClasses)
            {
                string _className = MyClass.SelectSingleNode("Name").InnerText; 
                string _supervisorID = MyClass.SelectSingleNode("Supervisor/UserID").InnerText; 
                string _supervisorName = DataManagement.getUserById(_supervisorID).Name;
                this.ClassesTable.Rows.Add(_className, _supervisorID, _supervisorName);
            }
        
        }
    }
}
