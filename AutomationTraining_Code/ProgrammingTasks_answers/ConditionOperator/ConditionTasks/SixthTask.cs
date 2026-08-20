using ProgrammingTasks_answers.InputOutput;

namespace ProgrammingTasks_answers.ConditionOperator.ConditionTasks;

class SixthTask : IConditionOperatorTask
{
    /*
     *  The user entered two numbers. The system should check whether numbers are not equal and display the bigest one.
     */

    private readonly IOutput _output = GeneralMethods.output;

    private int CountNumbers(int[] array)
    {
        if (array[0] > array[1]) return array[0];
        else return array[1];
    }

    public void Execute()
    {
        var array = GeneralMethods.AssignNumbers(2);
        if (array[0] != array[1]) _output.WriteLine($"The biggest number: {CountNumbers(array)}");
        else _output.WriteLine($"The numbers are the same: {array[0]} = {array[1]}");
    }
}