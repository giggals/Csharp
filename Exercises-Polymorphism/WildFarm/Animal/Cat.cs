using System;
using System.Collections.Generic;
using System.Text;


public class Cat : Feline
{
    private const double INCREASE_WEIGHT = 0.30;

    public Cat(string name , double weight , string livinRegion,string breeds) : base(name,weight,livinRegion,breeds)
    {

    }


    public override void Eat(string food, int quantity)
    {
        if (food != "Vegetable" && food != "Meat")
        {
            Console.WriteLine($"{this.GetType().Name} does not eat {food.ToString()}!");
            this.FoodEaten = 0;
        }
        else
        {
            this.FoodEaten = quantity;
        }
     
    }

    public override string MakeSound()
    {
        return "Meow";
    }

    public override double WeightIncreaser()
    {
        return this.Weight += this.FoodEaten * INCREASE_WEIGHT;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

