namespace GuessingGame
{
    public partial class Form1 : Form
    {
        // ---- 2D array: [row, 0] = country, [row, 1] = capital ----
        private readonly string[,] countryCapitals = new string[,]
        {
            { "France", "Paris" },
            { "Japan", "Tokyo" },
            { "Egypt", "Cairo" },
            { "Australia", "Canberra" },
            { "Brazil", "Brasilia" },
            { "Canada", "Ottawa" },
            { "South Africa", "Pretoria" },
            { "Germany", "Berlin" },
            { "India", "New Delhi" },
            { "Italy", "Rome" },
            { "Kenya", "Nairobi" },
            { "Mexico", "Mexico City" },
            { "Norway", "Oslo" },
            { "Russia", "Moscow" },
            { "Spain", "Madrid" },
            { "Thailand", "Bangkok" },
            { "Turkey", "Ankara" },
            { "Argentina", "Buenos Aires" },
            { "Greece", "Athens" },
            { "Portugal", "Lisbon" }
        };

        // Leaderboard storage: a List<T> of completed rounds (top 5 kept & shown)
        private readonly List<LeaderboardEntry> leaderboard = new();

        private const int MaxAttempts = 5;
        private const int CorrectPoints = 10;
        private const int WrongPenalty = 1;

        private readonly Random rng = new();
        private int currentIndex;
        private int attemptsLeft;
        private int score;
        private int lettersRevealed;
        private DateTime roundStart;

        public Form1()
        {
            InitializeComponent();
            StartNewRound();
        }

        private void StartNewRound()
        {
            currentIndex = rng.Next(countryCapitals.GetLength(0)); // pick random row
            attemptsLeft = MaxAttempts;
            lettersRevealed = 0;

            lblCountry.Text = countryCapitals[currentIndex, 0];
            lblHint.Text = "";
            lblFeedback.Text = "";
            lblFeedback.ForeColor = Color.Black;
            lblAttempts.Text = attemptsLeft.ToString();
            lblScore.Text = score.ToString();
            txtGuess.Text = "";
            txtGuess.Enabled = true;
            btnGuess.Enabled = true;
            txtGuess.Focus();

            roundStart = DateTime.Now;
            lblTimer.Text = "00:00";
            roundTimer.Start();
        }

        private void RoundTimer_Tick(object? sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - roundStart;
            lblTimer.Text = elapsed.ToString(@"mm\:ss");
        }

        private void TxtGuess_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnGuess_Click(sender, e);
            }
        }

        private void BtnGuess_Click(object? sender, EventArgs e)
        {
            string answer = countryCapitals[currentIndex, 1];
            string guess = txtGuess.Text.Trim();

            if (string.IsNullOrWhiteSpace(guess))
            {
                lblFeedback.ForeColor = Color.DarkOrange;
                lblFeedback.Text = "Type a guess first!";
                return;
            }

            if (string.Equals(guess, answer, StringComparison.OrdinalIgnoreCase))
            {
                score += CorrectPoints;
                lblScore.Text = score.ToString();
                lblFeedback.ForeColor = Color.Green;
                lblFeedback.Text = $"✅ Correct! {answer} (+{CorrectPoints} pts)";
                EndRound(won: true);
            }
            else
            {
                score -= WrongPenalty;
                attemptsLeft--;
                lblScore.Text = score.ToString();
                lblAttempts.Text = attemptsLeft.ToString();

                if (attemptsLeft <= 0)
                {
                    lblFeedback.ForeColor = Color.Red;
                    lblFeedback.Text = $"❌ Out of guesses! It was {answer}.";
                    EndRound(won: false);
                }
                else
                {
                    lettersRevealed++;
                    string hintText = answer.Substring(0, Math.Min(lettersRevealed, answer.Length));
                    lblHint.Text = $"Hint: starts with \"{hintText}\"";
                    lblFeedback.ForeColor = Color.Red;
                    lblFeedback.Text = $"❌ Wrong guess. ({WrongPenalty} pt) {attemptsLeft} left.";
                }
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }

        private void EndRound(bool won)
        {
            roundTimer.Stop();
            txtGuess.Enabled = false;
            btnGuess.Enabled = false;

            TimeSpan elapsed = DateTime.Now - roundStart;

            leaderboard.Add(new LeaderboardEntry
            {
                Country = countryCapitals[currentIndex, 0],
                Score = won ? CorrectPoints : 0,
                TimeTaken = elapsed,
                PlayedAt = DateTime.Now
            });

            RefreshLeaderboard();
        }

        private void RefreshLeaderboard()
        {
            // Sort by score descending, then by fastest time; keep top 5
            var top5 = leaderboard
                .OrderByDescending(entry => entry.Score)
                .ThenBy(entry => entry.TimeTaken)
                .Take(5)
                .ToList();

            lstLeaderboard.Items.Clear();
            for (int i = 0; i < top5.Count; i++)
            {
                lstLeaderboard.Items.Add($"{i + 1}. {top5[i]}");
            }
        }

        private void BtnNewRound_Click(object? sender, EventArgs e)
        {
            StartNewRound();
        }
    }
}
