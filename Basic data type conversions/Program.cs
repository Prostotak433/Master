using System;

namespace Basic_data_type_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 4;
            byte b = (byte)(a + 70);

            byte a1 = 4;             // 0000100
            ushort b1= a1;   // 000000000000100

            sbyte a2 = -4;           // 1111100
            short b2= a2;    // 111111111111100

            try
            {
                int a3 = 33;
                int b3 = 600;
                byte c = checked((byte)(a3 + b3));
                Console.WriteLine(c);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
