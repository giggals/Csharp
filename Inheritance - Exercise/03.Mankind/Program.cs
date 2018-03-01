using System;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            string[] studentInput = Console.ReadLine().Split(" ");
            string firstName = studentInput[0];
            string secondName = studentInput[1];
            string facultyNumber = studentInput[2];

            Student student = new Student(firstName, secondName, facultyNumber);
           

            string[] workerInput = Console.ReadLine().Split(" ");
            string workerFirstName = workerInput[0];
            string workerSecondName = workerInput[1];
            decimal weeksalary = decimal.Parse(workerInput[2]);
            int houresPerDay = int.Parse(workerInput[3]);

            Worker worker = new Worker(workerFirstName, workerSecondName, weeksalary, houresPerDay);

            Console.WriteLine(student);
            Console.WriteLine(worker);


        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }
        
    }

    
}

