using System;
using System.Threading;
using System.Threading.Tasks;

namespace Class.Tasks1111
{
    class Program
    {
        static void Main(string[] args)
        {
            var outer = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Внешняя задача стартонула....");
                var inner = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Внутрення задача стартонула...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Внутрення задача завершилась ...");
                }, TaskCreationOptions.AttachedToParent);
            });
            outer.Wait();
            Console.WriteLine("Завершение Main");
            

            Task[] tasks1 = new Task[3]
            {
                new Task(() => Console.WriteLine("First Task")),
                new Task(() => Console.WriteLine("Second Task")),
                new Task(() => Console.WriteLine("Third Task"))
            };
            foreach (var i in tasks1)
                i.Start();
            Task[] tasks2 = new Task[3];
            int j = 1;
            for (int i = 0; i < tasks2.Length; i++)
                tasks2[i] = Task.Factory.StartNew(() => Console.WriteLine($"Task{j++}"));
            Console.WriteLine("Завершение метода Маин");
            Console.ReadLine();
            
        }
    }
}
