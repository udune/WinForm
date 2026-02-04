using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CheckBox_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            next_button.Enabled = false;
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = new List<string>();

            if (reading_check.Checked)
            {
                selectedItems.Add("독서");
            }

            if (health_check.Checked)
            {
                selectedItems.Add("운동");
            }

            if (game_check.Checked)
            {
                selectedItems.Add("게임");
            }

            MessageBox.Show("선택한 취미: " + string.Join(", ", selectedItems));
        }

        private void agree_check(object sender, EventArgs e)
        {
            if (check_agree.Checked)
            {
                next_button.Enabled = true;
            }
            else
            {
                next_button.Enabled = false;
            }
        }

        private void agree_state_check(object sender, EventArgs e)
        {
            bool isChecked = state_check.CheckState == CheckState.Checked;
            next_button.Enabled = isChecked;

            switch (state_check.CheckState)
            {
                case CheckState.Checked:
                    current_state.Text = "현재 상태: 체크됨";
                    break;
                case CheckState.Unchecked:
                    current_state.Text = "현재 상태: 체크 해제됨";
                    break;
                case CheckState.Indeterminate:
                    current_state.Text = "현재 상태: 체크 상태 불명확";
                    break;
            }
        }
    }
}
