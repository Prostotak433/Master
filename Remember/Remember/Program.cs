using System;

namespace Remember
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int result = 0;
            foreach(int i in numbers)
            {
                if (i > 0)
                    result++;
            }
            Console.WriteLine(result);

        }
        
    }
}
