using System;

namespace Overloading_Type_Conversion_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = new Counter { Seconds = 33 };
            int x = (int)counter1;
            Console.WriteLine(x);
            Counter counter2 = x;
            Console.WriteLine(counter2.Seconds);
        }
    }
    class Counter
    {
        public int Seconds { get; set; }
        public static implicit operator Counter(int x)
        {
            return new Counter { Seconds = x };
        }
        public static explicit operator int(Counter counter)
        {
            return counter.Seconds;
        }
    }
}
