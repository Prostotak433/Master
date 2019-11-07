using System;

namespace Console_input_and_output
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            Console.WriteLine(hello);
            string name = "Jon";
            int age = 33;
            double height = 1.76;
            Console.WriteLine($"Имя : {name} Возраст : {age} Рост : {height}");
            Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);

            Console.Write("Введите свое имя");
            string name1 = Console.ReadLine();
            Console.Write("Введите ваш возраст");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш рост");
            double height1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вашу ЗП");
            decimal salary1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Имя: {name1}  Возраст: {age1}  Рост: {height1}м  Зарплата: {salary1}$");


            Console.ReadKey();
        }
    }
}
