using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public abstract class Account : IDepositable
    {
        public Customer Customer { get; protected set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; private set; }

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        virtual public decimal CalculateInterest(int months)
        {
            return months * this.InterestRate;
        }

        public void Deposit(decimal money)
        {
            this.Balance += money;
        }

        public virtual void Withdraw(int p)
        { }
    }
}
