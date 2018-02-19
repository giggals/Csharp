using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string firstName;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    private string lastName ;

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    
    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }


    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }


    public Person(string firstname,string lastname , int age , decimal salary)
    {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Age = age;
        this.Salary = salary;
    }


    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
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

