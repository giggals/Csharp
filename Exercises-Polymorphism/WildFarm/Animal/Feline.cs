using System;
using System.Collections.Generic;
using System.Text;


public abstract class Feline : Animals
{
    public Feline(string name, double weight, string livingRegion , string breed) : base(name, weight)
    {
        this.Breed = breed;
        this.LivingRegion = livingRegion;
    }
    private string breed;

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

    private string  livingRegion;

    public string  LivingRegion
    {
        get { return livingRegion; }
        set { livingRegion = value; }
    }


    public abstract double WeightIncreaser();

    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.WeightIncreaser()}, {this.LivingRegion}, {FoodEaten}]";
    }
}

