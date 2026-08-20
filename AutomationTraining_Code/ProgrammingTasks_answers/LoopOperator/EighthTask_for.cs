using System;

namespace ProgrammingTasks_answers.LoopOperator
{
    /*
     * Display triangles with '*' elements.
     *     *
     *    **
     *   ***
     *  ****
     * *****
     * 
     * *****
     *  ****
     *   ***
     *    **
     *     *
     */
    public class EighthTask_for : ILoopOperatorTask
    {
        public void Execute()
        {
            TriangleOutput();
        }

        public void TriangleOutput()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i > j)
                        Console.Write(" ");
                    else Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i > j)
                        Console.Write(" ");
                    else Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}
