namespace GuessingGame
{
    // Simple model for one completed round, used to build the Top 5 leaderboard.
    public class LeaderboardEntry
    {
        public string Country { get; set; } = "";
        public int Score { get; set; }
        public TimeSpan TimeTaken { get; set; }
        public DateTime PlayedAt { get; set; }

        public override string ToString()
        {
            return $"{Country,-15} | {Score,3} pts | {TimeTaken:mm\\:ss} | {PlayedAt:HH:mm:ss}";
        }
    }
}
