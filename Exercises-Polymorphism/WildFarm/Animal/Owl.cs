using System;
using System.Collections.Generic;
using System.Text;


public class Owl : Bird
{
    private const double INCREASE_WEIGHT = 0.25;


    public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {

    }

    public override void Eat(string food, int quantity)
    {

        if (food.ToString() != "Meat")
        {
            Console.WriteLine($"{this.GetType().Name} does not eat {food.ToString()}!");
            this.FoodEaten = quantity;

        }
        else
        {
            this.FoodEaten = quantity;
        }

    }

    public override string MakeSound()
    {
        return $"Hoot Hoot";
    }

    public override string ToString()
    {
        return base.ToString() + $"{this.Weight += this.FoodEaten * INCREASE_WEIGHT}, {this.FoodEaten}]";
    }
}

