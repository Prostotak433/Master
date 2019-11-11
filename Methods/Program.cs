using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string opa = GetHellow();
            Console.WriteLine(opa);
            int hi = GetSum();
            Console.WriteLine(hi);

            SayGoodBye();
            SayHello();
        }
        static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        static void SayGoodBye()
        {
            Console.WriteLine("Bye");
        }
        static int GetSum()
        {
            int x = 2;
            int y = 3;
            int z = x + y;
            return z;
        }
        static string GetHello()
        {
            return "Hello";
        }
        static void Serega() => Console.WriteLine("serega ");
        static string GetHellow() => "111111111111111111111111";
    }
}
