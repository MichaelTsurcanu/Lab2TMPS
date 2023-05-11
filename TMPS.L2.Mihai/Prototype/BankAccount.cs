using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L2.Mihai.Prototype
{
    // Prototype Design Pattern
    public class BankAccount : BankAccountPrototype
    {
        private int accountNumber;
        private string accountType;
        private double balance;

        public BankAccount(int accountNumber, string accountType, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.balance = balance;
        }

        public override BankAccountPrototype Clone()
        {
            return (BankAccountPrototype)MemberwiseClone();
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public override string ToString()
        {
            return $"Account Number: {accountNumber}\nAccount Type: {accountType}\nBalance: {balance:C}\n";
        }
    }
}