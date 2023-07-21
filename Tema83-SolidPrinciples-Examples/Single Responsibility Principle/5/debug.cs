using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Single_Responsibility_Principle._5
{
    public class debug
    {
        public debug()
        {
            Employee employee1 = new Employee("John", "Doe", 3000, 160);
            Employee employee2 = new Employee("Jane", "Smith", 4000, 180);

            decimal salary1 = employee1.CalculateSalary();
            decimal salary2 = employee2.CalculateSalary();

            Console.WriteLine($"{employee1.FirstName} {employee1.LastName} salary: {salary1}$");
            Console.WriteLine($"{employee2.FirstName} {employee2.LastName} salary: {salary2}$");

            EmployeeService employeeService = new EmployeeService();
            employeeService.IssueMealVouchers(employee1, 5);
            employeeService.IssueMealVouchers(employee2, 7);
        }

    }
}
