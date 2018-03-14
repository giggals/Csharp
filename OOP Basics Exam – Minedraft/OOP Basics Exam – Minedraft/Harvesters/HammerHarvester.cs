using System;
using System.Collections.Generic;
using System.Text;


public class HammerHarvester : Harvester
{
    private const int oreOutputMultiplier = 2;
    private const int energyMultiplier = 1;

    public HammerHarvester(string id, double oreOutput, double enertgyRequired) 
        : base(id, oreOutput, enertgyRequired)
    {
        this.OreOutput += this.OreOutput * oreOutputMultiplier;
        this.EnergyRequirement += this.EnergyRequirement * energyMultiplier;
    }
}

