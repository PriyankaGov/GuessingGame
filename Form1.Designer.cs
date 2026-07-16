namespace GuessingGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Label lblTitle;
        private Label lblQuestion;
        private Label lblCountry;
        private Label lblHint;
        private Label lblFeedback;
        private TextBox txtGuess;
        private Button btnGuess;
        private Button btnNewRound;
        private Label lblScoreCaption;
        private Label lblScore;
        private Label lblAttemptsCaption;
        private Label lblAttempts;
        private Label lblTimerCaption;
        private Label lblTimer;
        private Label lblLeaderboardCaption;
        private ListBox lstLeaderboard;
        private System.Windows.Forms.Timer roundTimer;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblQuestion = new Label();
            lblCountry = new Label();
            lblHint = new Label();
            lblFeedback = new Label();
            txtGuess = new TextBox();
            btnGuess = new Button();
            btnNewRound = new Button();
            lblScoreCaption = new Label();
            lblScore = new Label();
            lblAttemptsCaption = new Label();
            lblAttempts = new Label();
            lblTimerCaption = new Label();
            lblTimer = new Label();
            lblLeaderboardCaption = new Label();
            lstLeaderboard = new ListBox();
            roundTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();

            // lblTitle
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 60, 114);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Size = new Size(500, 40);
            lblTitle.Text = "🌍 Country Capital Guesser";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblQuestion
            lblQuestion.Font = new Font("Segoe UI", 11F);
            lblQuestion.Location = new Point(30, 80);
            lblQuestion.Size = new Size(500, 25);
            lblQuestion.Text = "What is the capital of:";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;

            // lblCountry
            lblCountry.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCountry.ForeColor = Color.FromArgb(220, 60, 30);
            lblCountry.Location = new Point(30, 108);
            lblCountry.Size = new Size(500, 45);
            lblCountry.Text = "Country";
            lblCountry.TextAlign = ContentAlignment.MiddleCenter;

            // lblHint
            lblHint.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblHint.ForeColor = Color.DimGray;
            lblHint.Location = new Point(30, 158);
            lblHint.Size = new Size(500, 25);
            lblHint.Text = "";
            lblHint.TextAlign = ContentAlignment.MiddleCenter;

            // txtGuess
            txtGuess.Font = new Font("Segoe UI", 12F);
            txtGuess.Location = new Point(80, 195);
            txtGuess.Size = new Size(280, 30);
            txtGuess.KeyDown += TxtGuess_KeyDown;

            // btnGuess
            btnGuess.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuess.BackColor = Color.FromArgb(30, 60, 114);
            btnGuess.ForeColor = Color.White;
            btnGuess.FlatStyle = FlatStyle.Flat;
            btnGuess.Location = new Point(370, 194);
            btnGuess.Size = new Size(90, 32);
            btnGuess.Text = "Guess";
            btnGuess.Click += BtnGuess_Click;

            // lblFeedback
            lblFeedback.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFeedback.Location = new Point(30, 235);
            lblFeedback.Size = new Size(500, 30);
            lblFeedback.Text = "";
            lblFeedback.TextAlign = ContentAlignment.MiddleCenter;

            // lblScoreCaption
            lblScoreCaption.Font = new Font("Segoe UI", 9F);
            lblScoreCaption.Location = new Point(30, 280);
            lblScoreCaption.Size = new Size(60, 20);
            lblScoreCaption.Text = "Score:";

            // lblScore
            lblScore.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblScore.Location = new Point(90, 280);
            lblScore.Size = new Size(80, 20);
            lblScore.Text = "0";

            // lblAttemptsCaption
            lblAttemptsCaption.Font = new Font("Segoe UI", 9F);
            lblAttemptsCaption.Location = new Point(200, 280);
            lblAttemptsCaption.Size = new Size(90, 20);
            lblAttemptsCaption.Text = "Guesses left:";

            // lblAttempts
            lblAttempts.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAttempts.Location = new Point(295, 280);
            lblAttempts.Size = new Size(40, 20);
            lblAttempts.Text = "5";

            // lblTimerCaption
            lblTimerCaption.Font = new Font("Segoe UI", 9F);
            lblTimerCaption.Location = new Point(350, 280);
            lblTimerCaption.Size = new Size(50, 20);
            lblTimerCaption.Text = "Time:";

            // lblTimer
            lblTimer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTimer.Location = new Point(400, 280);
            lblTimer.Size = new Size(70, 20);
            lblTimer.Text = "00:00";

            // btnNewRound
            btnNewRound.Font = new Font("Segoe UI", 9F);
            btnNewRound.Location = new Point(30, 315);
            btnNewRound.Size = new Size(150, 30);
            btnNewRound.Text = "New Round";
            btnNewRound.Click += BtnNewRound_Click;

            // lblLeaderboardCaption
            lblLeaderboardCaption.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLeaderboardCaption.Location = new Point(30, 360);
            lblLeaderboardCaption.Size = new Size(300, 25);
            lblLeaderboardCaption.Text = "🏆 Top 5 Rounds";

            // lstLeaderboard
            lstLeaderboard.Font = new Font("Consolas", 9.5F);
            lstLeaderboard.Location = new Point(30, 390);
            lstLeaderboard.Size = new Size(500, 110);

            // roundTimer
            roundTimer.Interval = 1000;
            roundTimer.Tick += RoundTimer_Tick;

            // Form1
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(562, 520);
            BackColor = Color.White;
            Controls.Add(lblTitle);
            Controls.Add(lblQuestion);
            Controls.Add(lblCountry);
            Controls.Add(lblHint);
            Controls.Add(txtGuess);
            Controls.Add(btnGuess);
            Controls.Add(lblFeedback);
            Controls.Add(lblScoreCaption);
            Controls.Add(lblScore);
            Controls.Add(lblAttemptsCaption);
            Controls.Add(lblAttempts);
            Controls.Add(lblTimerCaption);
            Controls.Add(lblTimer);
            Controls.Add(btnNewRound);
            Controls.Add(lblLeaderboardCaption);
            Controls.Add(lstLeaderboard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Country Capital Guesser";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
