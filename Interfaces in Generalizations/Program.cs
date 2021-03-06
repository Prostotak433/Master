﻿using System;

namespace Interfaces_in_Generalizations
{
    interface IUser<T>
    {
        T Id { get; }
    }
    class User<T> : IUser<T>
    {
        T _id;
        public User(T id)
        {
            _id = id;
        }
        public T Id { get { return _id; } }
    }
    interface IAccount
    {
        int CurrentSum { get; } 
        void Put(int sum);      
        void Withdraw(int sum); 
    }
    interface IClient
    {
        string Name { get; set; }
    }
    class Client : IAccount, IClient
    {
        int _sum; 
        public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }
        public string Name { get; set; }
        public int CurrentSum { get { return _sum; } }
        public void Put(int sum)
        {
            _sum += sum;
        }
        public void Withdraw(int sum)
        {
            if(sum<= _sum)
            {
                _sum -= sum;
            }
        }
    }
    class Transaction<T> where T: IAccount, IClient
    {
        public void Operate(T acc1,T acc2,int sum)
        {
            if(acc1.CurrentSum >= sum)
            {
                acc1.Withdraw(sum);
                acc2.Put(sum);
                Console.WriteLine($"{acc1.Name} : {acc1.CurrentSum}\n{acc2.Name} : {acc2.CurrentSum}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IUser<int> user1 = new User<int>(64223);
            Console.WriteLine(user1.Id);
            IUser<string> user2 = new User<string>("323121");
            Console.WriteLine(user2.Id);
            Client account1 = new Client("Tom", 300);
            Client account2 = new Client("Bob", 500);
            Transaction<Client> transaction = new Transaction<Client>();
            transaction.Operate(account1, account2, 150);
        }
    }
}
