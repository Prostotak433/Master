using System;

namespace LIterals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Логические литералы
            Console.WriteLine(true);
            Console.WriteLine(false);

            //Целочисленные литералы 10 форма
            Console.WriteLine(-24);
            Console.WriteLine(100);
            // 2 -чная форма
            Console.WriteLine(0b11);  // 3
            Console.WriteLine(0b100001);//  33
            //16 - чная форма
            Console.WriteLine(0x0a); // 16
            Console.WriteLine(0xFF); //255

            //Вещественные литералы
            Console.WriteLine(3.2e3); // по сути равно 3.2 * 10<sup>3</sup> = 3200
            Console.WriteLine(1.2E-1); // равно 1.2 * 10<sup>-1</sup> = 0.12

            //Символьные литералы
            Console.WriteLine('\x78'); // x
            Console.WriteLine('\u0420'); //P

            //Строковые литералы
            Console.WriteLine("Компания \"Рога и копыта\"");
            Console.WriteLine("'\'слеш");
        }
    }
}
