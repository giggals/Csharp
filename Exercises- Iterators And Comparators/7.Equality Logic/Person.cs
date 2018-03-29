
using System;

public class Person : IComparable
{
    public string Name { get; set; }

    public int Age { get; set; }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public int CompareTo(object obj)
    {
        var result = Name.CompareTo(((Person)obj).Name);
        if (result == 0)
        {
            result = Age.CompareTo(((Person)obj).Age);
        }

        return result;
    }

    public override bool Equals(object obj)
    {
        if (obj is Person other)
        {
            return this.Name == other.Name && this.Age == other.Age;
        }

        return false;
    
    }

    public override int GetHashCode()
    {
        return this.Name.GetHashCode() + this.Age.GetHashCode();
    }
}
