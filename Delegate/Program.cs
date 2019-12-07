using System;

namespace Delegate
{
    class Math
    {
        public int Sum(int x, int y) { return x + y; }
    }
    class Program
    {
        delegate T Operation<T, K>(K val);
        delegate void Message();
        delegate int Op(int x, int y);

        static void Main(string[] args)
        {
            Operation<decimal, int> op5 = Square;
            Math math = new Math();
            Op op1 = math.Sum;
            int res = op1(4, 5);
            Console.WriteLine(res);
            Message ms1 = GoodMorning;
            Message ms2 = Hello;
            ms2?.Invoke();
            Message ms3 = ms1 + ms2;
            ms3();

            Message mes1 = Hello;
            mes1 += HowAreYou;
            mes1();
            Message mes; 
            if (DateTime.Now.Hour<12)
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
        static decimal Square(int n)
        {
            return n * n;
        }
    }
}
