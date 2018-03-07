﻿using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : IIdentifiable, IBirthable
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Id { get; private set; }
    public string Birthdate { get; private set; }

    public Citizen(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public Citizen(string name, int age, string id, string birthday)
        : this(name, age)
    {
        this.Id = id;
        this.Birthdate = birthday;
    }

}

