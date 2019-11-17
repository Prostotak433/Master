using System;

namespace Static_members_and_modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Account.bonus);
            Account.bonus += 200;

        }
    }
    class Account
    {
        public static decimal bonus = 100;
        public decimal TotalSum;
        public Account(decimal Sum)
        {
            TotalSum += Sum + bonus;
        }
    }
}
