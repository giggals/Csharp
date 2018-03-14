using System;
using System.Collections.Generic;
using System.Text;


public abstract class Harvester : Unit
{

    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement) : base(id)
    {

        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double OreOutput
    {
        get { return oreOutput; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {GetType().GetProperty("OreOutput").Name}");
            }
            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        protected set
        {
            if (value < 0 || value > 20_000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {GetType().GetProperty("EnergyRequirement").Name}");
            }
            this.energyRequirement = value;
        }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        return result.AppendLine($"{ConvertedType((this.GetType().Name))} - {this.Id}")
                    .AppendLine($"Ore Output: {this.OreOutput}").Append($"Energy Requirement: {this.EnergyRequirement}").ToString();
    }



}

