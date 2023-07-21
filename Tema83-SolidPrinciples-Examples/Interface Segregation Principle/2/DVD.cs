using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Interface_Segregation_Principle._2
{
    public class DVD : ILendableItem, IBorrowable, IReturnable
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public bool IsBorrowed { get; private set; }
        public DateTime BorrowDate { get; private set; }

        public void BorrowItem(string borrower)
        {
            IsBorrowed = true;
            BorrowDate = DateTime.Now;
            Console.WriteLine($"DVD '{Title}' directed by {Director} borrowed by {borrower}.");
        }

        public void ReturnItem()
        {
            IsBorrowed = false;
            Console.WriteLine($"DVD '{Title}' directed by {Director} returned.");
        }

        public void ExtendBorrowPeriod(int days)
        {
            BorrowDate = BorrowDate.AddDays(days);
            Console.WriteLine($"Borrow period for DVD '{Title}' extended by {days} days.");
        }

        public bool IsOverdue
        {
            get { return DateTime.Now > BorrowDate.AddDays(14); }
        }

        public void NotifyOverdue()
        {
            Console.WriteLine($"DVD '{Title}' directed by {Director} is overdue!");
        }
    }
}
