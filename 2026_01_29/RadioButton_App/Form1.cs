using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void result_button_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (rbtmale.Checked == true)
            {
                list.Add(rbtmale.Text);
            }

            if (rbtfemale.Checked == true)
            {
                list.Add(rbtfemale.Text);
            }

            if (rbtred.Checked == true)
            {
                list.Add(rbtred.Text);
            }

            if (rbtblue.Checked == true)
            {
                list.Add(rbtblue.Text);
            }

            MessageBox.Show(string.Join(", ", list), "선택 결과");
        }
    }
}
