using System;

namespace ProgrammingTasks_answers.LoopOperator
{
    /*
     * Display all even numbers up to and including 100 in two ways: with remainder and without.
     */
    public class SixthTask_for : ILoopOperatorTask
    {
        public void Execute()
        {
            OutputTableMethod1();
            OutputTableMethod2();
        }

        // The method adds 2 to the previous number
        public void OutputTableMethod1()
        {
            for (int i = 2; i < 101; i += 2)
            {
                Console.WriteLine($"Numbers: {i}");
            }
        }

        // The method takes every subsequent number and verify remainder after dividing by 2. 
        public void OutputTableMethod2()
        {
            for (double i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"Numbers: {i}");
            }
        }
    }
}
