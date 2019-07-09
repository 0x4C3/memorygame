namespace MemoryGame
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.floBlockPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.labScore = new System.Windows.Forms.Label();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.labTime = new System.Windows.Forms.Label();
            this.labTimer = new System.Windows.Forms.Label();
            this.labScorer = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReStart = new System.Windows.Forms.Button();
            this.panelScor = new System.Windows.Forms.Panel();
            this.floTimerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labGameEndScore = new System.Windows.Forms.Label();
            this.labGameEndTime = new System.Windows.Forms.Label();
            this.panelTimer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelScor.SuspendLayout();
            this.floTimerPanel.SuspendLayout();
            this.panelGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // floBlockPanel
            // 
            this.floBlockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floBlockPanel.Location = new System.Drawing.Point(5, 5);
            this.floBlockPanel.Name = "floBlockPanel";
            this.floBlockPanel.Padding = new System.Windows.Forms.Padding(8);
            this.floBlockPanel.Size = new System.Drawing.Size(259, 307);
            this.floBlockPanel.TabIndex = 0;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartGame.Location = new System.Drawing.Point(4, 4);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(115, 46);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labScore.Location = new System.Drawing.Point(58, 10);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(22, 23);
            this.labScore.TabIndex = 2;
            this.labScore.Text = "0";
            // 
            // panelTimer
            // 
            this.panelTimer.Controls.Add(this.labTime);
            this.panelTimer.Controls.Add(this.labTimer);
            this.panelTimer.Location = new System.Drawing.Point(4, 4);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelTimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelTimer.Size = new System.Drawing.Size(115, 62);
            this.panelTimer.TabIndex = 3;
            this.panelTimer.Visible = false;
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.labTime.Location = new System.Drawing.Point(14, 29);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(0, 23);
            this.labTime.TabIndex = 3;
            // 
            // labTimer
            // 
            this.labTimer.AutoSize = true;
            this.labTimer.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labTimer.Location = new System.Drawing.Point(14, 10);
            this.labTimer.Name = "labTimer";
            this.labTimer.Size = new System.Drawing.Size(100, 18);
            this.labTimer.TabIndex = 4;
            this.labTimer.Text = "Elapsed Time:";
            // 
            // labScorer
            // 
            this.labScorer.AutoSize = true;
            this.labScorer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labScorer.Location = new System.Drawing.Point(14, 12);
            this.labScorer.Name = "labScorer";
            this.labScorer.Size = new System.Drawing.Size(49, 18);
            this.labScorer.TabIndex = 4;
            this.labScorer.Text = "Score:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnStartGame);
            this.flowLayoutPanel1.Controls.Add(this.btnReStart);
            this.flowLayoutPanel1.Controls.Add(this.panelScor);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(270, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(124, 160);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnReStart
            // 
            this.btnReStart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReStart.Location = new System.Drawing.Point(4, 56);
            this.btnReStart.Name = "btnReStart";
            this.btnReStart.Size = new System.Drawing.Size(115, 46);
            this.btnReStart.TabIndex = 1;
            this.btnReStart.Text = "Restart Game";
            this.btnReStart.UseVisualStyleBackColor = true;
            this.btnReStart.Visible = false;
            this.btnReStart.Click += new System.EventHandler(this.BtnReStart_Click);
            // 
            // panelScor
            // 
            this.panelScor.Controls.Add(this.labScorer);
            this.panelScor.Controls.Add(this.labScore);
            this.panelScor.Location = new System.Drawing.Point(4, 108);
            this.panelScor.Name = "panelScor";
            this.panelScor.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelScor.Size = new System.Drawing.Size(118, 46);
            this.panelScor.TabIndex = 5;
            this.panelScor.Visible = false;
            // 
            // floTimerPanel
            // 
            this.floTimerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.floTimerPanel.Controls.Add(this.panelTimer);
            this.floTimerPanel.Controls.Add(this.panelGameOver);
            this.floTimerPanel.Location = new System.Drawing.Point(270, 242);
            this.floTimerPanel.Name = "floTimerPanel";
            this.floTimerPanel.Padding = new System.Windows.Forms.Padding(1);
            this.floTimerPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.floTimerPanel.Size = new System.Drawing.Size(124, 70);
            this.floTimerPanel.TabIndex = 5;
            // 
            // panelGameOver
            // 
            this.panelGameOver.Controls.Add(this.labGameEndTime);
            this.panelGameOver.Controls.Add(this.labGameEndScore);
            this.panelGameOver.Controls.Add(this.label2);
            this.panelGameOver.Location = new System.Drawing.Point(4, 72);
            this.panelGameOver.Name = "panelGameOver";
            this.panelGameOver.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelGameOver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelGameOver.Size = new System.Drawing.Size(115, 62);
            this.panelGameOver.TabIndex = 3;
            this.panelGameOver.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Game Over!";
            // 
            // labGameEndScore
            // 
            this.labGameEndScore.AutoSize = true;
            this.labGameEndScore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labGameEndScore.Location = new System.Drawing.Point(3, 20);
            this.labGameEndScore.Name = "labGameEndScore";
            this.labGameEndScore.Size = new System.Drawing.Size(62, 13);
            this.labGameEndScore.TabIndex = 4;
            this.labGameEndScore.Text = "Your score:";
            // 
            // labGameEndTime
            // 
            this.labGameEndTime.AutoSize = true;
            this.labGameEndTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labGameEndTime.Location = new System.Drawing.Point(3, 33);
            this.labGameEndTime.Name = "labGameEndTime";
            this.labGameEndTime.Size = new System.Drawing.Size(59, 13);
            this.labGameEndTime.TabIndex = 4;
            this.labGameEndTime.Text = "Your time: ";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 320);
            this.Controls.Add(this.floTimerPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.floBlockPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelScor.ResumeLayout(false);
            this.panelScor.PerformLayout();
            this.floTimerPanel.ResumeLayout(false);
            this.panelGameOver.ResumeLayout(false);
            this.panelGameOver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel floBlockPanel;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Label labScorer;
        private System.Windows.Forms.Label labTimer;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelScor;
        private System.Windows.Forms.FlowLayoutPanel floTimerPanel;
        private System.Windows.Forms.Button btnReStart;
        private System.Windows.Forms.Panel panelGameOver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labGameEndTime;
        private System.Windows.Forms.Label labGameEndScore;
    }
}

