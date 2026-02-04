using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MessageBox.Show(
                "파일을 저장하시겠습니까?", "저장 확인",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
             );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "파일을 저장하시겠습니까?", "저장 확인",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
             );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Yes 버튼을 클릭했습니다.");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("No 버튼을 클릭했습니다.");
            }
        }
    }
}
