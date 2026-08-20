using System;

namespace ProgrammingTasks_answers.Matrics
{
    public class Task4 : Matrix, IMatrixTask
    {
        public void Execute()
        {
            MatrixTask4();
        }

        private void SumEvenValues(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) - i; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        sum += matrix[i, j];
                }
            }
            Console.WriteLine($"Sum of elements: {sum}");
        }
        public void MatrixTask4()
        {
            SumEvenValues(EnterMatrixParameters());
        }
    }

}
