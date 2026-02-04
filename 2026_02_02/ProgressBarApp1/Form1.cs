using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = progressBar1.Maximum;
            progressBar1.MarqueeAnimationSpeed = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((progressBar1.Value + 10) < progressBar1.Maximum)
            {
                progressBar1.Value += 10;
            }
            else if ((progressBar1.Value + 10) >= progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Maximum;
            }
        }
    }
}
