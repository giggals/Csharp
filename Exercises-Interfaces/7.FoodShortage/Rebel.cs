using System;
using System.Collections.Generic;
using System.Text;


public class Rebel : IBuyer
{
    private const int rebelBuying = 5;
    
    private string name;
    private int age;
    private string group;
    private List<int> foodBought;
    public int Food { get; }


    public Rebel(string name , int age , string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public int  Age
    {
        get { return age; }
        set { age = value; }
    }
    
    public string  Group
    {
        get { return group; }
        set { group = value; }
    }

    public List<int> list
    {
        get { return foodBought; }
        set { this.foodBought = value; }
    }
    
    public int BuyFood()
    {
        foodBought = new List<int>();

        foodBought.Add(rebelBuying);

        return rebelBuying;
    }
}

