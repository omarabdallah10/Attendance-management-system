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
           string validator= login.isAdmin(email, password);
            if(validator == null )
            {
                MessageBox.Show("Login Failed. Please check your email and password.");
            }
            else
            {
                char type = validator[0];
                switch (type)
                {
                    case 'A':
                        MessageBox.Show("Login Successful as Admin!");
                        //Close();

                        
                        //Form2 form2 = new Form2();
                        //form2.Show();
                        break;
                    case 'T':
                        MessageBox.Show("Login Successful as Teacher!");
                        break;
                    case 'S':
                        MessageBox.Show("Login Successful as Student!");
                        break;
                    default:
                        MessageBox.Show("Login Successful.");
                        break;


                }
            }
        }
    }
}
