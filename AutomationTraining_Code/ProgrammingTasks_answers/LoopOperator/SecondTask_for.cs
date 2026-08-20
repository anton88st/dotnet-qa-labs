using System;

namespace ProgrammingTasks_answers.LoopOperator
{
    /*
     * Every 3 hours the count of amebas is increasing twice. How many amebas will be after 24 hours if there is only 1 from the start?
     * */
    public class SecondTask_for : ILoopOperatorTask
    {
        public void Execute()
        {
            AmebaCount();
        }

        public void AmebaCount()
        {
            int amebacount = 1;
            for (int i = 0; i < 25; i += 3)
            {
                Console.WriteLine($"hours: {i}, amebas: {amebacount}");
                int amebaperhours = amebacount * 2;
                amebacount = amebaperhours;
            }

        }
    }
}
