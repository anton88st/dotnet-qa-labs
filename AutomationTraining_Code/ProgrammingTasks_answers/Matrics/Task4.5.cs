namespace ProgrammingTasks_answers.Matrics
{
    public class Task5 : Matrix, IMatrixTask
    {
        public void Execute()
        {
            MatrixTask5();
        }

        /*
         * Input any matrix with positive numbers.Display the origin matrix and reverse all diagonals' numbers in the matrix.
         * E.g: 
         * origin matrix:
         * 1 2 3
         * 4 5 6
         * 7 8 9
         * reversed matrix:
         * 1 4 7
         * 2 5 8
         * 3 6 9
         */
        private int[,] ChangeValues(int[,] matrix)
        {
            int[,] changeMatrix = new int[matrix.GetUpperBound(0) + 1, matrix.GetUpperBound(1) + 1];

            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    changeMatrix[i, j] = matrix[j, i];
                }
            }
            return changeMatrix;
        }

        public void MatrixTask5()
        {
            PrintMatrix(ChangeValues(EnterMatrixParameters()));
        }
    }

}
