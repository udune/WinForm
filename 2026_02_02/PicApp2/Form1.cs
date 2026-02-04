using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            
            comboBox1.Items.Add("AutoSize");
            comboBox1.Items.Add("CenterImage");
            comboBox1.Items.Add("Normal");
            comboBox1.Items.Add("StretchImage");
            comboBox1.SelectedIndex = 0;
        }

        private void image_load_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                MessageBox.Show(ofd.FileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 1:
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 2:
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case 3:
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }
    }
}
