using System;
using System.Threading;

namespace Class.Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(Count);
            myThread.Start();
            
            for(int i = 1; i<9; i++)
            {
                Console.WriteLine("Первый поток");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
                
            }
            Console.Read();
        }
        public static void Count()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Второй поток:");
                Console.WriteLine(i * i);
                Thread.Sleep(600);
            }
        }
    }
}
