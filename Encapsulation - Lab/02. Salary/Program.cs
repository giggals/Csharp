using System;
using System.Collections.Generic;
using System.Linq



    ;
namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < inputCount; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = commandArgs[0];
                string secondName = commandArgs[1];
                int age = int.Parse(commandArgs[2]);
                decimal salary = decimal.Parse(commandArgs[3]);
                var person = new Person(firstName, secondName, age, salary);
                persons.Add(person);

            }
            decimal salaryPercentage = decimal.Parse(Console.ReadLine());

            persons.ForEach(s => s.IncreaseSalary(salaryPercentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
            //foreach (var item in persons)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} receives {item.Salary:f2} leva.");
            //}
        }
    }
}
