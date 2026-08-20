namespace Calculator
{
    class Multiplication : MathOperations
    {
        public override double Calculate()
        {
            var result = Number1 * Number2;
            Console.WriteLine("Result:{0}x{1}={2}", Number1, Number2, result);
            return result;
        }
    }
}
