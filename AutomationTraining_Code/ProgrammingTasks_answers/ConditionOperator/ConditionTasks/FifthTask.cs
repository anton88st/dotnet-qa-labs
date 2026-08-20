using ProgrammingTasks_answers.InputOutput;

namespace ProgrammingTasks_answers.ConditionOperator.ConditionTasks;

class FifthTask : IConditionOperatorTask
{
    /*
     * The user entered 3 numbers. The system count, how many positive and negative numbers have been entered by the user.
     */

    private readonly IOutput _output = GeneralMethods.output;

    private (int, int) CountNumbers(int[] array)
    {
        int countpos = default;
        int countneg = default;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                countpos++;
            else if (array[i] < 0)
                countneg++;
        }

        return (countpos, countneg);
    }

    public void Execute()
    {
        (var positiveCount, var negativeCount) = CountNumbers(GeneralMethods.AssignNumbers(3));
        _output.WriteLine($"Total count of positive numbers: {positiveCount}");
        _output.WriteLine($"Total count of negative numbers: {negativeCount}");
    }
}
