using AttendanceSysytem.Classes;
using AttendanceSysytem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace AttendanceSysytem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
            InitializeComponent();
            Settings.ChangeFont(this, Settings.MyFont, true);
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUserName.Text;
            string password = txtPassword.Text;

            User validator = (User)login.isAdmin(email, password);

            if (validator == null)
            {
                MessageBox.Show("Login Failed. Please check your email and password.");
            }
            else
            {
                char type = validator.UserID[0];
                switch (type)
                {
                    case 'A':
                        MessageBox.Show("Login Successful as Admin!");
                        AdminFunctionalitiesForm adminForm = new AdminFunctionalitiesForm();
                        adminForm.recived = (Users.Admin)validator;
                        adminForm.Show();
                        Hide();
                        break;
                    case 'T':
                        MessageBox.Show("Login Successful as Teacher!");
                        teacherFunctionalitiesForm teachers = new teacherFunctionalitiesForm();
                        teachers.recived = (Users.Teacher)validator;
                        teachers.Show();
                        Hide();
                        break;
                    case 'S':
                        MessageBox.Show("Login Successful as Student!");
                        StudentForm studentForm = new StudentForm();
                        studentForm.recived = (Users.Student)validator;
                        studentForm.Show();
                        Hide();
                        break;
                    default:
                        MessageBox.Show("Try again something went wrong");
                        break;
                }
            }
        }
        private void loginForm_Load(object sender, EventArgs e)
        {
            CultureInfo[] a = CultureInfo.GetCultures(CultureTypes.AllCultures);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
