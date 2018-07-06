using P02_DatabaseFirst.Data;
using System;
using System.IO;
using System.Linq;

namespace P10_Departments_with_More_Than_5_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var departments = context.Departments
                    .Where(d => d.Employees.Count > 5)
                    .Select(d => new
                    {
                        d.Name,
                        ManagerName = d.Manager.FirstName + " " + d.Manager.LastName,
                        Employees = d.Employees.Select(e => new
                        {
                            e.FirstName,
                            e.LastName,
                            e.JobTitle
                        })
                        .OrderBy(e => e.FirstName)
                        .ThenBy(e => e.LastName)
                       .ToArray()
                    })
                    .OrderBy(d => d.Employees.Count())
                    .ThenBy(d => d.Name)
                    .ToArray();


                string path = @"C:\Users\nikol\source\repos\Exercises-Introduction to Entity Framework\P10_Departments with More Than 5 Employees\P10";

                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var d in departments)
                    {
                        sw.WriteLine($"{d.Name} - {d.ManagerName}");

                        foreach (var e in d.Employees)
                        {
                            sw.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                        }

                        sw.WriteLine("----------");
                    }
                }

            }
        }
    }
}
