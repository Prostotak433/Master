using System;
using System.Text;
namespace Class_StringBuilder
{
    
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Привет мир");
            sb.Append("!");
            sb.Insert(7, "компьютерный ");
            Console.WriteLine(sb);
            sb.Replace("мир", "world");
            Console.WriteLine(sb);
            sb.Remove(7, 13);
            Console.WriteLine(sb);
            string s = sb.ToString();
            Console.WriteLine(s);

        }
        
    }
    
}
