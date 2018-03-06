using System;
using System.Collections.Generic;
using System.Text;


public class Dog : Mammal
{
    private const double INCREASE_WEIGHT = 0.40;

    public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {

    }

    public override void Eat(string food, int quantity)
    {
        if (food != "Meat")
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
        return "Woof!";
    }

    public override double WeightIncrease()
    {
        return this.Weight += this.FoodEaten * INCREASE_WEIGHT;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

