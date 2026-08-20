using System;
using ProgrammingTasks_answers.ConditionOperator;
using ProgrammingTasks_answers.ConditionOperator.ConditionTasks;

namespace ProgrammingTasks_answers.Array
{
    class ArrayThirdTask : IArrayTask
    {
        int ArrayLength { get; set; }

        public void Execute()
        {
            ArrayTask3();
        }
        private void OutputMassive(int[] array)
        {
            int maxElement = int.MinValue;
            int secondMaxElement = int.MinValue;

            Console.Write("Array: ");

            foreach (int element in array)
            {
                Console.Write($"{element} ");
                if (element > maxElement)
                {
                    secondMaxElement = maxElement;
                    maxElement = element;
                }
                else if (element != maxElement && element > secondMaxElement)
                {
                    secondMaxElement = element;
                }
            }

            Console.WriteLine($"Second Max value:{secondMaxElement}");
            Console.WriteLine();
        }

        private int[] EnterArray()
        {
            LenghArray();
            int[] array = new int[ArrayLength];
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine($"Enter {i} value:");
                array[i] = GeneralMethods.VerifyInput(GeneralMethods.EnterNumber());
            }
            return array;
        }

        private void LenghArray()
        {
            ArrayLength = GeneralMethods.VerifyInput(GeneralMethods.EnterNumber("Enter an array length:"));
        }

        public void ArrayTask3()
        {
            OutputMassive(EnterArray());
        }

    }
}
