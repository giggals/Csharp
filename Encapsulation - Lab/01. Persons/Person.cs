using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string firstName;

    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }

    private string lastName;

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

    public Person(string firstname,string lastName , int age)
    {
        this.firstName = firstname;
        this.lastName = lastName;
        this.age = age;
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.lastName} is {this.Age} years old.";
    }

}

