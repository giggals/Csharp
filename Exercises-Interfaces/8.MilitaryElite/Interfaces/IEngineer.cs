using System;
using System.Collections.Generic;
using System.Text;


public interface IEngineer
{
    Dictionary<string , int> Repairs { get; set; }

    string PartName { get; set; }

    int HouresWorked { get; set; }
}

