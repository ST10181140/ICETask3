using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empployee
{
    internal class Employee
    {
        public string Name { get; set; }   
        public double Salary { get; set; }
        public Employee(string name, double salary)
        { 
            Name = name;
            Salary = salary;
        }

        public static Employee operator +(Employee employee, double percentage)
        {
            employee.Salary += employee.Salary * (percentage/100);
            return employee;
        }
    }
}
