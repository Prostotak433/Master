using System;
using System.Threading.Tasks;

namespace Class.Tasks1111
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(Display);
            task1.Start();
            task1.Wait();
            Console.WriteLine("Завершение метода Маин");
            Console.ReadLine();
           
        }
        static void Display()
        {
            Console.WriteLine("Начало работы метода Display");

            Console.WriteLine("Завершение работы метода Display");
        }
    }
}
