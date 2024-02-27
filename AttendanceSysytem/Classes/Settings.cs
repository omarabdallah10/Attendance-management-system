using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;
using System.Threading;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using AttendanceSysytem.Forms;

namespace AttendanceSysytem.Classes
{
    internal class Settings
    {
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
