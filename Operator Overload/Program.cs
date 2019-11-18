using System;

namespace Operator_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter { Value = 23 };
            Counter c2 = new Counter { Value = 33 };
            bool result = c2 > c1;
            Console.WriteLine(result);
            Counter c3 = c1 + c2;
            Console.WriteLine(c3.Value);
            int z = c1 + 23;
            Console.WriteLine(z);
        }
    }
    class Counter
    {
        public int Value { get; set; }
        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value + c2.Value };
        }
        public static bool operator >(Counter c1, Counter c2)
        {
            return c1.Value > c2.Value;
        }
        public static bool operator <(Counter c1, Counter c2)
        {
            return c1.Value < c2.Value;
        }
        public static int operator +(Counter c1, int val)
        {
            return c1.Value + val;
        }
    }
}
