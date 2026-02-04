using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btn_button3.Click += new EventHandler(btn_button3_Click);
        }

        private void btn_button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼이 클릭되었습니다.");
        }

        private void btn_button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이벤트 핸들러로 처리된 버튼 클릭입니다.");
        }

        private void btn_button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("디자이너에서 처리된 버튼 클릭입니다.");
        }
    }
}
