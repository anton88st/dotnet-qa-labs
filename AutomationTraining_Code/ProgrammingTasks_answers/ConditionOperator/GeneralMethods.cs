using ProgrammingTasks_answers.InputOutput;

namespace ProgrammingTasks_answers.ConditionOperator;

public static class GeneralMethods
{
    public static IOutput output;

    public static string? EnterNumber(string? customString = null)
    {
        if (!string.IsNullOrEmpty(customString))
            output.WriteLine(customString);
        else
            output.Write("Input a number: ");

        return Console.ReadLine();
    }

    public static int VerifyInput(string? input)
    {
        bool verify = int.TryParse(input, out int number);

        if (verify == true)
            return number;
        else
            throw new FormatException();
    }

    public static int[] AssignNumbers(int elementsCount)
    {
        int[] array = new int[elementsCount];
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = VerifyInput(EnterNumber());
        }

        return array;
    }
}
