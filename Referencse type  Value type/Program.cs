﻿using System;

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
        static void GetData(in int x, int y, out int area, out int perim)
        {
            x = x + 10; 
            y = y + 10;
            area = x * y;
            perim = (x + y) * 2;
        }
    }
}
