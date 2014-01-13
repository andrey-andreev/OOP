using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public interface IDepositable
    {
        void Deposit(decimal money);
    }
}
