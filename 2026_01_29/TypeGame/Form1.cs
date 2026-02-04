using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TypeGame
{
    public partial class Form1 : Form
    {
        private readonly string[] sentences =
        {
            "안녕하세요",
            "C#은 재미 있네요",
            "타이핑을 얼마나 빠르게 할 수 있을까요",
            "WinForms은 신나는데요",
            "계속 코딩 합시다",
            "연습만이 살길이다"
        };

        private Random random = new Random();
        private Timer timer = new Timer { Interval = 1000 };

        private int remainTime;
        private int currentScore;
        private string currentText;
        private int bestTime = int.MaxValue;
        private int totalLength;
        private int typeCount;
        private bool isPause;

        private Stopwatch stopWatch = new Stopwatch();
        private bool isTypeStart = false;

        public Form1()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            input_textbox.KeyDown += TxtInput_KeyDown;
        }

        private string GetRandomSentence()
        {
            return sentences[random.Next(sentences.Length)];
        }

        private void StartNewRound()
        {
            remainTime = 30;
            remaintime_label.Text = $"{remainTime}초";
            example_label.Text = GetRandomSentence();
            input_textbox.Text = "";
            input_textbox.Focus();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            input_textbox.Enabled = true;
            currentScore = 0;
            score_value_label.Text = "0점";
            besttime_value_label.Text = "-";

            StartNewRound();
            timer.Start();
            stopWatch.Restart();
            start_button.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            remainTime--;
            remaintime_label.Text = $"{remainTime}초";

            if (remainTime <= 0)
            {
                GameOver();
            }
        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            if (input_textbox.Text != example_label.Text)
            {
                return;
            }

            int elapsed = 30 - remainTime;
            if (elapsed > 0 && elapsed < bestTime)
            {
                bestTime = elapsed;
                besttime_value_label.Text = $"{bestTime}초";
                currentScore++; // 추가점수
            }

            totalLength += input_textbox.Text.Length;

            currentScore++;
            score_value_label.Text = $"{currentScore}점";

            StartNewRound();
        }

        private void GameOver(bool isStop = false)
        {
            timer.Stop();
            start_button.Enabled = true;
            score_value_label.Text = "0점";
            remaintime_label.Text = "30초";
            besttime_value_label.Text = "-";

            if (isStop)
            {
                MessageBox.Show($"최종 점수: {currentScore}점", "게임 종료");
            }
            else
            {
                MessageBox.Show($"시간 초과! 최종 점수: {currentScore}점", "게임 종료");
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            GameOver(true);
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void GamePause()
        {
            if (isPause)
            {
                timer.Start();
                pause_button.Text = "일시정지";
                input_textbox.Enabled = true;
                isPause = false;
            }
            else
            {
                timer.Stop();
                pause_button.Text = "다시시작";
                input_textbox.Enabled = false;
                isPause = true;   
            }
        }

        private void input_textbox_TextChanged(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning && stopWatch.Elapsed.TotalSeconds > 0)
            {
                double elapsed = stopWatch.Elapsed.TotalSeconds;
                int currentTotal = totalLength + input_textbox.Text.Length;

                typeCount = (int)((currentTotal / elapsed) * 60);
                typeCount_value_label.Text = typeCount.ToString();
            }
        }
    }
}
