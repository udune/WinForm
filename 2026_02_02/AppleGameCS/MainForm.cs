using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace AppleGameCS
{
    /// <summary>
    /// 사과 드래그 게임의 메인 폼.
    /// 10x10 보드에 사과(숫자)를 배치하고, 드래그로 선택한 사과들의 합이 10이면 제거하는 게임.
    /// </summary>
    public partial class MainForm : Form
    {
        private const int Rows = 10;       // 보드의 행 수
        private const int Cols = 10;       // 보드의 열 수
        private const int CellSize = 50;   // 각 셀의 픽셀 크기

        private Label[,] buttons = new Label[Rows, Cols]; // 각 셀에 대응하는 Label 컨트롤 배열
        private int[,] values = new int[Rows, Cols];      // 각 셀의 숫자 값 배열

        private Point dragStart;            // 드래그 시작 좌표
        private Rectangle selectionRect;    // 현재 드래그 선택 영역
        private bool isDragging = false;    // 드래그 중 여부

        private Image appleImage;           // 사과 이미지
        private WindowsMediaPlayer bgmPlayer; // BGM 재생용 플레이어
        private SoundPlayer sfxPlayer;      // 효과음 재생용 플레이어

        public MainForm()
        {
            InitializeComponent();

            // 사과 이미지 로드
            appleImage = Image.FromFile("apple.png");

            // BGM 설정 및 반복 재생
            bgmPlayer = new WindowsMediaPlayer();
            bgmPlayer.URL = "gar.wav";
            bgmPlayer.settings.setMode("loop", true);
            bgmPlayer.controls.play();

            // 패널 마우스 이벤트 등록 (드래그 선택 기능)
            panelBoard.MouseDown += Panel_MouseDown;
            panelBoard.MouseMove += Panel_MouseMove;
            panelBoard.MouseUp += Panel_MouseUp;
            panelBoard.Paint += Panel_Paint;
        }

        /// <summary>
        /// 폼 로드 시 보드를 초기화한다.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitBoard();
        }

        /// <summary>
        /// 10x10 보드를 생성하고 각 셀에 1~9 랜덤 숫자가 적힌 사과 Label을 배치한다.
        /// </summary>
        private void InitBoard()
        {
            var rand = new Random();
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {
                    int val = rand.Next(1, 10); // 1~9 사이 랜덤 숫자 생성
                    var lbl = new Label
                    {
                        Width = CellSize - 4,
                        Height = CellSize - 4,
                        Location = new Point(x * CellSize, y * CellSize),
                        Font = new Font("Arial", 14, FontStyle.Bold),
                        Text = val.ToString(),
                        BackColor = Color.Transparent,
                        Tag = new Point(x, y),   // 셀의 (열, 행) 좌표를 Tag에 저장
                        Image = new Bitmap(appleImage, new Size(CellSize + 20, CellSize + 20)),
                        ImageAlign = ContentAlignment.MiddleCenter,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    // Label 위에서 마우스 이벤트가 발생해도 패널 드래그가 동작하도록 이벤트 전달
                    lbl.MouseDown += Lbl_MouseDown;
                    lbl.MouseMove += Lbl_MouseMove;
                    lbl.MouseUp += Lbl_MouseUp;

                    buttons[y, x] = lbl;
                    values[y, x] = val;
                    panelBoard.Controls.Add(lbl);
                }
            }
        }

        /// <summary>
        /// Label 위에서 발생한 MouseDown을 패널 좌표로 변환하여 Panel_MouseDown에 전달한다.
        /// </summary>
        private void Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            var pt = panelBoard.PointToClient(((Control)sender).PointToScreen(e.Location));
            Panel_MouseDown(panelBoard, new MouseEventArgs(e.Button, e.Clicks, pt.X, pt.Y, e.Delta));
        }

        /// <summary>
        /// Label 위에서 발생한 MouseMove를 패널 좌표로 변환하여 Panel_MouseMove에 전달한다.
        /// </summary>
        private void Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            var pt = panelBoard.PointToClient(((Control)sender).PointToScreen(e.Location));
            Panel_MouseMove(panelBoard, new MouseEventArgs(e.Button, e.Clicks, pt.X, pt.Y, e.Delta));
        }

        /// <summary>
        /// Label 위에서 발생한 MouseUp을 패널 좌표로 변환하여 Panel_MouseUp에 전달한다.
        /// </summary>
        private void Lbl_MouseUp(object sender, MouseEventArgs e)
        {
            var pt = panelBoard.PointToClient(((Control)sender).PointToScreen(e.Location));
            Panel_MouseUp(panelBoard, new MouseEventArgs(e.Button, e.Clicks, pt.X, pt.Y, e.Delta));
        }

        /// <summary>
        /// 드래그 시작: 시작 좌표를 기록하고 선택 영역을 초기화한다.
        /// </summary>
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStart = e.Location;
            selectionRect = Rectangle.Empty;
        }

        /// <summary>
        /// 드래그 중: 시작 좌표와 현재 좌표로 선택 영역(사각형)을 갱신하고 패널을 다시 그린다.
        /// </summary>
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int x = Math.Min(e.X, dragStart.X);
                int y = Math.Min(e.Y, dragStart.Y);
                int width = Math.Abs(e.X - dragStart.X);
                int height = Math.Abs(e.Y - dragStart.Y);
                selectionRect = new Rectangle(x, y, width, height);
                panelBoard.Invalidate(); // 선택 영역 시각적 업데이트 요청
            }
        }

        /// <summary>
        /// 드래그 종료: 선택 영역과 겹치는 사과들의 합을 계산하여
        /// 합이 10이면 해당 사과들을 제거(애니메이션)하고, 아니면 실패 메시지를 표시한다.
        /// </summary>
        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;

            var selectedPoints = new List<Point>(); // 선택된 셀 좌표 목록
            int sum = 0; // 선택된 셀 값의 합

            // 보드 전체를 순회하며 선택 영역과 겹치는 셀을 찾는다
            for (int y = 0; y < Rows; y++)
                for (int x = 0; x < Cols; x++)
                {
                    var lbl = buttons[y, x];
                    if (lbl.Visible)
                    {
                        var rect = new Rectangle(lbl.Location, lbl.Size);
                        if (selectionRect.IntersectsWith(rect))
                        {
                            selectedPoints.Add(new Point(x, y));
                            sum += values[y, x];
                        }
                    }
                }

            // 합이 10이면 정답 처리
            if (sum == 10)
            {
                foreach (var pt in selectedPoints)
                    JumpAndFadeOut(buttons[pt.Y, pt.X]); // 각 사과에 제거 애니메이션 적용

                lblInfo.Text = "🎉 정답! 합이 10입니다!";
            }
            else
            {
                lblInfo.Text = $"선택한 합은 {sum}입니다. 다시 시도하세요.";
            }

            // 선택 영역 초기화 및 화면 갱신
            selectionRect = Rectangle.Empty;
            panelBoard.Invalidate();
        }

        /// <summary>
        /// 드래그 선택 영역을 빨간 점선 사각형과 반투명 배경으로 그린다.
        /// </summary>
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            if (!selectionRect.IsEmpty)
            {
                // 빨간 점선 테두리
                using (Pen pen = new Pen(Color.Red, 3))
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    e.Graphics.DrawRectangle(pen, selectionRect);
                }

                // 반투명 어두운 빨간색 채우기
                using (Brush brush = new SolidBrush(Color.FromArgb(80, Color.DarkRed)))
                {
                    e.Graphics.FillRectangle(brush, selectionRect);
                }
            }
        }

        /// <summary>
        /// 사과 Label에 점프+축소 애니메이션을 적용한 뒤 제거한다.
        /// 동시에 효과음을 재생한다.
        /// </summary>
        private void JumpAndFadeOut(Label lbl)
        {
            Timer timer = new Timer();
            int steps = 15;        // 총 애니메이션 프레임 수
            int currentStep = 0;   // 현재 프레임

            Point originalLocation = lbl.Location;
            Size originalSize = lbl.Size;

            // 효과음 재생
            var sfxPlayer = new SoundPlayer("pop.wav");
            sfxPlayer.Play();

            timer.Interval = 30; // 30ms 간격으로 프레임 갱신
            timer.Tick += delegate (object sender, EventArgs e)
            {
                OnJumpAndFadeTick(sender, e, lbl, timer, ref currentStep, steps, originalLocation, originalSize);
            };

            timer.Start();
        }

        /// <summary>
        /// 점프+축소 애니메이션의 한 프레임을 처리한다.
        /// 위로 포물선 이동 + 크기 축소 효과를 적용하고, 마지막 프레임에서 Label을 제거한다.
        /// </summary>
        private void OnJumpAndFadeTick(object sender, EventArgs e, Label lbl, Timer timer,
                                         ref int currentStep, int steps, Point originalLocation, Size originalSize)
        {
            currentStep++;

            // 위로 이동 (포물선: 처음엔 올라가고 점차 내려오는 궤적)
            int jumpOffset = -5 * currentStep + currentStep * currentStep / 5;
            lbl.Location = new Point(
                originalLocation.X,
                originalLocation.Y + jumpOffset
            );

            // 진행도에 따라 서서히 축소 (1.0 → 0.0)
            float scale = 1f - (float)currentStep / steps;
            lbl.Width = (int)(originalSize.Width * scale);
            lbl.Height = (int)(originalSize.Height * scale);

            // 축소되면서 가운데 정렬이 유지되도록 X좌표 보정
            lbl.Left = originalLocation.X + (originalSize.Width - lbl.Width) / 2;
            lbl.Top = lbl.Location.Y;

            // 마지막 프레임이면 타이머 중지 후 Label 제거
            if (currentStep >= steps)
            {
                timer.Stop();
                lbl.Visible = false;
                lbl.Dispose();
            }
        }

    }
}
