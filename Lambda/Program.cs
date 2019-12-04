using System;

namespace Lambda
{
    class Program
    {
        delegate bool IsEqual(int x);
        delegate void Method2();
        delegate void Ref(ref int a);
        delegate void Hello();
        delegate int Add(int x, int y, int z);
        static void Main(string[] args)
        {
            Method2 mess = () => Method1();
            mess();
            int a = 5;
            Ref ref1 = (ref int n) => n= n * n;
            ref1(ref a);
            Console.WriteLine(a);
            Hello hello = () => Console.WriteLine("HIII");
            hello();
            Add add = (x, y, z) => x + y * z;
            Console.WriteLine(add(10, 10, 2));
            Console.WriteLine(add(5, 5, 5));
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int result1 = Sum(array, b => b > 5);
        }
        private static void Method1()
        {
            Console.WriteLine("Method1");
        }
        private static int Sum(int[] numbers, IsEqual func)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                if (func(i))
                    result += i;
            }
            return result;
        }
    }
}
