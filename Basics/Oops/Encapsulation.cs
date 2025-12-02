using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Account 
{
    public string name;
    private double balance;
    public Account(string name,double balance)
    {
        this.name = name;
        this.balance = balance;
    }

    public double getBalance()
    {
        return balance;
    }
    public void setBalance(double amount)
    {
        this.balance = amount;
    }
}
class Bank
{
    public void depsosit(Account a,double amount)
    {
        if (amount>0)
        {
            double balance=a.getBalance() + amount;
            a.setBalance(balance);
            Console.WriteLine(a.getBalance());
        }

    }

    public void withdraw(Account a,double amount) { 
        if (amount<=a.getBalance())
        {
            double balance = a.getBalance() - amount;
            a.setBalance(balance);
            Console.WriteLine(a.getBalance());
        }

    }
}

namespace Basics.Oops
{
    internal class Encapsulation
    {
        public static void Main(string [] args)
        {
            Account a1 = new Account("haranath", 20000);
            Bank b = new Bank();
            b.depsosit(a1, 5000);
            b.withdraw(a1, 20000);
        }
    }
}
