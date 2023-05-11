using TMPS.L2.Mihai.Factory;
using TMPS.L2.Mihai.Prototype;
using TMPS.L2.Mihai.Singleton;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = Bank.GetInstance();
        Console.WriteLine($"Bank instance: {bank}");

        BankAccountPrototype prototypeAccount = new BankAccount(12345, "Savings", 1000.00);
        Console.WriteLine($"Prototype Account:\n{prototypeAccount}");

        BankAccountPrototype clonedAccount = prototypeAccount.Clone() as BankAccountPrototype;
        Console.WriteLine($"Cloned Account:\n{clonedAccount}");

        BankAccountFactory savingsAccountFactory = new SavingsAccountFactory();
        BankAccount savingsAccount = savingsAccountFactory.CreateBankAccount(54321);
        Console.WriteLine($"Savings Account:\n{savingsAccount}");

        BankAccountFactory checkingAccountFactory = new CheckingAccountFactory();
        BankAccount checkingAccount = checkingAccountFactory.CreateBankAccount(67890);
        Console.WriteLine($"Checking Account:\n{checkingAccount}");

        savingsAccount.Deposit(500.00);
        Console.WriteLine($"Savings Account:\n{savingsAccount}");

        checkingAccount.Withdraw(250.00);
        Console.WriteLine($"Checking Account:\n{checkingAccount}");
    }
}
