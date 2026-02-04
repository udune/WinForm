using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBox_App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_OutputText_Click(object sender, EventArgs e)
        {
            input_label.Text = input_TextBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string input_string = input_TextBox2.Text;
            Console.WriteLine($"입력값 {input_string}");

            MessageBox.Show("입력값 " + input_string);
        }
    }
}
