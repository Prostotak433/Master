-using System;

namespace Assignment_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a += 10;        // 20
            a -= 4;         // 16
            a *= 2;         // 32
            a /= 8;         // 4
            a <<= 4;      // 64
            a >>= 2;      // 16

            int a1 = 8;
            int b = 6;
            int c = a1 += b -= 5;    // 9
        }
    }
}
