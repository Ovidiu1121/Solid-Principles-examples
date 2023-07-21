using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Single_Responsibility_Principle._2
{
    internal class debug
    {

        public debug()
        {
            BankAccount account1 = new BankAccount("123456789", "John Doe", 1000);
            BankAccount account2 = new BankAccount("987654321", "Jane Smith", 500);

            account1.Withdraw(200);
            account2.Deposit(300);

            TransactionService transactionService = new TransactionService();
            transactionService.Transfer(account1, account2, 400);
        }

    }
}
