using System;

namespace ProgrammingTasks_answers.Matrics
{
    public class Matrix
    {
        int rows { get; set; }
        string sRows { get; set; }
        int columns { get; set; }
        string sColumns { get; set; }
        int matrixvalue { get; set; }
        string MatrixValue { get; set; }

        private int VerifyInput(int intValue, string stringValue, string nameValue)
        {
            do
            {
                Console.Write($"Enter number of {nameValue}: ");
                stringValue = Console.ReadLine();
            }
            while (!int.TryParse(stringValue, out intValue));
            return intValue;
        }

        private int[,] EnterMatrixValue(int[,] matrix)
        {
            string stringmatrixValue;
            int element;
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    do
                    {
                        do
                        {
                            Console.Write($"[{i}],[{j}] : ");
                            stringmatrixValue = Console.ReadLine();
                        }
                        while (!int.TryParse(stringmatrixValue, out element));
                    }
                    while (element > 50 || element < 0);
                    matrix[i, j] = element;
                }

            }
            return matrix;
        }

        public void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public int[,] EnterMatrixParameters()
        {
            rows = VerifyInput(rows, sRows, "rows");
            columns = VerifyInput(columns, sColumns, "columns");

            if (rows != columns)
            {
                Console.WriteLine("You've entered not a square matrix");
            }

            int[,] matrix = new int[rows, columns];
            matrix = EnterMatrixValue(matrix);
            PrintMatrix(matrix);

            return matrix;
        }

    }
}
