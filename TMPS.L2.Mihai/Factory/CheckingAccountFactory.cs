using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS.L2.Mihai.Builder;
using TMPS.L2.Mihai.Prototype;

namespace TMPS.L2.Mihai.Factory
{
    // Factory Method Design Pattern
    public class CheckingAccountFactory : BankAccountFactory
    {
        public override BankAccount CreateBankAccount(int accountNumber) => new BankAccountBuilder()
                .WithAccountNumber(accountNumber)
                .WithAccountType("Checking")
                .WithBalance(0)
                .Build();
    }
}
