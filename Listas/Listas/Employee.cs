using System;
using System.Collections.Generic;
using System.Globalization;

namespace Listas
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public double Salary;

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void increaseSalary(double percentage)
        {
            Salary += Salary * percentage;
        }
        public override string ToString()
        {
            return Id + ", "
                + Name + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }





    }
}
