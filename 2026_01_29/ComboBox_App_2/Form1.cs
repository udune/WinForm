using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_App_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            cbbox.Items.Add("사과");
            cbbox.Items.Add("바나나");
            cbbox.Items.Add("포도");

            cbbox.SelectedIndex = 0;
        }

        private void cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb.Text = $"선택된 과일 : {cbbox.SelectedItem.ToString()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"선택된 과일은 {cbbox.SelectedItem.ToString()}");
        }
    }
}
