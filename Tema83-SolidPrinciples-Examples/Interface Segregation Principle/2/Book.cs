using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Interface_Segregation_Principle._2
{
    public class Book : ILendableItem, IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; private set; }
        public DateTime BorrowDate { get; private set; }

        public void BorrowItem(string borrower)
        {
            IsBorrowed = true;
            BorrowDate = DateTime.Now;
            Console.WriteLine($"Book '{Title}' by {Author} borrowed by {borrower}.");
        }

        public void ReturnItem()
        {
            IsBorrowed = false;
            Console.WriteLine($"Book '{Title}' by {Author} returned.");
        }

        public void ExtendBorrowPeriod(int days)
        {
            BorrowDate = BorrowDate.AddDays(days);
            Console.WriteLine($"Borrow period for book '{Title}' extended by {days} days.");
        }
    }
}
