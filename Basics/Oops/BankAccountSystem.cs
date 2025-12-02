using System;

namespace ObjectOrientedProgramming.problems
{
    class BankAccount
    {
        public static string bankName = "sbi";
        public static int totalAccounts = 0;
        public string accountHolderName;
        public readonly string accountNumber;

        public BankAccount(string accountHolderName, string accountNumber)
        {
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;
            totalAccounts++;
        }

        public static int GetTotalAccounts()
        {
            return totalAccounts;
        }

        public void displayAccountInfo()
        {
            Console.WriteLine("Bank Name: " + bankName);
            Console.WriteLine("Account Holder Name: " + accountHolderName);
            Console.WriteLine("Account Number: " + accountNumber);
        }
    } 
    internal class BankAccountSystem
    {
        public static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("manoj", "12345");
            BankAccount account2 = new BankAccount("tarun", "67890");

            Console.WriteLine("bank name : " + BankAccount.bankName);
            Console.WriteLine("Total accounts : " + BankAccount.GetTotalAccounts());

            if (account1 is BankAccount)
            {
                account1.displayAccountInfo();
            }
            if (account2 is BankAccount)
            {
                account2.displayAccountInfo();
            }

        }
    }
}
