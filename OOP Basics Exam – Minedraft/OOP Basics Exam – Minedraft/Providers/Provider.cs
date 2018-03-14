using System;
using System.Collections.Generic;
using System.Text;


public abstract class Provider : Unit
{
    private double energyOutput;

    protected Provider(string id, double energyOutput) : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get { return energyOutput; }
        protected set
        {
            if (value < 0 || value >= 10_000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {GetType().GetProperty("EnergyOutput").Name}");
            }
            energyOutput = value;
        }
    }
    
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        return result.AppendLine($"{ConvertedType(this.GetType().Name)} - {this.Id}")
                    .Append($"Energy Output: {this.EnergyOutput}").ToString();
    }


}

