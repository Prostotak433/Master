using System;

namespace Class.Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            Array.Reverse(numbers);
            Array.Resize(ref numbers, 4);
            foreach(int numb in numbers)
            {
                Console.Write($"{numb}\t");
            }

            int[] numbers1 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int[] numbers2 = new int[5];
            Array.Copy(numbers1, 2, numbers2, 0, 5);
            foreach (int res in numbers2)
            {
                Console.Write($"{res} \t");
            }
            int[] mass = { -3, 10, 0, -5, 12, 1, 22, 3 };
            Array.Sort(mass);
            foreach(int massres in mass)
            {
                Console.Write($"{massres} \t");
            }

        }
    }
}
