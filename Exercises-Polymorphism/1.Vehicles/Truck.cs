using System;
using System.Collections.Generic;
using System.Text;


public class Truck : Vehicle
{
    private const double airCondition = 1.6;

    public Truck(double fuelQuantity, double letersPerKm, double tankCapacity) : base(fuelQuantity, letersPerKm , tankCapacity)
    {

    }


    public override string DrivenGivenDistance(double distance)
    {
        var litersToRemove = distance * (this.LetersPerKm + airCondition);

        if (this.FuelQuantity >= litersToRemove)
        {
            this.FuelQuantity -= litersToRemove;
            return $"{nameof(Truck)} travelled {distance} km";
        }

        return $"{nameof(Truck)} needs refueling";

    }

    public override void RefueledAmountFuel(double letersToadd)
    {
        if (letersToadd <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
      var result = this.FuelQuantity + (letersToadd * 0.95);
        if (result > this.TankCapacity)
        {
            Console.WriteLine($"Cannot fit {letersToadd} fuel in the tank");
        }
        else
        {
            this.FuelQuantity =this.FuelQuantity +(letersToadd * 0.95);
        }
    }
}

