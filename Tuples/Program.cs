using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = (19, count:30);
            Console.WriteLine(type.Item1);
            type.Item1 += 11;
            Console.WriteLine(type.Item1);
            Console.WriteLine(type.count);
        }
    }
}
