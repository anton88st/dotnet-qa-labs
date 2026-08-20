using System;
using ProgrammingTasks_answers.ConditionOperator;
using ProgrammingTasks_answers.ConditionOperator.ConditionTasks;

namespace ProgrammingTasks_answers.LoopOperator
{
    /*
     * Multiple two inputted positive numbers via FOR loop.
     */
    public class FourthTask_for : ILoopOperatorTask
    {
        int a;
        int b;

        public void Execute()
        {
            ResultMultiply();
        }

        private int MultiplyNumbers(int a, int b)
        {
            int result = 0;
            for (int i = 1; i <= b; i++)
            {
                result += a;
            }
            return result;
        }

        public void ResultMultiply()
        {
            do
            {
                a = GeneralMethods.VerifyInput(GeneralMethods.EnterNumber());
            } while (a < 0);

            do
            {
                b = GeneralMethods.VerifyInput(GeneralMethods.EnterNumber());
            } while (b < 0);

            Console.WriteLine($"Result: {MultiplyNumbers(a, b)}");
        }
    }
}
