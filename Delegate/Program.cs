using System;

namespace Delegate
{
    class Program
    {
        delegate void Message(); 

        static void Main(string[] args)
        {
            Message mes1 = Hello;
            mes1 += HowAreYou;
            mes1();
            Message mes; 
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning; 
            }
            else
            {
                mes = GoodEvening;
            }
            mes();
            Console.ReadKey();
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
        private static void Hello()
        {
            Console.WriteLine("Hello");
        }
        private static void HowAreYou()
        {
            Console.WriteLine("How are you?");
        }
        private static void Hello1()
        {
            Console.WriteLine("Hello");
        }
    }
}
