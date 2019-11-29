using System;

namespace Try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число");
            int x;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out x))
            {
                x *= x;
                Console.WriteLine("Квадрат числа: " + x);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            Console.Read();

        }
    }
}
