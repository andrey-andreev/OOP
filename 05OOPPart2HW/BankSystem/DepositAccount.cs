using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void Withdraw(decimal money)
        {
            if (this.Balance > money)
            {
                this.Balance -= money;
            }
            else
            {
                throw new Exception("Not enough money.");
            }
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return months * this.InterestRate;
            }
        }
    }
}
