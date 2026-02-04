using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            role_combobox.Items.Add("학생");
            role_combobox.Items.Add("교사");
            role_combobox.SelectedIndex = 0;
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            string name = name_textbox.Text;
            string age = age_textbox.Text;
            string role = role_combobox.Text;
            string major = major_textbox.Text;

            Person person = null;

            if (role == "학생")
            {
                person = new Student
                {
                    Name = name,
                    Age = int.Parse(age),
                    Major = major
                };
            }
            else if (role == "교사")
            {
                person = new Teacher
                {
                    Name = name,
                    Age = int.Parse(age),
                    Major = major
                };
            }

            output_listbox.Items.Add(person.GetInfo());
        }
    }
}
