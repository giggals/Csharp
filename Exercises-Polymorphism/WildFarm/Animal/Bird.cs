using System;
using System.Collections.Generic;
using System.Text;


public abstract class Bird : Animals
{
    public Bird(string name, double weight , double wingSize) : base( name, weight)
    {
        this.WingSize = wingSize;
    }

    private double wingSize;

    public double WingSize
    {
        get { return wingSize; }
        set { wingSize = value; }
    }


    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, ";
    }


}

