using ProgrammingTasks_answers.InputOutput;

namespace ProgrammingTasks_answers.ConditionOperator.ConditionTasks;

public class SecondTask : IConditionOperatorTask
{
    /*
     * The user entered 3 numbers. The system should verfiy if these numbers represent a triangle.
     * If each of two numbers are more than the thrid -> it is a triangle. Otherwise - not.
     */

    private readonly IOutput _output = GeneralMethods.output;

    private void Compare(int[] array)
    {
        if (array[0] > 0 && array[1] > 0 && array[2] > 0)
        {
            if (array[0] < array[1] + array[2]
                && array[1] < array[0] + array[2]
                && array[2] < array[0] + array[1])
                _output.WriteLine("It's a triangle");
            else
                _output.WriteLine("Sorry, it's not a triangle");
        }
        else
            _output.WriteLine("Triangle side can't be less or equal zero");

    }

    public void Execute()
    {
        var array = GeneralMethods.AssignNumbers(3);
        Compare(array);
    }
}
