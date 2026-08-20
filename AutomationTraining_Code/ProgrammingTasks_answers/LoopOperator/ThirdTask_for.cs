using System;

namespace ProgrammingTasks_answers.LoopOperator
{
    /*
     * Display the sum of all even numbers up to and including 256.*/
    public class ThirdTask_for : ILoopOperatorTask
    {
        public void Execute()
        {
            SummNumbers();
        }

        public void SummNumbers()
        {
            int summ = 0;
            for (int i = 0; i <= 256; i++)
            {
                if (i % 2 == 0)
                {   
                summ += i;
                Console.WriteLine($"i={i}, Summ:{summ}");
                }
            }
        }
    }
}
