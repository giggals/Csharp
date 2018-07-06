using P02_DatabaseFirst.Data;
using System;
using System.IO;
using System.Linq;

namespace _3._Employees_Full_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoftUniContext contex = new SoftUniContext())
            {
                var employees = contex.Employees
                    .OrderBy(e => e.EmployeeId)
                    .Select(e => new
                    {
                        e.FirstName,
                        e.LastName,
                        e.MiddleName,
                        e.JobTitle,
                        e.Salary
                    })
                   .ToArray();
                
                using (StreamWriter sw = new StreamWriter(@"C:\Users\nikol\source\repos\Exercises-Introduction to Entity Framework\P03_Employees Full Information\CHEK"))
                {
                    foreach (var employee in employees)
                    {
                        sw.WriteLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {Math.Round(employee.Salary, 2)}");
                    }
                }


            }
        }
    }
}