using ProgrammingTasks_answers.InputOutput;

namespace ProgrammingTasks_answers.ConditionOperator.ConditionTasks;

public class FirstTask : IConditionOperatorTask
{
    /*
     * The user entered a number. The system should verify:
     * 1. Is the number positive or negative or zero?
     * 2. How many digits the number contains? Single or more.
     * 
     */

    private readonly IOutput _output = GeneralMethods.output;

    private static string VerifyPositiveNegative(int number)
    {
        string? word = null;
        if (number == 0)
            word = "zero";
        else if (number < 0)
            word = "negative";
        else if (number > 0)
            word = "positive";
        return word;
    }

    private static string NumbersCount(string? input)
    {
        bool minus = input.Contains("-") || input.Contains("+");
        int count = input.Length;

        string? word2;
        if (minus == true)
        {
            if (count == 2)
                word2 = "single-digit";
            else word2 = "two-digit/three-digit/multi-digit";
        }
        else
        {
            if (count == 1)
                word2 = "single-digit";
            else
                word2 = "two-digit/three-digit/multi-digit";
        }

        return word2;
    }

    public void Execute()
    {
        var input = GeneralMethods.EnterNumber();
        var number = GeneralMethods.VerifyInput(input);

        _output.WriteLine($"You entered {VerifyPositiveNegative(number)} {NumbersCount(input)} number");
    }
}