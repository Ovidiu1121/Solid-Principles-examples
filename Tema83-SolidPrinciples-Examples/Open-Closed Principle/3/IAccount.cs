using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Open_Closed_Principle._3
{
    interface IAccount
    {
        // members and function declaration, properties
        decimal Balance { get; set; }
        decimal CalcInterest();
    }
}
