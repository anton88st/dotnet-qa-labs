namespace TicTacToe
{
    public class Core
    {
        private const int Size = 3;

        public void GameStart()
        {
            var matrix = GameArea();
            PrintMatrix(matrix);

            var players = new[] { ("First", "X"), ("Second", "O") };
            var turn = 0;

            while (true)
            {
                var (player, symbol) = players[turn % players.Length];
                EnterMatrixValuePlayer(matrix, player, symbol);
                PrintMatrix(matrix);

                if (HasWinningLine(matrix, symbol))
                {
                    Console.WriteLine($"GAME OVER. THE {player.ToUpperInvariant()} PLAYER IS THE WINNER");
                    return;
                }

                if (IsBoardFull(matrix))
                {
                    Console.WriteLine("GAME OVER. THERE IS NO WINNER IN THE ROUND!!!");
                    return;
                }

                turn++;
            }
        }

        private static string[,] GameArea()
        {
            var matrix = new string[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    matrix[i, j] = $"|{i},{j}|";
                }
            }

            return matrix;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void EnterMatrixValuePlayer(string[,] matrix, string player, string symbol)
        {
            while (true)
            {
                int row = ReadCoordinate("row", $"{player} Player");
                int column = ReadCoordinate("column", $"{player} Player");

                if (matrix[row, column] != "X" && matrix[row, column] != "O")
                {
                    matrix[row, column] = symbol;
                    return;
                }

                Console.WriteLine("This field is occupied. Please, enter another coordinates");
            }
        }

        private static int ReadCoordinate(string name, string player)
        {
            while (true)
            {
                Console.Write("{1} - Enter {0}: ", name, player);
                var input = Console.ReadLine();

                if (int.TryParse(input, out var value) && value >= 0 && value < Size)
                {
                    return value;
                }

                Console.WriteLine($"Please enter a number between 0 and {Size - 1}.");
            }
        }

        private static bool HasWinningLine(string[,] matrix, string symbol)
        {
            for (int i = 0; i < Size; i++)
            {
                var rowWin = true;
                var columnWin = true;
                for (int j = 0; j < Size; j++)
                {
                    if (matrix[i, j] != symbol) rowWin = false;
                    if (matrix[j, i] != symbol) columnWin = false;
                }
                if (rowWin || columnWin) return true;
            }

            var mainDiagonalWin = true;
            var antiDiagonalWin = true;
            for (int i = 0; i < Size; i++)
            {
                if (matrix[i, i] != symbol) mainDiagonalWin = false;
                if (matrix[i, Size - 1 - i] != symbol) antiDiagonalWin = false;
            }

            return mainDiagonalWin || antiDiagonalWin;
        }

        private static bool IsBoardFull(string[,] matrix)
        {
            return matrix.Cast<string?>().All(cell => cell == "X" || cell == "O");
        }
    }
}
