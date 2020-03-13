using System;
using System.Text;

namespace System.String1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb2 = new StringBuilder("Hello world");
            Console.WriteLine($"Dlina stroki { sb2.Length}");
            Console.WriteLine($"Еmkost6 stroki {sb2.Capacity}");
            StringBuilder sb1 = new StringBuilder(20);

            StringBuilder sb = new StringBuilder("Название: ");
            Console.WriteLine($"Длина строки: {sb.Length}"); 
            Console.WriteLine($"Емкость строки: {sb.Capacity}");
            sb.Append(" Руководство");
            Console.WriteLine($"Длина строки: {sb.Length}");
            Console.WriteLine($"Емкость строки: {sb.Capacity}");
            sb.Append(" по С#");
            Console.WriteLine($"Длина строки: {sb.Length}");
            Console.WriteLine($"Емкость строки: {sb.Capacity}");
            sb.Append("ssssssss");
            Console.WriteLine($"Длина строки: {sb.Length}"); 
            Console.WriteLine($"Емкость строки: {sb.Capacity}");

            StringBuilder tb = new StringBuilder("Привет мир");
            tb.Append("!");
            tb.Insert(7, "Компьютерный ");
            Console.WriteLine(tb);
            tb.Replace("мир", "world");
            Console.WriteLine(tb);
            tb.Remove(7, 13);
            Console.WriteLine(tb);
            string s = tb.ToString();
            Console.WriteLine(s);

        }
    }
  
}
