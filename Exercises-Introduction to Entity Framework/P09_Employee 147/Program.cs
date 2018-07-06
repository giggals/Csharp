using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.IO;
using System.Linq;

namespace P0_Employee_147
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var employee = context.Employees
                    .Where(e => e.EmployeeId == 147)
                    .Select(e => new
                    {
                        Name = e.FirstName + " " + e.LastName,
                        e.JobTitle,
                        Projects = e.EmployeesProjects.Select(p => new
                        {
                            ProjectName = p.Project.Name,
                        })
                        .OrderBy(p => p.ProjectName)
                        .ToArray()
                    })
                    .ToArray();


                string path = @"C:\Users\nikol\source\repos\Exercises-Introduction to Entity Framework\P09_Employee 147\P09";

                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var e in employee)
                    {
                        sw.WriteLine($"{e.Name} - {e.JobTitle}");

                        foreach (var p in e.Projects)
                        {
                            sw.WriteLine($"{p.ProjectName}");
                        }
                    }
                    
                }
            }
        }
    }
}
