using Listas;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int add = int.Parse(Console.ReadLine());

            for(int i = 1; i <= add; i++)
            {
                Console.WriteLine("Employee #" + i + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");            
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();

            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int procuraId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == procuraId);

            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
            }else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee em in list)
            {
                Console.WriteLine(em);
            }
            
            
            
        }
    }
}