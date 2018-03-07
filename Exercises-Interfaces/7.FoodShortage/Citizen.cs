using System;
using System.Collections.Generic;
using System.Text;


public class Citizen : ICitizens,IBuyer
{
    private const int citizenBuying = 10;

    public string PersonName { get; private set; }

    public int Age { get; private set; }

    public string IdPerson { get; private set; }

    public string BirthDate { get; private set; }

    public int Food { get; }
    private List<int> foodBuying;

    public Citizen(string name , int age , string id , string birthday)
    {
        this.PersonName = name;
        this.Age= age;
        this.IdPerson = id;
        this.BirthDate = birthday;
    }

    public List<int> list
    {
        get { return this.foodBuying; }
        set { this.foodBuying = value; }
    }

    public int BuyFood()
    {
        foodBuying = new List<int>();

        list.Add(citizenBuying);
        return citizenBuying;
    }

   
}

