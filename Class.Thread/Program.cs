using System;
using System.Threading;

namespace Class.Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 6; i++)
            {
                Reader reader = new Reader(i);
            }
            Console.ReadLine();
        }
    }    
    class Reader
    {
        static Semaphore sen = new Semaphore(3, 3);
        Thread myThread;
        int count = 3;
        public Reader(int i)
        {
            myThread = new Thread(Read);
            myThread.Name = $"Читатель {i.ToString()}";
            myThread.Start();
        }
        public void Read()
        {
            while(count > 0)
            {
                sen.WaitOne();
                Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");
                Console.WriteLine($"{Thread.CurrentThread.Name} читает");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");
                sen.Release();
                count--;
                Thread.Sleep(1000);
            }
        }
    }
}
