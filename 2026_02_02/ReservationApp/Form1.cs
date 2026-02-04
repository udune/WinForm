using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            CountCombobox_Init();
        }

        private void CountCombobox_Init()
        {
            for (int i = 1; i <= 5; i++)
            {
                count_combobox.Items.Add(i + "명");
            }
            count_combobox.SelectedIndex = 0;
        }

        private void reservation_confirm_button_Click(object sender, EventArgs e)
        {
            string result = $"이름: {GetName()}\n" +
                $"예약일: {GetDate()}\n" +
                $"인원: {GetCount()}\n" +
                $"좌석 위치: {string.Join(", ", GetSeat())}\n" +
                $"요청 사항: {string.Join(", ", GetRequest())}";
            MessageBox.Show(result, "예약 확인");
        }

        private string GetName()
        {
            return name_textbox.Text;
        }

        private string GetDate()
        {
            DateTime dateValue = datetimepicker.Value;
            return dateValue.ToString("yyyy-MM-dd ddd");
        }

        private string GetCount()
        {
            return count_combobox.SelectedItem.ToString();
        }

        private List<string> GetSeat()
        {
            var radioButtons = new[] { window_rdbtn, hall_rdbtn, middle_rdbtn };
            return radioButtons
                .Where(rb => rb.Checked)
                .Select(rb => rb.Text)
                .ToList();
        }

        private List<string> GetRequest()
        {
            var checkBoxes = new[] { water_checkbox, consent_checkbox, silent_checkbox };
            return checkBoxes
                .Where(chk => chk.Checked)
                .Select(chk => chk.Text)
                .ToList();
        }
    }
}
