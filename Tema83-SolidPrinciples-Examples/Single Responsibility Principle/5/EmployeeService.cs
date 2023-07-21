using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Single_Responsibility_Principle._5
{
    public class EmployeeService
    {
        public void IssueMealVouchers(Employee employee, int numberOfVouchers)
        {
            // Simulăm emiterea de tichete de masă pentru angajat
            // Într-un sistem real, ar fi aici logica pentru emiterea tichetelor de masă
            Console.WriteLine($"{numberOfVouchers} meal vouchers issued to {employee.FirstName} {employee.LastName}.");
        }
    }
}
