using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Single_Responsibility_Principle._5
{
    public class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public decimal BaseSalary { get; private set; }
        public int WorkingHours { get; private set; }

        public Employee(string firstName, string lastName, decimal baseSalary, int workingHours)
        {
            FirstName = firstName;
            LastName = lastName;
            BaseSalary = baseSalary;
            WorkingHours = workingHours;
        }

        public decimal CalculateSalary()
        {
            // Simulăm un calcul simplu pentru salariu, folosind baza salarială și numărul de ore lucrate
            return BaseSalary + (WorkingHours * 10);
        }
    }
}
