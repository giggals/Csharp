using System;
using System.Collections.Generic;
using System.Text;


public class Mouse : Mammal
{
    private const double INCREASE_WEIGHT = 0.10;


    public Mouse(string name, double weight, string livigRegion) : base(name, weight, livigRegion)
    {

    }


    public override void Eat(string food, int quantity)
    {

        if (food != "Vegetable" && food != "Fruit")
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
        return "Squeak";
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

