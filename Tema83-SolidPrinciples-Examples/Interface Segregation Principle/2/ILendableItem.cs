using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Interface_Segregation_Principle._2
{
    public interface ILendableItem
    {
        void BorrowItem(string borrower);
        void ReturnItem();
    }
}
