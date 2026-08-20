namespace RockPaperScissors
{
    internal class TextHelper
    {
        public const string HeaderText = "Hello! This is a ROCK, PAPER, SCISSORS game. Let's play!!!";
        public const string SelectorText = "0. Rock\r\n1. Paper\r\n2. Scissors";
        public const string GameOverWin = "Game over: you win the game!";
        public const string GameOverLost = "Game over: you lose the game(";
        public const string GameOverDraw = "Game over: it's a draw.";
        public const string ChooseOptionFrom = "Choose the option from the following:";
        public const string Round = "Round {0} of {1}";
        public const string RoundResult = "Round result:";

        public static readonly string[] Outcomes = { "lose", "draw", "win" };
    }
}
