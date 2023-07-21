using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Single_Responsibility_Principle._2
{
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string OwnerName { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, string ownerName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}$ into account {AccountNumber}. New balance: {Balance}$");
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount}$ from account {AccountNumber}. New balance: {Balance}$");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}
