namespace Calculator
{
    class MenuMatrix
    {
        public void OutputMatrixMain()
        {
            var data = new DataHelp();
            Console.Clear();
            data.EnterNameApplication();

            if (!data.TryTypeParametersMatrix("A", out var matrixA) ||
                !data.TryTypeParametersMatrix("B", out var matrixB))
            {
                return;
            }

            if (matrixA.GetUpperBound(1) + 1 != matrixB.GetUpperBound(0) + 1)
            {
                throw new Exception("Columns number in Matrix A should be equal by rows number in Matrix B.");
            }

            if (!data.TryTypeElementsMatrix(matrixA, "Matrix A") ||
                !data.TryTypeElementsMatrix(matrixB, "Matrix B"))
            {
                return;
            }

            Console.WriteLine("Matrix A");
            data.PrintConsole(matrixA);
            Console.WriteLine("Matrix B");
            data.PrintConsole(matrixB);

            var multiply = new MultiplicationMatrix { MatrixA = matrixA, MatrixB = matrixB };
            Console.WriteLine("Matrix C");
            data.PrintConsole(multiply.Calculate());
            Console.ReadLine();
        }
    }
}
