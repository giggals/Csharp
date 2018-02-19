using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    const decimal MIN_SALARY = 460;


    private string firstName;

    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (value?.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            firstName = value;
        }
    }

    private string lastName;

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            lastName = value;
        }
    }

    private int age;

    public int Age
    {
        get { return age; }
         set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");

            }
            age = value;
            
        }
    }


    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
         set
        {
            
            if (salary < MIN_SALARY)
            {
                throw new ArgumentException($"Salary cannot be less than {MIN_SALARY} leva!");
            }
            salary = value;
        }
    }


    public override string ToString()
    {
        return $"{this.FirstName} {this.lastName} gets {this.Salary:f2} leva.";
    }


    public Person(string firstname, string lastname, int age, decimal salary)
    {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Age = age;
        this.Salary = salary;
    }


    public void IncreaseSalary(decimal percentage)
    {
        if (this.age < 30)
        {
            this.salary += salary * percentage / 200;
        }
        else
        {
            this.salary += salary * percentage / 100;
        }
    }
}

