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
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email=txtUserName.Text;
            string password=txtPassword.Text;

            User validator = (User)login.auth(email, password);
            Console.WriteLine(validator.ToString());

             if (validator == null )
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
                         //Close();


                         AdminFunctionalities form2 = new AdminFunctionalities();
                         form2.Show();
                         break;
                     case 'T':
                         MessageBox.Show("Login Successful as Teacher!");
                        // Close();
                        Teachers teachers = new Teachers();
                         teachers.Show();
                         break;
                     case 'S':
                         MessageBox.Show("Login Successful as Student!");
                         StudentForm studentForm = new StudentForm();    
                         studentForm.Show();
                         break;
                     default:
                         MessageBox.Show("Login Successful.");
                         break;


                 }
             }
        }
    }
}
