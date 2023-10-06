using Empployee;
using System;

 class Program
{
    public static void Main(String[] args)
    {
        Employee employee = new Employee("Jessica Alba", 60000.00);

        Console.WriteLine("Initial salary:" + employee.Salary);

        employee += 10;

        Console.WriteLine("New salary: " + employee.Salary);
    }
}