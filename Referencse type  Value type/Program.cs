using System;

namespace Referencse_type__Value_type
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 33;
            Add(ref a, b);
            Console.WriteLine(a);

            int x = 10;
            GetData(x, 15, out int area, out int perimetr);
            Console.WriteLine("Площадь : " + area);
            Console.WriteLine("Периметр : " + perimetr);

        }
        
        
        static void Add(ref int a,  int b)
        {
            a += b;
        }
        static void GetData(int x, int y, out int area, out int perim)
        {
            area = x * y;
            perim = (x + y) * 2;
        }
    }
}
