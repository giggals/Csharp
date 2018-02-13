using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Person
{
     string name;
     int age;
     List<BankAccount> accounts;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        this.accounts = new List<BankAccount>();
    }

    public Person(string name, int age, List<BankAccount> accounts) : this(name, age)
    {
        this.accounts = accounts;
    }

    public decimal GetBalance()
    {
        return accounts.Sum(a => a.Balance);
    }

}



