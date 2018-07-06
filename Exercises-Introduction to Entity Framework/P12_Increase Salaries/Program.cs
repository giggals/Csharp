using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.IO;
using System.Linq;

namespace P12_Increase_Salaries
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var employees = context.Employees
                    .Where(e => e.Department.Name == "Engineering" ||
                    e.Department.Name == "Tool Design" || e.Department.Name == "Marketing" ||
                    e.Department.Name == "Information Services")
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .ToArray();

                string path = @"C:\Users\nikol\source\repos\Exercises-Introduction to Entity Framework\P12_Increase Salaries\P12";

                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var e in employees)
                    {
                        e.Salary = e.Salary * 1.12M;
                        sw.WriteLine($"{e.FirstName} {e.LastName} (${e.Salary:f2})");
                       
                    }
                }

                context.SaveChanges();
            }
        }
    }
}
