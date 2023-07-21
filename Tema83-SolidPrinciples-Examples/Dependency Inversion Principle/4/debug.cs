using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._4
{
    public class debug
    {
        public debug()
        {
            EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
            Employee emp = employeeBusinessLogic.GetEmployeeDetails(1001);
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
        }

    }
}
