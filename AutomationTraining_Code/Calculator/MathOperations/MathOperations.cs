namespace Calculator
{
    abstract class MathOperations
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public abstract double Calculate();
    }
}
