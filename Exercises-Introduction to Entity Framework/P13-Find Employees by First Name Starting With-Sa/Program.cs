using Microsoft.EntityFrameworkCore;
using P02_DatabaseFirst.Data;
using System;
using System.IO;
using System.Linq;

namespace P13_Find_Employees_by_First_Name_Starting_With_Sa
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var employees = context
                    .Employees
                    .Where(e => EF.Functions.Like(e.FirstName,"Sa%"))
                    .Select(e => new
                    {
                        e.FirstName,
                        e.LastName,
                        e.JobTitle,
                        e.Salary
                    })
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .ToArray();

                string path = @"C:\Users\nikol\source\repos\Exercises-Introduction to Entity Framework\P13-Find Employees by First Name Starting With-Sa\P13";

                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var e in employees)
                    {
                        sw.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})");
                    }
                }
            }
        }
    }
}
