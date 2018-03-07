using System;
using System.Collections.Generic;
using System.Text;


public class Society : ICitizens, IRobots
{
    public string PersonName { get; private set; }

    public int Age { get; private set; }

    public string IdPerson { get; private set; }

    public string Model { get; private set; }

    public string IdRobot { get; private set; }

    public Society(string model , string idRobot)
    {
        this.Model = model;
        this.IdRobot = idRobot;
    }

    public Society(string personName , int age , string idPerson) 
    {
        this.PersonName = personName;
        this.Age = age;
        this.IdPerson = idPerson;
      
    }

}

