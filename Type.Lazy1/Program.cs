using System;


namespace Type.Lazy1
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            reader.ReadBook();
            reader.ReadEbook();
        }
    }
    class Reader
    {
        Lazy<Libary> libary = new Lazy<Libary>();
        public void ReadBook()
        {
            libary.Value.GetBook();
            Console.WriteLine("Читаем бумажную книгу");
        }

        public void ReadEbook()
        {
            Console.WriteLine("Читаем книгу на компьютере");
        }
    }
    
    class Libary
    {
        private string[] books = new string[99];
        public void GetBook()
        {
            Console.WriteLine("Выдаем книгу читателю");
        }
    }
}
