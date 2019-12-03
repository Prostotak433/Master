using System;

namespace Аpplication_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
            }
        }
        public delegate void AccountStateHangler(string message);
        AccountStateHangler _del;
        public void RegisterHandler(AccountStateHangler del)
        {
            _del = del;
        }
    }

}
