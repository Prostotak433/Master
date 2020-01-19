using System;

namespace Covariance_and_contravariance_of_generic_interfaces
{
    interface IBank<out T>
    {
        T CreatAccount(int sum);
    }
    class Bank<T> : IBank<T> where T : Account, new()
    {
        public T CreateAccount(int sum)
        {
            T acc = new T();  // создаем счет
            acc.DoTransfer(sum);
            return acc;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
