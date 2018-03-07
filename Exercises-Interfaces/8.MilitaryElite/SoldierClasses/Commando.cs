using System;
using System.Collections.Generic;
using System.Text;


public class Commando : SpecialisedSoldier, ICommando
{

    public Commando(int id, string firstName, string lastName, decimal salary, string corps) 
        : base(id, firstName, lastName ,corps)
    {
        this.Salary = salary;
        Missions = new List<string>();
      
    }

    public Commando(int id, string firstName, string lastName, decimal salary, string corps , string codeName , string missionsStade) 
        : base(id, firstName, lastName,corps)
    {
        Missions = new List<string>();
        this.Salary = salary;
      
        this.MissionCode = codeName;
        this.MissionStade = missionsStade;
    }

    public List<string> Missions { get; set; }

    public string MissionCode { get; set; }

    private string missionStade;

    public string MissionStade
    {
        get { return missionStade; }
        set
        {
            if (value != "inProgress" && value != "Finished")
            {
                
            }
            else
            {
                Missions.Add(value);
                missionStade = value;
            }

        }
    }

   

    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }



    private static void CompleteMission()
    {

    }

    public override string ToString()
    {
        if (Missions.Count == 0)
        {
            return $"{base.ToString() + $"Salary: {this.Salary:f2}"} {Environment.NewLine} Corps: {this.Corps}" + Environment.NewLine + "Missions:";
        }

        StringBuilder str = new StringBuilder();
        str.AppendLine($"{base.ToString()}Salary: {this.Salary:f2}");
        str.AppendLine($"Corps: {this.Corps}");
        str.AppendLine("Missions:");
       
        for (int i = 0; i < Missions.Count; i++)
        {
            str.Append($"  Code Name: {this.MissionCode} State: {Missions[i]}");
            if (i == Missions.Count - 1)
            {
                break;
            }
            str.Append(Missions[i]);
        }

        return str.ToString().TrimEnd();
    }
}

