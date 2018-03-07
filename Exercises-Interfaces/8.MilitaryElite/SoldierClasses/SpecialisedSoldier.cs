using System;
using System.Collections.Generic;
using System.Text;

public class SpecialisedSoldier : Soldier, ISpecialisedSoldier
{
    public SpecialisedSoldier(int id, string firstName, string lastName , string corps) : base(id, firstName, lastName)
    {
        this.Corps = corps;


    }
    
    private string corps;

    public string Corps
    {
        get { return corps; }
        set
        {
            if (value != "Airforces" && value != "Marines")
            {
                throw new ArgumentException("Wrong");
            }
            else
            {
                corps = value;
            }
          
        }
    }

}

