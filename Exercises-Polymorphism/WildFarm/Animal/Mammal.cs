using System;
using System.Collections.Generic;
using System.Text;


public abstract class Mammal : Animals
{
    private const double INCREASE_WEIGHT = 0;

    public Mammal(string name , double weight , string livingRegion) : base (name, weight) 
    {
        this.LivingRegion = livingRegion;
    }
    
    private string livingRegion;

    public string LivingRegion
    {
        get { return livingRegion; }
        set { livingRegion = value; }
    }

    public virtual double WeightIncrease()
    {
        var result = this.Weight + this.FoodEaten * INCREASE_WEIGHT;

        return result;
    }


    public override string ToString()
    {
        var result = $"{this.GetType().Name} [{this.Name}, {this.WeightIncrease()}, {this.LivingRegion}, {FoodEaten}]";
        return result;
    }

}

