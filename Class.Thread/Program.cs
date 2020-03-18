using System;
using System.Threading;

namespace Class.Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter(4,5);
            

            Thread myThread = new Thread(new ThreadStart(counter.Count));
            myThread.Start();
            
            for(int i = 1; i<9; i++)
            {
                Console.WriteLine("Первый поток");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
                
            }
            Console.Read();
        }
      
        
        public class Counter
        {
            private int _x;
            private int _y;
            public Counter(int x, int y)
            {
                this._x = x;
                this._y = y;
            }
            public void Count()
            {
                for (int i = 1; i < 9; i++)
                {

                    Console.WriteLine("Второй поток:");
                    Console.WriteLine(i *_x* _y);
                    Thread.Sleep(400);
                }
            }

        }       
    }
}
