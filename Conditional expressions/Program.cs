using System;

namespace Conditional_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 4;
            bool c = a == b; // false

            int a = 10;
            int b = 4;
            bool c = a != b;    // true
            bool d = a != 10;     // false

            bool x1 = (5 > 6) | (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            bool x2 = (5 > 6) | (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false

            bool x1 = (5 > 6) & (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
            bool x2 = (5 < 6) & (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true
        }
    }
}
