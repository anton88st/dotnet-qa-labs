using System;
using ProgrammingTasks_answers.ConditionOperator.ConditionTasks;

namespace ProgrammingTasks_answers.Array
{
    /*
     * Create a random array with 20 positive numbers in the range 0...16. Display an array and maximum number from the array.
     */
    class ArraySecondTask : IArrayTask
    {
        public void Execute()
        {
            ArrayTask2();
        }

        private static void OutputMassive(int[] a)
        {
            int b = a[0];
            int index = 0;
            Console.Write("Array: ");

            foreach (int element in a)
            {
                Console.Write($"{element},");
            }

            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                if (b <= a[i])
                {
                    b = a[i];
                    index = i;
                }

            }
            Console.WriteLine($"Max value:{b}");
            Console.WriteLine($"Index:{index}");
            Console.WriteLine();
        }

        private int[] EnterArray()
        {
            Random rand = new Random();
            int[] array = new int[20];

            for (int i = 0; i < 20; i++)
            {
                int number = rand.Next(0, 16);
                array[i] = number;
            }
            return array;
        }

        public void ArrayTask2()
        {
            OutputMassive(EnterArray());
        }

    }
}
