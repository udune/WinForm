using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_App
{
    class Fruit
    {
        public string Name { get; set; }
        public string Color { get; set; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            List<Fruit> fruits = new List<Fruit>()
            {
                new Fruit() { Name = "사과", Color = "Red" },
                new Fruit() { Name = "바나나", Color = "Yellow" },
                new Fruit() { Name = "포도", Color = "Purple" }
            };

            cbbox.DataSource = fruits;
            cbbox.DisplayMember = "Name";
            cbbox.ValueMember = "Color";

            cbbox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultstr = $"선택된 과일: {cbbox.Text}, 색상: {cbbox.SelectedValue.ToString()}";
            MessageBox.Show(resultstr);
        }
    }
}
