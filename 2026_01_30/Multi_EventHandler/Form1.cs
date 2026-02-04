using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_EventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += new EventHandler(DisplayMessage);
            button1.Click += new EventHandler(ChangeColor);
        }

        private void DisplayMessage(object sender, EventArgs e)
        {
            MessageBox.Show("버튼이 클릭되었습니다!");
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            btn.BackColor = Color.Aqua;
        }
    }
}
