using System;
using System.Collections.Generic;
using System.Text;


public class Pet
{
    private string name;
    private string birthday;

    public Pet(string name , string birthday)
    {
        this.Name = name;
        this.BirthDay = birthday;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public string BirthDay
    {
        get { return birthday; }
        set { birthday = value; }
    }
    
}

