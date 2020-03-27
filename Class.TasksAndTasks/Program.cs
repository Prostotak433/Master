using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Class.Tasks1111
{
    class Program
    {
        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 1, 3, 5, 8 }, Factorial);
            Console.ReadLine();
        }
       
        static void Factorial(int x)
        {
            int result = 1;
            for(int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
            Console.WriteLine($"Факториал числа {x} равен {result}");
            Thread.Sleep(3000);
        }
    }
}