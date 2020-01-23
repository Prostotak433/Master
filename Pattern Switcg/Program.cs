using System;

namespace Pattern_Switcg
{
   
    class Program
    {
        static int Select(int op, int a, int b)
        {
            switch (op)
            {
                case 1: return a + b;
                case 2: return a - b;
                case 3: return a * b;
                default: throw new ArgumentException("Non cod operation");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                int x = Select(1, 4, 10);
                Console.WriteLine(x);

                x = Select(4, 4, 10);
                Console.WriteLine(x);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
