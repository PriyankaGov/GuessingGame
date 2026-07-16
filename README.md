# Country Capital Guesser

A WinForms C# guessing game built for the ICE task.

## How to open
1. Extract the zip.
2. Double-click `GuessingGame.csproj` (or open the folder) in Visual Studio 2022+.
3. Press **F5** to run (requires the ".NET desktop development" workload).

## Features implemented
- **2D array** (`countryCapitals[,]`) storing 20 country/capital pairs — core data source.
- **Score System**: +10 for a correct guess, −1 per wrong guess.
- **Guess Limit**: 5 attempts per round, tracked with a loop-free countdown + conditionals.
- **Hint System**: each wrong guess reveals one more letter of the capital.
- **Leaderboard**: every completed round is stored in a `List<LeaderboardEntry>`, sorted by score/time, and the top 5 are shown after each round.
- **Timer**: `DateTime` marks round start; a `System.Windows.Forms.Timer` updates a live mm:ss display each second and the final time is logged to the leaderboard.

## Files
- `Form1.cs` — game logic (array lookup, scoring, hints, leaderboard)
- `Form1.Designer.cs` — UI layout (all controls, generated in code)
- `LeaderboardEntry.cs` — simple model for a completed round
- `Program.cs` — app entry point
- `GuessingGame.csproj` — project file (targets net8.0-windows, WinForms)

## Notes
- Add more rows to the `countryCapitals` array to extend the question bank.
- Change `MaxAttempts`, `CorrectPoints`, or `WrongPenalty` constants in `Form1.cs` to tune difficulty.
