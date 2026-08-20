using System;
using ProgrammingTasks_answers.ConditionOperator;
using ProgrammingTasks_answers.ConditionOperator.ConditionTasks;

namespace ProgrammingTasks_answers.Array
{
    /*
     * Input an array and verify, that the array is a strictly ascending array, otherwise - not.
     */
    class ArrayFirstTask : IArrayTask
    {
        int ArrayLenth { get; set; }

        public void Execute()
        {
            ArrayTask1();
        }

        private void OutputMassive(int[] a)
        {
            int b = 0;
            Console.Write("Array: ");
            foreach (int element in a)
            { Console.Write("{0} ", element); }
            Console.WriteLine();
            for (int i = 1; i < ArrayLenth; i++)
            {
                b = a[i - 1];
                if (b < a[i])
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("It isn't a strictly ascending array");
                    return;
                }
            }
            Console.WriteLine("It is a strictly ascending array");
            Console.WriteLine();
        }

        private int[] EnterArray()
        {
            LenghArray();
            int[] a = new int[ArrayLenth];
            for (int i = 0; i < ArrayLenth; i++)
            {
                do
                {
                    Console.WriteLine($"Enter {i} value between 0-10");
                    a[i] = GeneralMethods.VerifyInput(GeneralMethods.EnterNumber());
                }
                while ((a[i] >= 10) || (a[i] <= 0));
            }
            return a;
        }
        private void LenghArray()
        {
            ArrayLenth = GeneralMethods.VerifyInput(GeneralMethods.EnterNumber("Enter an array length:"));
        }

        public void ArrayTask1()
        {
            OutputMassive(EnterArray());
        }

    }
}
