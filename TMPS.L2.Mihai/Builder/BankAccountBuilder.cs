
using TMPS.L2.Mihai.Prototype;

namespace TMPS.L2.Mihai.Builder
{
    // Builder Design Pattern
    public class BankAccountBuilder
    {
        private int accountNumber;
        private string? accountType;
        private double balance;

        public BankAccountBuilder WithAccountNumber(int accountNumber)
        {
            this.accountNumber = accountNumber;
            return this;
        }

        public BankAccountBuilder WithAccountType(string accountType)
        {
            this.accountType = accountType;
            return this;
        }

        public BankAccountBuilder WithBalance(double balance)
        {
            this.balance = balance;
            return this;
        }

        public BankAccount Build()
        {
            return new BankAccount(accountNumber, accountType, balance);
        }
    }
}
