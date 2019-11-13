using System;

namespace Recursive_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonachi = Fibonachi(10);
            Console.WriteLine(fibonachi);
            int factorial = Factorial(30);
            Console.WriteLine(factorial);
        }
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
}
