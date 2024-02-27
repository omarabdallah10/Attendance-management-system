using AttendanceSysytem.Classes;
using AttendanceSysytem.Forms;
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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            DataManagement.ChangeFont(this, DataManagement.MyFont, true);
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
                        AdminDashboard adminForm = new AdminDashboard();
                        adminForm.recived =validator;
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
                Console.WriteLine(validator);
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
