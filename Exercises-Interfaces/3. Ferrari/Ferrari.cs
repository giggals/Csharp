using System;
using System.Collections.Generic;
using System.Text;


public class Ferrari : ICar
{
    public string DriverName { get; private set; }
    public string Model { get; private set; }

    public Ferrari(string driverName)
    {
        this.DriverName = driverName;
    }

    public string UseBreaks()
    {
        return $"Brakes!";
    }

    public string UseGaz()
    {
        return $"Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"488-Spider/{this.UseBreaks()}/{this.UseGaz()}/{this.DriverName}";
    }
}


