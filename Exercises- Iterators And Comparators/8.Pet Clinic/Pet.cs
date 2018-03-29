
using System.Collections.Generic;
using System.Linq;

public class Pet
{
    public string Name { get; set; }

    public int Age { get; set; }

    public string Type { get; set; }
    
    public Pet(string name, int age, string type)
    {
        this.Name = name;
        this.Age = age;
        this.Type = type;
        
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Age} {this.Type}";
    }
}
