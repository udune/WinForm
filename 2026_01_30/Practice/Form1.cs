using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button2.Click += new EventHandler(button2_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = input_textbox.Text;
            MessageBox.Show("버튼 1을 클릭하셨습니다!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = input_textbox.Text;
            MessageBox.Show("버튼 2를 클릭하셨습니다!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = input_textbox.Text;
            MessageBox.Show("버튼 3을 클릭하셨습니다!");
        }
    }
}
