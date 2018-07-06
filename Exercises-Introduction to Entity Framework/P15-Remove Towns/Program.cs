using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.Linq;

namespace P15_Remove_Towns
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            
            using (SoftUniContext contex = new SoftUniContext())
            {
                var employees = contex.Employees
                    .Where(e => e.Address.Town.Name == townName)
                    .ToArray();

                foreach (var e in employees)
                {
                    e.AddressId = null;
                }


                var addresses = contex.Addresses
                    .Where(a => a.Town.Name == townName)
                    .ToArray();

                foreach (var a in addresses)
                {
                    contex.Addresses.RemoveRange(addresses);
                }

                Town town = contex.Towns
                    .Where(t => t.Name == townName)
                    .FirstOrDefault();

                contex.Towns.Remove(town);


                Console.WriteLine($"{addresses.Count()} address in {townName} was deleted");
                contex.SaveChanges();
                
            }
        }
    }
}
