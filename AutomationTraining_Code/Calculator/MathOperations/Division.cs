namespace Calculator
{
    class Division : MathOperations
    {
        public override double Calculate()
        {
            if (Number2 == 0)
            {
                throw new DivideByZeroException();
            }

            var result = Number1 / Number2;
            Console.WriteLine("Result:{0}/{1}={2}", Number1, Number2, result);
            return result;
        }
    }
}
