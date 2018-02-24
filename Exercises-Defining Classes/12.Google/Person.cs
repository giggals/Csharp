using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private Company companyName;
    private Pokemon pokemonName;
    private Parents parentsName;
    private Children childrens;
    private Car car;

    public Car Cars
    {
        get { return this.car; }
        set { this.car = value;  }
    }

    public Children Childrens
    {
        get { return this.childrens; }
        set { this.childrens = value; }
    }


    public Parents ParentsName
    {
        get {return this.parentsName; }
        set { this.parentsName = value; }
    }


    public Pokemon PokemonName
    {
        get { return this.pokemonName; }
        set { this.pokemonName = value; }
    }
    
    public Company Comp
    {
        get {return this.companyName; }
        set { this.companyName = value; }
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Person(string name,Company company)
    {
        this.Name = name;
        this.Comp = company;
    }

    public Person(string name,Pokemon pokemon) 
    {
        this.Name = name;
        this.PokemonName = pokemon;
    }

    public Person(string name, Parents parents)
    {
        this.Name = name;
        this.ParentsName = parents;
    }

    public Person(string name)
    {
        this.Name = name;
    }


    public Person(string name ,Children children )
    {
        this.Name = name;
        this.Childrens = children;
    }

    public Person(string name , Car car)
    {
        this.Name = name;
        this.Cars = car;
    }

    //public override string ToString()
    //{
    //    StringBuilder stringBuilder = new StringBuilder();

    //    stringBuilder.AppendLine(this.Name);
    //    stringBuilder.AppendLine("Company");
    //    stringBuilder.AppendLine(this.Comp.CompanyName);
    //    stringBuilder.AppendLine("Car");
    //    stringBuilder.AppendLine();
    //    stringBuilder.AppendLine("Pokemon:");
    //    stringBuilder.AppendLine($"{this.PokemonName.PokemonName} {this.PokemonName.PokemonType}");
    //    stringBuilder.AppendLine($"Parents:");
    //    stringBuilder.AppendLine($"{this.ParentsName.ParentName} {this.ParentsName.ParentBirthday}");
    //    stringBuilder.AppendLine($"Children");

    //    return stringBuilder.ToString();
            
    //}

}

