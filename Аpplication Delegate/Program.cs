using System;

namespace Аpplication_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200);
            account.RegisterHandler(new Account.AccountStateHangler(Show_Message));
            Account.AccountStateHangler collorDelegate = new Account.AccountStateHangler(Color_Message);
            account.RegisterHandler(new Account.AccountStateHangler(Show_Message));
            account.RegisterHandler(collorDelegate);
            account.Withdraw(100);
            account.Withdraw(150);
            account.Withdraw(120);
            Console.ReadLine();
        }
        private static void Show_Message(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Account
    {
        int _sum;
        public Account(int sum)
        {
            _sum = sum;
        }
        public int CurrentSum
        {
            get { return _sum; }
        }
        public void Put(int sum)
        {
            _sum += sum;
        }
        public void Withdraw(int sum)
        {
            if(sum<=_sum)
            {
                _sum -= sum;
                if (_del != null)
                    _del($"Cумма {sum} снята со счета");
            }
            else
            {
                if (_del != null)
                    _del("Недостаточно денег на счете");
            }
        }
        public delegate void AccountStateHangler(string message);
        AccountStateHangler _del;
        public void RegisterHandler(AccountStateHangler del)
        {
            _del += del;
        }
        public void UnregisterHandler(AccountStateHangler del)
        {
            _del -= del; // удаляем делегат
        }
        private static void Color_Message(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

}
