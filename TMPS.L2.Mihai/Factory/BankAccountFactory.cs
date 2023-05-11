using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS.L2.Mihai.Prototype;

namespace TMPS.L2.Mihai.Factory
{
    // Factory Method Design Pattern
    public abstract class BankAccountFactory
    {
        public abstract BankAccount CreateBankAccount(int accountNumber);
    }
}
