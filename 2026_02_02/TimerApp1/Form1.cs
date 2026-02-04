using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp1
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            stop_btn.Enabled = false;
            reset_btn.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            count += 1;
            TimeSpan ts = TimeSpan.FromSeconds(count);

            string result = $"{ts.Hours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}";

            timer_label.Text = result;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            stop_btn.Enabled = true;
            reset_btn.Enabled = true;
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stop_btn.Enabled = false;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            count = 0;
            timer_label.Text = "00:00:00";
            stop_btn.Enabled = false;
            reset_btn.Enabled = false;
        }
    }
}
