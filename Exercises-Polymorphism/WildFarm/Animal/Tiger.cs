using System;
using System.Collections.Generic;
using System.Text;


public class Tiger : Feline
{
    private const double INCREASE_WEIGHT = 1;
    
    public Tiger(string name , double weight , string livingRegion , string breeds) : base (name ,weight ,livingRegion,breeds)
    {

    }


    public override void Eat(string food, int quantity)
    {
        if (food != "Meat")
        {
            Console.WriteLine(($"{this.GetType().Name} does not eat {food.ToString()}!"));
            this.FoodEaten = 0;
        }
        else
        {
            this.FoodEaten = quantity;
        }
      
    }

    public override string MakeSound()
    {
        return "ROAR!!!";
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

