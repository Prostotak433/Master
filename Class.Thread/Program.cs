using System;
using System.Threading;

namespace Class.Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            TimerCallback tm = new TimerCallback(Count);
            Timer timer = new Timer(tm, num, 0, 2000);
            Console.ReadLine();
        }
        public static void Count(object obj)
        {
            int x = (int)obj;
            for(int i = 1; i < 9; i++, x++)
            {
                Console.WriteLine($"{x * i}");
            }
        }
    }
}