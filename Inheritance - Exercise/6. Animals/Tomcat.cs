using System;
using System.Collections.Generic;
using System.Text;


public class Tomcat : Cat
{
    public Tomcat(string name , int age , string gender) : base(name , age , gender)
    {

    }

    public override string ProduceSound()
    {
        return "MEOW";
    }

    public override string GetResult()
    {
        StringBuilder tomcatResult = new StringBuilder();

        tomcatResult.AppendLine($"{this.Name} {this.Age} Male");
        tomcatResult.Append($"MEOW");

        return tomcatResult.ToString();

    }
}

