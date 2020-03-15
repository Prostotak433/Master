using System;
using System.Globalization;

namespace Method.ParseAndTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse("30,30");
            Console.WriteLine(a);

            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            double b = double.Parse("23.56", formatter);

            int number;
            Console.WriteLine("Введите строку");
            string imput = Console.ReadLine();

            bool result = int.TryParse(imput, out number);
            if (result == true)
                Console.WriteLine("Успешно");
            else
                Console.WriteLine("Не успешно");

        }
    }
}
