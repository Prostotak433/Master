using System;

namespace Keyword_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Array(1, 2, 3, 4, 5, 6, 7, 8, 9, 0);
            int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            Array(array1);
            Array();
            Console.ReadKey();
        }
        static void Array(params int[] mass)
        {
            int result = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                result += mass[i];
            }
            Console.WriteLine(result);
        }

    }
}
