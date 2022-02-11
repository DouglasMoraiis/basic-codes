using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {

        }

        public void Deposit(double amount)
        {

        }
    }
}
