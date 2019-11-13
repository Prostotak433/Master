using System;

namespace Enum
{
    class Program
    {
        enum Operation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }
        static void MathOp(double x, double y, Operation op)
        {
            double result = 0.0;
            switch(op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }
            Console.WriteLine("Результат операции равен {0}", result);
        }
        static void Main(string[] args)
        {
            MathOp(12.3, 17.7, Operation.Multiply);
            Console.WriteLine(Operation.Multiply);

            Days day;
            day = Days.Sunday;
            Console.WriteLine((int)day);
        }
        enum Days
        {
            Monday = 1,
            Tuesday = 3,
            Wednesday = 2,
            Thursday,
            Friday,
            Saturday = Monday,
            Sunday
        }

    }
}
