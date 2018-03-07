using System;
using System.Collections.Generic;
using System.Text;


public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(string firstName, string lastName, int id, decimal salary, string corps) : base(id, firstName, lastName, corps)
    {

        this.Salary = salary;
    }

    public Engineer(string firstName, string lastName, int id, decimal salary, string corps, string partName, int hoursWorked) : this(firstName, lastName, id, salary, corps)
    {

        this.PartName = partName;
        this.HouresWorked = hoursWorked;
    }


    private Dictionary<string, int> repairs;

    public Dictionary<string, int> Repairs
    {
        get { return repairs; }
        set { repairs = value; }
    }


    public string PartName { get; set; }

    public int HouresWorked { get; set; }

    public decimal Salary { get; set; }

    public void AddToDict(string partname, int housersworked)
    {
        Repairs = new Dictionary<string, int>();
        this.Repairs.Add(partname, housersworked);
    }

    public override string ToString()
    {
        if (Repairs.Count == 0)
        {
            return base.ToString() + $"Salary: {this.Salary:f2} {Environment.NewLine}Corps: {this.Corps}";
        }

        StringBuilder engineer = new StringBuilder();
        engineer.AppendLine(base.ToString() + $"Salary: {this.Salary:f2} {Environment.NewLine}Corps: {this.Corps}")
            .Append("Repairs:");

       

        return engineer.ToString().TrimEnd();

    }
}

