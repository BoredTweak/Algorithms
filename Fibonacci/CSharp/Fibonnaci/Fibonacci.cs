using System;

namespace Fibonnaci
{
    public class Fibonacci
    {
        public static int CalculateFib(int n)
        {
            if (n < 2)
            {
                return n;
            }

            var output = CalculateFib(n - 2) + CalculateFib(n - 1);
            Console.WriteLine($"Input {n} - Output {output}");
            return output;
        }
    }
}
