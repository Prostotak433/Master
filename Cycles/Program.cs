using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 9; i++)
            {
                if (i == 1)
                    continue;
                if (i == 3)
                    break;
                Console.WriteLine($"Квадрат числа {i} равен {i * i}");
            }
            var c = 9;
            do
            {
                Console.WriteLine(c);
                c--;
            }
            while (c > 0);
        }
    }
}
