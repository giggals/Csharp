using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Topping
{
    private Dictionary<string, double> validTypes = new Dictionary<string, double>
    {
        ["meat"] = 1.2,
        ["veggies"] = 0.8,
        ["cheese"] = 1.1,
        ["sauce"] = 0.9,
    };
    private string type;
    private double weight;

    public Topping (string type, double weight)
    {
        this.Type = type;
        ValidTopping(type, weight);
        this.Weight = weight;
    }

    private void ValidTopping(string topping, double weight)
    {
        if (weight < 1 || weight > 50)
        {
            throw new ArgumentException($"{topping} weight should be in the range[1..50].");
        }
    }

    public double ToppingCalories => 2 * this.Weight * validTypes[this.Type];
    
    public string Type
    {
        get { return type; }
        set
        {
            if (!this.validTypes.Any(t => t.Key == value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            type = value.ToLower();
        }
    }
    

    public double Weight
    {
        get { return weight; }
        set
        {
            ValidWeight(value, this.Type);
            weight = value;
        }
    }

    private static void ValidWeight(double weight, string type)
    {
        if (weight < 1 || weight > 50)
        {
            throw new ArgumentException($"Cannot place {type} on top of your pizza.");
        }

    }

}

