using System;

namespace Class.Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
                        Console.WriteLine(math.GetMath());
        }
    }
    partial class Math
    {
        public int z = 3;
        public int x = 4;
    }
    partial class Math
    {
        public int y = 10;

        public int GetMath()
        {
            return y + z + x;
        }
    }
}