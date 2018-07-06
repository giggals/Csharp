using P02_DatabaseFirst.Data;
using System;
using System.IO;
using System.Linq;

namespace P05___Employees_from_Research_and_Development
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var employeesFromResearchAndDeveploment =
                    context.Employees.
                    Where(e => e.Department.Name == "Research and Development")
                    .Select(e => new
                    {
                        e.FirstName,
                        e.LastName,
                        DepartmentName = e.Department.Name,
                        e.Salary
                    })
                    .OrderBy(e => e.Salary)
                    .ThenByDescending(e => e.FirstName)
                    .ToArray();


                using (StreamWriter sw = new StreamWriter(@"C:\Users\nikol\source\repos\Exercises-Introduction to Entity Framework\P05 - Employees from Research and Development\EmployeesFromResearchAndDeveploment"))
                {
                    foreach (var e in employeesFromResearchAndDeveploment)
                    {
                        sw.WriteLine($"{e.FirstName} {e.LastName} from {e.DepartmentName} - ${e.Salary:f2}");
                    }
                }
                    
            }
        }
    }
}
