using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordQuizApp1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> wordDict;
        private List<string> keys;
        private int currentIdx = 0;

        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            wordDict = new Dictionary<string, string>()
            {
                { "학교", "school" },
                { "자동차", "car" },
                { "사과", "apple" },
                { "책", "book" }
            };

            keys = wordDict.Keys
                .OrderBy(x => rand.Next())
                .ToList();

            ShowQuiz();

            this.AcceptButton = save_button;
        }

        private void ShowQuiz()
        {
            if (currentIdx < keys.Count)
            {
                quiz_label.Text = keys[currentIdx];
                answer_textbox.Clear();
                answer_textbox.Focus();
            }
            else
            {
                quiz_label.Text = "종료";

                DialogResult result = MessageBox.Show(
                    "모든 문제를 다 풀었습니다! 다시 시작하시겠습니까?",
                    "퀴즈 종료",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                 );

                if (result == DialogResult.Yes)
                {
                    ResetQuiz();
                }
                else
                {
                    answer_textbox.Enabled = false;
                    save_button.Enabled = false;
                }
            }
        }

        private void ResetQuiz()
        {
            currentIdx = 0;
            result_listbox.Items.Clear();
            answer_textbox.Enabled = true;
            save_button.Enabled = true;

            keys = wordDict.Keys.OrderBy(x => rand.Next()).ToList();

            ShowQuiz();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (currentIdx >= keys.Count)
            {
                return;
            }

            string currentKorean = keys[currentIdx];
            string correctAnswer = wordDict[currentKorean];
            string userAnswer = answer_textbox.Text.Trim().ToLower();

            if (userAnswer == correctAnswer.ToLower())
            {
                result_listbox.Items.Add($"[정답] {currentKorean}");
            }
            else
            {
                result_listbox.Items.Add($"[오답] {currentKorean}");
            }

            result_listbox.SelectedIndex = result_listbox.Items.Count - 1;

            currentIdx++;
            ShowQuiz();
        }
    }
}
