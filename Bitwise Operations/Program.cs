using System;

namespace Bitwise_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // &(логическое умножение)
            int x1 = 2; //010
            int y1 = 5;//101
            Console.WriteLine(x1 & y1); // выведет 0

            int x2 = 4; //100
            int y2 = 5; //101
            Console.WriteLine(x2 & y2); // выведет 4

            //  | (логическое сложение)
            int x11 = 2; //010
            int y11 = 5;//101
            Console.WriteLine(x11 | y11); // выведет 7 - 111
            int x22 = 4; //100
            int y22 = 5;//101
            Console.WriteLine(x22 | y22); // выведет 5 - 101

            //^ (логическое исключающее ИЛИ)
            int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
            int key = 102; //Пусть это будет ключ - в двоичной форме 1100110
            int encrypt = x ^ key; //Результатом будет число 1001011 или 75
            Console.WriteLine("Зашифрованное число: " + encrypt);

            int decrypt = encrypt ^ key; // Результатом будет исходное число 45
            Console.WriteLine("Расшифрованное число: " + decrypt);

            //~ (логическое отрицание или инверсия)
            int x111 = 12;                 // 00001100
            Console.WriteLine(~x);      // 11110011   или -13

            int x1111 = 12;
            int y = ~x1111;
            y += 1;
            Console.WriteLine(y);   // -12

        }
    }
}
