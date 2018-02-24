using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string model;
    private string engine;
    private string weight;
    private string color;
    private List<Engine> powerengine;

    public List<Engine> EnginePower
    {
        get { return this.powerengine; }
        set { this.powerengine = value; }
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string EngineReference
    {
        get { return this.engine; }
        set { this.engine = value; }
    }

    public string Weight
    {
        get { return this.weight; }
        set { this.weight = value; }
    }

    public string Color
    {
        get { return this.color; }
        set { this.color = value; }
    }

    public Car(string carModel, string engineModel, string weight)
    {
        this.Model = carModel;
        this.EngineReference = engineModel;
        this.Weight = weight;

        int weightParsed = 0;
        if (int.TryParse(weight, out weightParsed))
        {
            this.Weight = weight.ToString();
            this.Color = "n/a";
        }
        else
        {
            this.Color = color;
            this.Weight = "n/a";
        }

    }

    public Car(string carModel, string engineModel, string weight, string colour) : this(carModel, engineModel, weight)
    {
        this.EnginePower = new List<Engine>();
        this.Color = colour;
    }


    public void AddEngine(Engine engine)
    {
        powerengine.Add(engine);
    }
    
}

