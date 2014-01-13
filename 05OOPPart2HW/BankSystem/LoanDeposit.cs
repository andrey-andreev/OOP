using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public override decimal CalculateInterest(int months)
        {
            if (months <= 3 && this.Customer is IndividualCustomer)
            {
                return 0;
            }
            else if (months <= 2 && this.Customer is Company)
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
