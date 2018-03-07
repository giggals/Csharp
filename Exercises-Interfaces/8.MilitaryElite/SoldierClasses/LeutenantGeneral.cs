using System;
using System.Collections.Generic;
using System.Text;


public class LeutenantGeneral : Private , ILeutenantGeneral
{
    public LeutenantGeneral(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
    {
        this.Privates = new List<Private>();
    }

    public List<Private> Privates { get ; set ; }


    public void Add(Private privates)
    {
        this.Privates.Add(privates);
    }

    public override string ToString()
    {
        StringBuilder resultLeutanatnt = new StringBuilder();
        resultLeutanatnt.AppendLine($"{base.ToString()}").Append("Privates:");

        return resultLeutanatnt.ToString().TrimEnd();
           
    }
}

