using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._4
{
    public interface IEmployeeDataAccessLogic
    {
        Employee GetEmployeeDetails(int id);
        //Any Other Employee Related Method Declarations
    }
}
