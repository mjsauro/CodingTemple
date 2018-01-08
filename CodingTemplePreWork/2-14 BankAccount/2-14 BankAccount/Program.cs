using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_14_BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount mattsAccount = new CheckingAccount("B200", "Matt", 500);
            Console.WriteLine("{0} has created a new checking account called {1} with {2} balance", mattsAccount.Owner, mattsAccount.Number, mattsAccount.Balance);
            mattsAccount.Deposit(500);
            Console.WriteLine("{0} deposited money and the balance is now {1}", mattsAccount.Owner, mattsAccount.Balance);

            Console.ReadLine();
        }
    }

    public class BankAccount
    {
        //This is a good time to pay attention to access modifiers
        public string Number 
        {
            get;
            private set;
        }

        public string Owner
        {
            get;
            set;
        }

        //unsigned integers allow for only positive numbers,
        //as they use all 32 bits for number data
        //I'd probably want to use decimal for this in a real world application:
        //Accounts can have negative balances
        //Accounts also allow fofr ractional dollar amounts (cents)
        public uint Balance
        {
            get;
            protected set;
        }

        public BankAccount(string number, string owner, uint balance) :this (number, owner)
        {
            Balance = balance;
        }

        public BankAccount(string number, string owner)
        {
            Number = number;
            Owner = owner;
            Balance = 0;
        }


        public void Withdraw(uint amount)
        {
            Balance -= amount;
        }

        public void Deposit(uint amount)
        {
            Balance += amount;
        }
    }

    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string number, string owner, uint balance) : base(number, owner, balance)
        {
        }
        public new void Withdraw(uint amount)
        {
            if (amount > Balance)
            {
                Balance = 0;
            }
            else
            {
                Balance -= amount;
            }
        }
    }

    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string number, string owner, uint balance) : base(number, owner, balance)
        {
        }
        public new void Withdraw(uint amount)
        {
            if (amount > Balance *.10)
            {
                Balance = 0;
            }
            else
            {
                Balance -= amount;
            }
        }

        public void AddInterest(decimal interest)
        {
            Balance += (uint)(Balance * interest);
        }
    }
}
