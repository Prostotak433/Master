using System;

namespace Arithmetic_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 5;
            int z1 = ++x1; 
            Console.WriteLine($"{x1} - {z1}");

            int x2 = 5;
            int z2 = x2++;
            Console.WriteLine($"{x2} - {z2}");

            int x11 = 5;
            int z11 = --x1; // z1=4; x1=4
            Console.WriteLine($"{x11} - {z11}");

            int x22 = 5;
            int z22 = x2--; // z2=5; x2=4
            Console.WriteLine($"{x22} - {z22}");

        }
    }
}
