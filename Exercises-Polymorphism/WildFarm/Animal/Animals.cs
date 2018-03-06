using System;
using System.Collections.Generic;
using System.Text;


public abstract class Animals
{
    public Animals(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = 0;
    }

    
    private string name;
    private double weight;
    private int foodEaten;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public int FoodEaten
    {
        get { return foodEaten; }
        set { foodEaten = value; }
    }
    
    public abstract string MakeSound();

    public abstract void Eat(string food , int quantity);
}

