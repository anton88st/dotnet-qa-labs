using System;

namespace ProgrammingTasks_answers.Matrics
{
    /*
     * Input any matrix. Display the matrix and sum of all even numbers on the main matrix diagonal.
     */
    public class Task1 : Matrix, IMatrixTask
    {
        public void Execute()
        {
            MatrixTask1();
        }

        private void ReturnSumm(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    if (i == j && matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Addition even numbers on the main matrix diagonal: {sum}");
        }
        public void MatrixTask1()
        {
            ReturnSumm(EnterMatrixParameters());
        }
    }
}
