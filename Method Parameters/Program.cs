using System;

namespace Method_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int a = 25;
            int b = 35;
            int result = Sum(a, b);
            Console.WriteLine(result);

            result = Sum(b, 45);
            Console.WriteLine(result);

            result = Sum(a + b + 12, 18);
            Console.WriteLine(result);

            result = Sum(10, 15);
            Console.WriteLine(result);
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Display(string name, int age)
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }
}
