namespace Calculator
{
    abstract class MatrixOperation
    {
        public int[,] MatrixA { get; set; } = new int[0, 0];
        public int[,] MatrixB { get; set; } = new int[0, 0];
        public abstract int[,] Calculate();
    }
}
