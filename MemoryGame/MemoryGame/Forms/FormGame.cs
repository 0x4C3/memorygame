using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();

        }
        Game game;
        Stopwatch timer;
        private void Game_OnBlockCreated(Block block)
        {
            floBlockPanel.Controls.Add(block);
        }

        private void Game_OnScoreChanged(int score)
        {
            this.Invoke((Action)(() => labScore.Text = score.ToString()));
        }

        private void Game_OnGameOver()
        {
            timer.Stop();
            this.Invoke((Action)(() =>
            {
                btnStartGame.Visible = true;
                panelTimer.Visible = false;
                panelScor.Visible = false;
                btnReStart.Visible = false;
                panelGameOver.Visible = true;
                labGameEndScore.Text = $"Your score: { labScore.Text }";
                labGameEndTime.Text = $"Your time:{ timer.Elapsed.ToString("hh\\:mm\\:ss") }";
            }));          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResizeFormWithDif(Difficulty.Beginner);
            game = new Game(Difficulty.Beginner);
            game.GameOver += Game_OnGameOver;
            game.ScoreChanged += Game_OnScoreChanged;
            game.BlockCreated += Game_OnBlockCreated;
            game.CreateBlocks();
            floBlockPanel.Enabled = false;
        }

        private void Timer()
        {
            timer = new Stopwatch();
            timer.Start();
            new Thread(() =>
            {
                try
                {
                    while (timer == null || timer.IsRunning)
                    {
                        this.Invoke((Action)(() => labTime.Text = timer.Elapsed.ToString("hh\\:mm\\:ss")));
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception)
                {
                }
            })
            {
                IsBackground = true
            }.Start();
        }
        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            using (var form = new FormInput())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    floBlockPanel.Enabled = true;
                    floBlockPanel.Controls.Clear();
                    labScore.Text = "0";
                    Timer();
                    ResizeFormWithDif(form.Dif);
                    game = new Game(form.Dif);
                    game.GameOver += Game_OnGameOver;
                    game.ScoreChanged += Game_OnScoreChanged;
                    game.BlockCreated += Game_OnBlockCreated;
                    game.CreateBlocks();
                    btnStartGame.Visible = false;
                    panelTimer.Visible = true;
                    panelScor.Visible = true;
                    btnReStart.Visible = true;
                    panelGameOver.Visible = false;
                }
            }

        }

        private void ResizeFormWithDif(Difficulty dif)
        {
            switch (dif)
            {
                case Difficulty.Beginner:
                    this.Size = new Size(482, 317);
                    break;
                case Difficulty.Easy:
                    this.Size = new Size(585, 317);
                    break;
                case Difficulty.Normal:
                    this.Size = new Size(687, 367);
                    break;
                case Difficulty.Hard:
                    this.Size = new Size(787, 469);
                    break;
                case Difficulty.VeryHard:
                    this.Size = new Size(890, 777);
                    break;
            }
        }

        private void BtnReStart_Click(object sender, EventArgs e)
        {
            btnReStart.Visible = false;
            timer.Stop();
            btnStartGame.Visible = true;
            btnStartGame.PerformClick();
        }
    }
}
