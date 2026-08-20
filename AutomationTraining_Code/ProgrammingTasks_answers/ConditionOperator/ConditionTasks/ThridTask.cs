using ProgrammingTasks_answers.InputOutput;

namespace ProgrammingTasks_answers.ConditionOperator.ConditionTasks;

public class ThirdTask : IConditionOperatorTask
{
    /*
     * The user entered a number. If the number is positive add 1, if negative - subtract 2, zero - display 10.
     */

    private readonly IOutput _output = GeneralMethods.output;

    private int ReturnResult(int num1) =>
         num1 switch
        {
            > 0 => num1 + 1,
            < 0 => num1 - 2,
            _ => 10
        };

    public void Execute() => _output.WriteLine($"You number is: {ReturnResult(GeneralMethods.VerifyInput(GeneralMethods.EnterNumber()))}");
}
