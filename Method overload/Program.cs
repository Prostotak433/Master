using System;

namespace Method_overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Add(1, 2);
            calc.Add(1.1, 2.2);
        }


    }
    class Calculator
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Result is {result}");
        }
        public void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine($"Result is {result}");
        }
        public int Add(int a, int b, int c, int d)
        {
            int result = a + b + c + d;
            Console.WriteLine($"Result is {result}");
            return result;
        }
        public void Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"Result is {result}");
        }
    }
}
