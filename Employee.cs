using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInformations
{
    class Employee
    {
        public string Name;
        public double Wage, Duty;

        public double FreeWage()
        {
            return Wage - Duty;
        }

        public double IncreaseWage(double percentual)
        {
            return FreeWage() + (Wage * (percentual / 100));
        }
    }
}
