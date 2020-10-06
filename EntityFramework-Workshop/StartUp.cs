using SoftUni.Data;
using SoftUni.Models;

using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SoftUni
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            string result = RemoveTown(context);

            Console.WriteLine(result);
        }
        //P04
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employees = context
                .Employees
                .Where(e => e.Salary > 50000)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName) //IOrderedQueryable<Employee>
                .ToList();

            foreach (var e in employees)
            {
                sb
                    .AppendLine($"{e.FirstName} - {e.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        //P05

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context
                .Employees
                .Where(e => e.Department.Name == "Research and Development")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    DeparmentName = e.Department.Name,
                    e.Salary
                })
                .OrderBy(e => e.Salary)
                .ThenByDescending(e =>
                e.FirstName)
                .ToList();

            foreach (var e in employees)
            {
                sb
                    .AppendLine($"{e.FirstName} {e.LastName} from {e.DeparmentName} - {e.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        //P06
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            Address newAddress = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };
            Employee employeeNakov = context
                .Employees
                .First(e => e.LastName == "Nakov");

            employeeNakov.Address = newAddress;

            context.SaveChanges();

            var addresses = context
                .Employees
                .OrderByDescending(e => e.AddressId)
                .Take(10)
                .Select(e => e.Address.AddressText)
                .ToList();

            foreach (var address in addresses)
            {
                sb
                    .AppendLine(address);
            }

            return sb.ToString().TrimEnd();
        }

        //P07

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context
                .Employees
                .Where(e => e.EmployeeProject.Any(ep => ep.Project.StartDate.Year >= 2001 &&
                                                         ep.Project.StartDate.Year <= 2003))
                .Take(10)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    ManagerFirstName = e.Manager.FirstName,
                    ManagerLastName = e.Manager.LastName,
                    Projects = e.EmployeeProject
                    .Select(ep => new
                    {
                        ProjectName = ep.Project.Name,
                        StartDate = ep.Project
                        .StartDate
                        .ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                        EndDate = ep.Project.EndDate.HasValue
                        ? ep.Project
                        .EndDate
                        .Value
                        .ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                        : "not finished"

                    })
                    .ToList()
                })
                .ToList();
            foreach (var e in employees)
            {
                sb
                    .AppendLine($"{e.FirstName} {e.LastName} - Manager:" +
                    $"{e.ManagerFirstName} {e.ManagerLastName}");

                foreach (var p in e.Projects)
                {
                    sb
                        .AppendLine($"--{p.ProjectName} - {p.StartDate} - {p.EndDate}");
                }


            }
            return sb.ToString().TrimEnd();
        }

        //P09
        public static string GetEmployee147(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employee147 = context
                .Employees
                .Where(e => e.EmployeeId == 147)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    Projects = e.EmployeeProject
                    .Select(ep => ep.Project.Name)
                    .OrderBy(pn => pn)
                    .ToList()
                })
                .Single();
            sb
                .AppendLine($"{employee147.FirstName} {employee147.LastName} - {employee147.JobTitle}");

            foreach (string projectName in employee147.Projects)
            {
                sb
                    .AppendLine(projectName);
            }
            return sb.ToString().TrimEnd();
        }

        //P10

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var departments = context
                .Departments
                .Where(d => d.Employees.Count() > 5)
                .OrderBy(d => d.Employees.Count())
                .ThenBy(d => d.Name)
                .Select(d => new
                {
                    d.Name,
                    ManagerFirstName = d.Manager.FirstName,
                    ManagerLastName = d.Manager.LastName,
                    DepEmployees = d.Employees
                    .Select(e => new
                    {
                        EmployeeFirstName = e.FirstName,
                        EmployeeLastName = e.LastName,
                        e.JobTitle
                    })
                    .OrderBy(e => e.EmployeeFirstName)
                    .ThenBy(e =>
                    e.EmployeeLastName)
                    .ToList()
                    
                })
               
                .ToList();

            foreach (var d in departments)
            {
                sb
                    .AppendLine($"{d.Name} - {d.ManagerFirstName} {d.ManagerLastName}");

                foreach (var e in d.DepEmployees)
                {
                    sb
                        .AppendLine($"{e.EmployeeFirstName} {e.EmployeeLastName} - {e.JobTitle}");
                }
            }
            return sb.ToString().TrimEnd();
        }

        //P12

        public static string IncreaseSalaries(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            IQueryable<Employee> employeesToIncrase = context
                .Employees
                .Where(e => e.Department.Name == "Engineering" ||
                           e.Department.Name == "Tool Design" ||
                           e.Department.Name == "Marketing" ||
                           e.Department.Name == "Information Services");

            foreach (Employee e in employeesToIncrase)
            {
                e.Salary += e.Salary + 0.12m;
            }
            context.SaveChanges();

            var employeesInfo = employeesToIncrase
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e =>
                e.LastName)
                .ToList();

            foreach (var e in employeesInfo)
            {
                sb
                    .AppendLine($"{e.FirstName} {e.LastName} - {e.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        //P15

        public static string RemoveTown(SoftUniContext context)
        {
            Town townToDel = context
                .Towns
                .First(t => t.Name == "Seattle");
            IQueryable<Address> addressesToDel = context
                .Addresses
                .Where(a => a.TownId == townToDel.TownId);

            int adressesCount = addressesToDel.Count();

            IQueryable<Employee> employeesToDelAdresses = context
                .Employees
                .Where(e => addressesToDel
                .Any(a => a.AddressId == e.AddressId));

            foreach (Employee e in employeesToDelAdresses)
            {
                e.AddressId = null;
            }
            foreach (Address address in addressesToDel)
            {
                context
                    .Addresses
                    .Remove(address);
            }
            context.Towns.Remove(townToDel);
            context.SaveChanges();
            return $"{adressesCount} addresses in {townToDel.Name} were deleted!";
        }
    }
}
