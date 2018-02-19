using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var persons = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string firstName = input[0];    
            string lastname = input[1];
            int age = int.Parse(input[2]);
            decimal salary = decimal.Parse(input[3]);
            try
            {
                var person = new Person(firstName, lastname, age, salary);
                persons.Add(person);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
          
        }
        int bonus = int.Parse(Console.ReadLine());

        persons.ForEach(s => s.IncreaseSalary(bonus));
        persons.ForEach(p => Console.WriteLine(p));
        
    }
}

