using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Dough
    
{
    private const int MIN_WEIGHT = 1;
    private const int MAX_WEIGHT = 200;
    private Dictionary<string, double> flourTypeDict
        = new Dictionary<string, double>
        {
            ["white"] = 1.5,
            ["wholegrain"] = 1.0,
        };

    private Dictionary<string, double> bakingTypesDict = new Dictionary<string, double>
    {
        ["crispy"] = 0.9,
        ["chewy"] = 1.1,
        ["homemade"] = 1.0,
    };

    public Dough(string flourType , string bakingTechnieque , double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnieque;
        this.Weight = weight;
    }


    private string flourType;
    private string bakingTechnique;
    private double weight;

    private double FlourMultiplier => flourTypeDict[this.FlourType];

    private double BakingTechniQieMultiplier => bakingTypesDict[this.BakingTechnique];

    public double Calories => 2 * this.FlourMultiplier * BakingTechniQieMultiplier * this.Weight;


    public string FlourType
    {
        get { return flourType; }
        set
        {
            if (!(this.flourTypeDict.Any(x => x.Key == value.ToLower())))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value.ToLower();
        }
    }
    
    public string BakingTechnique
    {
        get { return bakingTechnique; }
        set
        {

            if (!(this.bakingTypesDict.Any(x => x.Key == value.ToLower())))
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            bakingTechnique = value.ToLower();
        }

    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException($"Dough weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
            }
            weight = value;
        }
    }


}

