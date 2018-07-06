using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.IO;
using System.Linq;

namespace P06._Adding_a_New_Address_and_Updating_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var newAddress = new Address()
                {
                    AddressText = "Vitoshka 15",
                    TownId = 4
                };
                

                var employeeToFind = context.Employees
                    .Where(e => e.LastName == "Nakov")
                    .FirstOrDefault();
                employeeToFind.Address = newAddress;

                context.SaveChanges();

                var employees = context.Employees
                    .OrderByDescending(e => e.AddressId)
                    .Take(10)
                    .Select(e => new
                    {
                        AddressText = e.Address.AddressText,
                    })
                    .ToArray();

                using (StreamWriter sw = new StreamWriter($@"C:\Users\nikol\source\repos\Exercises-Introduction to Entity Framework\P06.-Adding a New Address and Updating Employee\P06"))
                {
                    foreach (var e in employees)
                    {
                        sw.WriteLine($"{e.AddressText}");
                    }
                }
                   
               
            }
        }
    }
}
