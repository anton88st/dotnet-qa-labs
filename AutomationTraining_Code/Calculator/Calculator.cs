namespace Calculator;

internal class Calculator
{
    private readonly DataHelp _dataHelp = new();
    private double _save;

    public void Start()
    {
        var running = true;
        while (running)
        {
            running = SelectMainMenu();
        }
        Console.ReadLine();
    }

    private bool SelectMainMenu()
    {
        var select = _dataHelp.OutputMenu();
        switch (select)
        {
            case "q":
                return Close();
            case "mm":
                EnterMenuMatrix();
                return true;
            case "a" or "s" or "m" or "d":
                Calculate(select);
                return true;
            default:
                return true;
        }
    }

    private void Calculate(string select)
    {
        Console.Clear();
        _dataHelp.EnterNameApplication();

        if (!_dataHelp.TryInputNumber("First", _save, out var number1) ||
            !_dataHelp.TryInputNumber("Second", _save, out var number2))
        {
            return;
        }

        try
        {
            _save = SelectCalculation(select, number1, number2);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        Console.ReadLine();
    }

    private static double SelectCalculation(string select, double number1, double number2)
    {
        MathOperations operation = select switch
        {
            "a" => new Addition(),
            "s" => new Subtraction(),
            "m" => new Multiplication(),
            "d" => new Division(),
            _ => throw new ArgumentOutOfRangeException(nameof(select)),
        };

        operation.Number1 = number1;
        operation.Number2 = number2;

        return operation.Calculate();
    }

    private static void EnterMenuMatrix()
    {
        try
        {
            new MenuMatrix().OutputMatrixMain();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
    }

    private static bool Close()
    {
        Console.WriteLine("Closing application...");
        return false;
    }
}
