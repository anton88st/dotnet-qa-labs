namespace Calculator
{
    class Addition : MathOperations
    {
        public override double Calculate()
        {
            var result = Number1 + Number2;
            Console.WriteLine("Result:{0}+{1}={2}", Number1, Number2, result);
            return result;
        }
    }
}
