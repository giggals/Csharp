using P02_DatabaseFirst.Data;
using System;
using System.IO;
using System.Linq;

namespace P08_Addresses_by_Town
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoftUniContext contex = new SoftUniContext())
            {
                var addresses = contex.Addresses
                    .Select(a => new
                    {
                        a.AddressText,
                        TownName = a.Town.Name,
                        EmployeeCount = a.Employees.Count()
                    })
                    .OrderByDescending(e => e.EmployeeCount)
                    .ThenBy(e => e.TownName)
                    .ThenBy(e => e.AddressText)
                    .Take(10)
                    .ToArray();


                using (StreamWriter sw = new StreamWriter(@"C:\Users\nikol\source\repos\Exercises-Introduction to Entity Framework\P08-Addresses by Town\P08"))
                {
                    foreach (var a in addresses)
                    {
                        sw.WriteLine($"{a.AddressText}, {a.TownName} - {a.EmployeeCount} employees");
                    }
                }
            }
        }
    }
}
