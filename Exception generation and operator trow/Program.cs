using System;

namespace Exception_generation_and_operator_trow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Введите строку:");
                    string mes = Console.ReadLine();
                    if(mes.Length>6)
                    {
                        throw new Exception("Ддина строки больше 6 символов");
                    }
                }
                catch
                {
                    Console.WriteLine("Возникло исключение");
                    throw;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
