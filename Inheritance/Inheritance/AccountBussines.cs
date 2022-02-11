using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class AccountBussines : Account
    {
        public double LoanLimit { get; set; }
        public AccountBussines()
        {
        }

        public AccountBussines(int number, string holder, double balance) : base(number, holder, balance)
        {
        }

        public void Loan(double amount)
        {

        }
    }
}
