using P02_DatabaseFirst.Data;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace P07_Employees_and_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var employees = context.Employees
                    .Where(e => e.EmployeesProjects.Any(x => x.Project.StartDate.Year >= 2001 &&
                    x.Project.StartDate.Year <= 2003))
                    .Take(30)
                    .Select(e => new
                    {
                        e.FirstName,
                        e.LastName,
                        ManagerFirstName = e.Manager.FirstName,
                        ManagerLasttName = e.Manager.LastName,
                        Projects = e.EmployeesProjects.Select(p => new
                        {
                           ProjectName = p.Project.Name,
                           ProjectStartDate = p.Project.StartDate,
                           ProjectEndDate = p.Project.EndDate

                        }).ToArray()
                    })
                    .ToArray();

                using (StreamWriter sw = new StreamWriter(@"C:\Users\nikol\source\repos\Exercises-Introduction to Entity Framework\P07_Employees and Projects\P07"))
                {
                    foreach (var e in employees)
                    {
                        sw.WriteLine($"{e.FirstName} {e.LastName} - Manager: {e.ManagerFirstName} {e.ManagerLasttName}");

                        foreach (var p in e.Projects)
                        {
                            sw.WriteLine($"--{p.ProjectName} - {p.ProjectStartDate.ToString("M/d/yyyy h:mm:ss tt",CultureInfo.InvariantCulture)} - {p.ProjectEndDate?.ToString("M/d/yyyy h:mm:ss tt",CultureInfo.InvariantCulture) ?? "not finished"}");
                        }
                    }
                }
                   
            }
        }
    }
}
