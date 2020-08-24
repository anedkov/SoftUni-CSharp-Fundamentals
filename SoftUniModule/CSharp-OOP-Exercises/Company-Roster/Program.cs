using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            List<string> departments = new List<string>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] personInfo = Console.ReadLine().Split();

                Employee employee = new Employee(personInfo[0], double.Parse(personInfo[1]), personInfo[2]);
                employees.Add(employee);
                departments.Add(personInfo[2]);
            }


            departments = departments.Distinct().ToList();

            //find Department with Highest Average Salary
            string departmentHighestAve = "";
            double highestAveSalary = double.MinValue;

            foreach (string department in departments)
            {
                double aveSalary = employees.Where(e => e.Department == department).Select(e => e.Salary).Average();
                if (aveSalary > highestAveSalary)
                {
                    departmentHighestAve = department;
                    highestAveSalary = aveSalary;
                }
            }

            //Printing results
            Console.WriteLine($"Highest Average Salary: {departmentHighestAve}");

            foreach (var employee in employees.Where(e => e.Department == departmentHighestAve).OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }


        }
    }
}
