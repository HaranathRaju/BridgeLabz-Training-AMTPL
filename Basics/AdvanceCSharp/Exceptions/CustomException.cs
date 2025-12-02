using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BalanceInSufficientException : Exception
{
    public BalanceInSufficientException (string msg) : base(msg)
    {

    }
}

class ATM
{
    private double balance;
    public ATM (double balance)
    {
        this.balance = balance;
    }
    public void withdraw(double amount)
    {
        if (amount<=balance)
        {
            balance -= amount;
            Console.WriteLine(balance);
        } else
        {
            throw new BalanceInSufficientException("balance is insufficient");
        }
    }
}


namespace Basics.AdvanceC_.Exceptions
{
    internal class CustomException
    {
        public static void Main(string[] args)
        {

            ATM a = new ATM(20000);
            try
            {
                a.withdraw(25000);

            }  catch (BalanceInSufficientException e)
            {
                Console.WriteLine(e.Message);
            } 
        }
    }
}
