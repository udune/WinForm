using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedChanged
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            checkbutton.Enabled = false;
        }

        private void agreeCheck_Click(object sender, EventArgs e)
        {
            
        }

        private void agreeStateCheck_Click(object sender, EventArgs e)
        {
            if (checkBox.CheckState == CheckState.Checked)
            {
                checkbutton.Enabled = true;
                state_label.Text = "체크됨";
            }
            else if (checkBox.CheckState == CheckState.Unchecked)
            {
                checkbutton.Enabled = false;
                state_label.Text = "체크 해제됨";
            }
            else if (checkBox.CheckState == CheckState.Indeterminate)
            {
                checkbutton.Enabled = false;
                state_label.Text = "체크 상태 불명확";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = new List<string>();

            if (check_apple.Checked)
            {
                selectedItems.Add("사과");
            }

            if (check_banana.Checked)
            {
                selectedItems.Add("바나나");
            }

            if (check_orange.Checked)
            {
                selectedItems.Add("오렌지");
            }

            MessageBox.Show("선택한 과일: " + string.Join(", ", selectedItems));
        }
    }
}
