using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            listbox.Items.Add(input_txtbox.Text);
            input_txtbox.Clear();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            while(listbox.SelectedItems.Count > 0)
            {
                listbox.Items.Remove(listbox.SelectedItems[0]);
            }
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            if (listbox.SelectedItems.Count <= 0)
            {
                MessageBox.Show("선택된 항목이 없습니다.");
                return;
            }

            string resultstr = "";
            foreach (var item in listbox.SelectedItems)
            { 
                resultstr += $"{item.ToString()}, ";
            }

            MessageBox.Show(resultstr);
        }
    }
}
