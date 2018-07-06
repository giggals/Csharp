using P02_DatabaseFirst.Data;
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (SoftUniContext context = new SoftUniContext())
        {
            var employeesWithBigSalary = context.Employees
                .Where(e => e.Salary > 50000)
                .Select(e => new
                {
                    e.FirstName
                })
                .OrderBy(e => e.FirstName)
                .ToArray();
               


            using (StreamWriter sw = new StreamWriter(@"C:\Users\nikol\source\repos\Exercises-Introduction to Entity Framework\P04-Employees with Salary Over 50 000\EmployeesWithBigSalary"))
            {
                foreach (var e in employeesWithBigSalary)
                {
                    sw.WriteLine($"{e.FirstName}");
                }
                
            }
        }
    }
}

