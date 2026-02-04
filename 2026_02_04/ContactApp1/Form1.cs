using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApp1
{
    public partial class Form1 : Form
    {
        List<Contact> contactList;

        public Form1()
        {
            InitializeComponent();

            contactList = new List<Contact>();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string name = name_textbox.Text;
            string phone = phonebook_textbox.Text;

            Contact newContact = new Contact();
            newContact.Name = name;
            newContact.PhoneNumber = phone;

            result_listbox.Items.Add(newContact);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ContactFileReadWrite.SaveContactList(contactList, filePath);
            }
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                List<Contact> contactList = ContactFileReadWrite.LoadContactList(filePath);
                if (contactList.Count > 0)
                {
                    result_listbox.Items.Clear();

                    foreach (Contact contact in contactList)
                    {
                        result_listbox.Items.Add(contact.ToString());
                    }
                }
            }
        }
    }
}
