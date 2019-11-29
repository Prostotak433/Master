using System;

namespace Exception_filters
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 5;

            try
            {

                int result = x / y;
                Console.WriteLine($"Результат: {y}");
            }
            catch(Exception ex) when (x ==0 )
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}
