using System;

namespace ProgrammingTasks_answers.Matrics
{
    /*
     * Input any matrix. Display the matrix and calculate the following: 
     * 1. Multiple all numbers on the main matrix diagonal
     * 2. Multiple all numbers on the secondary matrix diagonal.
     */
    public class Task3 : Matrix, IMatrixTask
    {
        public void Execute()
        {
            MatrixTask3();
        }

        private int MultiplyValues(int[,] matrix)
        {
            int multiplyMain = 1;
            int multiplyOdd = 1;

            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                int j = i;
                int k = matrix.GetUpperBound(0) - i;
                multiplyMain *= matrix[i, j];
                multiplyOdd *= matrix[i, k];
            }
            Console.WriteLine($"Multiplication: {multiplyMain}");
            Console.WriteLine($"Multiplication: {multiplyOdd}");

            return (multiplyMain > multiplyOdd) ? multiplyMain : multiplyOdd;
        }

        public void MatrixTask3()
        {
            Console.WriteLine(MultiplyValues(EnterMatrixParameters()));
        }
    }

}
