using AttendanceSysytem.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSysytem
{ 
    public partial class teacherFunctionalitiesForm : Form
    {
        public Teacher recived { get; set; }
        public teacherFunctionalitiesForm()
        {
            InitializeComponent();
        }

        private void btnTakeAttendance_Click(object sender, EventArgs e)
        {

        }
    }
}
