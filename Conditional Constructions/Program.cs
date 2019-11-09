using System;

namespace Conditional_Constructions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            int num2 = 10;
            if(num1 < num2)
            {
                Console.WriteLine(num1 < num2);
            }
            else if (num1 > num2)
            {
                Console.WriteLine(num1 > num2);
            }
            else
            {
                Console.WriteLine(num1 = num2);
            }
            Console.WriteLine("нажмите Y или U");
            string vubor = Console.ReadLine();
            switch(vubor)
            {
                case "Y":
                    Console.WriteLine("Y");
                    break;
                case "U":
                    Console.WriteLine("U");
                    break;
                default:
                    Console.WriteLine("bezdar6");
                    break;
            }
            int x = 3;
            int y = 4;
            Console.WriteLine("нажмите + или -");
            string result = Console.ReadLine();
            int z = result == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);

        }
    }
}
