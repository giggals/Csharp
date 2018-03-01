using System;
using System.Collections.Generic;
using System.Text;


public class Kittens : Cat
{
    public Kittens(string name , int age , string gender) : base(name , age ,gender)
    {

    }

    public override string ProduceSound()
    {
        return "Meow";
    }

    public override string GetResult()
    {
        StringBuilder kittenResult = new StringBuilder();
        kittenResult.AppendLine($"{this.Name} {this.Age} Female");
        kittenResult.Append($"Meow");
        return kittenResult.ToString();
    }
}

