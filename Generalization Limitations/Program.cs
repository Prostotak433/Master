using System;

namespace Generalization_Limitations
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(3000) { Sum = 4500 };
            Account account1 = new Account(1777) { Sum = 7000 };
            Transaction<Account> transaction1 = new Transaction<Account> {FromAccount = account,ToAccount = account1,Sum = 3900};
            transaction1.Exe();
            Console.Read();
        }
    }
    class Account
    {
        public int Id { get; private set; } // номер счета
        public int Sum { get; set; }
        public Account(int _id)
        {
            Id = _id;
        }
    }
    class Transaction<T> where T : Account
    {
        public T FromAccount { get; set; }
        public T ToAccount { get; set; }
        public int Sum { get; set; }
        public void Exe()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"Счет {FromAccount.Id}: {FromAccount.Sum}$ \nСчет {ToAccount.Id}: {ToAccount.Sum}$");
            }
            else
            {
                Console.WriteLine($"Недостаточно денег на счете {FromAccount.Id}");
            }
        }
    }
}
