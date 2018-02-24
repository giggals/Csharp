using System;
using System.Collections.Generic;
using System.Text;


public class Engine
{
    private string model;
    private int power;
    private string displacement;
    private string efficiency;
   
    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public int Power
    {
        get { return power; }
        set { power = value; }
    }

    public string Displacmenet
    {
        get { return displacement; }
        set { displacement = value; }
    }

    public string Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }
    
    public Engine(string model, int power, string diplacemenet)
    {
        this.Model = model;
        this.Power = power;
        this.Displacmenet = diplacemenet;
        int deplacement = 0;
        if (int.TryParse(diplacemenet, out deplacement))
        {
            this.displacement = deplacement.ToString();
            this.efficiency = "n/a";
        }
        else
        {
            this.efficiency = diplacemenet;
            this.displacement = "n/a";
        }
    }

    public Engine(string model, int power, string diplacemenet, string efficiency) : this(model, power, diplacemenet)
    {
        this.Efficiency = efficiency;
    }
    
}
