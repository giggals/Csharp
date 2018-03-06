using System;
using System.Collections.Generic;
using System.Text;


public class Bus : Vehicle
{
    private const double BusAirCondition = 1.4; 

    public Bus(double fuelAmount , double letersPerKm , double tankCapacity) 
        : base (fuelAmount,letersPerKm,tankCapacity)
    {

    }


    public override string DrivenGivenDistance(double distance)
    {
        var litersToRemove = distance * (this.LetersPerKm + BusAirCondition);

        if (this.FuelQuantity >= litersToRemove)
        {
            this.FuelQuantity -= litersToRemove;
            return $"{nameof(Bus)} travelled {distance} km";
        }

        return $"{nameof(Bus)} needs refueling";

    }

    public string DrivenGivenDistanceEmpty(double distance)
    {
        var litersToRemove = distance * (this.LetersPerKm);

        if (this.FuelQuantity >= litersToRemove)
        {
            this.FuelQuantity -= litersToRemove;
            return $"{nameof(Bus)} travelled {distance} km";
        }

        return $"{nameof(Bus)} needs refueling";
    }

    public override void RefueledAmountFuel(double letersToAdd)
    {
        if (letersToAdd <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        var result = this.FuelQuantity + (letersToAdd );
        if (result > this.TankCapacity)
        {
            Console.WriteLine($"Cannot fit {letersToAdd} fuel in the tank");
        }
        else
        {
            this.FuelQuantity = this.FuelQuantity + (letersToAdd);
        }
    }
    
}

