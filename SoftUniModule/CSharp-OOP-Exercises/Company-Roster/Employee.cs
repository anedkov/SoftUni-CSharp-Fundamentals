using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company_Roster
{
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            
            builder.AppendLine($"{this.Name} {Salary}");

            return builder.ToString();
        }
        public string BestDepartment (List<Employee> employees)
        {
            double salary = 0;
            string name = "";
            this.Salary = salary;
            this.Department = name;

            var bestSalary = employees.OrderBy(x => x.Salary);
            var bestDepartment = employees.Select(f => f.Department).ToString();

            return bestDepartment.ToString();
        }
        
       
    }
}
