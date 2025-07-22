using InheritanceInCSharp.BankSystem;

namespace InheritanceInCSharp
{
    
       // Bank system for testing accounts 
        class Program
        {
            static void Main(string[] args)
            {
                // Create a Savings Account 
                BankAccount savings = new SavingsAccount("SAV123", 1000);
                savings.ShowBalance();
                savings.Deposit(500);
                savings.Withdraw(200);
                ((SavingsAccount)savings).ApplyInterest();
                savings.ShowBalance();

                Console.WriteLine();

                // Create a Current Account 
                BankAccount current = new CurrentAccount("CUR456", 2000, 500);
                current.ShowBalance();
                current.Deposit(300);
                current.Withdraw(2500);
                current.ShowBalance();
            }
        }
    }
    

