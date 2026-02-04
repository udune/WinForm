using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDictionaryApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> orderDic = new Dictionary<string, int>()
        {
            {"햄버거", 5000 },
            {"피자", 8000 },
            {"치킨", 12000 },
            {"떡볶이", 3000 }
        };

        public Form1()
        {
            InitializeComponent();

            menu_combobox.Items.AddRange(orderDic.Keys.ToArray());
            menu_combobox.SelectedIndex = 0;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string selectedItem = menu_combobox.SelectedItem.ToString();
            int price = orderDic[selectedItem];
            result_listbox.Items.Add($"{selectedItem} - {price}원");
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (var item in result_listbox.Items)
            {
                string[] parts = item.ToString().Split('-');
                int price = int.Parse(parts[1].Replace("원", "").Trim());
                total += price;
            }
            MessageBox.Show($"총 주문 금액: {total}원");
        }
    }
}
