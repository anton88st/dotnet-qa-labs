using System;

namespace ProgrammingTasks_answers.LoopOperator
{
    /*
     * In the first hour a person walked 10 km, what distance will he walk after 7 hours if at each subsequent hour he walks 10 percent more than in the previous one?
     */
    public class FirstTask_for : ILoopOperatorTask
    {
        public void Execute()
        {
            Distance();
        }

        public void Distance()
        {
            double distance = 10;
            double totaldistance = 10;
            for (int i = 2; i < 8; i++)
            {
                distance *= 1.1;
                totaldistance += distance;
            }
            Console.WriteLine($"Total distance: {totaldistance}");
        }
    }
}
