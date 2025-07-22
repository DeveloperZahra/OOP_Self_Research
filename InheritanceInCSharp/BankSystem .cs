using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    namespace BankSystem
    {
        // Abstract class representing a general bank account 
        abstract class BankAccount
        {
            // Encapsulated fields with private access 
            private string accountNumber;
            protected double balance = 0;

            // Constructor to initialize bank account 
            public BankAccount(string accountNumber, double initialBalance)
            {
                this.accountNumber = accountNumber;
                balance += initialBalance;
            }

            // Abstract method to be implemented by derived classes 
            public abstract void Withdraw(double amount);

            // Non-abstract method with implementation 
            public void Deposit(double amount)
            {
                balance += amount;
                Console.WriteLine($"{amount} deposited successfully. New balance: {balance:C}");
            }

            // Virtual method that can be overridden in derived classes 
            public virtual void ShowBalance()
            {
                Console.WriteLine($"Account {accountNumber} balance: {balance:C}");
            }
        }

        // Derived class representing a Savings Account 
        class SavingsAccount : BankAccount
        {
            private const double InterestRate = 0.03; // 3% interest rate 

            public SavingsAccount(string accountNumber, double initialBalance)
                : base(accountNumber, initialBalance)
            {
            }
            // Override the abstract method for withdrawing money 
            public override void Withdraw(double amount)
            {
                if (amount > balance)
                {
                    Console.WriteLine("Insufficient funds. Withdrawal failed.");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine($"{amount:C} withdrawn successfully. New balance: {balance:C}");
                }
            }

            // Additional method specific to SavingsAccount 
            public void ApplyInterest()
            {
                double interest = balance * InterestRate;
                balance += interest;
                Console.WriteLine($"Interest applied: {interest:C}. New balance: {balance:C}");
            }

            // Optionally override the virtual method 
            public override void ShowBalance()
            {
                base.ShowBalance();
                Console.WriteLine($"(Savings account - includes interest)");
            }
        }

        // Derived class representing a Current Account 
        class CurrentAccount : BankAccount
        {
            private double overdraftLimit;

            public CurrentAccount(string accountNumber, double initialBalance, double overdraftLimit)
                : base(accountNumber, initialBalance)
            {
                this.overdraftLimit = overdraftLimit;
            }

            // Override the abstract method for withdrawing money 
            public override void Withdraw(double amount)
            {
                if (amount > balance + overdraftLimit)
                {
                    Console.WriteLine("Withdrawal exceeds overdraft limit. Withdrawal failed.");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine($"{amount:C} withdrawn successfully. New balance: {balance:C}");
                }
            }

            // Optionally override the virtual method 
            public override void ShowBalance()
            {
                base.ShowBalance();
                Console.WriteLine($"(Current account - Overdraft limit: {overdraftLimit:C})");
            }
        }

     
    }
}
