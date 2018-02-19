using System;
using System.Collections.Generic;
using System.Text;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;
    
   
    
    public IReadOnlyCollection<Person> FirstTeam
    {
        get => this.firstTeam.AsReadOnly();
    }


    public IReadOnlyCollection<Person> ReserveTeam
    {
        get => this.reserveTeam.AsReadOnly();
       
    }
    
    public Team(string name) 
    {
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
        this.name = name;
    }

    public void AddPlayers(Person person)
    {
        if (person.Age < 40)
        {
            firstTeam.Add(person);
        }
        else
        {
            reserveTeam.Add(person);
        }
    }
}

