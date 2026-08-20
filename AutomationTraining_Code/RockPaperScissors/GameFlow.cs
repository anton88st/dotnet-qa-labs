using RockPaperScissors.GameObjects;

namespace RockPaperScissors
{
    internal class GameFlow
    {
        private const int Rounds = 3;
        private static readonly Random Random = new();

        private int _score = 0;
        private readonly GameObject[] _objects = { new Rock(), new Paper(), new Scissors() };

        public void Start()
        {
            Console.WriteLine(TextHelper.HeaderText);
            for (int i = 0; i < Rounds; i++)
            {
                Console.WriteLine($"\r\n{string.Format(TextHelper.Round, i + 1, Rounds)}");
                var randomObject = PickObject();
                var playerObject = GetPlayerObject();
                var compare = playerObject.Compare(randomObject);
                var compareText = playerObject.CompareText(randomObject);
                _score += compare;
                Console.WriteLine($"\r\n{TextHelper.RoundResult}" +
                    $"\r\nYou choice: {playerObject}\r\nMachine choice: {randomObject}" +
                    $"\r\nResult: {compareText}\r\n{TextHelper.Outcomes[compare + 1]}\r\n");
            }
            GameResult();
        }

        private GameObject GetPlayerObject()
        {
            while (true)
            {
                Console.WriteLine($"{TextHelper.ChooseOptionFrom}\r\n{TextHelper.SelectorText}");
                if (int.TryParse(Console.ReadLine(), out var input) && input >= 0 && input < _objects.Length)
                {
                    return _objects[input];
                }

                Console.WriteLine($"Please enter a number between 0 and {_objects.Length - 1}.");
            }
        }

        private GameObject PickObject() => _objects[Random.Next(_objects.Length)];

        private void GameResult()
        {
            if (_score > 0)
            {
                Console.WriteLine(TextHelper.GameOverWin);
            }
            else if (_score < 0)
            {
                Console.WriteLine(TextHelper.GameOverLost);
            }
            else
            {
                Console.WriteLine(TextHelper.GameOverDraw);
            }
        }
    }
}
