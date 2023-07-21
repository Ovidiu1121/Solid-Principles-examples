using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._4
{
    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccessLogic _IEmployeeDataAccessLogic;
        public EmployeeBusinessLogic()
        {
            _IEmployeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _IEmployeeDataAccessLogic.GetEmployeeDetails(id);
        }
    }
}
