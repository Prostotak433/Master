using System;

namespace Anonim_Method
{
    class Program
    {
        delegate void MessageHandler(string message);
        delegate int Add(int x, int y );
        static void Main(string[] args)
        {
            Add add = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine(add(20, 30));
            Console.WriteLine(add(10, 760));
            Console.WriteLine(add(10, 730));

            MessageHandler handler = delegate 
            {
                Console.WriteLine("serj");
            };
            handler("Serj TOP");
            Console.Read();
        
        }
    }
}
