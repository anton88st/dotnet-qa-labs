using System;

namespace ProgrammingTasks_answers.Matrics
{
    /*
     * Input any matrix. Display the matrix and all odd numbers included under the main diagonal in the matrix.
     */
    public class Task2 : Matrix, IMatrixTask
    {
        public void Execute()
        {
            MatrixTask2();
        }

        private void ReturnElements(int[,] matrix)
        {
            Console.WriteLine("Odd numbers.");
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    if (i >= j && matrix[i, j] % 2 != 0)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                }
            }
        }

        public void MatrixTask2()
        {
            ReturnElements(EnterMatrixParameters());
        }
    }
}
