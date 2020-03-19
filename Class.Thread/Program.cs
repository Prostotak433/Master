using System;
using System.Threading;

namespace Class.Thread1
{
    class Program
    {
        static int x = 0;
        static object locker = new object();
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = $"Поток {i.ToString()}";
                myThread.Start();
            }
            Console.ReadLine();
        }       
        public static void Count()
        {
            bool acquireloock = false;
            try
            {
                Monitor.Enter(locker, ref acquireloock);
                x = 1;
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                    x++;
                    Thread.Sleep(100);
                }
            }
            finally
            {
                if (acquireloock) Monitor.Exit(locker);
            }
        }
    }
}
