using System;
using System.Threading;

namespace Class.Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine($"Имя потока: {t.Name}");
            t.Name = "Метод Main";
            Console.WriteLine($"Имя потока: {t.Name}");
            Console.WriteLine($"Запущен ли поток: {t.IsAlive}");
            Console.WriteLine($"Приоритет потока: {t.Priority}");
            Console.WriteLine($"Статус потока: {t.ThreadState}");

            Console.WriteLine($"Домен приложения: {Thread.GetDomain().FriendlyName}");
            Console.ReadLine();
        }
    }
}
