using System;
using System.Collections.Generic;
using System.Text;


public class Hen : Bird
{
    private const double INCREASE_WEIGHT = 0.35;

    public Hen(string name, double weight, double wingSize) : base(name , weight,wingSize)
    { 

    }

    public override void Eat(string food, int quantity)
    {
        this.FoodEaten = quantity;
    }

    public override string MakeSound()
    {
        return "Cluck";
    }

    public override string ToString()
    {
        return base.ToString() + $"{this.Weight += this.FoodEaten * INCREASE_WEIGHT}, {this.FoodEaten}]";
    }
}

