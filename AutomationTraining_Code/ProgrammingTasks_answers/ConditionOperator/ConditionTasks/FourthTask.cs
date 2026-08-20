using ProgrammingTasks_answers.InputOutput;

namespace ProgrammingTasks_answers.ConditionOperator.ConditionTasks;

class FourthTask : IConditionOperatorTask
{
    /*
     * The user should enter 3 numbers. The system should count? how many positive numbers have been entered by the user.
     */

    private readonly IOutput _output = GeneralMethods.output;

    private int CountNumbers(int[] array)
    {
        int summ = default;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                summ++;
        }

        return summ;
    }

    public void Execute() =>
        _output.WriteLine($"Total count of positive numbers: {CountNumbers(GeneralMethods.AssignNumbers(3))}");
}