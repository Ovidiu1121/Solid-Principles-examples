using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Single_Responsibility_Principle._2
{
    public class TransactionService
    {
        public void Transfer(BankAccount sourceAccount, BankAccount destinationAccount, decimal amount)
        {
            if (sourceAccount.Balance >= amount)
            {
                sourceAccount.Withdraw(amount);
                destinationAccount.Deposit(amount);
                Console.WriteLine($"Transferred {amount}$ from account {sourceAccount.AccountNumber} to account {destinationAccount.AccountNumber}.");
            }
            else
            {
                Console.WriteLine($"Transfer failed. Insufficient funds in account {sourceAccount.AccountNumber}.");
            }
        }
    }
}
