using System;

namespace ProgrammingTasks_answers.LoopOperator
{
    /*
     * Convert inches to cm in range from 0 to 21 inch.
     */
    public class FifthTask_for : ILoopOperatorTask
    {
        public void Execute()
        {
            ConvertTable();
        }

        public void ConvertTable()
        {
            double cm = 0;
            for (int i = 1; i < 21; i++)
            {
                cm += 2.54;
                Console.WriteLine($"Inch: {i}, cm: {cm:N2}");
            }

        }
    }
}
