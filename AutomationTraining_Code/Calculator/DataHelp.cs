namespace Calculator;

internal class DataHelp
{
    public string? OutputMenu()
    {
        Console.Clear();
        EnterNameApplication();
        Console.WriteLine("Select calculation: ");
        Console.WriteLine("Add numbers-------- a");
        Console.WriteLine("Subtract numbers--- s");
        Console.WriteLine("Divide numbers----- d");
        Console.WriteLine("Multiply numbers--- m");
        Console.WriteLine("Multiply matrics--- mm");
        Console.WriteLine("Exit--------------- q");
        Console.Write("Your choice: ");

        return Console.ReadLine();
    }

    // Returns false when the user types "q" to return to the main menu.
    public bool TryInputNumber(string name, double save, out double number)
    {
        Console.Write("Type a {0} number: ", name);
        var input = Console.ReadLine();

        while (!double.TryParse(input, out number))
        {
            if (input == "q")
            {
                number = 0;
                return false;
            }
            if (input == "s")
            {
                number = save;
                return true;
            }
            Console.WriteLine("The entered data is not valid!! Type only numbers.");
            Console.Write("Type a {0} number: ", name);
            input = Console.ReadLine();
        }

        return true;
    }

    public void EnterNameApplication()
    {
        var nameApplication = "Welcome: Console Calculator.\n";
        Console.SetCursorPosition((Console.WindowWidth - nameApplication.Length) / 2, Console.CursorTop);
        Console.WriteLine(nameApplication);
    }

    // Returns false when the user types "q" to return to the main menu.
    public bool TryTypeParametersMatrix(string name, out int[,] matrix)
    {
        matrix = new int[0, 0];

        if (!TryReadPositiveInt($"Type number of rows in matrix {name}: ", out var rows) ||
            !TryReadPositiveInt($"Type number of columns in matrix {name}: ", out var columns))
        {
            return false;
        }

        matrix = new int[rows, columns];
        return true;
    }

    // Fills the matrix in place. Returns false when the user types "q".
    public bool TryTypeElementsMatrix(int[,] matrix, string name)
    {
        for (var i = 0; i < matrix.GetUpperBound(0) + 1; i++)
        {
            for (var j = 0; j < matrix.GetUpperBound(1) + 1; j++)
            {
                Console.Write("{0} number -  [{1},{2}]: ", name, i, j);
                var input = Console.ReadLine();
                int element;
                while (!int.TryParse(input, out element))
                {
                    if (input == "q")
                    {
                        return false;
                    }
                    Console.WriteLine("Entered data isn't valid. Type only integer numbers.");
                    Console.Write("{0} number -  [{1},{2}]: ", name, i, j);
                    input = Console.ReadLine();
                }
                matrix[i, j] = element;
            }
        }

        return true;
    }

    public void PrintConsole(int[,] matrix)
    {
        for (var i = 0; i < matrix.GetUpperBound(0) + 1; i++)
        {
            for (var j = 0; j < matrix.GetUpperBound(1) + 1; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
    }

    private bool TryReadPositiveInt(string prompt, out int value)
    {
        Console.Write(prompt);
        var input = Console.ReadLine();

        while (!int.TryParse(input, out value) || value <= 0)
        {
            if (input == "q")
            {
                value = 0;
                return false;
            }
            Console.WriteLine("Entered data isn't valid. Type only positive integer numbers.");
            Console.Write(prompt);
            input = Console.ReadLine();
        }

        return true;
    }
}
