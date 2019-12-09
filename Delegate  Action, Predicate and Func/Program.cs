using System;

namespace Delegate__Action__Predicate_and_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> predicate = delegate (int x) { return x > 0; };
            Console.WriteLine(predicate(20));
            Func<int, int> retFunc = Factorial;

            Action<int, int> op;
            op = Add;
            Operation(10, 6, op);
            op = Substract;
            Operation(10, 3, op);

            Console.Read();
        }

        static void Operation(int x1, int x2, Action<int, int> op)
        {
            if (x1 > x2)
                op(x1, x2);
        }

        static void Add(int x1, int x2)
        {
            Console.WriteLine("Сумма чисел: " + (x1 + x2));
        }

        static void Substract(int x1, int x2)
        {
            Console.WriteLine("Разность чисел: " + (x1 - x2));
        }
    }
}
