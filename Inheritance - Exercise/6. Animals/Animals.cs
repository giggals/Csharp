using System;
using System.Collections.Generic;
using System.Text;


public class Animals : IProduceSound
{
    private string name;
    private int age;
    private string gender;

    public Animals(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }


    public string Name
    {
        get { return name; }
        set
        {
            Validation(value);
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (string.IsNullOrEmpty(value.ToString()) || value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            age = value;
        }
    }

    public string Gender
    {
        get { return gender; }
        set
        {
            Validation(value);
            gender = value;
        }
    }

    public virtual string ProduceSound()
    {
        return $"";
    }

    public void Validation(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Invalid input!");
        }
    }

    public virtual string GetResult()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine(($"{this.Name} {this.Age} {this.Gender}"));
        return str.ToString();
    }

}

