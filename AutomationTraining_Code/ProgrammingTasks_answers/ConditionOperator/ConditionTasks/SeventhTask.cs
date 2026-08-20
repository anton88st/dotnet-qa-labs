using ProgrammingTasks_answers.InputOutput;

namespace ProgrammingTasks_answers.ConditionOperator.ConditionTasks;

class SeventhTask : IConditionOperatorTask
{
    /*
     * There is a word 'programist'. The system should display the current variant of this word as per the user entered value. E.g: 1 programist, 2 programista,
     * 10 programistov.
     */

    private readonly IOutput _output = GeneralMethods.output;

    private string WordEnd(int lastNumber) =>
         lastNumber switch
         {
             >= 2 and < 5 => "a",
             >= 5 and < 20 => "ov",
             0 => "ov",
             _ => "",
         };

    private int GetLastNumber(int userInput)
    {
        if (userInput < 20)
        {
            return userInput;
        }
        return userInput % 10;
    }

    public void Execute()
    {
        var userNumber = GeneralMethods.VerifyInput(GeneralMethods.EnterNumber());
        _output.WriteLine($"{userNumber} programist{WordEnd(GetLastNumber(GeneralMethods.VerifyInput(GeneralMethods.EnterNumber())))}");
    }
}
