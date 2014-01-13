using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= 6 && this.Customer is IndividualCustomer)
            {
                return 0;
            }
            else if (months <= 12 && this.Customer is Company)
            {
                return (months * this.InterestRate * this.Balance);
            }
            else
            {
                return months * this.InterestRate * this.Balance;
            }
        }
    }
}
