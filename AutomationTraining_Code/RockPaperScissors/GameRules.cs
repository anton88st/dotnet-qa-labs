namespace RockPaperScissors
{
    // Game rules indexed by [playerObjectId, opponentObjectId].
    internal static class GameRules
    {
        // 1 = player wins, 0 = draw, -1 = player loses.
        public static readonly int[,] Comparison = {
            {0, -1, 1},
            {1, 0, -1},
            {-1, 1, 0},
        };

        public static readonly string[,] CompareText = {
            {"Rock matches rock", "Rock gets wrapped", "Rock smashes scissors"},
            {"Paper wraps rock", "Paper matches paper", "Paper gets cut"},
            {"Scissors get smashed", "Scissors cut paper", "Scissors match scissors"},
        };
    }
}
