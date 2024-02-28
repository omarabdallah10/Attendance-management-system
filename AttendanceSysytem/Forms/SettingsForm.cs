using AttendanceSysytem.Classes;
using AttendanceSysytem.Users;
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
using System.Xml;

namespace AttendanceSysytem.Forms
{
    public partial class SettingsForm : Form
    {
        public User Recived { get; set; }
        public XmlDocument Document { get; set; }
        public XmlElement User { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Languages.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Font = Classes.Settings.MyFont;
            Document = DataManagement.xmlDoc();
            //Console.WriteLine(Recived.Name);
            string type = "Student";
            if (Recived.UserID[0] == 'T')
            {
                type = "Teacher";
            }
            else if (Recived.UserID[0] == 'A')
            {
                type = "Admin";

            }
            User = DataManagement.GetElementById(Document, Recived.UserID, type);

            XmlNode password = User.SelectSingleNode("Password");
            password_box.Text = password.InnerText;
        }


        private void font_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();

            Classes.Settings.ChangeFontForAllPages(font.Font);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            XmlNode password = User.SelectSingleNode("Password");
            if (password_box.Text != password.InnerText)
            {
                password.InnerText = password_box.Text;
                DataManagement.SaveXml(Document);
                MessageBox.Show("Password updated successfully");
            }
            else
            {
                MessageBox.Show("Password didn't change");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Languages.SelectedIndex == 0)
                Classes.Settings.SwitchLanguage("ar");
            else
                Classes.Settings.SwitchLanguage("en");
        }
        //*****************************************  Font Data  *****************************************

        public static Font MyFont = new Font("Times New Roman", 10f);

        public static void ChangeFont(Control control, Font font, bool changeChildren)
        {
            control.Font = font;
            if (changeChildren)
            {
                foreach (Control childControl in control.Controls)
                {
                    ChangeFont(childControl, font, changeChildren);
                }
            }
        }

        public static void ChangeFontForAllPages(Font font)
        {
            MyFont = font;
            foreach (Form form in Application.OpenForms)
            {
                // Change font for each form
                ChangeFont(form, font, true);
            }
        }



        //*****************************************  Language Data  *****************************************
        private static List<Form> openedForms = new List<Form>();

        public static void Initialize()
        {
            // Subscribe to Form.Load event for the existing forms
            foreach (Form form in Application.OpenForms)
            {
                AddForm(form);
            }

            FormOpened += (form) => AddForm(form);
            // Subscribe to FormOpened event to track new forms
        }

        public static void AddForm(Form form)
        {
            // Subscribe to Form.Load event for the new form
            form.Load += (sender, e) => UpdateUIControls((sender as Form).Controls);

            // Add the form to the list of opened forms
            openedForms.Add(form);
        }

        public static void SwitchLanguage(string languageCode)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(languageCode);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(languageCode);

            foreach (Form form in openedForms)
            {
                form.RightToLeft = RightToLeft.No;
                form.RightToLeftLayout = false;
                if (languageCode == "ar")
                {
                    form.RightToLeft = RightToLeft.Yes;
                    form.RightToLeftLayout = true;
                }
                UpdateUIControls(form.Controls);
            }
        }

        private static void UpdateUIControls(Control.ControlCollection controls)
        {
            // Iterate through all controls
            foreach (Control control in controls)
            {
                control.Font = MyFont;
                if (!string.IsNullOrEmpty(control.Text))
                {
                    control.Text = Properties.Resources.ResourceManager.GetString(control.Name);
                }

                // Recursively update controls if they have child controls
                if (control.Controls.Count > 0)
                {
                    UpdateUIControls(control.Controls);
                }
            }
        }

        public static event Action<Form> FormOpened;

        // Method to raise the FormOpened event
        public static void OnFormOpened(Form form)
        {
            FormOpened?.Invoke(form);
        }
    }
}
